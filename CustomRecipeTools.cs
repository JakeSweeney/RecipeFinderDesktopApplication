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
            if(noWeblinkBox.Checked) 
            {
                weblinkBox.Visible = false;
                weblinkPromptLbl.Visible = false;
            }
            else
            {
                weblinkBox.Visible = true;
                weblinkPromptLbl.Visible = true;
                //test
            }
        }

        private void returnHomeButton_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].WindowState = FormWindowState.Normal;
            Close();
        }
    }
}
