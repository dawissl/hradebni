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
            this.NumCount = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumCount)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtName.Location = new System.Drawing.Point(115, 17);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(175, 33);
            this.TxtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "název";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "cena";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPrice.Location = new System.Drawing.Point(115, 60);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(175, 33);
            this.TxtPrice.TabIndex = 2;
            // 
            // ComboType
            // 
            this.ComboType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboType.FormattingEnabled = true;
            this.ComboType.Items.AddRange(new object[] {
            "zboží",
            "drogerie",
            "potravina"});
            this.ComboType.Location = new System.Drawing.Point(115, 145);
            this.ComboType.Name = "ComboType";
            this.ComboType.Size = new System.Drawing.Size(175, 33);
            this.ComboType.TabIndex = 4;
            this.ComboType.SelectedIndexChanged += new System.EventHandler(this.ComboType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(38, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "typ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(-1, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "skladování";
            // 
            // TxtStoring
            // 
            this.TxtStoring.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtStoring.Location = new System.Drawing.Point(115, 232);
            this.TxtStoring.Name = "TxtStoring";
            this.TxtStoring.Size = new System.Drawing.Size(175, 33);
            this.TxtStoring.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(23, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "určeno";
            // 
            // TxtFor
            // 
            this.TxtFor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtFor.Location = new System.Drawing.Point(115, 192);
            this.TxtFor.Name = "TxtFor";
            this.TxtFor.Size = new System.Drawing.Size(175, 33);
            this.TxtFor.TabIndex = 6;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAdd.Location = new System.Drawing.Point(23, 292);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(145, 67);
            this.BtnAdd.TabIndex = 10;
            this.BtnAdd.Text = "Přidat položku";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEmpty
            // 
            this.BtnEmpty.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEmpty.Location = new System.Drawing.Point(174, 292);
            this.BtnEmpty.Name = "BtnEmpty";
            this.BtnEmpty.Size = new System.Drawing.Size(116, 67);
            this.BtnEmpty.TabIndex = 11;
            this.BtnEmpty.Text = "Vyprázdnit";
            this.BtnEmpty.UseVisualStyleBackColor = true;
            this.BtnEmpty.Click += new System.EventHandler(this.BtnEmpty_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(342, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "nákupní seznam";
            // 
            // LblShoppingList
            // 
            this.LblShoppingList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblShoppingList.Location = new System.Drawing.Point(342, 46);
            this.LblShoppingList.Name = "LblShoppingList";
            this.LblShoppingList.Size = new System.Drawing.Size(352, 379);
            this.LblShoppingList.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 30);
            this.label8.TabIndex = 14;
            this.label8.Text = "výsledná cena";
            // 
            // LblTotalPrice
            // 
            this.LblTotalPrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTotalPrice.Location = new System.Drawing.Point(151, 402);
            this.LblTotalPrice.Name = "LblTotalPrice";
            this.LblTotalPrice.Size = new System.Drawing.Size(175, 35);
            this.LblTotalPrice.TabIndex = 15;
            // 
            // NumCount
            // 
            this.NumCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumCount.Location = new System.Drawing.Point(115, 106);
            this.NumCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumCount.Name = "NumCount";
            this.NumCount.Size = new System.Drawing.Size(175, 33);
            this.NumCount.TabIndex = 16;
            this.NumCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 30);
            this.label7.TabIndex = 17;
            this.label7.Text = "množství";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NumCount);
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
            ((System.ComponentModel.ISupportInitialize)(this.NumCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtName;
        private Label label1;
        private Label label2;
        private TextBox TxtPrice;
        private ComboBox ComboType;
        private Label label3;
        private Label label4;
        private TextBox TxtStoring;
        private Label label5;
        private TextBox TxtFor;
        private Button BtnAdd;
        private Button BtnEmpty;
        private Label label6;
        private Label LblShoppingList;
        private Label label8;
        private Label LblTotalPrice;
        private NumericUpDown NumCount;
        private Label label7;
    }
}