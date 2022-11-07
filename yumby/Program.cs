namespace yumby;

class Program
{
    static void Main(string[] args)
    {
        MainMenu.Start();
    }
}


//class Program
//{
//private static bool _exit;

//static void Main(string[] args)
//{
//    Console.BackgroundColor = ConsoleColor.Black;
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.Clear();

//    Banner.WelcomeMessage();    
//    while (!_exit)
//    {
//        MainMenu();
//    }
//}

//public static void MainMenu()
//{
//    Console.WriteLine("Please make a selection");
//    Console.WriteLine("1: Find a new Recipe");
//    Console.WriteLine("2: Search existing Recipes");
//    Console.WriteLine("3: Add Recipe");
//    Console.WriteLine("4: Edit Recipe");
//    Console.WriteLine("5: User Settings");
//    Console.WriteLine("6: Exit");
//    //Console.WriteLine("7: Surprise ;)");

//    string mainMenuChoice = Console.ReadLine();

//    switch (mainMenuChoice)
//    {
//        case "1":
//            //NewRecipe();
//            Console.WriteLine($"You entered {mainMenuChoice}");
//            break;

//        case "2":
//            //SearchRecipes();
//            Console.WriteLine($"You entered {mainMenuChoice}");
//            break;

//        case "3":
//            //AddRecipe();
//            Console.WriteLine($"You entered {mainMenuChoice}");
//            break;

//        case "4":
//            //EditRecipe();
//            Console.WriteLine($"You entered {mainMenuChoice}");
//            break;

//        case "5":
//            //UserSettings();
//            Console.WriteLine($"You entered {mainMenuChoice}");
//            break;

//        case "6":
//            Console.WriteLine($"You entered {mainMenuChoice}");
//            _exit = true;
//            break;

//        case "7":
//            Console.BackgroundColor = ConsoleColor.Black;
//            Console.Clear();
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.Beep(440, 250);
//            Banner.Foob();
//            Console.Beep(654, 250);
//            Console.Beep(859, 250);
//            Console.Beep(1140, 250);
//            Console.Beep(465, 520);
//            Console.Beep(769, 250);
//            Console.Beep(110, 500);

//            Console.BackgroundColor = ConsoleColor.DarkRed;
//            Console.ForegroundColor = ConsoleColor.White;
//            Console.Clear();
//            Banner.Foob();
//            Console.ReadLine();
//            break;
//    }

//}
//}