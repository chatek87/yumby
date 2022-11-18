namespace yumby;

public static class RecipeSubMenu
{
    public static void Start(Recipe recipe)
    {
        Run(recipe);
    }
    
    private static void Run(Recipe recipeInput)
    {
        while (true)
        {
            var selectedRecipe = recipeInput;
            string prompt = $"<< {selectedRecipe.Name} >>\n";
            string[] options = { "view recipe", "change serving size", "view shopping list", "back" };
            var recipeSubMenu = new Menu(prompt, options);
            int selectionIndex = recipeSubMenu.Run();

            switch (selectionIndex)
            {
                case 0:
                    //view recipe
                    Console.Clear();
                    RecipeHelper.DisplayRecipe(selectedRecipe);

                    Console.WriteLine("\n");
                    Console.WriteLine("Press any key to return to previous menu");
                    Console.ReadKey(true);
                    recipeInput = selectedRecipe;
                    continue;
                case 1:
                    //change serving size
                    Console.Clear();
                    var myConvertedRecipe = Utility.ChangeServingSize(selectedRecipe);
                    Console.Clear();
                    RecipeHelper.DisplayRecipe(myConvertedRecipe);

                    Console.WriteLine("\n");
                    Console.WriteLine("Press any key to return to previous menu");
                    Console.ReadKey(true);
                    recipeInput = selectedRecipe;
                    continue;
                case 2:
                    //view shopping list
                    Console.Clear();
                    RecipeHelper.DisplayShoppingList(selectedRecipe);

                    Console.WriteLine("\n");
                    Console.WriteLine("Press any key to return to previous menu");
                    Console.ReadKey(true);
                    recipeInput = selectedRecipe;
                    continue;
                case 3:
                    //go back
                    RecipeMenu.Start();
                    break;
            }
            break;
        }
    }
}