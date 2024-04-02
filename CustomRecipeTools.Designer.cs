namespace RecipeFinderPrototype
{
    partial class CustomRecipeTools
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            logoLbl = new Label();
            returnHomeButton = new Button();
            recipeAdditionBox = new GroupBox();
            allergenCheckedListBox = new CheckedListBox();
            recipeOriginTextBox = new TextBox();
            originRecipeLbl = new Label();
            weblinkPromptLbl = new Label();
            weblinkBox = new TextBox();
            noWeblinkBox = new CheckBox();
            recipeNameBox = new TextBox();
            recipeNameLbl = new Label();
            ingredientQuantityLbl = new Label();
            ingredientNameLbl = new Label();
            addIngredientButton = new Button();
            ingredientQuantityBox = new TextBox();
            ingredientSelectComboBox = new ComboBox();
            ingredientListDisplayBox = new TextBox();
            addRecipeButton = new Button();
            recipeAllergenPromptLbl = new Label();
            recipeRemovalBox = new GroupBox();
            removeRecipeButton = new Button();
            recipeRemovalNameBox = new TextBox();
            recipeRemovalNameLbl = new Label();
            taskStatusGroupBox = new GroupBox();
            taskStatusLbl = new Label();
            removeIngredientButton = new Button();
            recipeAdditionBox.SuspendLayout();
            recipeRemovalBox.SuspendLayout();
            taskStatusGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // logoLbl
            // 
            logoLbl.AutoSize = true;
            logoLbl.BackColor = SystemColors.ControlLight;
            logoLbl.BorderStyle = BorderStyle.FixedSingle;
            logoLbl.Location = new Point(12, 9);
            logoLbl.Name = "logoLbl";
            logoLbl.Size = new Size(126, 22);
            logoLbl.TabIndex = 0;
            logoLbl.Text = "Choose My Food!";
            // 
            // returnHomeButton
            // 
            returnHomeButton.Location = new Point(435, 5);
            returnHomeButton.Name = "returnHomeButton";
            returnHomeButton.Size = new Size(108, 29);
            returnHomeButton.TabIndex = 1;
            returnHomeButton.Text = "Return Home";
            returnHomeButton.UseVisualStyleBackColor = true;
            returnHomeButton.Click += returnHomeButton_Click;
            // 
            // recipeAdditionBox
            // 
            recipeAdditionBox.Controls.Add(removeIngredientButton);
            recipeAdditionBox.Controls.Add(allergenCheckedListBox);
            recipeAdditionBox.Controls.Add(recipeOriginTextBox);
            recipeAdditionBox.Controls.Add(originRecipeLbl);
            recipeAdditionBox.Controls.Add(weblinkPromptLbl);
            recipeAdditionBox.Controls.Add(weblinkBox);
            recipeAdditionBox.Controls.Add(noWeblinkBox);
            recipeAdditionBox.Controls.Add(recipeNameBox);
            recipeAdditionBox.Controls.Add(recipeNameLbl);
            recipeAdditionBox.Controls.Add(ingredientQuantityLbl);
            recipeAdditionBox.Controls.Add(ingredientNameLbl);
            recipeAdditionBox.Controls.Add(addIngredientButton);
            recipeAdditionBox.Controls.Add(ingredientQuantityBox);
            recipeAdditionBox.Controls.Add(ingredientSelectComboBox);
            recipeAdditionBox.Controls.Add(ingredientListDisplayBox);
            recipeAdditionBox.Controls.Add(addRecipeButton);
            recipeAdditionBox.Controls.Add(recipeAllergenPromptLbl);
            recipeAdditionBox.Location = new Point(12, 34);
            recipeAdditionBox.Name = "recipeAdditionBox";
            recipeAdditionBox.Size = new Size(531, 489);
            recipeAdditionBox.TabIndex = 2;
            recipeAdditionBox.TabStop = false;
            recipeAdditionBox.Text = "Recipe Addition Tool";
            // 
            // allergenCheckedListBox
            // 
            allergenCheckedListBox.FormattingEnabled = true;
            allergenCheckedListBox.HorizontalScrollbar = true;
            allergenCheckedListBox.Items.AddRange(new object[] { "Celery", "Gluten", "Crustaceans", "Egg", "Fish", "Milk", "Molluscs", "Mustard", "Nuts", "Peanuts", "Sesame seeds", "Soya", "Sulphur dioxide" });
            allergenCheckedListBox.Location = new Point(6, 133);
            allergenCheckedListBox.MultiColumn = true;
            allergenCheckedListBox.Name = "allergenCheckedListBox";
            allergenCheckedListBox.Size = new Size(507, 70);
            allergenCheckedListBox.TabIndex = 28;
            // 
            // recipeOriginTextBox
            // 
            recipeOriginTextBox.Location = new Point(269, 67);
            recipeOriginTextBox.Name = "recipeOriginTextBox";
            recipeOriginTextBox.Size = new Size(244, 27);
            recipeOriginTextBox.TabIndex = 27;
            // 
            // originRecipeLbl
            // 
            originRecipeLbl.AutoSize = true;
            originRecipeLbl.Location = new Point(5, 70);
            originRecipeLbl.Name = "originRecipeLbl";
            originRecipeLbl.Size = new Size(258, 20);
            originRecipeLbl.TabIndex = 26;
            originRecipeLbl.Text = "Enter the region of the recipe's origin:";
            // 
            // weblinkPromptLbl
            // 
            weblinkPromptLbl.AutoSize = true;
            weblinkPromptLbl.Location = new Point(4, 397);
            weblinkPromptLbl.Name = "weblinkPromptLbl";
            weblinkPromptLbl.Size = new Size(113, 20);
            weblinkPromptLbl.TabIndex = 25;
            weblinkPromptLbl.Text = "Enter a weblink:";
            // 
            // weblinkBox
            // 
            weblinkBox.Location = new Point(119, 394);
            weblinkBox.Name = "weblinkBox";
            weblinkBox.Size = new Size(394, 27);
            weblinkBox.TabIndex = 24;
            // 
            // noWeblinkBox
            // 
            noWeblinkBox.AutoSize = true;
            noWeblinkBox.Location = new Point(6, 420);
            noWeblinkBox.Name = "noWeblinkBox";
            noWeblinkBox.Size = new Size(198, 24);
            noWeblinkBox.TabIndex = 23;
            noWeblinkBox.Text = "Tick if there is no weblink";
            noWeblinkBox.UseVisualStyleBackColor = true;
            noWeblinkBox.CheckedChanged += noWebLinkBox_CheckedChanged;
            // 
            // recipeNameBox
            // 
            recipeNameBox.Location = new Point(177, 30);
            recipeNameBox.Name = "recipeNameBox";
            recipeNameBox.Size = new Size(336, 27);
            recipeNameBox.TabIndex = 22;
            // 
            // recipeNameLbl
            // 
            recipeNameLbl.AutoSize = true;
            recipeNameLbl.Location = new Point(5, 30);
            recipeNameLbl.Name = "recipeNameLbl";
            recipeNameLbl.Size = new Size(166, 20);
            recipeNameLbl.TabIndex = 21;
            recipeNameLbl.Text = "Enter the recipe's name:";
            // 
            // ingredientQuantityLbl
            // 
            ingredientQuantityLbl.AutoSize = true;
            ingredientQuantityLbl.Location = new Point(162, 224);
            ingredientQuantityLbl.Name = "ingredientQuantityLbl";
            ingredientQuantityLbl.Size = new Size(209, 20);
            ingredientQuantityLbl.TabIndex = 20;
            ingredientQuantityLbl.Text = "Ingredient quantity (in grams):";
            // 
            // ingredientNameLbl
            // 
            ingredientNameLbl.AutoSize = true;
            ingredientNameLbl.Location = new Point(4, 222);
            ingredientNameLbl.Name = "ingredientNameLbl";
            ingredientNameLbl.Size = new Size(121, 20);
            ingredientNameLbl.TabIndex = 19;
            ingredientNameLbl.Text = "Ingredient name:";
            // 
            // addIngredientButton
            // 
            addIngredientButton.Location = new Point(373, 245);
            addIngredientButton.Name = "addIngredientButton";
            addIngredientButton.Size = new Size(54, 29);
            addIngredientButton.TabIndex = 18;
            addIngredientButton.Text = "Add";
            addIngredientButton.UseVisualStyleBackColor = true;
            addIngredientButton.Click += addIngredientButton_Click;
            // 
            // ingredientQuantityBox
            // 
            ingredientQuantityBox.Location = new Point(162, 247);
            ingredientQuantityBox.Name = "ingredientQuantityBox";
            ingredientQuantityBox.Size = new Size(205, 27);
            ingredientQuantityBox.TabIndex = 17;
            // 
            // ingredientSelectComboBox
            // 
            ingredientSelectComboBox.FormattingEnabled = true;
            ingredientSelectComboBox.Items.AddRange(new object[] { "Cream", "Whipped cream", "Sour cream", "Double cream", "Yoghurt", "Milk", "Condensed milk", "Evapourated milk", "Buttermilk", "Egg", "Cheese", "Butter", "Custard", "Margerine", "Sunflower oil", "Canola oil", "Vegetable oil", "Peanut oil", "Rapeseed oil", "Mustard oil", "Sunflower oil", "Olive oil", "Coconut oil", "Sesame oil", "Orange", "Lemon", "Mango", "Apple", "Blueberry", "Raspberry", "Strawberry", "Cranberry", "Kiwi", "Banana", "Watermelon", "Tomato", "Water Chestnut", "Papaya", "Olive", "Pear", "Sultana", "Mulberry", "Lychee", "Raisins", "Jamun", "Tamarind", "Gooseberry", "Grapefruit", "Dates", "Custard apple", "Black currant", "Red currant", "Coconut", "Cherry", "Apricot", "Figs", "Pomegranate", "Grapes", "Pineapple", "Guava", "Plum", "Bok choy", "Green bean", "Sorrel leaf", "Rocket leaf", "Plantain", "Turnip", "Sweet potatoes", "Round gourd", "Pimento", "Spinach", "Brown onion", "Red onion", "Spring onion", "Shallot", "Mustard leaf", "Mushroom", "Radish", "Lettuce", "Leek", "Pumpkin", "Yam", "Jalapeno", "Jackfruit", "Horseradish", "Peas", "Chilli", "Gherkin", "Garlic", "Fenugreek", "Cucumber", "Courgette", "Aubergine", "Corn cob", "Baby corn", "Mushroom", "Celery", "Cauliflower", "Carrot", "Green bell pepper", "Yellow bell pepper", "Orange bell pepper", "Red bell pepper", "Capers", "Broccoli", "Broad bean", "Bottle gourd", "Bitter gourd", "Lotus stem", "Beetroot", "Pigweed", "Cabbage", "Bamboo shoot", "Avocado", "Asparagus", "Arichoke", "Taro", "Potato", "Ginger", "Coriander ", "Chive", "Galangal", "Tulsi", "Sage", "Rosemary", "Basil", "Mint", "Chives", "Chilli powder", "Oregano", "Nasturtium", "Salt", "Mustard", "Paprika", "Marjoram", "Lemongrass", "Saffron", "Dried fenugreek", "Fenugreek seed", "Kashmiri Mirch", "Onion seed", "Mace", "Nutmeg", "Mixed herbs", "Thyme", "Tumeric", "Garam masala", "Five spice", "Fennel", "Green Cardamom", "Dried ginger", "Dill", "Curry leaf", "Cumin seeds", "Black cumin", "Bay leaf", "Clove", "Cinnamon", "Star anise", "Cayenne", "Caraway seed", "Cajun spice", "Rock salt", "Black pepper", "Black Cardamom", "Asafoetida", "Aniseed", "Raw mango powder", "Carom seed", "Parsley", "Acacia leaf", "Amaranth", "Flour", "Muesli", "Oat", "Jowar", "Brown rice", "Long grain brown rice", "White rice", "Long grain white rice", "Pilau rice", "Basmati rice", "White jasmine rice", "Puffed rice", "Arborio rice", "Tapioca", "Semolina", "Millet", "Wheat", "Buckwheat", "Kidney bean", "Gram", "Gram flour", "Chickpea", "Lentil", "Cous-cous", "Cornmeal", "Bread", "Bread crumb", "Bean", "Barley", "Bean Sprout", "Beef", "Chicken", "Turkey", "Pork", "Bacon", "Lamb", "Partridge", "Quail", "Mutton", "Meat stock", "Keema", "Mincemeat", "Sausages", "Black pudding", "Liver", "Ham", "Breast steak", "Thigh steak", "Rump steak", "Kidney", "Crab", "Chop", "Shrimp", "Fish", "Fish stock", "Tuna", "Pate", "Shellfish", "Shark", "Hilsa", "Sardine", "Salmon", "Prawn", "Pomfret", "Mussel", "Mullet", "Squid", "Haddock", "Flounder", "Caviar", "Cuttlel fish", "Cod", "Clam", "Catfish", "Mackerel", "Anchovie", "Chia seed", "Hazelnut", "Pine nut", "Sunflower seed", "Pistachio", "Mustard seed", "Sesame seed", "Peanut", "Chironji", "Cashew nut", "Almond", "Walnut", "Brown sugar", "White sugar", "Cane sugar", "Castor sugar", "Caramel", "Artificial sweetener", "Icing sugar", "Food dye", "Crystallised sugar lumps", "Honey", "Jaggery", "Golden syrup" });
            ingredientSelectComboBox.Location = new Point(5, 248);
            ingredientSelectComboBox.Name = "ingredientSelectComboBox";
            ingredientSelectComboBox.Size = new Size(151, 28);
            ingredientSelectComboBox.TabIndex = 16;
            // 
            // ingredientListDisplayBox
            // 
            ingredientListDisplayBox.Location = new Point(6, 290);
            ingredientListDisplayBox.Multiline = true;
            ingredientListDisplayBox.Name = "ingredientListDisplayBox";
            ingredientListDisplayBox.ReadOnly = true;
            ingredientListDisplayBox.Size = new Size(507, 96);
            ingredientListDisplayBox.TabIndex = 15;
            // 
            // addRecipeButton
            // 
            addRecipeButton.Location = new Point(6, 450);
            addRecipeButton.Name = "addRecipeButton";
            addRecipeButton.Size = new Size(94, 29);
            addRecipeButton.TabIndex = 1;
            addRecipeButton.Text = "Add recipe";
            addRecipeButton.UseVisualStyleBackColor = true;
            addRecipeButton.Click += addRecipeButton_Click;
            // 
            // recipeAllergenPromptLbl
            // 
            recipeAllergenPromptLbl.AutoSize = true;
            recipeAllergenPromptLbl.Location = new Point(6, 110);
            recipeAllergenPromptLbl.Name = "recipeAllergenPromptLbl";
            recipeAllergenPromptLbl.Size = new Size(371, 20);
            recipeAllergenPromptLbl.TabIndex = 0;
            recipeAllergenPromptLbl.Text = "Tick a box if the recipe contains one of these allergens:";
            // 
            // recipeRemovalBox
            // 
            recipeRemovalBox.Controls.Add(removeRecipeButton);
            recipeRemovalBox.Controls.Add(recipeRemovalNameBox);
            recipeRemovalBox.Controls.Add(recipeRemovalNameLbl);
            recipeRemovalBox.Location = new Point(12, 529);
            recipeRemovalBox.Name = "recipeRemovalBox";
            recipeRemovalBox.Size = new Size(531, 110);
            recipeRemovalBox.TabIndex = 3;
            recipeRemovalBox.TabStop = false;
            recipeRemovalBox.Text = "Recipe Removal Tool";
            // 
            // removeRecipeButton
            // 
            removeRecipeButton.Location = new Point(6, 66);
            removeRecipeButton.Name = "removeRecipeButton";
            removeRecipeButton.Size = new Size(119, 29);
            removeRecipeButton.TabIndex = 2;
            removeRecipeButton.Text = "Remove recipe";
            removeRecipeButton.UseVisualStyleBackColor = true;
            removeRecipeButton.Click += removeRecipeButton_Click;
            // 
            // recipeRemovalNameBox
            // 
            recipeRemovalNameBox.Location = new Point(144, 32);
            recipeRemovalNameBox.Name = "recipeRemovalNameBox";
            recipeRemovalNameBox.Size = new Size(353, 27);
            recipeRemovalNameBox.TabIndex = 1;
            // 
            // recipeRemovalNameLbl
            // 
            recipeRemovalNameLbl.AutoSize = true;
            recipeRemovalNameLbl.Location = new Point(6, 32);
            recipeRemovalNameLbl.Name = "recipeRemovalNameLbl";
            recipeRemovalNameLbl.Size = new Size(132, 20);
            recipeRemovalNameLbl.TabIndex = 0;
            recipeRemovalNameLbl.Text = "Enter recipe name:";
            // 
            // taskStatusGroupBox
            // 
            taskStatusGroupBox.Controls.Add(taskStatusLbl);
            taskStatusGroupBox.Location = new Point(12, 645);
            taskStatusGroupBox.Name = "taskStatusGroupBox";
            taskStatusGroupBox.Size = new Size(531, 72);
            taskStatusGroupBox.TabIndex = 4;
            taskStatusGroupBox.TabStop = false;
            taskStatusGroupBox.Text = "Task Status:";
            // 
            // taskStatusLbl
            // 
            taskStatusLbl.AutoEllipsis = true;
            taskStatusLbl.AutoSize = true;
            taskStatusLbl.Location = new Point(5, 23);
            taskStatusLbl.Name = "taskStatusLbl";
            taskStatusLbl.Size = new Size(143, 20);
            taskStatusLbl.TabIndex = 0;
            taskStatusLbl.Text = "No previous actions.";
            // 
            // removeIngredientButton
            // 
            removeIngredientButton.Location = new Point(433, 245);
            removeIngredientButton.Name = "removeIngredientButton";
            removeIngredientButton.Size = new Size(80, 29);
            removeIngredientButton.TabIndex = 29;
            removeIngredientButton.Text = "Remove";
            removeIngredientButton.UseVisualStyleBackColor = true;
            removeIngredientButton.Click += removeIngredientButton_Click;
            // 
            // CustomRecipeTools
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 729);
            Controls.Add(taskStatusGroupBox);
            Controls.Add(recipeRemovalBox);
            Controls.Add(recipeAdditionBox);
            Controls.Add(returnHomeButton);
            Controls.Add(logoLbl);
            Name = "CustomRecipeTools";
            Text = "Custom Recipe Tools";
            recipeAdditionBox.ResumeLayout(false);
            recipeAdditionBox.PerformLayout();
            recipeRemovalBox.ResumeLayout(false);
            recipeRemovalBox.PerformLayout();
            taskStatusGroupBox.ResumeLayout(false);
            taskStatusGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label logoLbl;
        private Button returnHomeButton;
        private GroupBox recipeAdditionBox;
        private GroupBox recipeRemovalBox;
        private GroupBox taskStatusGroupBox;
        private Label taskStatusLbl;
        private Label recipeAllergenPromptLbl;
        private CheckBox celeryCheckBox;
        private Button addRecipeButton;
        private CheckBox eggsCheckBox;
        private CheckBox crustaceansCheckBox;
        private CheckBox glutenCheckBox;
        private CheckBox sulphurDioxideCheckBox;
        private CheckBox soyaCheckBox;
        private CheckBox sesameCheckBox;
        private CheckBox peanutsCheckBox;
        private CheckBox nutsCheckBox;
        private CheckBox mustardCheckBox;
        private CheckBox molluscsCheckBox;
        private CheckBox milkCheckBox;
        private CheckBox fishCheckBox;
        private Button addIngredientButton;
        private TextBox ingredientQuantityBox;
        private ComboBox ingredientSelectComboBox;
        private TextBox ingredientListDisplayBox;
        private Label ingredientQuantityLbl;
        private Label ingredientNameLbl;
        private TextBox recipeNameBox;
        private Label recipeNameLbl;
        private Label weblinkPromptLbl;
        private TextBox weblinkBox;
        private CheckBox noWeblinkBox;
        private Label recipeRemovalNameLbl;
        private Button removeRecipeButton;
        private TextBox recipeRemovalNameBox;
        private Label originRecipeLbl;
        private TextBox recipeOriginTextBox;
        private CheckedListBox allergenCheckedListBox;
        private Button removeIngredientButton;
    }
}