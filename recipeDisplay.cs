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
    public partial class recipeDisplay : UserControl
    {
        public recipeDisplay()
        {
            InitializeComponent();
        }
        public string Name
        {
            get { return recipeNameBox != null ? recipeNameBox.Text : string.Empty; }
            set { if (recipeNameBox != null) recipeNameBox.Text = value; }
        }
        public string Ingredients
        {
            get { return ingredientBox != null ? ingredientBox.Text : string.Empty; }
            set { if ( ingredientBox != null) ingredientBox.Text = value; }
        }
        public string Region
        {
            get { return regionTextBox != null ? regionTextBox.Text : string.Empty;}
            set { if(regionTextBox != null) regionTextBox.Text = value;}
        }
        public string WebLink
        {
            get { return webLinkLabel != null ? webLinkLabel.Text : string.Empty; }
            set { if (webLinkLabel != null) webLinkLabel.Text = value; }
        }
        public string Allergens
        {
            get { return allergenBox != null ? allergenBox.Text : string.Empty; }
            set { if (allergenBox != null) allergenBox.Text = value; }
        }
    }
}
