
namespace NumberAnalyzer
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
            this.Number = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.LblDividedBy2 = new System.Windows.Forms.Label();
            this.LblDividedBy6 = new System.Windows.Forms.Label();
            this.LblDividedBy3 = new System.Windows.Forms.Label();
            this.LblDividedBy9 = new System.Windows.Forms.Label();
            this.LblDividedBy7 = new System.Windows.Forms.Label();
            this.LblDividedBy8 = new System.Windows.Forms.Label();
            this.LblDividedBy4 = new System.Windows.Forms.Label();
            this.LblDividedBy5 = new System.Windows.Forms.Label();
            this.LblPrime = new System.Windows.Forms.Label();
            this.LblPerfect = new System.Windows.Forms.Label();
            this.LblEven = new System.Windows.Forms.Label();
            this.LblOdd = new System.Windows.Forms.Label();
            this.LblPositive = new System.Windows.Forms.Label();
            this.LblNegative = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Number)).BeginInit();
            this.SuspendLayout();
            // 
            // Number
            // 
            this.Number.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Number.Location = new System.Drawing.Point(12, 12);
            this.Number.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.Number.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(123, 29);
            this.Number.TabIndex = 0;
            this.Number.ValueChanged += new System.EventHandler(this.Number_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(156, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Divided by";
            // 
            // LblDividedBy2
            // 
            this.LblDividedBy2.AutoSize = true;
            this.LblDividedBy2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDividedBy2.Location = new System.Drawing.Point(273, 18);
            this.LblDividedBy2.Name = "LblDividedBy2";
            this.LblDividedBy2.Size = new System.Drawing.Size(19, 21);
            this.LblDividedBy2.TabIndex = 2;
            this.LblDividedBy2.Text = "2";
            // 
            // LblDividedBy6
            // 
            this.LblDividedBy6.AutoSize = true;
            this.LblDividedBy6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDividedBy6.Location = new System.Drawing.Point(373, 18);
            this.LblDividedBy6.Name = "LblDividedBy6";
            this.LblDividedBy6.Size = new System.Drawing.Size(19, 21);
            this.LblDividedBy6.TabIndex = 3;
            this.LblDividedBy6.Text = "6";
            // 
            // LblDividedBy3
            // 
            this.LblDividedBy3.AutoSize = true;
            this.LblDividedBy3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDividedBy3.Location = new System.Drawing.Point(298, 18);
            this.LblDividedBy3.Name = "LblDividedBy3";
            this.LblDividedBy3.Size = new System.Drawing.Size(19, 21);
            this.LblDividedBy3.TabIndex = 4;
            this.LblDividedBy3.Text = "3";
            // 
            // LblDividedBy9
            // 
            this.LblDividedBy9.AutoSize = true;
            this.LblDividedBy9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDividedBy9.Location = new System.Drawing.Point(448, 18);
            this.LblDividedBy9.Name = "LblDividedBy9";
            this.LblDividedBy9.Size = new System.Drawing.Size(19, 21);
            this.LblDividedBy9.TabIndex = 5;
            this.LblDividedBy9.Text = "9";
            // 
            // LblDividedBy7
            // 
            this.LblDividedBy7.AutoSize = true;
            this.LblDividedBy7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDividedBy7.Location = new System.Drawing.Point(398, 18);
            this.LblDividedBy7.Name = "LblDividedBy7";
            this.LblDividedBy7.Size = new System.Drawing.Size(19, 21);
            this.LblDividedBy7.TabIndex = 6;
            this.LblDividedBy7.Text = "7";
            // 
            // LblDividedBy8
            // 
            this.LblDividedBy8.AutoSize = true;
            this.LblDividedBy8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDividedBy8.Location = new System.Drawing.Point(423, 18);
            this.LblDividedBy8.Name = "LblDividedBy8";
            this.LblDividedBy8.Size = new System.Drawing.Size(19, 21);
            this.LblDividedBy8.TabIndex = 7;
            this.LblDividedBy8.Text = "8";
            // 
            // LblDividedBy4
            // 
            this.LblDividedBy4.AutoSize = true;
            this.LblDividedBy4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDividedBy4.Location = new System.Drawing.Point(323, 18);
            this.LblDividedBy4.Name = "LblDividedBy4";
            this.LblDividedBy4.Size = new System.Drawing.Size(19, 21);
            this.LblDividedBy4.TabIndex = 8;
            this.LblDividedBy4.Text = "4";
            // 
            // LblDividedBy5
            // 
            this.LblDividedBy5.AutoSize = true;
            this.LblDividedBy5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDividedBy5.Location = new System.Drawing.Point(348, 18);
            this.LblDividedBy5.Name = "LblDividedBy5";
            this.LblDividedBy5.Size = new System.Drawing.Size(19, 21);
            this.LblDividedBy5.TabIndex = 9;
            this.LblDividedBy5.Text = "5";
            // 
            // LblPrime
            // 
            this.LblPrime.AutoSize = true;
            this.LblPrime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPrime.Location = new System.Drawing.Point(156, 41);
            this.LblPrime.Name = "LblPrime";
            this.LblPrime.Size = new System.Drawing.Size(144, 30);
            this.LblPrime.TabIndex = 11;
            this.LblPrime.Text = "Prime number";
            // 
            // LblPerfect
            // 
            this.LblPerfect.AutoSize = true;
            this.LblPerfect.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPerfect.Location = new System.Drawing.Point(156, 71);
            this.LblPerfect.Name = "LblPerfect";
            this.LblPerfect.Size = new System.Drawing.Size(155, 30);
            this.LblPerfect.TabIndex = 12;
            this.LblPerfect.Text = "Perfect number";
            // 
            // LblEven
            // 
            this.LblEven.AutoSize = true;
            this.LblEven.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblEven.Location = new System.Drawing.Point(156, 101);
            this.LblEven.Name = "LblEven";
            this.LblEven.Size = new System.Drawing.Size(57, 30);
            this.LblEven.TabIndex = 13;
            this.LblEven.Text = "Even";
            // 
            // LblOdd
            // 
            this.LblOdd.AutoSize = true;
            this.LblOdd.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblOdd.Location = new System.Drawing.Point(214, 101);
            this.LblOdd.Name = "LblOdd";
            this.LblOdd.Size = new System.Drawing.Size(53, 30);
            this.LblOdd.TabIndex = 14;
            this.LblOdd.Text = "Odd";
            // 
            // LblPositive
            // 
            this.LblPositive.AutoSize = true;
            this.LblPositive.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPositive.Location = new System.Drawing.Point(273, 101);
            this.LblPositive.Name = "LblPositive";
            this.LblPositive.Size = new System.Drawing.Size(83, 30);
            this.LblPositive.TabIndex = 15;
            this.LblPositive.Text = "Positive";
            // 
            // LblNegative
            // 
            this.LblNegative.AutoSize = true;
            this.LblNegative.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNegative.Location = new System.Drawing.Point(362, 101);
            this.LblNegative.Name = "LblNegative";
            this.LblNegative.Size = new System.Drawing.Size(96, 30);
            this.LblNegative.TabIndex = 16;
            this.LblNegative.Text = "Negative";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 148);
            this.Controls.Add(this.LblNegative);
            this.Controls.Add(this.LblPositive);
            this.Controls.Add(this.LblOdd);
            this.Controls.Add(this.LblEven);
            this.Controls.Add(this.LblPerfect);
            this.Controls.Add(this.LblPrime);
            this.Controls.Add(this.LblDividedBy5);
            this.Controls.Add(this.LblDividedBy4);
            this.Controls.Add(this.LblDividedBy8);
            this.Controls.Add(this.LblDividedBy7);
            this.Controls.Add(this.LblDividedBy9);
            this.Controls.Add(this.LblDividedBy3);
            this.Controls.Add(this.LblDividedBy6);
            this.Controls.Add(this.LblDividedBy2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Number);
            this.Name = "Form1";
            this.Text = "Number Analyzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDividedBy2;
        private System.Windows.Forms.Label LblDividedBy6;
        private System.Windows.Forms.Label LblDividedBy3;
        private System.Windows.Forms.Label LblDividedBy9;
        private System.Windows.Forms.Label LblDividedBy7;
        private System.Windows.Forms.Label LblDividedBy8;
        private System.Windows.Forms.Label LblDividedBy4;
        private System.Windows.Forms.Label LblDividedBy5;
        private System.Windows.Forms.Label LblPrime;
        private System.Windows.Forms.Label LblPerfect;
        private System.Windows.Forms.Label LblEven;
        private System.Windows.Forms.Label LblOdd;
        private System.Windows.Forms.Label LblPositive;
        private System.Windows.Forms.Label LblNegative;
    }
}

