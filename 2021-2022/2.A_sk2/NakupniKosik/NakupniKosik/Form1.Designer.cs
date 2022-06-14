namespace NakupniKosik
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.ComboType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtStoring = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtFor = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEmpty = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.LblShoppingList = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblTotalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtName.Location = new System.Drawing.Point(210, 27);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(175, 44);
            this.TxtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(87, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "název";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(102, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "cena";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPrice.Location = new System.Drawing.Point(210, 70);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(175, 44);
            this.TxtPrice.TabIndex = 2;
            // 
            // ComboType
            // 
            this.ComboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboType.FormattingEnabled = true;
            this.ComboType.Items.AddRange(new object[] {
            "zboží",
            "drogerie",
            "potravina"});
            this.ComboType.Location = new System.Drawing.Point(210, 144);
            this.ComboType.Name = "ComboType";
            this.ComboType.Size = new System.Drawing.Size(175, 45);
            this.ComboType.TabIndex = 4;
            this.ComboType.SelectedIndexChanged += new System.EventHandler(this.ComboType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(114, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "typ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 37);
            this.label4.TabIndex = 9;
            this.label4.Text = "skladování";
            // 
            // TxtStoring
            // 
            this.TxtStoring.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtStoring.Location = new System.Drawing.Point(210, 231);
            this.TxtStoring.Name = "TxtStoring";
            this.TxtStoring.Size = new System.Drawing.Size(175, 44);
            this.TxtStoring.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(52, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 37);
            this.label5.TabIndex = 7;
            this.label5.Text = "určeno";
            // 
            // TxtFor
            // 
            this.TxtFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtFor.Location = new System.Drawing.Point(210, 191);
            this.TxtFor.Name = "TxtFor";
            this.TxtFor.Size = new System.Drawing.Size(175, 44);
            this.TxtFor.TabIndex = 6;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAdd.Location = new System.Drawing.Point(23, 292);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(205, 84);
            this.BtnAdd.TabIndex = 10;
            this.BtnAdd.Text = "Přidat položku";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEmpty
            // 
            this.BtnEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEmpty.Location = new System.Drawing.Point(234, 292);
            this.BtnEmpty.Name = "BtnEmpty";
            this.BtnEmpty.Size = new System.Drawing.Size(180, 84);
            this.BtnEmpty.TabIndex = 11;
            this.BtnEmpty.Text = "Vyprázdnit";
            this.BtnEmpty.UseVisualStyleBackColor = true;
            this.BtnEmpty.Click += new System.EventHandler(this.BtnEmpty_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(524, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 37);
            this.label6.TabIndex = 12;
            this.label6.Text = "nákupní seznam";
            // 
            // LblShoppingList
            // 
            this.LblShoppingList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblShoppingList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblShoppingList.Location = new System.Drawing.Point(524, 60);
            this.LblShoppingList.Name = "LblShoppingList";
            this.LblShoppingList.Size = new System.Drawing.Size(352, 379);
            this.LblShoppingList.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 37);
            this.label8.TabIndex = 14;
            this.label8.Text = "výsledná cena";
            // 
            // LblTotalPrice
            // 
            this.LblTotalPrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTotalPrice.Location = new System.Drawing.Point(234, 404);
            this.LblTotalPrice.Name = "LblTotalPrice";
            this.LblTotalPrice.Size = new System.Drawing.Size(249, 35);
            this.LblTotalPrice.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 539);
            this.Controls.Add(this.LblTotalPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblShoppingList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnEmpty);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtStoring);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtFor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.ComboBox ComboType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtStoring;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtFor;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEmpty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblShoppingList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblTotalPrice;
    }
}