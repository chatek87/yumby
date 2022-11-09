namespace yumby;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
        MainMenu.Start(); 
        }
        else
        {
            Console.WriteLine("Usage: dotnet run");
        }
    }
}