namespace yumby;

public class Recipe
{
    public string? Name { get; set; }
    public List<Ingredient> Ingredients { get; set; } = null!;
    public List<string> Instructions { get; set; } = null!;
    public decimal ServingsYielded { get; set; }

    public Ingredient AddNewIngredient()
    {
        var ingredient = new Ingredient();
        
        Console.Write("Enter ingredient name: ");
        string? lowerCaseIngredientName = Console.ReadLine();
        ingredient.Name = lowerCaseIngredientName?.ToLower();
      
        decimal ingredientQuantity;
        do Console.Write("Enter ingredient quantity (must be numerical value): ");
        while (!decimal.TryParse(Console.ReadLine(), out ingredientQuantity));
        ingredient.Quantity = ingredientQuantity;
        if (ingredient.Quantity == 0)
        {
            ingredient.Quantity = 1;
            Console.WriteLine($"Ingredient quantity set to 1 by default");
        }
        
        Console.Write("Enter ingredient unit: ");
        ingredient.Unit = Console.ReadLine();
        
        return ingredient;
    }

    public string? AddInstructionsLine()
    {
        string? instructionsLine = Console.ReadLine();
        return instructionsLine;
    }
}
