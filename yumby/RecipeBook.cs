namespace yumby;
using static Console;
using System.Text.Json;

public class RecipeBook
{
    public string? RecipeBookName { get; set; }
    public Dictionary<string, Recipe> MyRecipeBook = new Dictionary<string, Recipe>();
   
    public static Recipe CreateNewRecipe()
    {
        var myRecipe = new Recipe();
        
        Write("Recipe name: ");
        myRecipe.Name = ReadLine();
        
        //AddIngredients()
        myRecipe.AddIngredient();
        WriteLine("You added an ingredient. Add another?");
        
        //AddInstructions()
        Write("Recipe instructions: ");
        myRecipe.Instructions = new List<string> { ReadLine()! };
        Clear();
        
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