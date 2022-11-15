namespace yumby;
using static Console;

public class Recipe
{
    public string? Name { get; set; }
    public List<Ingredient> Ingredients = new List<Ingredient>();
    public List<string?> Instructions = new List<string?>();
    public double ServingsYielded;

    public Ingredient AddNewIngredient()
    {
        var ingredient = new Ingredient();
        
        Write("Enter ingredient name: ");
        ingredient.Name = ReadLine();
        
        do Write("Enter ingredient quantity: ");
        while (!double.TryParse(Console.ReadLine(), out ingredient.Quantity));
        
        Write("Enter ingredient unit: ");
        ingredient.Unit = ReadLine();
        
        return ingredient;
    }

    public string? AddInstructionsLine()
    {
        string? instructionsLine = ReadLine();
        return instructionsLine;
    }

    
}
