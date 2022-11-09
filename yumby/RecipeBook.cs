namespace yumby;

public class RecipeBook
{
    public string? RecipeBookName { get; set; }
    public IDictionary<string, Recipe> MyRecipeBook = new Dictionary<string, Recipe>();

    public void CreateNewRecipe()
    {
        Console.Write("Recipe title: ");
        string? recipeName = Console.ReadLine();
        if (recipeName != null)
        {
            var myRecipe = new Recipe(recipeName);
            Console.Write("Recipe instructions: ");
            myRecipe.Instructions = Console.ReadLine();
                
            Console.Clear();
            Console.WriteLine($"You entered {myRecipe.Name} for your recipe name");
            Console.WriteLine($"{myRecipe.Name} INSTRUCTIONS: {myRecipe.Instructions}");
        }
    }

    public void EditRecipe()
    {
        
    }

    public void SaveRecipe()
    {
        
    }
    
    public void ListAllRecipes()
    {
        
    }
}