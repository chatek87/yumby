namespace yumby;

public static class Utility
{
    public static Recipe ChangeServingSize(Recipe convertedRecipe)
    {
        Console.WriteLine("Enter the desired number of servings yielded for the recipe: ");
        decimal desiredServings;
        while (!decimal.TryParse(Console.ReadLine(), out desiredServings));

        var conversionFactor = desiredServings /convertedRecipe.ServingsYielded;
        
        foreach (var ingredient in convertedRecipe.Ingredients)
        {
            ingredient.Quantity = decimal.Round(ingredient.Quantity * conversionFactor, 2); //;
        }

        convertedRecipe.ServingsYielded = decimal.Round(desiredServings);
        
        return convertedRecipe;
    }    
}