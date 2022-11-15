﻿namespace yumby;
using static Console;


public static class RecipeHelper
{
    public static Recipe CreateNewRecipe()
    {
        var myRecipe = new Recipe();
        
        Write("Recipe name: ");
        myRecipe.Name = ReadLine();
        
        //TODO: FIGURE OUT WHY THE SUBSEQUENT FIELDS ARE NOT BEING SAVED 
        myRecipe.Ingredients = new List<Ingredient>();
        myRecipe.Ingredients.Add(myRecipe.AddNewIngredient());

        string[] options1 = { "add another ingredient", "done adding ingredients" };
        string prompt1 = $"<< {myRecipe.Name} ingredients >>";//Add another ingredient?";
        var menu1 = new Menu(prompt1, options1);
        
        int selectionIndex1 = menu1.Run();
        while (selectionIndex1 == 0)
        {
            myRecipe.Ingredients.Add(myRecipe.AddNewIngredient());
            selectionIndex1 = menu1.Run();
        }
        Clear();

        double myRecipeServingsYielded;
        do Write("Enter number of servings yielded: ");
        while (!double.TryParse(ReadLine(), out myRecipeServingsYielded));
        myRecipe.ServingsYielded = myRecipeServingsYielded;
        Clear();
        
        WriteLine("Recipe instructions: \n(type one line at a time, followed by \"ENTER\"");
        myRecipe.Instructions = new List<string>();
        myRecipe.Instructions.Add(myRecipe.AddInstructionsLine());
        string[] options2 = { "add another line", "finish" };
        string prompt2 = $"<< {myRecipe.Name} instructions >>";
        var menu2 = new Menu(prompt2, options2);
        int selectionIndex2 = menu2.Run();
        while (selectionIndex2 == 0)
        {
            myRecipe.Instructions.Add((myRecipe.AddInstructionsLine()));
            selectionIndex2 = menu2.Run();
        }

        Clear();
        
        Console.WriteLine($"{myRecipe.Name}");
        Console.WriteLine($"Ingredients: {myRecipe.Ingredients}");
        Console.WriteLine($"{myRecipe.Name} INSTRUCTIONS: {myRecipe.Instructions}");

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