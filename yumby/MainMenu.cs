namespace yumby;

public static class MainMenu
{
    public static void Start()
    {
        Run();
    }

    private static void Run()
    {
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
        Console.Clear();
        Console.WriteLine("Yumby is a personal recipe keeper");
        Console.WriteLine("use it to search, store, edit, and find recipes");
        Console.WriteLine("\n");
        Console.WriteLine("Acknowledgements:");
        Console.WriteLine("Many thanks to mentors Adam, Ben, and JB, as well as code KY \nstaff and fellow students for all the help during this session.\nThis has been a great learning experience. Cheers!\n\n\n");
        Console.WriteLine("Press any key to return to the Main Menu");
        Console.ReadKey(true);
        Run();
    }
}