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
            if(!customRadioButton.Checked && !presetRadioButton.Checked)
            {
                taskStatusLbl.Text = "Please select whether you would like custom or preset recipes.";
            }
            else if(customRadioButton.Checked)
            {
                Data.displayRecipes.Clear();
                foreach(Recipe currentRecipe in Data.CustomRecipes)
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
                foreach(Recipe currentRecipe in Data.PresetRecipes)
                {
                    Data.displayRecipes.AddLast(currentRecipe);
                }
                RecipeSheet recipeSheet = new RecipeSheet();
                recipeSheet.Show();
                Close();
            }
        }
    }
}
