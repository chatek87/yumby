namespace yumby;

public class Recipe
{
    public string RecipeName { get; set; }
    public HashSet<Ingredient> Ingredients = new HashSet<Ingredient>();
    public string Author { get; set; }
    public string Instructions { get; set; }
    public double ServingSize { get; set; }
    public List<string> Tags = new List<string>();
}
