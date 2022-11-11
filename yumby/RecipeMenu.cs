using static System.Console;

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
                Clear();
                WriteLine("You selected BROWSE RECIPES");
                break;
            case 1:
                Clear();
                WriteLine("You selected SEARCH RECIPES");
                break;
            case 2:
                Clear();
                WriteLine("You selected ENTER NEW RECIPE");
                
                RecipeBook.CreateNewRecipe();
                WriteLine("Press any key to return to previous menu");
                ReadKey(true);
                Start();
                break;
            case 3:
                MainMenu.Start();
                break;
        }
        WriteLine("Press any key to return to Main Menu");
        ReadKey(true);

    }
}