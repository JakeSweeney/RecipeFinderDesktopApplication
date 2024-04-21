using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RecipeFinderPrototype
{
    internal class Data
    {
        public static LinkedList<Recipe> presetRecipes = new LinkedList<Recipe>();
        public static LinkedList<Recipe> customRecipes = new LinkedList<Recipe>();
        public static LinkedList<Recipe> displayRecipes = new LinkedList<Recipe>();
        public static LinkedList<Recipe> PresetRecipes { get { return presetRecipes; } }
        public static LinkedList<Recipe> CustomRecipes { get { return customRecipes; } }
        public static LinkedList<Recipe> DisplayRecipes { get { return displayRecipes; } } 

        public static void RecipeAdd(Recipe addingRecipe)
        {
            
            if (CustomRecipes.Contains(addingRecipe))
            {
                throw new ArgumentException("Recipe name already entered, please enter a unique name.");
            }
            else
            {
                CustomRecipes.AddLast(addingRecipe);
            }
            
        }
        
        public static void PresetListAddAll()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Source\Recipes.txt");
            string allPresetRecipes = File.ReadAllText(path);
            string[] allRecipesSplitter = allPresetRecipes.Split("\n");
            foreach(string fullRecipe in allRecipesSplitter)
            {
                if (!string.IsNullOrEmpty(fullRecipe))
                {
                    string[] recipeComponents = fullRecipe.Split(",", StringSplitOptions.None);
                    string[] recipeIngredientsArray = recipeComponents[2].Split("/");
                    string[] allergenArray = recipeComponents[3].Split("/");
                    Recipe currentRecipe = new Recipe(recipeComponents[0], recipeComponents[1], recipeComponents[4]);
                    foreach (string ingredient in recipeIngredientsArray)
                    {
                        currentRecipe.AddIngredient(ingredient);
                    }
                    foreach (string allergen in allergenArray)
                    {
                        currentRecipe.AddAllergen(allergen);
                    }
                    presetRecipes.AddLast(currentRecipe);
                }
            }
        }
        
        public static void DisplayListAllergenFilter(LinkedList<string> userAllergens, LinkedList<Recipe> recipeList)
        {
            LinkedList<Recipe> allergenFreeRecipes = new LinkedList<Recipe>();
            if(recipeList.Count > 0 && userAllergens.Count > 0)
            {
                foreach(Recipe currentRecipe in recipeList)
                {
                    foreach (string allergen in userAllergens)
                    {
                        if (!currentRecipe.ContainsAllergen(allergen))
                        {
                            allergenFreeRecipes.AddLast(currentRecipe);
                        }
                    }
                }
                displayRecipes.Clear();
                foreach (Recipe currentRecipe in allergenFreeRecipes)
                {
                    displayRecipes.AddLast(currentRecipe);
                }
            }
        }
        public static void ListSort(LinkedList<Recipe> recipeList, LinkedList<string> userFridge)
        {
            if(recipeList.Count > 0)
            {
                foreach(Recipe recipeIndex in recipeList)
                {

                }
            }
            else
            {
                return;
            }
        }
        
        public static void RecipeRemove(string nameOfDeletion)
        {
            if (customRecipes.Count == 0 || nameOfDeletion == string.Empty)
            {
                return;
            }
            LinkedList<Recipe> newCustomRecipes = new LinkedList<Recipe> ();
            foreach (Recipe transferingRecipe in customRecipes)
            {
                if(transferingRecipe.Name != nameOfDeletion)
                {
                    newCustomRecipes.AddLast(transferingRecipe);
                }
            }
            customRecipes.Clear();
            foreach (Recipe addingRecipe in newCustomRecipes)
            {
                customRecipes.AddLast(addingRecipe);
            }
        }


    }

}
