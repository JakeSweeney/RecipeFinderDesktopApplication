using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeFinderPrototype
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        // credit to https://stackoverflow.com/questions/11365984/c-sharp-open-file-with-default-application-and-parameters
        public void OpenWithDefaultProgram(string path)
        {
            using Process fileopener = new Process();
            fileopener.StartInfo.FileName = "explorer";
            fileopener.StartInfo.Arguments = path;
            fileopener.Start();
        }


        private void customRecipeToolsButton_Click(object sender, EventArgs e)
        {
            CustomRecipeTools customRecipeTools = new CustomRecipeTools();
            customRecipeTools.Show();
            WindowState = FormWindowState.Minimized;
        }

        private void recipeFindingFormButton_Click(object sender, EventArgs e)
        {
            RecipePathway recipePathway = new RecipePathway();
            recipePathway.Show();
            WindowState = FormWindowState.Minimized;
        }



        /*private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ps = new ProcessStartInfo("https://moodle.mmu.ac.uk/course/view.php?id=172062")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }*/

        /*private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            OpenWithDefaultProgram(@"C:\Users\jakes\source\repos\Personal Projects\RecipeFinderPrototype\Source\Recipe Links\MyMMU.lnk");
            
        }*/
    }
}
