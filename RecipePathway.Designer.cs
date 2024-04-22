namespace RecipeFinderPrototype
{
    partial class RecipePathway
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
            returnHomeButton = new Button();
            logoLbl = new Label();
            recipeListTypePromptLbl = new Label();
            customRadioButton = new RadioButton();
            presetRadioButton = new RadioButton();
            displayAllButton = new Button();
            recipeChooseButton = new Button();
            taskStatusGroupBox = new GroupBox();
            taskStatusLbl = new Label();
            userFridgeGroupBox = new GroupBox();
            removeIngredientButton = new Button();
            addIngredientButton = new Button();
            ingredientListDisplay = new TextBox();
            ingredientQuantityBox = new TextBox();
            ingredientSelectComboBox = new ComboBox();
            ingredientQuantityLbl = new Label();
            label2 = new Label();
            ingredientNameLbl = new Label();
            allergenCheckedListBox = new CheckedListBox();
            label1 = new Label();
            taskStatusGroupBox.SuspendLayout();
            userFridgeGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // returnHomeButton
            // 
            returnHomeButton.Location = new Point(451, 12);
            returnHomeButton.Name = "returnHomeButton";
            returnHomeButton.Size = new Size(111, 29);
            returnHomeButton.TabIndex = 0;
            returnHomeButton.Text = "Return Home";
            returnHomeButton.UseVisualStyleBackColor = true;
            returnHomeButton.Click += returnHomeButton_Click;
            // 
            // logoLbl
            // 
            logoLbl.AutoSize = true;
            logoLbl.BackColor = SystemColors.ControlLight;
            logoLbl.BorderStyle = BorderStyle.FixedSingle;
            logoLbl.Location = new Point(12, 9);
            logoLbl.Name = "logoLbl";
            logoLbl.Size = new Size(126, 22);
            logoLbl.TabIndex = 1;
            logoLbl.Text = "Choose My Food!";
            // 
            // recipeListTypePromptLbl
            // 
            recipeListTypePromptLbl.AutoSize = true;
            recipeListTypePromptLbl.Location = new Point(19, 68);
            recipeListTypePromptLbl.Name = "recipeListTypePromptLbl";
            recipeListTypePromptLbl.Size = new Size(257, 20);
            recipeListTypePromptLbl.TabIndex = 2;
            recipeListTypePromptLbl.Text = "Which type of recipe are you finding?";
            // 
            // customRadioButton
            // 
            customRadioButton.AutoSize = true;
            customRadioButton.Location = new Point(282, 66);
            customRadioButton.Name = "customRadioButton";
            customRadioButton.Size = new Size(125, 24);
            customRadioButton.TabIndex = 3;
            customRadioButton.TabStop = true;
            customRadioButton.Text = "Custom recipe";
            customRadioButton.UseVisualStyleBackColor = true;
            // 
            // presetRadioButton
            // 
            presetRadioButton.AutoSize = true;
            presetRadioButton.Location = new Point(413, 66);
            presetRadioButton.Name = "presetRadioButton";
            presetRadioButton.Size = new Size(115, 24);
            presetRadioButton.TabIndex = 4;
            presetRadioButton.TabStop = true;
            presetRadioButton.Text = "Preset recipe";
            presetRadioButton.UseVisualStyleBackColor = true;
            // 
            // displayAllButton
            // 
            displayAllButton.Location = new Point(19, 501);
            displayAllButton.Name = "displayAllButton";
            displayAllButton.Size = new Size(154, 29);
            displayAllButton.TabIndex = 6;
            displayAllButton.Text = "Display all recipes";
            displayAllButton.UseVisualStyleBackColor = true;
            displayAllButton.Click += displayAllButton_Click;
            // 
            // recipeChooseButton
            // 
            recipeChooseButton.Location = new Point(408, 501);
            recipeChooseButton.Name = "recipeChooseButton";
            recipeChooseButton.Size = new Size(154, 29);
            recipeChooseButton.TabIndex = 8;
            recipeChooseButton.Text = "Choose my recipes!";
            recipeChooseButton.UseVisualStyleBackColor = true;
            recipeChooseButton.Click += recipeChooseButton_Click;
            // 
            // taskStatusGroupBox
            // 
            taskStatusGroupBox.Controls.Add(taskStatusLbl);
            taskStatusGroupBox.Location = new Point(19, 431);
            taskStatusGroupBox.Name = "taskStatusGroupBox";
            taskStatusGroupBox.Size = new Size(543, 64);
            taskStatusGroupBox.TabIndex = 9;
            taskStatusGroupBox.TabStop = false;
            taskStatusGroupBox.Text = "Task Status:";
            // 
            // taskStatusLbl
            // 
            taskStatusLbl.AutoSize = true;
            taskStatusLbl.Location = new Point(11, 32);
            taskStatusLbl.Name = "taskStatusLbl";
            taskStatusLbl.Size = new Size(143, 20);
            taskStatusLbl.TabIndex = 0;
            taskStatusLbl.Text = "No previous actions.";
            // 
            // userFridgeGroupBox
            // 
            userFridgeGroupBox.Controls.Add(removeIngredientButton);
            userFridgeGroupBox.Controls.Add(addIngredientButton);
            userFridgeGroupBox.Controls.Add(ingredientListDisplay);
            userFridgeGroupBox.Controls.Add(ingredientQuantityBox);
            userFridgeGroupBox.Controls.Add(ingredientSelectComboBox);
            userFridgeGroupBox.Controls.Add(ingredientQuantityLbl);
            userFridgeGroupBox.Controls.Add(label2);
            userFridgeGroupBox.Controls.Add(ingredientNameLbl);
            userFridgeGroupBox.Location = new Point(19, 227);
            userFridgeGroupBox.Name = "userFridgeGroupBox";
            userFridgeGroupBox.Size = new Size(543, 198);
            userFridgeGroupBox.TabIndex = 10;
            userFridgeGroupBox.TabStop = false;
            userFridgeGroupBox.Text = "Input ingredients you already have and their quantities (in grams):";
            // 
            // removeIngredientButton
            // 
            removeIngredientButton.Location = new Point(444, 56);
            removeIngredientButton.Name = "removeIngredientButton";
            removeIngredientButton.Size = new Size(86, 29);
            removeIngredientButton.TabIndex = 7;
            removeIngredientButton.Text = "Remove";
            removeIngredientButton.UseVisualStyleBackColor = true;
            removeIngredientButton.Click += removeIngredientButton_Click;
            // 
            // addIngredientButton
            // 
            addIngredientButton.Location = new Point(377, 56);
            addIngredientButton.Name = "addIngredientButton";
            addIngredientButton.Size = new Size(61, 29);
            addIngredientButton.TabIndex = 6;
            addIngredientButton.Text = "Add";
            addIngredientButton.UseVisualStyleBackColor = true;
            addIngredientButton.Click += addIngredientButton_Click;
            // 
            // ingredientListDisplay
            // 
            ingredientListDisplay.Location = new Point(6, 91);
            ingredientListDisplay.Multiline = true;
            ingredientListDisplay.Name = "ingredientListDisplay";
            ingredientListDisplay.ReadOnly = true;
            ingredientListDisplay.Size = new Size(524, 96);
            ingredientListDisplay.TabIndex = 5;
            // 
            // ingredientQuantityBox
            // 
            ingredientQuantityBox.Location = new Point(163, 58);
            ingredientQuantityBox.Name = "ingredientQuantityBox";
            ingredientQuantityBox.Size = new Size(208, 27);
            ingredientQuantityBox.TabIndex = 4;
            // 
            // ingredientSelectComboBox
            // 
            ingredientSelectComboBox.FormattingEnabled = true;
            ingredientSelectComboBox.Items.AddRange(new object[] { "Cream", "Whipped cream", "Sour cream", "Double cream", "Yoghurt", "Milk", "Condensed milk", "Evapourated milk", "Buttermilk", "Egg", "Cheese", "Butter", "Custard", "Margerine", "Sunflower oil", "Canola oil", "Vegetable oil", "Peanut oil", "Rapeseed oil", "Mustard oil", "Sunflower oil", "Olive oil", "Coconut oil", "Sesame oil", "Orange", "Lemon", "Mango", "Apple", "Blueberry", "Raspberry", "Strawberry", "Cranberry", "Kiwi", "Banana", "Watermelon", "Tomato", "Water Chestnut", "Papaya", "Olive", "Pear", "Sultana", "Mulberry", "Lychee", "Raisins", "Jamun", "Tamarind", "Gooseberry", "Grapefruit", "Dates", "Custard apple", "Black currant", "Red currant", "Coconut", "Cherry", "Apricot", "Figs", "Pomegranate", "Grapes", "Pineapple", "Guava", "Plum", "Bok choy", "Green bean", "Sorrel leaf", "Rocket leaf", "Plantain", "Turnip", "Sweet potatoes", "Round gourd", "Pimento", "Spinach", "Brown onion", "Red onion", "Spring onion", "Shallot", "Mustard leaf", "Mushroom", "Radish", "Lettuce", "Leek", "Pumpkin", "Yam", "Jalapeno", "Jackfruit", "Horseradish", "Peas", "Chilli", "Gherkin", "Garlic", "Fenugreek", "Cucumber", "Courgette", "Aubergine", "Corn cob", "Baby corn", "Mushroom", "Celery", "Cauliflower", "Carrot", "Green bell pepper", "Yellow bell pepper", "Orange bell pepper", "Red bell pepper", "Capers", "Broccoli", "Broad bean", "Bottle gourd", "Bitter gourd", "Lotus stem", "Beetroot", "Pigweed", "Cabbage", "Bamboo shoot", "Avocado", "Asparagus", "Arichoke", "Taro", "Potato", "Ginger", "Coriander ", "Chive", "Galangal", "Tulsi", "Sage", "Rosemary", "Basil", "Mint", "Chives", "Chilli powder", "Oregano", "Nasturtium", "Salt", "Mustard", "Paprika", "Marjoram", "Lemongrass", "Saffron", "Dried fenugreek", "Fenugreek seed", "Kashmiri Mirch", "Onion seed", "Mace", "Nutmeg", "Mixed herbs", "Thyme", "Tumeric", "Garam masala", "Five spice", "Fennel", "Green Cardamom", "Dried ginger", "Dill", "Curry leaf", "Cumin seeds", "Black cumin", "Bay leaf", "Clove", "Cinnamon", "Star anise", "Cayenne", "Caraway seed", "Cajun spice", "Rock salt", "Black pepper", "Black Cardamom", "Asafoetida", "Aniseed", "Raw mango powder", "Carom seed", "Parsley", "Acacia leaf", "Amaranth", "Flour", "Muesli", "Oat", "Jowar", "Brown rice", "Long grain brown rice", "White rice", "Long grain white rice", "Pilau rice", "Basmati rice", "White jasmine rice", "Puffed rice", "Arborio rice", "Tapioca", "Semolina", "Millet", "Wheat", "Buckwheat", "Kidney bean", "Gram", "Gram flour", "Chickpea", "Lentil", "Cous-cous", "Cornmeal", "Bread", "Bread crumb", "Bean", "Barley", "Bean Sprout", "Beef", "Chicken", "Turkey", "Pork", "Bacon", "Lamb", "Partridge", "Quail", "Mutton", "Meat stock", "Keema", "Mincemeat", "Sausages", "Black pudding", "Liver", "Ham", "Breast steak", "Thigh steak", "Rump steak", "Kidney", "Crab", "Chop", "Shrimp", "Fish", "Fish stock", "Tuna", "Pate", "Shellfish", "Shark", "Hilsa", "Sardine", "Salmon", "Prawn", "Pomfret", "Mussel", "Mullet", "Squid", "Haddock", "Flounder", "Caviar", "Cuttlel fish", "Cod", "Clam", "Catfish", "Mackerel", "Anchovie", "Chia seed", "Hazelnut", "Pine nut", "Sunflower seed", "Pistachio", "Mustard seed", "Sesame seed", "Peanut", "Chironji", "Cashew nut", "Almond", "Walnut", "Brown sugar", "White sugar", "Cane sugar", "Castor sugar", "Caramel", "Artificial sweetener", "Icing sugar", "Food dye", "Crystallised sugar lumps", "Honey", "Jaggery", "Golden syrup" });
            ingredientSelectComboBox.Location = new Point(6, 58);
            ingredientSelectComboBox.Name = "ingredientSelectComboBox";
            ingredientSelectComboBox.Size = new Size(151, 28);
            ingredientSelectComboBox.TabIndex = 3;
            // 
            // ingredientQuantityLbl
            // 
            ingredientQuantityLbl.AutoSize = true;
            ingredientQuantityLbl.Location = new Point(162, 35);
            ingredientQuantityLbl.Name = "ingredientQuantityLbl";
            ingredientQuantityLbl.Size = new Size(209, 20);
            ingredientQuantityLbl.TabIndex = 2;
            ingredientQuantityLbl.Text = "Ingredient quantity (in grams):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 35);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // ingredientNameLbl
            // 
            ingredientNameLbl.AutoSize = true;
            ingredientNameLbl.Location = new Point(6, 35);
            ingredientNameLbl.Name = "ingredientNameLbl";
            ingredientNameLbl.Size = new Size(121, 20);
            ingredientNameLbl.TabIndex = 0;
            ingredientNameLbl.Text = "Ingredient name:";
            // 
            // allergenCheckedListBox
            // 
            allergenCheckedListBox.BorderStyle = BorderStyle.FixedSingle;
            allergenCheckedListBox.FormattingEnabled = true;
            allergenCheckedListBox.HorizontalScrollbar = true;
            allergenCheckedListBox.Items.AddRange(new object[] { "Celery", "Gluten", "Crustaceans", "Egg", "Fish", "Milk", "Molluscs", "Mustard", "Nuts", "Peanuts", "Sesame seeds", "Soya", "Sulphur dioxide" });
            allergenCheckedListBox.Location = new Point(19, 120);
            allergenCheckedListBox.MultiColumn = true;
            allergenCheckedListBox.Name = "allergenCheckedListBox";
            allergenCheckedListBox.Size = new Size(543, 90);
            allergenCheckedListBox.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 97);
            label1.Name = "label1";
            label1.Size = new Size(305, 20);
            label1.TabIndex = 12;
            label1.Text = "Tick a box if you have one of these allergens:";
            // 
            // RecipePathway
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 540);
            Controls.Add(label1);
            Controls.Add(allergenCheckedListBox);
            Controls.Add(userFridgeGroupBox);
            Controls.Add(taskStatusGroupBox);
            Controls.Add(recipeChooseButton);
            Controls.Add(displayAllButton);
            Controls.Add(presetRadioButton);
            Controls.Add(customRadioButton);
            Controls.Add(recipeListTypePromptLbl);
            Controls.Add(logoLbl);
            Controls.Add(returnHomeButton);
            Name = "RecipePathway";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recipe Pathway";
            taskStatusGroupBox.ResumeLayout(false);
            taskStatusGroupBox.PerformLayout();
            userFridgeGroupBox.ResumeLayout(false);
            userFridgeGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button returnHomeButton;
        private Label logoLbl;
        private Label recipeListTypePromptLbl;
        private RadioButton customRadioButton;
        private RadioButton presetRadioButton;
        private Button displayAllButton;
        private Button recipeChooseButton;
        private GroupBox taskStatusGroupBox;
        private Label taskStatusLbl;
        private GroupBox userFridgeGroupBox;
        private Label label2;
        private Label ingredientNameLbl;
        private ComboBox ingredientSelectComboBox;
        private Label ingredientQuantityLbl;
        private TextBox ingredientQuantityBox;
        private TextBox ingredientListDisplay;
        private Button addIngredientButton;
        private CheckedListBox allergenCheckedListBox;
        private Label label1;
        private Button removeIngredientButton;
    }
}