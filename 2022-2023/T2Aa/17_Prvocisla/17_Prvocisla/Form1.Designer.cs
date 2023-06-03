namespace _17_Prvocisla
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
            this.BtnGetPrimes = new System.Windows.Forms.Button();
            this.LblPrimes = new System.Windows.Forms.Label();
            this.NumLeft = new System.Windows.Forms.NumericUpDown();
            this.NumRight = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRight)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGetPrimes
            // 
            this.BtnGetPrimes.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGetPrimes.Location = new System.Drawing.Point(75, 61);
            this.BtnGetPrimes.Name = "BtnGetPrimes";
            this.BtnGetPrimes.Size = new System.Drawing.Size(249, 60);
            this.BtnGetPrimes.TabIndex = 0;
            this.BtnGetPrimes.Text = "Vypiš prvočísla";
            this.BtnGetPrimes.UseVisualStyleBackColor = true;
            this.BtnGetPrimes.Click += new System.EventHandler(this.BtnGetPrimes_Click);
            // 
            // LblPrimes
            // 
            this.LblPrimes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblPrimes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPrimes.Location = new System.Drawing.Point(16, 141);
            this.LblPrimes.Name = "LblPrimes";
            this.LblPrimes.Size = new System.Drawing.Size(375, 82);
            this.LblPrimes.TabIndex = 1;
            this.LblPrimes.Click += new System.EventHandler(this.LblPrimes_Click);
            // 
            // NumLeft
            // 
            this.NumLeft.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumLeft.Location = new System.Drawing.Point(123, 20);
            this.NumLeft.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumLeft.Name = "NumLeft";
            this.NumLeft.Size = new System.Drawing.Size(62, 35);
            this.NumLeft.TabIndex = 2;
            // 
            // NumRight
            // 
            this.NumRight.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumRight.Location = new System.Drawing.Point(191, 20);
            this.NumRight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumRight.Name = "NumRight";
            this.NumRight.Size = new System.Drawing.Size(68, 35);
            this.NumRight.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 258);
            this.Controls.Add(this.NumRight);
            this.Controls.Add(this.NumLeft);
            this.Controls.Add(this.LblPrimes);
            this.Controls.Add(this.BtnGetPrimes);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnGetPrimes;
        private Label LblPrimes;
        private NumericUpDown NumLeft;
        private NumericUpDown NumRight;
    }
}