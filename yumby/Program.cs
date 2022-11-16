namespace yumby;

public class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.Title = "=== Yumby ===";
            
            MainMenu.Start(); 
        }
        else
        {
            Console.WriteLine("Usage: dotnet run");
        }
    }
}