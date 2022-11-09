namespace yumby;

public static class RecipeMenu
{
    public static void Start()
    {
        Run();
    }
    private static void Run()
    {
        string prompt = "my recipes";
        string[] options = { "browse all", "search", "enter new recipe", "back" };
        var menu = new Menu(prompt, options);
        int selectedIndex = menu.Run();

    
        switch (selectedIndex)
        {
            case 0:                
                Console.WriteLine("You selected BROWSE RECIPES");
                break;
            case 1:
                Console.WriteLine("You selected SEARCH RECIPES");
                break;
            case 2:
                Console.WriteLine("You selected ENTER NEW RECIPE");
                var myRecipeBook = new RecipeBook();
                myRecipeBook.CreateNewRecipe();
                

                Console.WriteLine("Press any key to return to Main Menu");
                Console.ReadKey(true);
                MainMenu.Start();
                break;
            case 3:
                MainMenu.Start();
                break;
        }
        Console.WriteLine("Press any key to return to Main Menu");
        Console.ReadKey(true);

    }
}