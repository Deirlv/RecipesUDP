using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;
using System.Text;
using RecipesLibrary;

namespace RecipesUDPServer
{
    public partial class Form1 : Form
    {
        int remotePort;

        IPAddress IPAddress;

        Task? receiver;

        public Form1()
        {
            IPAddress = IPAddress.Parse("192.168.178.34");
            remotePort = 11000;
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (receiver != null) { return; }

            receiver = Task.Run(async () =>
            {
                UdpClient listener = new UdpClient(new IPEndPoint(IPAddress, remotePort));
                try
                {
                    while (true)
                    {
                        UdpReceiveResult resultReceive = await listener.ReceiveAsync();

                        byte[] buff = resultReceive.Buffer;

                        string receivedJson = Encoding.Default.GetString(buff);


                        StringBuilder stringBuilder = new StringBuilder();
                        stringBuilder.AppendLine($"{buff.Length} received from {resultReceive.RemoteEndPoint}");
                        stringBuilder.AppendLine($"Products: {receivedJson}");

                        List<string>? products = JsonSerializer.Deserialize<List<string>>(receivedJson);

                        List<Recipe>? recipes = new List<Recipe>();
                        string? jsonData = null;

                        using (StreamReader reader = new StreamReader("recipes.json", Encoding.Default))
                        {
                            jsonData = await reader.ReadToEndAsync();
                        }

                        stringBuilder.AppendLine($"Json : \n{jsonData}");

                        if (jsonData != null)
                        {
                            recipes = JsonSerializer.Deserialize<List<Recipe>>(jsonData);
                        }

                        if (recipes != null)
                        {
                            List<Recipe>? foundRecipes = FindMatchingRecipes(recipes, products);

                            if (foundRecipes.Count == 0)
                            {
                                stringBuilder.AppendLine("The recipe was NOT found");
                            }

                            string jsonSend = JsonSerializer.Serialize<List<Recipe>>(foundRecipes);

                            byte[] bufferResponse = Encoding.Default.GetBytes(jsonSend);

                            await listener.SendAsync(bufferResponse, bufferResponse.Length, resultReceive.RemoteEndPoint);

                            stringBuilder.AppendLine($"{bufferResponse.Length} bytes send to: {resultReceive.RemoteEndPoint}");
                        }

                        textBoxLog.BeginInvoke(new Action<string>(AddText), stringBuilder.ToString());
                    };
                }
                catch (SystemException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    listener.Close();
                }

            });
            Text = "Server is working...";
        }

        private void AddText(string str)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(str);

            textBoxLog.Text = stringBuilder.ToString();
        }

        static List<Recipe> FindMatchingRecipes(List<Recipe> recipes, List<string> products)
        {
            List<Recipe> matchingRecipes = new List<Recipe>();

            foreach (var recipe in recipes)
            {
                bool containsAllProducts = true;
                foreach (var product in products)
                {
                    if (!recipe.Products.Contains(product))
                    {
                        containsAllProducts = false;
                        break;
                    }
                }
                if (containsAllProducts)
                {
                    matchingRecipes.Add(recipe);
                }
            }

            return matchingRecipes;
        }

    }
}
