yumby
=======

a personal recipe book application  
------------

#####  code KY Software Development 1 capstone project  </code>

yumby is a console application written in C# that allows a user to enter, store, and recall recipe information.  
yumby also allows a user to easily adjust a recipe to suit the desired number of portions served.  


yumby handles persistent data by serializing a dictionary<string RecipeName, Recipe> to JSON.  
Each recipe entry is saved as a Recipe object, which contains fields detailing the ingredients, quantities, and instructions pertinent to the recipe.



  

 

features list:
* Implement a “master loop” console application where the user can repeatedly enter commands/perform actions, including choosing to exit the program  
<code> see: Menu.cs, ExitMenu.cs, et al.</code> 

* Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program  
<code> see: Recipe.cs, RecipeMenu.cs</code>

* Read data from an external file, such as text, JSON, CSV, etc and use that data in your application  
<code> see: RecipeMenu.cs</code>

* Build a conversion tool that converts user input to another type and displays it (ex: converts cups to grams)  
<code> see: Utility.cs</code>


