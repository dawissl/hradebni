
namespace _02_GenerovanePole
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
            this.NumericArraySize = new System.Windows.Forms.NumericUpDown();
            this.BtnGenerateArray = new System.Windows.Forms.Button();
            this.BtnSum = new System.Windows.Forms.Button();
            this.BtnMul = new System.Windows.Forms.Button();
            this.BtnMax = new System.Windows.Forms.Button();
            this.BtnMin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblArray = new System.Windows.Forms.Label();
            this.LblOut = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericArraySize)).BeginInit();
            this.SuspendLayout();
            // 
            // NumericArraySize
            // 
            this.NumericArraySize.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumericArraySize.Location = new System.Drawing.Point(43, 29);
            this.NumericArraySize.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericArraySize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericArraySize.Name = "NumericArraySize";
            this.NumericArraySize.Size = new System.Drawing.Size(120, 35);
            this.NumericArraySize.TabIndex = 0;
            this.NumericArraySize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BtnGenerateArray
            // 
            this.BtnGenerateArray.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGenerateArray.Location = new System.Drawing.Point(227, 12);
            this.BtnGenerateArray.Name = "BtnGenerateArray";
            this.BtnGenerateArray.Size = new System.Drawing.Size(170, 68);
            this.BtnGenerateArray.TabIndex = 1;
            this.BtnGenerateArray.Text = "Generuj pole";
            this.BtnGenerateArray.UseVisualStyleBackColor = true;
            this.BtnGenerateArray.Click += new System.EventHandler(this.BtnGenerateArray_Click);
            // 
            // BtnSum
            // 
            this.BtnSum.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSum.Location = new System.Drawing.Point(43, 194);
            this.BtnSum.Name = "BtnSum";
            this.BtnSum.Size = new System.Drawing.Size(104, 68);
            this.BtnSum.TabIndex = 2;
            this.BtnSum.Text = "součet";
            this.BtnSum.UseVisualStyleBackColor = true;
            this.BtnSum.Click += new System.EventHandler(this.BtnSum_Click);
            // 
            // BtnMul
            // 
            this.BtnMul.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMul.Location = new System.Drawing.Point(170, 194);
            this.BtnMul.Name = "BtnMul";
            this.BtnMul.Size = new System.Drawing.Size(104, 68);
            this.BtnMul.TabIndex = 3;
            this.BtnMul.Text = "součin";
            this.BtnMul.UseVisualStyleBackColor = true;
            this.BtnMul.Click += new System.EventHandler(this.BtnMul_Click);
            // 
            // BtnMax
            // 
            this.BtnMax.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMax.Location = new System.Drawing.Point(310, 194);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(122, 68);
            this.BtnMax.TabIndex = 4;
            this.BtnMax.Text = "maximum";
            this.BtnMax.UseVisualStyleBackColor = true;
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // BtnMin
            // 
            this.BtnMin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMin.Location = new System.Drawing.Point(448, 194);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(122, 68);
            this.BtnMin.TabIndex = 5;
            this.BtnMin.Text = "minimum";
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pole: ";
            // 
            // LblArray
            // 
            this.LblArray.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblArray.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblArray.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblArray.Location = new System.Drawing.Point(122, 113);
            this.LblArray.Name = "LblArray";
            this.LblArray.Size = new System.Drawing.Size(540, 40);
            this.LblArray.TabIndex = 7;
            // 
            // LblOut
            // 
            this.LblOut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblOut.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblOut.Location = new System.Drawing.Point(122, 322);
            this.LblOut.Name = "LblOut";
            this.LblOut.Size = new System.Drawing.Size(540, 40);
            this.LblOut.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(35, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Výstup:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblOut);
            this.Controls.Add(this.LblArray);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnMin);
            this.Controls.Add(this.BtnMax);
            this.Controls.Add(this.BtnMul);
            this.Controls.Add(this.BtnSum);
            this.Controls.Add(this.BtnGenerateArray);
            this.Controls.Add(this.NumericArraySize);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumericArraySize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumericArraySize;
        private System.Windows.Forms.Button BtnGenerateArray;
        private System.Windows.Forms.Button BtnSum;
        private System.Windows.Forms.Button BtnMul;
        private System.Windows.Forms.Button BtnMax;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblArray;
        private System.Windows.Forms.Label LblOut;
        private System.Windows.Forms.Label label4;
    }
}

