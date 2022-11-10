namespace yumby;

public class Recipe
{
    public string? Name { get; set; }
    public List<Ingredient> Ingredients = new List<Ingredient>();
    public List<string> Instructions = new List<string>();

    // public string? Notes { get; set; }
    // public double NumberOfServings { get; set; }
    // public string? Author { get; set; }
    // public List<string> Tags = new List<string>();

    // public Recipe(string recipeName)
    // {
    //     Name = recipeName;
    // }
}
