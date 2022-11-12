namespace yumby;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.Title = "=== Yumby ===";
            var myRecipeBook = new RecipeBook();
            MainMenu.Start(); 
        }
        else
        {
            Console.WriteLine("Usage: dotnet run");
        }
    }
}