namespace yumby;
using static Console;        

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

    private void DisplayOptions()
    {
        WriteLine(_prompt);
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
                ForegroundColor = ConsoleColor.Yellow;
                // BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                prefix = "     ";
                suffix = "     ";
                ForegroundColor = ConsoleColor.DarkMagenta;
                // BackgroundColor = ConsoleColor.Black;
            }

            WriteLine($"{prefix} {currentOption} {suffix}");
        }
        ForegroundColor = ConsoleColor.DarkMagenta;
    }

    public int Run()
    {
        ConsoleKey keyPressed;
        do
        {
            //BackgroundColor = ConsoleColor.Black;
            //ForegroundColor = ConsoleColor.Yellow;
            Clear();
            DisplayOptions();

            ConsoleKeyInfo keyInfo = ReadKey(true);
            keyPressed = keyInfo.Key;

            // Update SelectionIndex based on arrow keys.
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