namespace yumby;

public class RecipeBook
{
    public string RecipeBookName { get; set; }
    private IDictionary<string, Recipe> MyRecipeBook = new Dictionary<string, Recipe>();

}