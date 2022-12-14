yumby
=======

a personal recipe book application  
------------

#####  code KY Software Development 1 capstone project  </code>

yumby is a console application written in C# that allows a user to enter, store, and recall recipe information.  
yumby also allows a user to easily adjust a recipe to suit the desired number of portions served.  
  
yumby handles persistent data by serializing a dictionary<string RecipeName, Recipe> to JSON.  
Each recipe entry is saved as a Recipe object, which contains fields detailing the ingredients, quantities, and instructions pertinent to the recipe.  
 
### instructions:
Use the up/down arrow keys to navigate menu and ENTER to select menu option.  
Select "list all recipes" to see all the (poorly entered) example recipe entries in your Recipe Book, or enter your own!  
Enter the name of an existing recipe entry in "search for recipe" to view recipe/shopping list, and to change desired number of servings.  

### features list:
* Implement a “master loop” console application where the user can repeatedly enter commands/perform actions, including choosing to exit the program  
<code> see: Menu.cs, MainMenu.cs, et al.</code> 

* Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program  
<code> see: Recipe.cs, RecipeMenu.cs</code>

* Read data from an external file, such as text, JSON, CSV, etc and use that data in your application  
<code> see: RecipeMenu.cs</code>

* Build a conversion tool that converts user input to another type and displays it (ex: converts cups to grams)  
<code> see: Utility.cs, RecipeSubMenu.cs</code>

### development roadmap for the future:
* Add edit/delete recipe functionality
* Allow user to select several recipes to add to a *PRINTABLE* shopping list (written to text file)
* Implement search recipes by ingredient feature


