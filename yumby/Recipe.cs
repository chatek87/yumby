namespace yumby;

public class Recipe
{
    public string? RecipeName { get; set; }
    public List<Ingredient> Ingredients = new List<Ingredient>();
    public string? Instructions { get; set; }

    public string? Notes { get; set; }
    public double NumberOfServings { get; set; }
    public string? Author { get; set; }
    public List<string> Tags = new List<string>();
}
