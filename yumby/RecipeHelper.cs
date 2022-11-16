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
        
        // add ingredients
        string prompt1 = $"<< {myRecipe.Name} ingredients >>";
        string[] options1 = { "add another ingredient", "done adding ingredients" };
        Console.WriteLine(prompt1);
        myRecipe.Ingredients = new List<Ingredient>();
        myRecipe.Ingredients.Add(myRecipe.AddNewIngredient());
        var menu1 = new Menu(prompt1, options1);
        int selectionIndex1 = menu1.Run();
        while (selectionIndex1 == 0)
        {
            Clear();
            //TODO: LIST ALL CURRENTLY ADDED INGREDIENTS 
            WriteLine(prompt1);
            foreach (Ingredient ingredient in myRecipe.Ingredients)
            {
                WriteLine($"{ingredient.Name} added to recipe!");
            }
            myRecipe.Ingredients.Add(myRecipe.AddNewIngredient());
            selectionIndex1 = menu1.Run();
        }
        Clear();

        // add instructions
        string prompt2 = $"<< {myRecipe.Name} instructions >> ";
        string[] options2 = { "add another line", "finish" };
        WriteLine(prompt2);
        Console.WriteLine("(type one line at a time, followed by \"ENTER\")");
        myRecipe.Instructions = new List<string>();
        myRecipe.Instructions.Add(myRecipe.AddInstructionsLine());
        var menu2 = new Menu(prompt2, options2);
        int selectionIndex2 = menu2.Run();
        while (selectionIndex2 == 0)
        {
            Clear();
            //TODO: LIST ALL CURRENTLY ADDED LINES OF INSTRUCTIONS 
            WriteLine(prompt2);
            foreach (string instructionLine in myRecipe.Instructions)
            {
                WriteLine(instructionLine);
            }
            myRecipe.Instructions.Add((myRecipe.AddInstructionsLine()));
            selectionIndex2 = menu2.Run();
        }
        Clear();
        
        // add servings yielded
        double myRecipeServingsYielded;
        do Write($"<< {myRecipe.Name} servings >> \nEnter number of servings yielded: ");
        while (!double.TryParse(ReadLine(), out myRecipeServingsYielded));
        myRecipe.ServingsYielded = myRecipeServingsYielded;
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