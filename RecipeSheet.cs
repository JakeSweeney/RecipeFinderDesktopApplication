using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeFinderPrototype
{
    public partial class RecipeSheet : Form
    {

        public RecipeSheet()
        {
            InitializeComponent();
            UpdateRecipeSheet(Data.displayRecipes.Count);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].WindowState = FormWindowState.Normal;
            Close();
        }

        private void UpdateRecipeSheet(int count)
        {
            fLPRecipeSheet.Controls.Clear();
            if (count > 0)
            {
                for (int currentRecipeIterator = 0; currentRecipeIterator < count; currentRecipeIterator++)
                {
                    Recipe recipe = Data.displayRecipes.ElementAt(currentRecipeIterator);
                    string ingredientBuffer = string.Empty;
                    foreach (string ingredient in recipe.IngredientList)
                    {
                        if (ingredient == recipe.IngredientList.First.ToString())
                        {
                            ingredientBuffer += $"{ingredient},";
                        }
                        else if (ingredient != recipe.IngredientList.First.ToString() && ingredient != recipe.IngredientList.Last().ToString())
                        {
                            ingredientBuffer += $" {ingredient},";
                        }
                        else
                        {
                            ingredientBuffer += $" {ingredient}.";
                        }
                    }
                    string allergenBuffer = string.Empty;
                    foreach (string allergen in recipe.AllergenList)
                    {
                        if (allergen == recipe.AllergenList.First.ToString())
                        {
                            allergenBuffer += $"{allergen},";
                        }
                        else if (allergen != recipe.AllergenList.First.ToString() && allergen != recipe.AllergenList.Last().ToString())
                        {
                            allergenBuffer += $" {allergen},";
                        }
                        else {
                            allergenBuffer += $" {allergen}.";
                        }
                    }
                    if (recipe != null)
                    {
                        fLPRecipeSheet.Controls.Add(new recipeDisplay() { Name = recipe.Name, Ingredients = ingredientBuffer, Region = recipe.Region, WebLink = recipe.WebLink, Allergens = allergenBuffer });
                    }
                }
            }
        }

        
    }
}
