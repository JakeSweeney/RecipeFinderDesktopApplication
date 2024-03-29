﻿namespace RecipeFinderPrototype
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
            SuspendLayout();
            // 
            // recipeNameBox
            // 
            recipeNameBox.BackColor = SystemColors.ControlLight;
            recipeNameBox.BorderStyle = BorderStyle.None;
            recipeNameBox.Location = new Point(3, 3);
            recipeNameBox.Name = "recipeNameBox";
            recipeNameBox.ReadOnly = true;
            recipeNameBox.Size = new Size(506, 20);
            recipeNameBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 26);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 1;
            label1.Text = "Ingredients:";
            // 
            // ingredientBox
            // 
            ingredientBox.BackColor = SystemColors.ControlLight;
            ingredientBox.BorderStyle = BorderStyle.None;
            ingredientBox.Location = new Point(5, 49);
            ingredientBox.Multiline = true;
            ingredientBox.Name = "ingredientBox";
            ingredientBox.ReadOnly = true;
            ingredientBox.Size = new Size(504, 84);
            ingredientBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 249);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 3;
            label2.Text = "Allergens:";
            label2.Visible = false;
            // 
            // allergenBox
            // 
            allergenBox.BackColor = SystemColors.ControlLight;
            allergenBox.BorderStyle = BorderStyle.None;
            allergenBox.ForeColor = Color.Red;
            allergenBox.Location = new Point(5, 272);
            allergenBox.Multiline = true;
            allergenBox.Name = "allergenBox";
            allergenBox.ReadOnly = true;
            allergenBox.Size = new Size(424, 76);
            allergenBox.TabIndex = 4;
            allergenBox.Visible = false;
            // 
            // webLinkLabel
            // 
            webLinkLabel.AutoSize = true;
            webLinkLabel.BackColor = SystemColors.ControlLight;
            webLinkLabel.Location = new Point(5, 218);
            webLinkLabel.Name = "webLinkLabel";
            webLinkLabel.Size = new Size(151, 20);
            webLinkLabel.TabIndex = 5;
            webLinkLabel.TabStop = true;
            webLinkLabel.Text = "No weblink available.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 189);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 6;
            label3.Text = "Weblink:";
            // 
            // regionLbl
            // 
            regionLbl.AutoSize = true;
            regionLbl.Location = new Point(0, 136);
            regionLbl.Name = "regionLbl";
            regionLbl.Size = new Size(56, 20);
            regionLbl.TabIndex = 7;
            regionLbl.Text = "Region";
            // 
            // regionTextBox
            // 
            regionTextBox.BackColor = SystemColors.ControlLight;
            regionTextBox.Location = new Point(5, 159);
            regionTextBox.Name = "regionTextBox";
            regionTextBox.ReadOnly = true;
            regionTextBox.Size = new Size(125, 27);
            regionTextBox.TabIndex = 8;
            // 
            // recipeDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Size = new Size(512, 372);
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
    }
}
