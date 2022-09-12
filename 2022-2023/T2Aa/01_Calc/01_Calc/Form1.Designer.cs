
namespace _01_Calc
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
            this.NumA = new System.Windows.Forms.NumericUpDown();
            this.NumB = new System.Windows.Forms.NumericUpDown();
            this.LblEqual = new System.Windows.Forms.Label();
            this.LblResult = new System.Windows.Forms.Label();
            this.BtnScitani = new System.Windows.Forms.Button();
            this.BtnOdcitani = new System.Windows.Forms.Button();
            this.BtnNasobeni = new System.Windows.Forms.Button();
            this.BtnDeleni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumB)).BeginInit();
            this.SuspendLayout();
            // 
            // NumA
            // 
            this.NumA.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumA.Location = new System.Drawing.Point(78, 56);
            this.NumA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NumA.Name = "NumA";
            this.NumA.Size = new System.Drawing.Size(120, 39);
            this.NumA.TabIndex = 0;
            // 
            // NumB
            // 
            this.NumB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumB.Location = new System.Drawing.Point(230, 56);
            this.NumB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NumB.Name = "NumB";
            this.NumB.Size = new System.Drawing.Size(120, 39);
            this.NumB.TabIndex = 1;
            // 
            // LblEqual
            // 
            this.LblEqual.AutoSize = true;
            this.LblEqual.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblEqual.Location = new System.Drawing.Point(38, 184);
            this.LblEqual.Name = "LblEqual";
            this.LblEqual.Size = new System.Drawing.Size(28, 30);
            this.LblEqual.TabIndex = 2;
            this.LblEqual.Text = "=";
            // 
            // LblResult
            // 
            this.LblResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblResult.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblResult.Location = new System.Drawing.Point(72, 183);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(359, 46);
            this.LblResult.TabIndex = 3;
            // 
            // BtnScitani
            // 
            this.BtnScitani.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnScitani.Location = new System.Drawing.Point(87, 115);
            this.BtnScitani.Name = "BtnScitani";
            this.BtnScitani.Size = new System.Drawing.Size(60, 50);
            this.BtnScitani.TabIndex = 4;
            this.BtnScitani.Text = "+";
            this.BtnScitani.UseVisualStyleBackColor = true;
            this.BtnScitani.Click += new System.EventHandler(this.BtnScitani_Click);
            // 
            // BtnOdcitani
            // 
            this.BtnOdcitani.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnOdcitani.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnOdcitani.Location = new System.Drawing.Point(153, 115);
            this.BtnOdcitani.Name = "BtnOdcitani";
            this.BtnOdcitani.Size = new System.Drawing.Size(60, 50);
            this.BtnOdcitani.TabIndex = 5;
            this.BtnOdcitani.Text = "-";
            this.BtnOdcitani.UseVisualStyleBackColor = true;
            this.BtnOdcitani.Click += new System.EventHandler(this.BtnOdcitani_Click);
            // 
            // BtnNasobeni
            // 
            this.BtnNasobeni.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnNasobeni.Location = new System.Drawing.Point(219, 115);
            this.BtnNasobeni.Name = "BtnNasobeni";
            this.BtnNasobeni.Size = new System.Drawing.Size(60, 50);
            this.BtnNasobeni.TabIndex = 6;
            this.BtnNasobeni.Text = "*";
            this.BtnNasobeni.UseVisualStyleBackColor = true;
            this.BtnNasobeni.Click += new System.EventHandler(this.BtnNasobeni_Click);
            // 
            // BtnDeleni
            // 
            this.BtnDeleni.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDeleni.Location = new System.Drawing.Point(285, 115);
            this.BtnDeleni.Name = "BtnDeleni";
            this.BtnDeleni.Size = new System.Drawing.Size(60, 50);
            this.BtnDeleni.TabIndex = 7;
            this.BtnDeleni.Text = "/";
            this.BtnDeleni.UseVisualStyleBackColor = true;
            this.BtnDeleni.Click += new System.EventHandler(this.BtnDeleni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 270);
            this.Controls.Add(this.BtnDeleni);
            this.Controls.Add(this.BtnNasobeni);
            this.Controls.Add(this.BtnOdcitani);
            this.Controls.Add(this.BtnScitani);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.LblEqual);
            this.Controls.Add(this.NumB);
            this.Controls.Add(this.NumA);
            this.Name = "Form1";
            this.Text = "Dummy Calc";
            ((System.ComponentModel.ISupportInitialize)(this.NumA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumA;
        private System.Windows.Forms.NumericUpDown NumB;
        private System.Windows.Forms.Label LblEqual;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Button BtnScitani;
        private System.Windows.Forms.Button BtnOdcitani;
        private System.Windows.Forms.Button BtnNasobeni;
        private System.Windows.Forms.Button BtnDeleni;
    }
}

