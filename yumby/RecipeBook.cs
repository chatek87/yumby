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
        
        myRecipe.Ingredients.Add(myRecipe.AddNewIngredient());
        string[] options1 = { "add another ingredient", "add recipe instructions" };
        string prompt1 = "";//Add another ingredient?";
        var menu1 = new Menu(prompt1, options1);
        
        int selectionIndex1 = menu1.Run();
        while (selectionIndex1 == 0)
        {
            myRecipe.Ingredients.Add(myRecipe.AddNewIngredient());
            selectionIndex1 = menu1.Run();
        }
        // switch (selectionIndex)
        // {
        //     case 0:
        //         myRecipe.Ingredients.Add(myRecipe.AddNewIngredient());
        //         break;
        //     case 1:
        //         break;
        // }
        
        WriteLine("Recipe instructions: \n(type one line at a time, followed by \"ENTER\"");
        myRecipe.Instructions.Add(myRecipe.AddInstructionsLine());
        string[] options2 = { "add another line", "finish" };
        string prompt2 = "";
        var menu2 = new Menu(prompt2, options2);
        int selectionIndex2 = menu2.Run();
        while (selectionIndex2 == 0)
        {
            myRecipe.Instructions.Add((myRecipe.AddInstructionsLine()));
            selectionIndex2 = menu2.Run();
        }
        
        
        // switch (selectionIndex)
        // {
        //     case 0:
        //         myRecipe.Instructions.Add(myRecipe.AddInstructionsLine());
        //         break;
        //     case 1:
        //         break;
        // }
        Clear();
        
        Console.WriteLine($"{myRecipe.Name}");
        Console.WriteLine($"Ingredients: {myRecipe.Ingredients}");
        Console.WriteLine($"{myRecipe.Name} INSTRUCTIONS: {myRecipe.Instructions}");
        
        return myRecipe;
    }

    public void EditRecipe()
    {
        
    }

    public void ListAllRecipes()
    {
        
    }
}