namespace yumby;

public static class Utility
{
    public static Recipe ChangeServingSize(Recipe convertedRecipe)
    {
        Console.Write($"Enter the desired number of servings yielded of {convertedRecipe.Name}: ");
        decimal desiredServings;
        decimal conversionFactor;
        while (!decimal.TryParse(Console.ReadLine(), out desiredServings));
        
        if (desiredServings == 0)
        {
            desiredServings = 1;
        }
        
        if (convertedRecipe.ServingsYielded == 0)
        {
            conversionFactor = 1;
        }
        else
        {
            conversionFactor = desiredServings / convertedRecipe.ServingsYielded;
        }

        foreach (var ingredient in convertedRecipe.Ingredients)
        {
            ingredient.Quantity = decimal.Round(ingredient.Quantity * conversionFactor, 2); //;
        }

        convertedRecipe.ServingsYielded = decimal.Round(desiredServings);
        
        return convertedRecipe;
    }    
}