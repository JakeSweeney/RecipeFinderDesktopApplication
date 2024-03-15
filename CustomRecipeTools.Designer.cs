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
            weblinkPromptLbl = new Label();
            weblinkBox = new TextBox();
            noWeblinkBox = new CheckBox();
            recipeNameBox = new TextBox();
            recipeNameLbl = new Label();
            label3 = new Label();
            label2 = new Label();
            addIngredientButton = new Button();
            ingredientQuantityBox = new TextBox();
            ingredientSelectComboBox = new ComboBox();
            ingredientListDisplayBox = new TextBox();
            sulphurDioxideCheckBox = new CheckBox();
            soyaCheckBox = new CheckBox();
            sesameCheckBox = new CheckBox();
            peanutsCheckBox = new CheckBox();
            nutsCheckBox = new CheckBox();
            mustardCheckBox = new CheckBox();
            molluscsCheckBox = new CheckBox();
            milkCheckBox = new CheckBox();
            fishCheckBox = new CheckBox();
            eggsCheckBox = new CheckBox();
            crustaceansCheckBox = new CheckBox();
            glutenCheckBox = new CheckBox();
            celeryCheckBox = new CheckBox();
            addRecipeButton = new Button();
            recipeAllergenPromptLbl = new Label();
            recipeRemovalBox = new GroupBox();
            removeRecipeButton = new Button();
            recipeRemovalNameBox = new TextBox();
            recipeRemovalNameLbl = new Label();
            groupBox3 = new GroupBox();
            taskStatusLbl = new Label();
            recipeAdditionBox.SuspendLayout();
            recipeRemovalBox.SuspendLayout();
            groupBox3.SuspendLayout();
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
            returnHomeButton.Location = new Point(407, 5);
            returnHomeButton.Name = "returnHomeButton";
            returnHomeButton.Size = new Size(108, 29);
            returnHomeButton.TabIndex = 1;
            returnHomeButton.Text = "Return Home";
            returnHomeButton.UseVisualStyleBackColor = true;
            returnHomeButton.Click += returnHomeButton_Click;
            // 
            // recipeAdditionBox
            // 
            recipeAdditionBox.Controls.Add(weblinkPromptLbl);
            recipeAdditionBox.Controls.Add(weblinkBox);
            recipeAdditionBox.Controls.Add(noWeblinkBox);
            recipeAdditionBox.Controls.Add(recipeNameBox);
            recipeAdditionBox.Controls.Add(recipeNameLbl);
            recipeAdditionBox.Controls.Add(label3);
            recipeAdditionBox.Controls.Add(label2);
            recipeAdditionBox.Controls.Add(addIngredientButton);
            recipeAdditionBox.Controls.Add(ingredientQuantityBox);
            recipeAdditionBox.Controls.Add(ingredientSelectComboBox);
            recipeAdditionBox.Controls.Add(ingredientListDisplayBox);
            recipeAdditionBox.Controls.Add(sulphurDioxideCheckBox);
            recipeAdditionBox.Controls.Add(soyaCheckBox);
            recipeAdditionBox.Controls.Add(sesameCheckBox);
            recipeAdditionBox.Controls.Add(peanutsCheckBox);
            recipeAdditionBox.Controls.Add(nutsCheckBox);
            recipeAdditionBox.Controls.Add(mustardCheckBox);
            recipeAdditionBox.Controls.Add(molluscsCheckBox);
            recipeAdditionBox.Controls.Add(milkCheckBox);
            recipeAdditionBox.Controls.Add(fishCheckBox);
            recipeAdditionBox.Controls.Add(eggsCheckBox);
            recipeAdditionBox.Controls.Add(crustaceansCheckBox);
            recipeAdditionBox.Controls.Add(glutenCheckBox);
            recipeAdditionBox.Controls.Add(celeryCheckBox);
            recipeAdditionBox.Controls.Add(addRecipeButton);
            recipeAdditionBox.Controls.Add(recipeAllergenPromptLbl);
            recipeAdditionBox.Location = new Point(12, 34);
            recipeAdditionBox.Name = "recipeAdditionBox";
            recipeAdditionBox.Size = new Size(503, 444);
            recipeAdditionBox.TabIndex = 2;
            recipeAdditionBox.TabStop = false;
            recipeAdditionBox.Text = "Recipe Addition Tool";
            // 
            // weblinkPromptLbl
            // 
            weblinkPromptLbl.AutoSize = true;
            weblinkPromptLbl.Location = new Point(6, 350);
            weblinkPromptLbl.Name = "weblinkPromptLbl";
            weblinkPromptLbl.Size = new Size(113, 20);
            weblinkPromptLbl.TabIndex = 25;
            weblinkPromptLbl.Text = "Enter a weblink:";
            // 
            // weblinkBox
            // 
            weblinkBox.Location = new Point(119, 350);
            weblinkBox.Name = "weblinkBox";
            weblinkBox.Size = new Size(369, 27);
            weblinkBox.TabIndex = 24;
            // 
            // noWeblinkBox
            // 
            noWeblinkBox.AutoSize = true;
            noWeblinkBox.Location = new Point(6, 383);
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
            recipeNameBox.Size = new Size(311, 27);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 181);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 20;
            label3.Text = "Ingredient quantity:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 181);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 19;
            label2.Text = "Ingredient name:";
            // 
            // addIngredientButton
            // 
            addIngredientButton.Location = new Point(364, 204);
            addIngredientButton.Name = "addIngredientButton";
            addIngredientButton.Size = new Size(124, 29);
            addIngredientButton.TabIndex = 18;
            addIngredientButton.Text = "Add ingredient";
            addIngredientButton.UseVisualStyleBackColor = true;
            // 
            // ingredientQuantityBox
            // 
            ingredientQuantityBox.Location = new Point(162, 206);
            ingredientQuantityBox.Name = "ingredientQuantityBox";
            ingredientQuantityBox.Size = new Size(196, 27);
            ingredientQuantityBox.TabIndex = 17;
            // 
            // ingredientSelectComboBox
            // 
            ingredientSelectComboBox.FormattingEnabled = true;
            ingredientSelectComboBox.Items.AddRange(new object[] { "Cream", "Whipped cream", "Sour cream", "Double cream", "Yoghurt", "Milk", "Condensed milk", "Evapourated milk", "Buttermilk", "Egg", "Cheese", "Butter", "Custard", "Margerine", "Sunflower oil", "Canola oil", "Vegetable oil", "Peanut oil", "Rapeseed oil", "Mustard oil", "Sunflower oil", "Olive oil", "Coconut oil", "Sesame oil", "Orange", "Lemon", "Mango", "Apple", "Blueberrie", "Raspberrie", "Strawberrie", "Cranberrie", "Kiwi", "Banana", "Watermelon", "Tomato", "Water Chestnut", "Papaya", "Olive", "Pear", "Sultana", "Mulberry", "Lychee", "Raisins", "Jamun", "Tamarind", "Gooseberry", "Grapefruit", "Dates", "Custard apple", "Black currant", "Red currant", "Coconut", "Cherry", "Apricot", "Figs", "Pomegranate", "Grapes", "Pineapple", "Guava", "Plum", "Bok choy", "Green bean", "Sorrel leaf", "Rocket leaf", "Plantain", "Turnip", "Sweet potatoes", "Round gourd", "Pimento", "Spinach", "Brown onion", "Red onion", "Spring onion", "Shallot", "Mustard leaf", "Mushroom", "Radish", "Lettuce", "Leek", "Pumpkin", "Yam", "Jalapeno", "Jackfruit", "Horseradish", "Peas", "Chilli", "Gherkin", "Garlic", "Fenugreek", "Cucumber", "Courgette", "Aubergine", "Corn cob", "Baby corn", "Mushroom", "Celery", "Cauliflower", "Carrot", "Green bell pepper", "Yellow bell pepper", "Orange bell pepper", "Red bell pepper", "Capers", "Broccoli", "Broad bean", "Bottle gourd", "Bitter gourd", "Lotus stem", "Beetroot", "Pigweed", "Cabbage", "Bamboo shoot", "Avocado", "Asparagus", "Arichoke", "Taro", "Potato", "Ginger", "Coriander ", "Chive", "Galangal", "Tulsi", "Sage", "Rosemary", "Basil", "Mint", "Chives", "Chilli powder", "Oregano", "Nasturtium", "Salt", "Mustard", "Paprika", "Marjoram", "Lemongrass", "Saffron", "Dried fenugreek", "Fenugreek seed", "Kashmiri Mirch", "Onion seed", "Mace", "Nutmeg", "Mixed herbs", "Thyme", "Tumeric", "Garam masala", "Five spice", "Fennel", "Green Cardamom", "Dried ginger", "Dill", "Curry leaf", "Cumin seeds", "Black cumin", "Bay leaf", "Clove", "Cinnamon", "Star anise", "Cayenne", "Caraway seed", "Cajun spice", "Rock salt", "Black pepper", "Black Cardamom", "Asafoetida", "Aniseed", "Raw mango powder", "Carom seed", "Parsley", "Acacia leaf", "Amaranth", "Flour", "Muesli", "Oat", "Jowar", "Brown rice", "Long grain brown rice", "White rice", "Long grain white rice", "Pilau rice", "Basmati rice", "White jasmine rice", "Puffed rice", "Arborio rice", "Tapioca", "Semolina", "Millet", "Wheat", "Buckwheat", "Kidney bean", "Gram", "Gram flour", "Chickpea", "Lentil", "Cous-cous", "Cornmeal", "Bread", "Bread crumb", "Bean", "Barley", "Bean Sprout", "Beef", "Chicken", "Turkey", "Pork", "Bacon", "Lamb", "Partridge", "Quail", "Mutton", "Meat stock", "Keema", "Mincemeat", "Sausages", "Black pudding", "Liver", "Ham", "Breast steak", "Thigh steak", "Rump steak", "Kidney", "Crab", "Chop", "Shrimp", "Fish", "Fish stock", "Tuna", "Pate", "Shellfish", "Shark", "Hilsa", "Sardine", "Salmon", "Prawn", "Pomfret", "Mussel", "Mullet", "Squid", "Haddock", "Flounder", "Caviar", "Cuttlel fish", "Cod", "Clam", "Catfish", "Mackerel", "Anchovie", "Chia seed", "Hazelnut", "Pine nut", "Sunflower seed", "Pistachio", "Mustard seed", "Sesame seed", "Peanut", "Chironji", "Cashew nut", "Almond", "Walnut", "Brown sugar", "White sugar", "Cane sugar", "Castor sugar", "Caramel", "Artificial sweetener", "Icing sugar", "Food dye", "Crystallised sugar lumps", "Honey", "Jaggery", "Golden syrup" });
            ingredientSelectComboBox.Location = new Point(5, 207);
            ingredientSelectComboBox.Name = "ingredientSelectComboBox";
            ingredientSelectComboBox.Size = new Size(151, 28);
            ingredientSelectComboBox.TabIndex = 16;
            // 
            // ingredientListDisplayBox
            // 
            ingredientListDisplayBox.Location = new Point(5, 241);
            ingredientListDisplayBox.Multiline = true;
            ingredientListDisplayBox.Name = "ingredientListDisplayBox";
            ingredientListDisplayBox.ReadOnly = true;
            ingredientListDisplayBox.Size = new Size(483, 96);
            ingredientListDisplayBox.TabIndex = 15;
            // 
            // sulphurDioxideCheckBox
            // 
            sulphurDioxideCheckBox.AutoSize = true;
            sulphurDioxideCheckBox.Location = new Point(200, 152);
            sulphurDioxideCheckBox.Name = "sulphurDioxideCheckBox";
            sulphurDioxideCheckBox.Size = new Size(135, 24);
            sulphurDioxideCheckBox.TabIndex = 14;
            sulphurDioxideCheckBox.Text = "Sulphur dioxide";
            sulphurDioxideCheckBox.UseVisualStyleBackColor = true;
            // 
            // soyaCheckBox
            // 
            soyaCheckBox.AutoSize = true;
            soyaCheckBox.Location = new Point(131, 152);
            soyaCheckBox.Name = "soyaCheckBox";
            soyaCheckBox.Size = new Size(63, 24);
            soyaCheckBox.TabIndex = 13;
            soyaCheckBox.Text = "Soya";
            soyaCheckBox.UseVisualStyleBackColor = true;
            // 
            // sesameCheckBox
            // 
            sesameCheckBox.AutoSize = true;
            sesameCheckBox.Location = new Point(5, 152);
            sesameCheckBox.Name = "sesameCheckBox";
            sesameCheckBox.Size = new Size(123, 24);
            sesameCheckBox.TabIndex = 12;
            sesameCheckBox.Text = "Sesame seeds";
            sesameCheckBox.UseVisualStyleBackColor = true;
            // 
            // peanutsCheckBox
            // 
            peanutsCheckBox.AutoSize = true;
            peanutsCheckBox.Location = new Point(386, 122);
            peanutsCheckBox.Name = "peanutsCheckBox";
            peanutsCheckBox.Size = new Size(81, 24);
            peanutsCheckBox.TabIndex = 11;
            peanutsCheckBox.Text = "Peanuts";
            peanutsCheckBox.UseVisualStyleBackColor = true;
            // 
            // nutsCheckBox
            // 
            nutsCheckBox.AutoSize = true;
            nutsCheckBox.Location = new Point(316, 122);
            nutsCheckBox.Name = "nutsCheckBox";
            nutsCheckBox.Size = new Size(61, 24);
            nutsCheckBox.TabIndex = 10;
            nutsCheckBox.Text = "Nuts";
            nutsCheckBox.UseVisualStyleBackColor = true;
            // 
            // mustardCheckBox
            // 
            mustardCheckBox.AutoSize = true;
            mustardCheckBox.Location = new Point(225, 122);
            mustardCheckBox.Name = "mustardCheckBox";
            mustardCheckBox.Size = new Size(85, 24);
            mustardCheckBox.TabIndex = 9;
            mustardCheckBox.Text = "Mustard";
            mustardCheckBox.UseVisualStyleBackColor = true;
            // 
            // molluscsCheckBox
            // 
            molluscsCheckBox.AutoSize = true;
            molluscsCheckBox.Location = new Point(131, 122);
            molluscsCheckBox.Name = "molluscsCheckBox";
            molluscsCheckBox.Size = new Size(88, 24);
            molluscsCheckBox.TabIndex = 8;
            molluscsCheckBox.Text = "Molluscs";
            molluscsCheckBox.UseVisualStyleBackColor = true;
            // 
            // milkCheckBox
            // 
            milkCheckBox.AutoSize = true;
            milkCheckBox.Location = new Point(66, 122);
            milkCheckBox.Name = "milkCheckBox";
            milkCheckBox.Size = new Size(59, 24);
            milkCheckBox.TabIndex = 7;
            milkCheckBox.Text = "Milk";
            milkCheckBox.UseVisualStyleBackColor = true;
            // 
            // fishCheckBox
            // 
            fishCheckBox.AutoSize = true;
            fishCheckBox.Location = new Point(5, 122);
            fishCheckBox.Name = "fishCheckBox";
            fishCheckBox.Size = new Size(56, 24);
            fishCheckBox.TabIndex = 6;
            fishCheckBox.Text = "Fish";
            fishCheckBox.UseVisualStyleBackColor = true;
            // 
            // eggsCheckBox
            // 
            eggsCheckBox.AutoSize = true;
            eggsCheckBox.Location = new Point(404, 92);
            eggsCheckBox.Name = "eggsCheckBox";
            eggsCheckBox.Size = new Size(63, 24);
            eggsCheckBox.TabIndex = 5;
            eggsCheckBox.Text = "Eggs";
            eggsCheckBox.UseVisualStyleBackColor = true;
            // 
            // crustaceansCheckBox
            // 
            crustaceansCheckBox.AutoSize = true;
            crustaceansCheckBox.Location = new Point(289, 92);
            crustaceansCheckBox.Name = "crustaceansCheckBox";
            crustaceansCheckBox.Size = new Size(109, 24);
            crustaceansCheckBox.TabIndex = 4;
            crustaceansCheckBox.Text = "Crustaceans";
            crustaceansCheckBox.UseVisualStyleBackColor = true;
            // 
            // glutenCheckBox
            // 
            glutenCheckBox.AutoSize = true;
            glutenCheckBox.Location = new Point(84, 92);
            glutenCheckBox.Name = "glutenCheckBox";
            glutenCheckBox.Size = new Size(199, 24);
            glutenCheckBox.TabIndex = 3;
            glutenCheckBox.Text = "Cereals containing gluten";
            glutenCheckBox.UseVisualStyleBackColor = true;
            // 
            // celeryCheckBox
            // 
            celeryCheckBox.AutoSize = true;
            celeryCheckBox.Location = new Point(6, 92);
            celeryCheckBox.Name = "celeryCheckBox";
            celeryCheckBox.Size = new Size(72, 24);
            celeryCheckBox.TabIndex = 2;
            celeryCheckBox.Text = "Celery";
            celeryCheckBox.UseVisualStyleBackColor = true;
            // 
            // addRecipeButton
            // 
            addRecipeButton.Location = new Point(5, 409);
            addRecipeButton.Name = "addRecipeButton";
            addRecipeButton.Size = new Size(94, 29);
            addRecipeButton.TabIndex = 1;
            addRecipeButton.Text = "Add recipe";
            addRecipeButton.UseVisualStyleBackColor = true;
            // 
            // recipeAllergenPromptLbl
            // 
            recipeAllergenPromptLbl.AutoSize = true;
            recipeAllergenPromptLbl.Location = new Point(6, 69);
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
            recipeRemovalBox.Location = new Point(12, 497);
            recipeRemovalBox.Name = "recipeRemovalBox";
            recipeRemovalBox.Size = new Size(503, 110);
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
            // 
            // recipeRemovalNameBox
            // 
            recipeRemovalNameBox.Location = new Point(144, 32);
            recipeRemovalNameBox.Name = "recipeRemovalNameBox";
            recipeRemovalNameBox.Size = new Size(344, 27);
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
            // groupBox3
            // 
            groupBox3.Controls.Add(taskStatusLbl);
            groupBox3.Location = new Point(12, 617);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(503, 72);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Task Status:";
            // 
            // taskStatusLbl
            // 
            taskStatusLbl.AutoSize = true;
            taskStatusLbl.Location = new Point(6, 37);
            taskStatusLbl.Name = "taskStatusLbl";
            taskStatusLbl.Size = new Size(143, 20);
            taskStatusLbl.TabIndex = 0;
            taskStatusLbl.Text = "No previous actions.";
            // 
            // CustomRecipeTools
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 693);
            Controls.Add(groupBox3);
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
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label logoLbl;
        private Button returnHomeButton;
        private GroupBox recipeAdditionBox;
        private GroupBox recipeRemovalBox;
        private GroupBox groupBox3;
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
        private Label label3;
        private Label label2;
        private TextBox recipeNameBox;
        private Label recipeNameLbl;
        private Label weblinkPromptLbl;
        private TextBox weblinkBox;
        private CheckBox noWeblinkBox;
        private Label recipeRemovalNameLbl;
        private Button removeRecipeButton;
        private TextBox recipeRemovalNameBox;
    }
}