namespace yumby;
using static Console;

public class MainMenu
{
    public static void Start()
    {
        Title = "=== Yumby ===";
        Run();
    }

    private static void Run()
    {
        var myRecipeBook = new Utilities();
        string prompt = Banner.YumbyArt() + "welcome to yumby!";
        string[] options = { "my recipes", "about", "exit" };
        var mainMenu = new Menu(prompt, options);
        int selectionIndex = mainMenu.Run();

        switch (selectionIndex)
        {
            case 0:
                RecipeMenu.Start();
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
        WriteLine("Yumby is a personal recipe keeper");
        WriteLine("use it to search, store, edit, and find recipes");
        WriteLine("Press any key to return to the menu");
        ReadKey(true);
        Run();
    }
}