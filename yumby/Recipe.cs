namespace yumby;
using static Console;

public class Recipe
{
    public string? Name { get; set; }
    public List<Ingredient> Ingredients = new List<Ingredient>();
    public List<string> Instructions = new List<string>();
    public double ServingsYielded { get; set; }

    public void AddIngredient()
    {
        var ingredient = new Ingredient();
        WriteLine("Enter ingredient name: ");
        ingredient.Name = ReadLine();
        WriteLine("Enter ingredient quantity: ");
        ingredient.Quantity = Double.Parse(ReadLine());
        WriteLine("Enter ingredient unit: ");
        ingredient.Unit = ReadLine();
    }

}
