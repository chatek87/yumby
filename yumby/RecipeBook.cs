﻿namespace yumby;

public class RecipeBook
{
    public string? RecipeBookName { get; set; }
    public IDictionary<string, Recipe> MyRecipeBook = new Dictionary<string, Recipe>();
}