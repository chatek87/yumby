namespace yumby;
using static Console;

public class Recipe
{
    public string? Name { get; set; }
    public List<Ingredient> Ingredients = new List<Ingredient>();
    public List<string> Instructions = new List<string>();
    public double ServingsYielded { get; set; }

    public Ingredient AddNewIngredient()
    {
        var ingredient = new Ingredient();
        Write("Enter ingredient name: ");
        ingredient.Name = ReadLine();
        Write("Enter ingredient quantity: ");
        ingredient.Quantity = decimal.Parse(ReadLine());
        Write("Enter ingredient unit: ");
        ingredient.Unit = ReadLine();
        
        return ingredient;
    }

    public string AddInstructionsLine()
    {
        var instructionsLine = ReadLine();
        return instructionsLine;
    }

    
}
