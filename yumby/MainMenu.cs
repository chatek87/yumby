namespace yumby;
using static System.Console;


public static class MainMenu
{
    public static void Start()
    {
        Title = "=== Yumby ===";
        Run();
    }

    private static void Run()
    {
        string prompt = Banner.YumbyArt() + "Welcome to Yumby!";
        string[] options = { "my recipes", "about", "exit" };
        var mainMenu = new Menu(prompt, options);
        int selectionIndex = mainMenu.Run();

        switch (selectionIndex)
        {
            case 0:
                RecipesMenu();
                break;
            case 1:
                DisplayAboutInfo();
                break;
            case 2:
                ExitMenu.Start();
                break;
        }
    }

    private static void DisplayAboutInfo()
    {
        Clear();
        ForegroundColor = ConsoleColor.Blue;
        WriteLine("Yumby is a personal recipe keeper");
        WriteLine("use it to search, store, edit, and find recipes");
        WriteLine("Press any key to return to the menu");
        ReadKey(true);
        Run();
    }

    private static void RecipesMenu()
    {
        string prompt = "my recipes";
        string[] options = { "browse all", "search", "enter new recipe", "back" };
        Menu recipeMenu = new Menu(prompt, options);
        int selectedIndex = recipeMenu.Run();

        //BackgroundColor = ConsoleColor.White;   
        switch (selectedIndex)
        {
            case 0:                
                WriteLine("You selected BROWSE RECIPES");
                break;
            case 1:
                WriteLine("You selected SEARCH RECIPES");
                break;
            case 2:
                WriteLine("You selected ENTER NEW RECIPE");
                break;
            case 3:
                Run();
                break;
        }
        WriteLine("Press any key to return to Main Menu");
        ReadKey(true);

        //ResetColor();
        Run();
    }
}