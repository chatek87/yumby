namespace yumby;
using static System.Console;


public static class MainMenu
{
    public static void Start()
    {
        Title = "=== Yumby ===";
        RunMainMenu();
    }

    private static void RunMainMenu()
    {       
        string prompt = "Welcome to Yumby!";
        string[] options = { "my recipes", "about", "exit" };
        Menu mainMenu = new Menu(prompt, options);
        int selectedIndex = mainMenu.Run();

        switch (selectedIndex)
        {
            case 0:
                MyRecipes();
                break;
            case 1:
                DisplayAboutInfo();
                break;
            case 2:
                ExitProgram();
                break;
        }
    }

    private static void ExitProgram()
    {
        WriteLine("\nPress any key to exit...");
        ReadKey(true);
        Environment.Exit(0);
    }

    private static void DisplayAboutInfo()
    {
        Clear();
        WriteLine("Yumby is a personal recipe keeper");
        WriteLine("use it to search, store, edit, and find recipes");
        WriteLine("Press any key to return to the menu");
        ReadKey(true);
        RunMainMenu();
    }

    private static void MyRecipes()
    {
        string prompt = "My Recipes";
        string[] options = { "Browse All Recipes", "Search Recipes", "Enter New Recipe" };
        Menu recipeMenu = new Menu(prompt, options);
        int selectedIndex = recipeMenu.Run();

        //BackgroundColor = ConsoleColor.White;   
        switch (selectedIndex)
        {
            case 0:                
                WriteLine("You selected BROWSE ALL RECIPES");
                break;
            case 1:
                WriteLine("You selected SEARCH RECIPES");
                break;
            case 2:
                WriteLine("You selected ENTER NEW RECIPE");
                break;
        }
        WriteLine("Press any key to return to Main Menu");
        ReadKey(true);

        //ResetColor();
        RunMainMenu();
    }
}