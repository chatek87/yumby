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
        var menu = new Menu(prompt, options);
        int selectedIndex = menu.Run();
        switch (selectedIndex)
        {
            case 0:
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
                Console.Clear();
                Console.WriteLine("My Recipe Book:");
                Console.WriteLine(" ");
                foreach (var entry in RecipeBook)
                {
                    Console.WriteLine(entry.Key);
                }
                
                Console.WriteLine("Press any key to return to previous menu");
                Console.ReadKey(true);
                Start();
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("You selected SEARCH RECIPES");
                
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
                
                // TODO: ADD SUBMENU HERE FOR MENU OPERATIONS. VIEW, CHANGE SERVING SIZE, GENERATE SHOPPING LIST.
                string recipeSubMenuPrompt = $"<< {selectedRecipe.Name} >>\n";
                string[] recipeSubMenuOptions = { "view recipe", "change serving size", "generate shopping list" };
                var recipeSubMenu = new Menu(recipeSubMenuPrompt, recipeSubMenuOptions);
                int recipeSubMenuSelectionIndex = recipeSubMenu.Run();

                switch (recipeSubMenuSelectionIndex)
                {
                    case 0:
                        //view recipe
                        RecipeHelper.DisplayRecipe(selectedRecipe);
                        break;
                    case 1:
                        //change serving size
                        Console.WriteLine("TODO: change serving size");
                        var myConvertedRecipe = Utility.ChangeServingSize(selectedRecipe);
                        RecipeHelper.DisplayRecipe(myConvertedRecipe);
                        break;
                    case 2:
                        //generate shopping list
                        Console.WriteLine("TODO: generate shopping list, write to text file?");
                        break;
                }
                
                Console.WriteLine("Press any key to return to previous menu");
                Console.ReadKey(true);
                Start();
                break;
            case 3:
                MainMenu.Start();
                break;
        }
        // WriteLine("Press any key to return to Main Menu");
        // ReadKey(true);
        // MainMenu.Start();
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