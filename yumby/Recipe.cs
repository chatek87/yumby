namespace yumby;

public class Recipe
{
    public string? Name { get; set; }
    public List<Ingredient> Ingredients { get; set; } = null!;
    public List<string> Instructions { get; set; } = null!;
    public double ServingsYielded { get; set; }

    public Ingredient AddNewIngredient()
    {
        var ingredient = new Ingredient();
        
        Console.Write("Enter ingredient name: ");
        string? lowerCaseIngredientName = Console.ReadLine();
        ingredient.Name = lowerCaseIngredientName?.ToLower();
        double ingredientQuantity;
      
        do Console.Write("Enter ingredient quantity: ");
        while (!double.TryParse(Console.ReadLine(), out ingredientQuantity));
        ingredient.Quantity = ingredientQuantity;
        
        Console.Write("Enter ingredient unit: ");
        ingredient.Unit = Console.ReadLine();
        
        return ingredient;
    }

    public string AddInstructionsLine()
    {
        string instructionsLine = Console.ReadLine();
        return instructionsLine;
    }
}
