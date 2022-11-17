namespace yumby;

class Menu
{
    private int _selectionIndex;
    private string[] _options;
    private string _prompt;

    public Menu(string prompt, string[] options)
    {
        _prompt = prompt;
        _options = options;
        _selectionIndex = 0;
    }

    // public Menu(string prompt, string[] options, Recipe recipeInput)
    // {
    //     _prompt = prompt;
    //     _options = options;
    //     _selectionIndex = 0;
    //     var recipeSelection = recipeInput;
    // }

    private void DisplayOptions()
    {
        Console.WriteLine(_prompt);
        //WriteLine(" ");
        for (int i = 0; i < _options.Length; i++)
        {
            string currentOption = _options[i];
            string prefix;
            string suffix;

            if (i == _selectionIndex)
            {
                prefix = ":) <<";
                suffix = ">> (:";
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                prefix = "     ";
                suffix = "     ";
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
            }
            Console.WriteLine($"{prefix} {currentOption} {suffix}");
        }
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
    }

    public int Run()
    {
        ConsoleKey keyPressed;
        do
        {
            Console.Clear();
            DisplayOptions();
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            keyPressed = keyInfo.Key;
            if (keyPressed == ConsoleKey.UpArrow)
            {
                _selectionIndex--;
                if (_selectionIndex == -1)
                {
                    _selectionIndex = _options.Length - 1;
                }
            }
            else if (keyPressed == ConsoleKey.DownArrow)
            {
                _selectionIndex++;
                if (_selectionIndex == _options.Length)
                {
                    _selectionIndex = 0;
                }
            }
        } 
        while (keyPressed != ConsoleKey.Enter);
        return _selectionIndex;
    }
}