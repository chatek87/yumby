using System.Text.Json;
namespace yumby;
using static Console;

public static class RecipeMenu
{
    public static Dictionary<string, Recipe> RecipeBook = new Dictionary<string, Recipe>();
    public static void Start()
    {
        // populate dictionary with JSON first
         try
         {
             ReadFromFilePopulateDictionary(RecipeBook);
         }
         catch (Exception e)
         {
             var jsonString = JsonSerializer.Serialize(RecipeBook);
             var jsonDirectory = Path.Combine(Directory.GetCurrentDirectory(), "data");
             var jsonFilePath = Path.Combine(jsonDirectory, "RecipeBook.json");
             Directory.CreateDirectory(jsonDirectory);
             File.WriteAllText(jsonFilePath, jsonString);
             throw;
         }
         
         Run();
    }
    private static void Run()
    {
        string prompt = "my recipes";
        string[] options = { "enter new recipe", "browse all", "search", "back" };
        var menu = new Menu(prompt, options);
        int selectedIndex = menu.Run();

        switch (selectedIndex)
        {
            case 0:
                Clear();
                WriteLine("You selected ENTER NEW RECIPE");
                var tempRecipe = RecipeHelper.CreateNewRecipe();
                // foreach (var ingredient in tempRecipe.Ingredients)
                // {
                //     Console.WriteLine(tempRecipe.Ingredients.Name);
                // }
                Console.WriteLine(tempRecipe.Ingredients);
                string tempName = tempRecipe.Name;
                RecipeBook.Add(tempName ,tempRecipe);
                WriteToFile(RecipeBook);

                WriteLine("Press any key to return to previous menu");
                ReadKey(true);
                Start();
                break;
            case 1:                
                Clear();
                WriteLine("You selected BROWSE RECIPES");
                break;
            case 2:
                Clear();
                WriteLine("You selected SEARCH RECIPES");
                break;
            case 3:
                MainMenu.Start();
                break;
        }
        WriteLine("Press any key to return to Main Menu");
        ReadKey(true);
        MainMenu.Start();
    }

    public static Dictionary<String, Recipe> ReadFromFilePopulateDictionary(Dictionary<String, Recipe> dict)
    {
        // read from file and populate dictionary
        var jsonDirectory = Path.Combine(Directory.GetCurrentDirectory(), "data");
        var jsonFilePath = Path.Combine(jsonDirectory, "RecipeBook.json");
        var contents = File.ReadAllText(jsonFilePath);
        var deserializedDictionary = JsonSerializer.Deserialize<Dictionary<String, Recipe>>(contents);
 
        return deserializedDictionary;
    }
    public static void WriteToFile(Dictionary<string, Recipe> dict)
    {
        //check to see if file exists in directory already
        //if it does, erase the file and create the new one using the dictionary
        //if it doesn't (1st recipe added probably) then create the new file 
        var jsonString = JsonSerializer.Serialize(dict);
        var jsonDirectory = Path.Combine(Directory.GetCurrentDirectory(), "data");
        var jsonFilePath = Path.Combine(jsonDirectory, "RecipeBook.json");
        File.WriteAllText(jsonFilePath, jsonString);
    }
}