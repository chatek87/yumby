namespace yumby;

public static class Utility
{
    //TODO: ADD conversion method
    public static Recipe ChangeServingSize(Recipe convertedRecipe)
    {
        Console.WriteLine("Enter the desired number of servings yielded for the recipe: ");
        double desiredServings;
        while (!double.TryParse(Console.ReadLine(), out desiredServings));

        double conversionFactor = desiredServings /convertedRecipe.ServingsYielded;
        
        foreach (var ingredient in convertedRecipe.Ingredients)
        {
            ingredient.Quantity = ingredient.Quantity * conversionFactor;
        }

        convertedRecipe.ServingsYielded = desiredServings;
        
        return convertedRecipe;
    }    
}