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
    public partial class CustomRecipeTools : Form
    {
        public CustomRecipeTools()
        {
            InitializeComponent();
        }
        private LinkedList<Recipe> CustomRecipes = Data.CustomRecipes;

        private void noWebLinkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (noWeblinkBox.Checked)
            {
                weblinkBox.Visible = false;
                weblinkPromptLbl.Visible = false;
            }
            else
            {
                weblinkBox.Visible = true;
                weblinkPromptLbl.Visible = true;
            }
        }

        private void returnHomeButton_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].WindowState = FormWindowState.Normal;
            Close();
        }

        private void addRecipeButton_Click(object sender, EventArgs e)
        {
            foreach (Recipe recipe in CustomRecipes)
            {
                if (recipe.Name == recipeNameBox.Text)
                {
                    taskStatusLbl.Text = $"There is already a custom recipe called {recipe.Name} saved.";
                    return;
                }
            }
            if (recipeNameBox.Text == string.Empty || originRecipeLbl.Text == string.Empty || ingredientListDisplayBox.Text == string.Empty)
            {
                taskStatusLbl.Text = "Please fill in all the relevant fields.";
                return;
            }
            else
            {
                string weblinkValue;
                if (noWeblinkBox.Checked)
                {
                    weblinkValue = string.Empty;
                }
                else
                {
                    weblinkValue = weblinkBox.Text;
                }
                Recipe addingRecipe = new Recipe(recipeNameBox.Text, recipeOriginTextBox.Text, weblinkValue);
                //Using code from https://stackoverflow.com/questions/14872577/iterate-through-checkedlistbox-testing-for-checked-cast-error
                for (int iterator = 0; iterator < allergenCheckedListBox.Items.Count; iterator++)
                {
                    if (allergenCheckedListBox.GetItemChecked(iterator) == true)
                    {
                        string addingAllergen = allergenCheckedListBox.Items[iterator].ToString();
                        addingRecipe.AllergenList.AddLast(addingAllergen);
                    }
                }
                string[] separatedIngredients = ingredientListDisplayBox.Text.Split('/');
                foreach (String addingIngredient in separatedIngredients)
                {
                    if (addingIngredient != string.Empty)
                    {
                        addingRecipe.IngredientList.AddLast(addingIngredient);
                    }
                }
                Data.RecipeAdd(addingRecipe);
                taskStatusLbl.Text = $"Recipe of name {addingRecipe.Name} added.";
                ingredientListDisplayBox.Text = string.Empty;
                return;
            }
        }

        private void addIngredientButton_Click(object sender, EventArgs e)
        {
            if (ingredientSelectComboBox.Text == string.Empty)
            {
                taskStatusLbl.Text = "Please add a valid ingredient.";
            }
            else
            {
                ingredientListDisplayBox.Text += $"{ingredientSelectComboBox.Text}/";
            }
        }
        private bool ingredientPresent(string ingredientName)
        {
            string[] ingredientArray = ingredientListDisplayBox.Text.Split('/');
            foreach(string ingredient in ingredientArray)
            {
                if(ingredient == ingredientName) { return true; }
            }
            return false;
        }
        private void removeIngredientButton_Click(object sender, EventArgs e)
        {
            if (ingredientListDisplayBox.Text == string.Empty)
            {
                taskStatusLbl.Text = "There are no ingredients to remove.";
            } else if (ingredientSelectComboBox.Text == string.Empty)
            {
                taskStatusLbl.Text = "Please enter an ingredient to remove.";
            } else if (!ingredientPresent(ingredientSelectComboBox.Text))
            {
                taskStatusLbl.Text = $"The ingredient {ingredientSelectComboBox.Text} was never added.";
            }
            else
            {
                string[] originalIngredientArray = ingredientListDisplayBox.Text.Split("/");
                LinkedList<string> newIngredientList = new LinkedList<string>();
                foreach (string ingredientName in originalIngredientArray) 
                {
                    if(ingredientName != ingredientSelectComboBox.Text && ingredientName != string.Empty)
                    {
                        newIngredientList.AddLast($"{ingredientName}/");
                    }
                }
                ingredientListDisplayBox.Text = string.Empty;
                foreach(string displayIngredient in  newIngredientList)
                {
                    ingredientListDisplayBox.Text += $"{displayIngredient}";
                }
                taskStatusLbl.Text = $"The ingredient {ingredientSelectComboBox.Text} was removed.";
            }
        }
        private bool recipePresent(string recipeName)
        {
            foreach (Recipe currentRecipe in CustomRecipes)
            {
                if (currentRecipe.Name == recipeName)
                {
                    return true;
                }
            }
            return false;
        }
        private void removeRecipeButton_Click(object sender, EventArgs e)
        {
            if (recipeRemovalNameBox.Text == string.Empty)
            {
                taskStatusLbl.Text = "Please enter a recipe name.";
            }
            else if (!recipePresent(recipeRemovalNameBox.Text))
            {
                taskStatusLbl.Text = $"No recipes called {recipeRemovalNameBox.Text} have been added.";
            }
            else
            {
                Data.RecipeRemove(recipeRemovalNameBox.Text);
                taskStatusLbl.Text = $"Recipe of name '{recipeRemovalNameBox.Text}' was removed.";
            }
        }

        
    }
}
