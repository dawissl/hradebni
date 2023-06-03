namespace _18_Sklad
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
            this.LblSklad = new System.Windows.Forms.Label();
            this.ComboItem = new System.Windows.Forms.ComboBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtCount = new System.Windows.Forms.TextBox();
            this.TxtUnit = new System.Windows.Forms.TextBox();
            this.TxtExpiration = new System.Windows.Forms.TextBox();
            this.TxtRestriction = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnRestore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblSklad
            // 
            this.LblSklad.BackColor = System.Drawing.SystemColors.Control;
            this.LblSklad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblSklad.Location = new System.Drawing.Point(368, 26);
            this.LblSklad.Name = "LblSklad";
            this.LblSklad.Size = new System.Drawing.Size(283, 384);
            this.LblSklad.TabIndex = 0;
            // 
            // ComboItem
            // 
            this.ComboItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboItem.FormattingEnabled = true;
            this.ComboItem.Items.AddRange(new object[] {
            "ZBOŽÍ",
            "POTRAVINA",
            "DROGERIE"});
            this.ComboItem.Location = new System.Drawing.Point(45, 26);
            this.ComboItem.Name = "ComboItem";
            this.ComboItem.Size = new System.Drawing.Size(283, 38);
            this.ComboItem.TabIndex = 1;
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtName.Location = new System.Drawing.Point(45, 83);
            this.TxtName.Name = "TxtName";
            this.TxtName.PlaceholderText = "název položky";
            this.TxtName.Size = new System.Drawing.Size(283, 33);
            this.TxtName.TabIndex = 2;
            // 
            // TxtCount
            // 
            this.TxtCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCount.Location = new System.Drawing.Point(45, 132);
            this.TxtCount.Name = "TxtCount";
            this.TxtCount.PlaceholderText = "počet";
            this.TxtCount.Size = new System.Drawing.Size(283, 33);
            this.TxtCount.TabIndex = 3;
            // 
            // TxtUnit
            // 
            this.TxtUnit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtUnit.Location = new System.Drawing.Point(45, 171);
            this.TxtUnit.Name = "TxtUnit";
            this.TxtUnit.PlaceholderText = "jednotky";
            this.TxtUnit.Size = new System.Drawing.Size(283, 33);
            this.TxtUnit.TabIndex = 4;
            // 
            // TxtExpiration
            // 
            this.TxtExpiration.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtExpiration.Location = new System.Drawing.Point(45, 248);
            this.TxtExpiration.Name = "TxtExpiration";
            this.TxtExpiration.PlaceholderText = "trvanlivost";
            this.TxtExpiration.Size = new System.Drawing.Size(283, 33);
            this.TxtExpiration.TabIndex = 5;
            // 
            // TxtRestriction
            // 
            this.TxtRestriction.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtRestriction.Location = new System.Drawing.Point(45, 287);
            this.TxtRestriction.Name = "TxtRestriction";
            this.TxtRestriction.PlaceholderText = "omezení";
            this.TxtRestriction.Size = new System.Drawing.Size(283, 33);
            this.TxtRestriction.TabIndex = 6;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAdd.Location = new System.Drawing.Point(45, 348);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(131, 62);
            this.BtnAdd.TabIndex = 7;
            this.BtnAdd.Text = "přidat";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnRestore
            // 
            this.BtnRestore.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRestore.Location = new System.Drawing.Point(182, 348);
            this.BtnRestore.Name = "BtnRestore";
            this.BtnRestore.Size = new System.Drawing.Size(146, 62);
            this.BtnRestore.TabIndex = 8;
            this.BtnRestore.Text = "odebrat";
            this.BtnRestore.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.BtnRestore);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtRestriction);
            this.Controls.Add(this.TxtExpiration);
            this.Controls.Add(this.TxtUnit);
            this.Controls.Add(this.TxtCount);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.ComboItem);
            this.Controls.Add(this.LblSklad);
            this.Name = "Form1";
            this.Text = "Sklad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblSklad;
        private ComboBox ComboItem;
        private TextBox TxtName;
        private TextBox TxtCount;
        private TextBox TxtUnit;
        private TextBox TxtExpiration;
        private TextBox TxtRestriction;
        private Button BtnAdd;
        private Button BtnRestore;
    }
}