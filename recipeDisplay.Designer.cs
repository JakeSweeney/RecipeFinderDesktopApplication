namespace RecipeFinderPrototype
{
    partial class recipeDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            recipeNameBox = new TextBox();
            label1 = new Label();
            ingredientBox = new TextBox();
            label2 = new Label();
            allergenBox = new TextBox();
            webLinkLabel = new LinkLabel();
            label3 = new Label();
            regionLbl = new Label();
            regionTextBox = new TextBox();
            label4 = new Label();
            matchValueBox = new TextBox();
            SuspendLayout();
            // 
            // recipeNameBox
            // 
            recipeNameBox.BackColor = SystemColors.ControlLight;
            recipeNameBox.BorderStyle = BorderStyle.None;
            recipeNameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recipeNameBox.Location = new Point(3, 3);
            recipeNameBox.Multiline = true;
            recipeNameBox.Name = "recipeNameBox";
            recipeNameBox.ReadOnly = true;
            recipeNameBox.Size = new Size(501, 43);
            recipeNameBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 81);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 1;
            label1.Text = "Ingredients:";
            // 
            // ingredientBox
            // 
            ingredientBox.BackColor = SystemColors.ControlLight;
            ingredientBox.BorderStyle = BorderStyle.None;
            ingredientBox.Location = new Point(0, 104);
            ingredientBox.Multiline = true;
            ingredientBox.Name = "ingredientBox";
            ingredientBox.ReadOnly = true;
            ingredientBox.Size = new Size(504, 84);
            ingredientBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 191);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 3;
            label2.Text = "Allergens:";
            // 
            // allergenBox
            // 
            allergenBox.BackColor = SystemColors.ControlLight;
            allergenBox.BorderStyle = BorderStyle.None;
            allergenBox.ForeColor = Color.Red;
            allergenBox.Location = new Point(5, 214);
            allergenBox.Multiline = true;
            allergenBox.Name = "allergenBox";
            allergenBox.ReadOnly = true;
            allergenBox.Size = new Size(499, 76);
            allergenBox.TabIndex = 4;
            // 
            // webLinkLabel
            // 
            webLinkLabel.AutoSize = true;
            webLinkLabel.BackColor = SystemColors.ControlLight;
            webLinkLabel.Location = new Point(5, 323);
            webLinkLabel.Name = "webLinkLabel";
            webLinkLabel.Size = new Size(151, 20);
            webLinkLabel.TabIndex = 5;
            webLinkLabel.TabStop = true;
            webLinkLabel.Text = "No weblink available.";
            webLinkLabel.LinkClicked += webLinkLabel_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 303);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 6;
            label3.Text = "Weblink:";
            // 
            // regionLbl
            // 
            regionLbl.AutoSize = true;
            regionLbl.Location = new Point(3, 52);
            regionLbl.Name = "regionLbl";
            regionLbl.Size = new Size(120, 20);
            regionLbl.TabIndex = 7;
            regionLbl.Text = "Region of origin:";
            // 
            // regionTextBox
            // 
            regionTextBox.BackColor = SystemColors.ControlLight;
            regionTextBox.BorderStyle = BorderStyle.None;
            regionTextBox.Location = new Point(129, 52);
            regionTextBox.Name = "regionTextBox";
            regionTextBox.ReadOnly = true;
            regionTextBox.Size = new Size(373, 20);
            regionTextBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 356);
            label4.Name = "label4";
            label4.Size = new Size(228, 20);
            label4.TabIndex = 9;
            label4.Text = "Number of matching ingredients:";
            // 
            // matchValueBox
            // 
            matchValueBox.BackColor = SystemColors.ControlLight;
            matchValueBox.BorderStyle = BorderStyle.None;
            matchValueBox.Location = new Point(239, 356);
            matchValueBox.Name = "matchValueBox";
            matchValueBox.Size = new Size(125, 20);
            matchValueBox.TabIndex = 10;
            // 
            // recipeDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(matchValueBox);
            Controls.Add(label4);
            Controls.Add(regionTextBox);
            Controls.Add(regionLbl);
            Controls.Add(label3);
            Controls.Add(webLinkLabel);
            Controls.Add(allergenBox);
            Controls.Add(label2);
            Controls.Add(ingredientBox);
            Controls.Add(label1);
            Controls.Add(recipeNameBox);
            Name = "recipeDisplay";
            Size = new Size(510, 392);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox recipeNameBox;
        private Label label1;
        private TextBox ingredientBox;
        private Label label2;
        private TextBox allergenBox;
        private LinkLabel webLinkLabel;
        private Label label3;
        private Label regionLbl;
        private TextBox regionTextBox;
        private Label label4;
        private TextBox matchValueBox;
    }
}
