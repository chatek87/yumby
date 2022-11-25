namespace yumby;

public static class Utility
{
    public static Recipe ChangeServingSize(Recipe convertedRecipe)
    {
        decimal desiredServings;
        decimal conversionFactor;
        do
        {
            Console.Write($"Enter the desired number of servings yielded of {convertedRecipe.Name} (must be numerical): ");
        }        
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

        convertedRecipe.ServingsYielded = decimal.Round(desiredServings, 2);
        
        return convertedRecipe;
    }    
}