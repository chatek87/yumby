namespace yumby;

public static class ExitMenu
{
    public static void Start()
    {
        Run();
    }

    private static void Run()
    {
        string prompt = Banner.ExitArt() + "Are you sure you want to exit?";
        string[] options = { "yes", "no, go back" };
        var menu = new Menu(prompt, options);
        int selectionIndex = menu.Run();

        switch (selectionIndex)
        {
            case 0:
                ExitProgram();
                break;
            case 1:
                MainMenu.Start();
                break;
            
        // Console.Clear();
        // Console.ForegroundColor = ConsoleColor.Blue;
        // Console.WriteLine(Banner.ExitArt());
        //
        // //Thread.Sleep(1250);
        // //WriteLine("\nPress any key to exit...");
        // Console.ReadKey(true);
        }

    }
    
    private static void ExitProgram()
    {

        Environment.Exit(0);
    }
}