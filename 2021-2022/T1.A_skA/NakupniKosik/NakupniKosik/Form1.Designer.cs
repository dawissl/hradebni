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
            this.label3 = new System.Windows.Forms.Label();
            this.TxtStore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtUsedBy = new System.Windows.Forms.TextBox();
            this.ComboType = new System.Windows.Forms.ComboBox();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.LblShop = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtName.Location = new System.Drawing.Point(148, 37);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(156, 39);
            this.TxtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(62, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Název";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(74, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cena";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPrice.Location = new System.Drawing.Point(148, 82);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(156, 39);
            this.TxtPrice.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Skladování";
            // 
            // TxtStore
            // 
            this.TxtStore.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtStore.Location = new System.Drawing.Point(148, 127);
            this.TxtStore.Name = "TxtStore";
            this.TxtStore.Size = new System.Drawing.Size(156, 39);
            this.TxtStore.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(59, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Určení";
            // 
            // TxtUsedBy
            // 
            this.TxtUsedBy.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtUsedBy.Location = new System.Drawing.Point(148, 172);
            this.TxtUsedBy.Name = "TxtUsedBy";
            this.TxtUsedBy.Size = new System.Drawing.Size(156, 39);
            this.TxtUsedBy.TabIndex = 6;
            // 
            // ComboType
            // 
            this.ComboType.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboType.FormattingEnabled = true;
            this.ComboType.Items.AddRange(new object[] {
            "Zboží",
            "Potravina",
            "Drogerie"});
            this.ComboType.Location = new System.Drawing.Point(33, 221);
            this.ComboType.Name = "ComboType";
            this.ComboType.Size = new System.Drawing.Size(271, 40);
            this.ComboType.TabIndex = 8;
            // 
            // BtnInsert
            // 
            this.BtnInsert.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnInsert.Location = new System.Drawing.Point(33, 276);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(271, 52);
            this.BtnInsert.TabIndex = 9;
            this.BtnInsert.Text = "Vložit do košíku";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // LblShop
            // 
            this.LblShop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblShop.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblShop.Location = new System.Drawing.Point(336, 22);
            this.LblShop.Name = "LblShop";
            this.LblShop.Size = new System.Drawing.Size(242, 369);
            this.LblShop.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(249, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cena";
            // 
            // LblPrice
            // 
            this.LblPrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblPrice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPrice.Location = new System.Drawing.Point(336, 407);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(242, 37);
            this.LblPrice.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblShop);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.ComboType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtUsedBy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtStore);
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

        private TextBox TxtName;
        private Label label1;
        private Label label2;
        private TextBox TxtPrice;
        private Label label3;
        private TextBox TxtStore;
        private Label label4;
        private TextBox TxtUsedBy;
        private ComboBox ComboType;
        private Button BtnInsert;
        private Label LblShop;
        private Label label5;
        private Label LblPrice;
    }
}