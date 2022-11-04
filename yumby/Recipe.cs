namespace yumby;
using static System.Console;

public class Recipe
{
    public string RecipeName { get; set; }
    public List<Ingredient> Ingredients = new List<Ingredient>();
    public string Author { get; set; }
    public string Instructions { get; set; }
    public double ServingSize { get; set; }
    
    public List<string> Tags = new List<string>();

    //Recipe()
    //{

    //}
}
