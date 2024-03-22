using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RecipeFinderPrototype
{
    internal class Data
    {
        public static LinkedList<Recipe> presetRecipes = new LinkedList<Recipe>();
        public static LinkedList<Recipe> customRecipes = new LinkedList<Recipe>();
        public static LinkedList<Recipe> PresetRecipes { get { return presetRecipes; } }
        public static LinkedList<Recipe> CustomRecipes { get { return customRecipes; } }


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
        //Example of deciding list type for a method to function
        /*public static void RecipeAdd(Recipe addingRecipe, bool customList = false)
        {
            if(!customList)
            {
                return;
            }
            else
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
            
        }*/
        public static void PresetListAddAll()
        {
            string allPresetRecipes = File.ReadAllText(@"C: \Users\jakes\source\repos\Personal Projects\RecipeFinderPrototype\Source\Recipes.txt");
            string[] allRecipesSplitter = allPresetRecipes.Split("\n");
            foreach(string fullRecipe in allRecipesSplitter)
            {
                string[] recipeComponents = fullRecipe.Split(",");
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
        //Olive
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
            foreach (Recipe recipeIterator in CustomRecipes)
            {
                if(recipeIterator.Name == nameOfDeletion)
                {
                    CustomRecipes.Remove(recipeIterator);
                }
            }
        }


    }

}
