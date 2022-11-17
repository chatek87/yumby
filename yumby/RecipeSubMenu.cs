namespace yumby;

public static class RecipeSubMenu
{
    public static void Start(Recipe recipe)
    {
        Run(recipe);
    }
    private static void Run(Recipe recipeInput)
    {
        var selectedRecipe = recipeInput;
        string prompt = $"<< {selectedRecipe.Name} >>\n";
        string[] options = { "view recipe", "change serving size", "generate shopping list", "back" };
        var recipeSubMenu = new Menu(prompt, options);
        int selectionIndex = recipeSubMenu.Run();

        switch (selectionIndex)
        {
            case 0:
                //view recipe
                RecipeHelper.DisplayRecipe(selectedRecipe);
                
                Console.WriteLine("\n\n");
                Console.WriteLine("Press any key to return to previous menu");
                Console.ReadKey(true);
                RecipeSubMenu.Run(selectedRecipe);
                break;
            case 1:
                //change serving size
                var myConvertedRecipe = Utility.ChangeServingSize(selectedRecipe);
                RecipeHelper.DisplayRecipe(myConvertedRecipe);
                
                Console.WriteLine("\n\n");
                Console.WriteLine("Press any key to return to previous menu");
                Console.ReadKey(true);
                RecipeSubMenu.Run(selectedRecipe);
                break;
            case 2:
                //generate shopping list
                // TODO: GENERATE SHOPPING LIST METHOD. 
                Console.WriteLine("TODO: generate shopping list, write to text file?");
                
                Console.WriteLine("\n\n");
                Console.WriteLine("Press any key to return to previous menu");
                Console.ReadKey(true);
                RecipeSubMenu.Run(selectedRecipe);
                break;
            case 3:
                //go back
                RecipeMenu.Start();
                break;
        }
    }
}