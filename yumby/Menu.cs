namespace yumby;
using static System.Console;        


class Menu
{
    private int SelectionIndex;
    private string[] Options;
    private string Prompt;

    public Menu(string prompt, string[] options)
    {
        Prompt = prompt;
        Options = options;
        SelectionIndex = 0;
    }

    private void DisplayOptions()
    {
        Banner.WelcomeMessage();
        WriteLine(Prompt);
        WriteLine(" ");
        for (int i = 0; i < Options.Length; i++)
        {
            string currentOption = Options[i];
            string prefix;
            string suffix;

            if (i == SelectionIndex)
            {
                prefix = ":) <<";
                suffix = ">> (:";
                ForegroundColor = ConsoleColor.Yellow;
                BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                prefix = "     ";
                suffix = "     ";
                ForegroundColor = ConsoleColor.White;
                BackgroundColor = ConsoleColor.Black;
            }

            WriteLine($"{prefix} {currentOption} {suffix}");
        }
        ResetColor();
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
                SelectionIndex--;
                if (SelectionIndex == -1)
                {
                    SelectionIndex = Options.Length - 1;
                }
            }
            else if (keyPressed == ConsoleKey.DownArrow)
            {
                SelectionIndex++;
                if (SelectionIndex == Options.Length)
                {
                    SelectionIndex = 0;
                }

            }
        } while (keyPressed != ConsoleKey.Enter);

        return SelectionIndex;
    }
}