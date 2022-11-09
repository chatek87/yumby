namespace yumby;
using System.Text.Json;

public class Utilities
{
   
    public static Recipe CreateNewRecipe()
    {
        
        Console.Write("Recipe name: ");
        string? recipeName = Console.ReadLine();
        var myRecipe = new Recipe(recipeName);
        
        Console.Write("Recipe instructions: ");
        myRecipe.Instructions = Console.ReadLine();
        Console.Clear();
            
        Console.WriteLine($"You entered {myRecipe.Name} for your recipe name");
        Console.WriteLine($"{myRecipe.Name} INSTRUCTIONS: {myRecipe.Instructions}");
        
        

        return myRecipe;
    }

    public void EditRecipe()
    {
        
    }

    public void SaveRecipe()
    {
        
    }
    
    public void ListAllRecipes()
    {
        
    }
}