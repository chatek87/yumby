namespace yumby;
using System.Text.Json;

public class RecipeBook
{
    public string? RecipeBookName { get; set; }
    public IDictionary<string, Recipe> MyRecipeBook = new Dictionary<string, Recipe>();
   
    public static Recipe CreateNewRecipe()
    {
        var myRecipe = new Recipe();
        
        Console.Write("Recipe name: ");
        myRecipe.Name = Console.ReadLine();
        
        Console.Write("Recipe instructions: ");
        myRecipe.Instructions = new List<string> { Console.ReadLine()! };
        Console.Clear();
        
        // myRecipe.Ingredients.Add();
        // Console.WriteLine($"You entered {myRecipe.Name} for your recipe name");
        // Console.WriteLine($"{myRecipe.Name} INSTRUCTIONS: {myRecipe.Instructions}");
        
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