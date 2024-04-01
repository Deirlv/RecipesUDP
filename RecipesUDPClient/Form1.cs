using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;
using System.Text;
using RecipesLibrary;

namespace RecipesUDPClient
{
    public partial class Form1 : Form
    {
        int remotePort;

        IPAddress IPAddress;

        List<string> products = new List<string>();
    
        public Form1()
        {
            IPAddress = IPAddress.Parse("192.168.178.34");
            remotePort = 11000;

            InitializeComponent();
            Process.Start("RecipesUDPServer.exe");
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            UdpClient client = new UdpClient();

            try
            {
                string json = JsonSerializer.Serialize<List<string>>(products);

                byte[] buff = Encoding.Default.GetBytes(json);

                IPEndPoint remoteEP = new IPEndPoint(IPAddress, remotePort);

                client.Send(buff, buff.Length, remoteEP);

                byte[] received = client.Receive(ref remoteEP);

                string dataResponse = Encoding.Default.GetString(received, 0, received.Length);

                List<Recipe>? recipes = JsonSerializer.Deserialize<List<Recipe>>(dataResponse);

                if (recipes == null)
                {
                    throw new Exception("Nothing was found");
                }
                else
                {
                    gridRecipes.DataSource = null;
                    gridRecipes.DataSource = recipes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            finally
            {
                client.Close();
            }
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox? checkBox = sender as CheckBox;

            if (checkBox == null) return;

            if(checkBox.Checked == true)
            {
                products.Add(checkBox.Text);
            }
            else
            {
                products.Remove(checkBox.Text);
            }
        }
    }
}
