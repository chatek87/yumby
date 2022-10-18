class Program
{
private static bool _exit;
    
static void Main(string[] args)
{
    Console.BackgroundColor = ConsoleColor.DarkMagenta;
    Console.ForegroundColor = ConsoleColor.Yellow;
        
    while (!_exit)
    {
        MainMenu();
    }
}
public static void MainMenu()
{
    Console.WriteLine("Welcome to *yUmBy~*~*~**");
    Console.Write("\n");
    Console.WriteLine("Please make a selection");
    Console.WriteLine("1: Find a new Recipe");
    Console.WriteLine("2: Search existing Recipes");
    Console.WriteLine("3: Add Recipe");
    Console.WriteLine("4: Edit Recipe");
    Console.WriteLine("5: User Settings");
    Console.WriteLine("6: Exit");
    string mainMenuChoice = Console.ReadLine();

    switch (mainMenuChoice)
    {
        case "1":
            //NewRecipe();
            Console.WriteLine($"You entered {mainMenuChoice}");
            break;
            
        case "2":
            //SearchRecipes();
            Console.WriteLine($"You entered {mainMenuChoice}");
            break;
            
        case "3":
            //AddRecipe();
            Console.WriteLine($"You entered {mainMenuChoice}");
            break;
            
        case "4":
            //EditRecipe();
            Console.WriteLine($"You entered {mainMenuChoice}");
            break;
           
        case "5":
            //UserSettings();
            Console.WriteLine($"You entered {mainMenuChoice}");
            break;
            
        case "6":
            Console.WriteLine($"You entered {mainMenuChoice}");
            _exit = true;
            break;
    }

}
}