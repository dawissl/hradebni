namespace _03_Hlavicky_funkci
{
    partial class Function_01
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
            this.TxtNum1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNum2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNum3 = new System.Windows.Forms.TextBox();
            this.LblSorted = new System.Windows.Forms.Label();
            this.BtnSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNum1
            // 
            this.TxtNum1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNum1.Location = new System.Drawing.Point(102, 20);
            this.TxtNum1.Name = "TxtNum1";
            this.TxtNum1.Size = new System.Drawing.Size(123, 33);
            this.TxtNum1.TabIndex = 0;
            this.TxtNum1.TextChanged += new System.EventHandler(this.TxtNum1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "číslo 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "číslo 2";
            // 
            // TxtNum2
            // 
            this.TxtNum2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNum2.Location = new System.Drawing.Point(102, 59);
            this.TxtNum2.Name = "TxtNum2";
            this.TxtNum2.Size = new System.Drawing.Size(123, 33);
            this.TxtNum2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "číslo 3";
            // 
            // TxtNum3
            // 
            this.TxtNum3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNum3.Location = new System.Drawing.Point(102, 98);
            this.TxtNum3.Name = "TxtNum3";
            this.TxtNum3.Size = new System.Drawing.Size(123, 33);
            this.TxtNum3.TabIndex = 4;
            // 
            // LblSorted
            // 
            this.LblSorted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblSorted.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSorted.Location = new System.Drawing.Point(12, 208);
            this.LblSorted.Name = "LblSorted";
            this.LblSorted.Size = new System.Drawing.Size(302, 54);
            this.LblSorted.TabIndex = 6;
            // 
            // BtnSort
            // 
            this.BtnSort.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSort.Location = new System.Drawing.Point(102, 152);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(123, 36);
            this.BtnSort.TabIndex = 7;
            this.BtnSort.Text = "Seřadit";
            this.BtnSort.UseVisualStyleBackColor = true;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // Function_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 280);
            this.Controls.Add(this.BtnSort);
            this.Controls.Add(this.LblSorted);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNum3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNum2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNum1);
            this.Name = "Function_01";
            this.Text = "Function_01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtNum1;
        private Label label1;
        private Label label2;
        private TextBox TxtNum2;
        private Label label3;
        private TextBox TxtNum3;
        private Label LblSorted;
        private Button BtnSort;
    }
}