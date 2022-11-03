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
        Clear();
        WriteLine(@"

                            ,-.
                        _,-' - `--._
                      ,'.:  __' _..-)       s e e   y o u   l a t e r ,  b u d d y !
                    ,'     /,o)'  ,'   
                   ;.    ,'`-' _,)
                 ,'   :.   _.-','
               ,' .  .    (   /
              ; .:'     .. `-/
            ,'       ;     ,'
         _,/ .   ,      .,' ,
       ,','     .  .  . .\,'..__
     ,','  .:.      ' ,\ `\)``
     `-\_..---``````-'-.`.:`._/
     ,'   '` .` ,`- -.  ) `--..`-..
     `-...__________..-'-.._  \
        ``--------..`-._ ```
                     ``    

");
        //Thread.Sleep(1250);
        //WriteLine("\nPress any key to exit...");
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
        string prompt = "my recipes";
        string[] options = { "browse recipes", "search recipes", "enter new recipe", "back" };
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
                RunMainMenu();
                break;
        }
        WriteLine("Press any key to return to Main Menu");
        ReadKey(true);

        //ResetColor();
        RunMainMenu();
    }
}