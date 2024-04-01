namespace RecipesUDPClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkTomato = new CheckBox();
            checkOnion = new CheckBox();
            checkCucumber = new CheckBox();
            checkPotato = new CheckBox();
            checkFlour = new CheckBox();
            checkSugar = new CheckBox();
            checkSalt = new CheckBox();
            checCocoa = new CheckBox();
            checkSourCream = new CheckBox();
            buttonFind = new Button();
            gridRecipes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridRecipes).BeginInit();
            SuspendLayout();
            // 
            // checkTomato
            // 
            checkTomato.AutoSize = true;
            checkTomato.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkTomato.Location = new Point(9, 324);
            checkTomato.Name = "checkTomato";
            checkTomato.Size = new Size(101, 34);
            checkTomato.TabIndex = 0;
            checkTomato.Text = "Tomato";
            checkTomato.UseVisualStyleBackColor = true;
            checkTomato.CheckedChanged += check_CheckedChanged;
            // 
            // checkOnion
            // 
            checkOnion.AutoSize = true;
            checkOnion.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkOnion.Location = new Point(145, 324);
            checkOnion.Name = "checkOnion";
            checkOnion.Size = new Size(89, 34);
            checkOnion.TabIndex = 1;
            checkOnion.Text = "Onion";
            checkOnion.UseVisualStyleBackColor = true;
            checkOnion.CheckedChanged += check_CheckedChanged;
            // 
            // checkCucumber
            // 
            checkCucumber.AutoSize = true;
            checkCucumber.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkCucumber.Location = new Point(281, 324);
            checkCucumber.Name = "checkCucumber";
            checkCucumber.Size = new Size(127, 34);
            checkCucumber.TabIndex = 2;
            checkCucumber.Text = "Cucumber";
            checkCucumber.UseVisualStyleBackColor = true;
            checkCucumber.CheckedChanged += check_CheckedChanged;
            // 
            // checkPotato
            // 
            checkPotato.AutoSize = true;
            checkPotato.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkPotato.Location = new Point(9, 364);
            checkPotato.Name = "checkPotato";
            checkPotato.Size = new Size(92, 34);
            checkPotato.TabIndex = 3;
            checkPotato.Text = "Potato";
            checkPotato.UseVisualStyleBackColor = true;
            checkPotato.CheckedChanged += check_CheckedChanged;
            // 
            // checkFlour
            // 
            checkFlour.AutoSize = true;
            checkFlour.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkFlour.Location = new Point(145, 364);
            checkFlour.Name = "checkFlour";
            checkFlour.Size = new Size(78, 34);
            checkFlour.TabIndex = 4;
            checkFlour.Text = "Flour";
            checkFlour.UseVisualStyleBackColor = true;
            checkFlour.CheckedChanged += check_CheckedChanged;
            // 
            // checkSugar
            // 
            checkSugar.AutoSize = true;
            checkSugar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkSugar.Location = new Point(281, 364);
            checkSugar.Name = "checkSugar";
            checkSugar.Size = new Size(85, 34);
            checkSugar.TabIndex = 5;
            checkSugar.Text = "Sugar";
            checkSugar.UseVisualStyleBackColor = true;
            checkSugar.CheckedChanged += check_CheckedChanged;
            // 
            // checkSalt
            // 
            checkSalt.AutoSize = true;
            checkSalt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkSalt.Location = new Point(9, 404);
            checkSalt.Name = "checkSalt";
            checkSalt.Size = new Size(66, 34);
            checkSalt.TabIndex = 6;
            checkSalt.Text = "Salt";
            checkSalt.UseVisualStyleBackColor = true;
            checkSalt.CheckedChanged += check_CheckedChanged;
            // 
            // checCocoa
            // 
            checCocoa.AutoSize = true;
            checCocoa.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            checCocoa.Location = new Point(145, 404);
            checCocoa.Name = "checCocoa";
            checCocoa.Size = new Size(90, 34);
            checCocoa.TabIndex = 7;
            checCocoa.Text = "Cocoa";
            checCocoa.UseVisualStyleBackColor = true;
            checCocoa.CheckedChanged += check_CheckedChanged;
            // 
            // checkSourCream
            // 
            checkSourCream.AutoSize = true;
            checkSourCream.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkSourCream.Location = new Point(281, 404);
            checkSourCream.Name = "checkSourCream";
            checkSourCream.Size = new Size(137, 34);
            checkSourCream.TabIndex = 8;
            checkSourCream.Text = "Sour cream";
            checkSourCream.UseVisualStyleBackColor = true;
            checkSourCream.CheckedChanged += check_CheckedChanged;
            // 
            // buttonFind
            // 
            buttonFind.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonFind.Location = new Point(428, 357);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(132, 46);
            buttonFind.TabIndex = 9;
            buttonFind.Text = "Find";
            buttonFind.UseVisualStyleBackColor = true;
            buttonFind.Click += buttonFind_Click;
            // 
            // gridRecipes
            // 
            gridRecipes.AllowUserToAddRows = false;
            gridRecipes.AllowUserToDeleteRows = false;
            gridRecipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridRecipes.Location = new Point(9, 12);
            gridRecipes.Name = "gridRecipes";
            gridRecipes.ReadOnly = true;
            gridRecipes.RowTemplate.Height = 25;
            gridRecipes.Size = new Size(551, 306);
            gridRecipes.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 450);
            Controls.Add(gridRecipes);
            Controls.Add(buttonFind);
            Controls.Add(checkSourCream);
            Controls.Add(checCocoa);
            Controls.Add(checkSalt);
            Controls.Add(checkSugar);
            Controls.Add(checkFlour);
            Controls.Add(checkPotato);
            Controls.Add(checkCucumber);
            Controls.Add(checkOnion);
            Controls.Add(checkTomato);
            Name = "Form1";
            Text = "Client";
            ((System.ComponentModel.ISupportInitialize)gridRecipes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkTomato;
        private CheckBox checkOnion;
        private CheckBox checkCucumber;
        private CheckBox checkPotato;
        private CheckBox checkFlour;
        private CheckBox checkSugar;
        private CheckBox checkSalt;
        private CheckBox checCocoa;
        private CheckBox checkSourCream;
        private Button buttonFind;
        private DataGridView gridRecipes;
    }
}
