namespace yumby;
using static Console;

public class Recipe
{
    public string? Name { get; set; }
    public List<Ingredient> Ingredients { get; set; }
    public List<string> Instructions { get; set; }
    public double ServingsYielded { get; set; }

    public Ingredient AddNewIngredient()
    {
        var ingredient = new Ingredient();
        
        Write("Enter ingredient name: ");
        ingredient.Name = ReadLine();

        double ingredientQuantity;
        do Write("Enter ingredient quantity: ");
        while (!double.TryParse(Console.ReadLine(), out ingredientQuantity));
        ingredient.Quantity = ingredientQuantity;
        
        Write("Enter ingredient unit: ");
        ingredient.Unit = ReadLine();
        
        return ingredient;
    }

    public string AddInstructionsLine()
    {
        string instructionsLine = ReadLine();
        return instructionsLine;
    }

    
}
