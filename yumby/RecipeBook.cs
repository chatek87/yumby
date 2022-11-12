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
        
        string[] options = { "yes", "no" };
        myRecipe.Ingredients.Add(myRecipe.AddNewIngredient());
        var menu = new Menu("Add another ingredient?", options);
        int selectionIndex = menu.Run();
        switch (selectionIndex)
        {
            case 0:
                myRecipe.Ingredients.Add(myRecipe.AddNewIngredient());
                break;
            case 1:
                break;
        }
        
        
        WriteLine("Recipe instructions: \n(type one line at a time, followed by \"ENTER\"");
        myRecipe.Instructions.Add(myRecipe.AddInstructionsLine());
        
        Clear();
        
        Console.WriteLine($"{myRecipe.Name}");
        Console.WriteLine($"Ingredients: {myRecipe.Ingredients.Count}");
        Console.WriteLine($"{myRecipe.Name} INSTRUCTIONS: {myRecipe.Instructions.Count}");
        
        return myRecipe;
    }

    public void EditRecipe()
    {
        
    }

    public void ListAllRecipes()
    {
        
    }
}