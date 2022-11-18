using System.Text.Json;
namespace yumby;

public static class RecipeMenu
{
    public static Dictionary<string, Recipe> RecipeBook = new Dictionary<string, Recipe>();
    public static void Start()
    {
         try
         {
             RecipeBook = ReadFromFilePopulateDictionary();
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
        string[] options = { "enter new recipe", "list all recipes", "search", "back" };
        var recipeMenu = new Menu(prompt, options);
        int selectedIndex = recipeMenu.Run();
        switch (selectedIndex)
        {
            case 0:
                //enter new recipe
                Console.Clear();
                Console.WriteLine("You selected ENTER NEW RECIPE");
                var tempRecipe = RecipeHelper.CreateNewRecipe();
                string tempName = tempRecipe.Name;
                RecipeBook.Add(tempName ,tempRecipe);
                WriteToFile(RecipeBook);

                Console.WriteLine("Press any key to return to previous menu");
                Console.ReadKey(true);
                Start();
                break;
            case 1:   
                //lift all recipes
                Console.Clear();
                Console.WriteLine("My Recipe Book:");
                Console.WriteLine(" ");
                foreach (var entry in RecipeBook)
                {
                    Console.WriteLine(entry.Key);
                }

                Console.WriteLine("\n");
                Console.WriteLine("Press any key to return to previous menu");
                Console.ReadKey(true);
                Start();
                break;
            case 2:
                //search
                Console.Clear();
                Console.WriteLine("Enter the name of an existing recipe:");
                
                string searchedRecipeName = Console.ReadLine();
                searchedRecipeName = searchedRecipeName.ToUpper();
                if (!RecipeBook.TryGetValue(searchedRecipeName, out Recipe selectedRecipe))
                {
                    Console.WriteLine($"Sorry, no recipe called \"{searchedRecipeName}\" found.");
                    Console.WriteLine("Press any key to return to previous menu");
                    Console.ReadKey(true);
                    Start();
                    break;
                }
                RecipeSubMenu.Start(selectedRecipe);
                break;
            case 3:
                //back
                MainMenu.Start();
                break;
        }
    }

    public static Dictionary<String, Recipe> ReadFromFilePopulateDictionary()
    {
        var jsonDirectory = Path.Combine(Directory.GetCurrentDirectory(), "data");
        var jsonFilePath = Path.Combine(jsonDirectory, "RecipeBook.json");
        var contents = File.ReadAllText(jsonFilePath);
        var deserializedDictionary = JsonSerializer.Deserialize<Dictionary<String, Recipe>>(contents);
 
        return deserializedDictionary;
    }
    public static void WriteToFile(Dictionary<string, Recipe> dict)
    {
        var jsonString = JsonSerializer.Serialize(dict);
        var jsonDirectory = Path.Combine(Directory.GetCurrentDirectory(), "data");
        var jsonFilePath = Path.Combine(jsonDirectory, "RecipeBook.json");
        File.WriteAllText(jsonFilePath, jsonString);
    }
}