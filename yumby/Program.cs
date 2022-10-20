class Program
{
private static bool _exit;
    
static void Main(string[] args)
{
    Console.BackgroundColor = ConsoleColor.DarkMagenta;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Clear();
    
    WelcomeMessage();    
    while (!_exit)
    {
        MainMenu();
    }
}

public static void WelcomeMessage()
{
    Console.WriteLine(@"
██╗   ██╗    ██╗   ██╗    ███╗   ███╗    ███╗   ███╗    ███╗   ███╗    ██████╗     ██╗   ██╗
╚██╗ ██╔╝    ██║   ██║    ████╗ ████║    ████╗ ████║    ████╗ ████║    ██╔══██╗    ╚██╗ ██╔╝
 ╚████╔╝     ██║   ██║    ██╔████╔██║    ██╔████╔██║    ██╔████╔██║    ██████╔╝     ╚████╔╝ 
  ╚██╔╝      ██║   ██║    ██║╚██╔╝██║    ██║╚██╔╝██║    ██║╚██╔╝██║    ██╔══██╗      ╚██╔╝  
   ██║       ╚██████╔╝    ██║ ╚═╝ ██║    ██║ ╚═╝ ██║    ██║ ╚═╝ ██║    ██████╔╝       ██║   
   ╚═╝        ╚═════╝     ╚═╝     ╚═╝    ╚═╝     ╚═╝    ╚═╝     ╚═╝    ╚═════╝        ╚═╝   
                                                                                            
");
}

public static void Foob()
{
    Console.WriteLine(@"
.7G#J!P&&&&&&!~!YY?!.:!~:~^!7?7!^  :.....:!?JJ!~J&
~~YP####&&&&&GGGB&&&!^7!!7??J?7!~^.!Y?.   .:~:!J7Y
G5P55P5JJ5P5GG#B####B^~!~~^^~~~^::^7~     ..!7~!^:
PP5Y7^77~!?7J!!YPBBBGP^:^:::!?~~7!^::.  .:.^?~.:75
PGBJ.^J?^^~?~::~JY5G5???YYYY5PP5GPYJJJ~   ^7?55YJ~
G###YJYY77?:.::!7JYYJ777777??JJ5PGGP!::.  :7?7!:. 
GGGGB#BYJJJ^.:^!Y5Y?77777??JJJJYY5P##P?!~~~:.     
GGGGGB#B55?!???YYYJ??????JJYYYY555PGB###P55YJ^  . 
5B##&&&&&##BYJJJYJJJJJJJYY5Y5555PPGGBBB#B577!7~...
Y#&&&&&#&&&G??JJJJJJJ?JJJJJJYYYY5PGGGBBBB#~       
?########&#???JJJJJ??????JJJJJY55PGGBBBBB#P:::^^:.
~####&&&&&G77?JJJJJJYJJYYYYYY5PPPGGGGGB#BBBYPGGGGP
:###&&&&&&577??7!~!!7?JY5555P5YJ?77!!7?5GGBY7PPPGG
:B##&&&&#P!~!~~^~~~^^^^^^~!!~~!!~~~!?JYJY!~::?55J?
:?JY5PPB5::JJ?7!~~:::::^. .. JJ^^^:~Y?5GG57:?5555P
!7!!~.:!77~??77!~!~^^^^~.^J5^^5?!!!?JY5PGBG!PGB5YY
!!!?!.:~!77~????7!!!!?7:^7?Y5~!Y5JJYJ5PBB#J?GB##BY
7!!7~::~!7!~~!77!!!~~^^7JJJYGBY??7???JY5555B5~~^7Y
!!!~:.::.!~!7???J??7!!?7755GBPGB5YYYYPGBBBBBY7?JJJ
777^^:^^:!^~!?JYJ7~~~^:.:!77?7?JY55YYPGBBBGGJ?JY55
YY?7777!!!^^~!??^:::::.:::::^~~!!7!!~7YGBGP5Y!..::
Y??JJJ???7^::^~~:...:^^~~~!!!7?YY?~^^^75PYJJ7.    
?Y55YYJJJJ?^::^^:..:^~!!~!!!77?YY?~^^~?JJJ77:     
Y5Y7^^:::7YJ!^^^:^!~^^^^~~~~!!7?777!7?JJ??7:      
7!^:.... .:!7?7~^~J?7!!!777777?7?J5YYYJJJJ^       
^::..... ....~J?!7JYYJ?JJYJ77JY5PPPPPYY5Y7~~~~~~~~
^::..... ..:^!?J??JJ55YYJYJJY55PGGBGGPGGY!~~^^^^^~
:........7Y5G5?JJJJJYPP5JJ5P55P5PGGGGGGG##BBBGP5J7
^^~~~^~YPPY?GP7?JJJJYY55PPPP55PPGGGGGGPG#&5P#BGPPG
PGBBBBBGPJ7~GB7???JJJJJYY555PPPPPPPPPPPB##G7P#G5YP
PGBBGGGP5?^~P#5!???JJJYYYY55PPPPPP5555P#BBB!JGGYY5
J5GBGGGP5?^~JB#P7???JJJJJYY5555555YY55B#GBB7!JGYJ5
JJ5GBBBGY~^^!BBBP77?J?JJJJJYY5555YY5YP#PG#P!~~YJJ5
JJYPBBBB5^^^~PBBBY~!??JJJJJJJYYYYYY?Y#PPB#J!~^~??5
JJJ5GG5PY^^^~YBBBB?^~!?JJJJJJJJJJ?!Y#PPGB#Y^~^:~75
5YJYPGP57:^^~JPBBBBY!~~77?77??77~~P#P5GGBBP~^:::~J
");
}
public static void MainMenu()
{
    Console.WriteLine("Please make a selection");
    Console.WriteLine("1: Find a new Recipe");
    Console.WriteLine("2: Search existing Recipes");
    Console.WriteLine("3: Add Recipe");
    Console.WriteLine("4: Edit Recipe");
    Console.WriteLine("5: User Settings");
    Console.WriteLine("6: Exit");
    Console.WriteLine("7: Surprise ;)");
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
        
        case "7":
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Foob();
            Console.ReadLine();
            break;
    }

}
}