namespace ListBox
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListBoxItems = new System.Windows.Forms.ListBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ListBoxSubs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ListBoxItems
            // 
            this.ListBoxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListBoxItems.FormattingEnabled = true;
            this.ListBoxItems.ItemHeight = 20;
            this.ListBoxItems.Location = new System.Drawing.Point(278, 77);
            this.ListBoxItems.Name = "ListBoxItems";
            this.ListBoxItems.Size = new System.Drawing.Size(251, 284);
            this.ListBoxItems.TabIndex = 0;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(60, 205);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(132, 41);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(60, 77);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(141, 20);
            this.TxtName.TabIndex = 2;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(60, 114);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(141, 20);
            this.TxtSurname.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(82, 156);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Subscription";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ListBoxSubs
            // 
            this.ListBoxSubs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListBoxSubs.FormattingEnabled = true;
            this.ListBoxSubs.ItemHeight = 20;
            this.ListBoxSubs.Location = new System.Drawing.Point(537, 77);
            this.ListBoxSubs.Name = "ListBoxSubs";
            this.ListBoxSubs.Size = new System.Drawing.Size(251, 284);
            this.ListBoxSubs.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListBoxSubs);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.ListBoxItems);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxItems;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox ListBoxSubs;
    }
}

