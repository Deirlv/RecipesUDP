namespace RecipesLibrary
{
    public class Recipe
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public List<string> Products { get; set; } = new List<string>();
    }
}
