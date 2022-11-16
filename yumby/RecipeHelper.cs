namespace yumby;
using static Console;


public static class RecipeHelper
{
    public static Recipe CreateNewRecipe()
    {
        // initialize recipe
        var myRecipe = new Recipe();
        
        // add name
        Write("Recipe name: ");
        myRecipe.Name = ReadLine();
        Clear();
        
        // add first ingredient
        string prompt1 = $"<< {myRecipe.Name} ingredients >>";
        string[] options1 = { "add another ingredient", "done adding ingredients" };
        Console.WriteLine(prompt1);
        myRecipe.Ingredients = new List<Ingredient>();
        myRecipe.Ingredients.Add(myRecipe.AddNewIngredient());
        
        // keep prompting to add new ingredients 
        var menu1 = new Menu(prompt1, options1);
        int selectionIndex1 = menu1.Run();
        while (selectionIndex1 == 0)
        {
            Clear();
            //TODO: LIST ALL CURRENTLY ADDED INGREDIENTS 
            myRecipe.Ingredients.Add(myRecipe.AddNewIngredient());
            selectionIndex1 = menu1.Run();
        }
        Clear();

        double myRecipeServingsYielded;
        do Write($"<< {myRecipe.Name} >> \nEnter number of servings yielded: ");
        while (!double.TryParse(ReadLine(), out myRecipeServingsYielded));
        myRecipe.ServingsYielded = myRecipeServingsYielded;
        Clear();
        
        
        string prompt2 = $"<< {myRecipe.Name} instructions >> \n(type one line at a time, followed by \"ENTER\")";
        string[] options2 = { "add another line", "finish" };
        WriteLine(prompt2);
        myRecipe.Instructions = new List<string>();
        myRecipe.Instructions.Add(myRecipe.AddInstructionsLine());
        
        var menu2 = new Menu(prompt2, options2);
        int selectionIndex2 = menu2.Run();
        while (selectionIndex2 == 0)
        {
            Clear();
            //TODO: LIST ALL CURRENTLY ADDED LINES OF INSTRUCTIONS 
            myRecipe.Instructions.Add((myRecipe.AddInstructionsLine()));
            selectionIndex2 = menu2.Run();
        }
        Clear();
        
        Console.WriteLine($"{myRecipe.Name} Added!");
        
        return myRecipe;
    }
    
    public static void DisplayRecipe(Recipe recipe)
    {
        Console.WriteLine(recipe.Name);
        Console.WriteLine(" ");
        Console.WriteLine(recipe.Ingredients);
        Console.WriteLine(recipe.Instructions);
        Console.WriteLine(recipe.ServingsYielded);
    }

    public static void ListAllRecipes()
    {
        
    }
}