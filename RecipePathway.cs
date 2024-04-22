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
    public partial class RecipePathway : Form
    {
        public RecipePathway()
        {
            InitializeComponent();
        }

        private void returnHomeButton_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].WindowState = FormWindowState.Normal;
            Close();
        }

        private void displayAllButton_Click(object sender, EventArgs e)
        {
            if (!customRadioButton.Checked && !presetRadioButton.Checked)
            {
                taskStatusLbl.Text = "Please select whether you would like custom or preset recipes.";
            }
            else if (customRadioButton.Checked)
            {
                Data.displayRecipes.Clear();
                foreach (Recipe currentRecipe in Data.CustomRecipes)
                {
                    Data.displayRecipes.AddLast(currentRecipe);
                }
                RecipeSheet recipeSheet = new RecipeSheet();
                recipeSheet.Show();
                Close();
            }
            else
            {
                Data.displayRecipes.Clear();
                foreach (Recipe currentRecipe in Data.PresetRecipes)
                {
                    Data.displayRecipes.AddLast(currentRecipe);
                }
                RecipeSheet recipeSheet = new RecipeSheet();
                recipeSheet.Show();
                Close();
            }
        }

        private LinkedList<string> allergenBuilder()
        {
            LinkedList<string> userAllergenBuilder = new LinkedList<string>();
            if (allergenCheckedListBox.SelectedItems.Count > 0)
            {

                for (int iterator = 0; iterator < allergenCheckedListBox.Items.Count; iterator++)
                {
                    if (allergenCheckedListBox.GetItemChecked(iterator) == true)
                    {
                        string addingAllergen = allergenCheckedListBox.Items[iterator].ToString();
                        userAllergenBuilder.AddLast(addingAllergen);
                    }
                }
                return userAllergenBuilder;
            }
            else
            {
                return userAllergenBuilder;
            }
        }
        private void recipeChooseButton_Click(object sender, EventArgs e)
        {
            if (!customRadioButton.Checked && !presetRadioButton.Checked)
            {
                taskStatusLbl.Text = "Please select whether you would like custom or preset recipes.";
            }
            else
            {
                LinkedList<string> userAllergens = allergenBuilder();
                if (ingredientListDisplay.Text.Length > 0)
                {
                    string[] separatedIngredients = ingredientListDisplay.Text.Split('/');
                    LinkedList<string> userFridge = new LinkedList<string>();
                    foreach (string ingredient in separatedIngredients)
                    {
                        userFridge.AddLast(ingredient);
                    }
                    if (customRadioButton.Checked)
                    {
                        Data.DisplayListAllergenFilter(userAllergens, Data.customRecipes);
                    }
                    else
                    {
                        Data.DisplayListAllergenFilter(userAllergens, Data.presetRecipes);
                    }
                    Data.ListMatchSort(Data.displayRecipes, userFridge);
                    RecipeSheet recipeSheet = new RecipeSheet();
                    recipeSheet.Show();
                    Close();
                }
                else
                {
                    taskStatusLbl.Text = "Please add some ingredients you already have.";
                    return;
                }

            }
        }
        private bool ingredientPresent(string ingredientName)
        {
            string[] ingredientArray = ingredientListDisplay.Text.Split('/');
            foreach (string ingredient in ingredientArray)
            {
                if (ingredient == ingredientName) { return true; }
            }
            return false;
        }
        private void addIngredientButton_Click(object sender, EventArgs e)
        {
            if (ingredientSelectComboBox.Text == string.Empty)
            {
                taskStatusLbl.Text = "Please add a valid ingredient.";
            }
            else if (ingredientPresent(ingredientSelectComboBox.Text))
            {
                taskStatusLbl.Text = $"The ingredient '{ingredientSelectComboBox.Text}' has already been added.";
            }
            else
            {
                ingredientListDisplay.Text += $"{ingredientSelectComboBox.Text}/";
            }
        }

        private void removeIngredientButton_Click(object sender, EventArgs e)
        {
            if (ingredientListDisplay.Text == string.Empty)
            {
                taskStatusLbl.Text = "There are no ingredients to remove.";
            }
            else if (ingredientSelectComboBox.Text == string.Empty)
            {
                taskStatusLbl.Text = "Please enter an ingredient to remove.";
            }
            else if (!ingredientPresent(ingredientSelectComboBox.Text))
            {
                taskStatusLbl.Text = $"The ingredient {ingredientSelectComboBox.Text} was never added.";
            }
            else
            {
                string[] originalIngredientArray = ingredientListDisplay.Text.Split("/");
                LinkedList<string> newIngredientList = new LinkedList<string>();
                foreach (string ingredientName in originalIngredientArray)
                {
                    if (ingredientName != ingredientSelectComboBox.Text && ingredientName != string.Empty)
                    {
                        newIngredientList.AddLast($"{ingredientName}/");
                    }
                }
                ingredientListDisplay.Text = string.Empty;
                foreach (string displayIngredient in newIngredientList)
                {
                    ingredientListDisplay.Text += $"{displayIngredient}";
                }
                taskStatusLbl.Text = $"The ingredient {ingredientSelectComboBox.Text} was removed.";
            }
        }
    }
}
