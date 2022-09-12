namespace _01_GenerovanePole
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
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.LblGeneratedArray = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnMul = new System.Windows.Forms.Button();
            this.BtnMax = new System.Windows.Forms.Button();
            this.BtnMin = new System.Windows.Forms.Button();
            this.LblResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericArraySize)).BeginInit();
            this.SuspendLayout();
            // 
            // NumericArraySize
            // 
            this.NumericArraySize.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumericArraySize.Location = new System.Drawing.Point(218, 43);
            this.NumericArraySize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericArraySize.Name = "NumericArraySize";
            this.NumericArraySize.Size = new System.Drawing.Size(120, 33);
            this.NumericArraySize.TabIndex = 0;
            this.NumericArraySize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGenerate.Location = new System.Drawing.Point(373, 33);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(201, 47);
            this.BtnGenerate.TabIndex = 1;
            this.BtnGenerate.Text = "Generuj pole";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // LblGeneratedArray
            // 
            this.LblGeneratedArray.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblGeneratedArray.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblGeneratedArray.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblGeneratedArray.Location = new System.Drawing.Point(49, 106);
            this.LblGeneratedArray.Name = "LblGeneratedArray";
            this.LblGeneratedArray.Size = new System.Drawing.Size(686, 43);
            this.LblGeneratedArray.TabIndex = 2;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAdd.Location = new System.Drawing.Point(34, 179);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(103, 47);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnMul
            // 
            this.BtnMul.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMul.Location = new System.Drawing.Point(143, 179);
            this.BtnMul.Name = "BtnMul";
            this.BtnMul.Size = new System.Drawing.Size(103, 47);
            this.BtnMul.TabIndex = 4;
            this.BtnMul.Text = "*";
            this.BtnMul.UseVisualStyleBackColor = true;
            this.BtnMul.Click += new System.EventHandler(this.BtnMul_Click);
            // 
            // BtnMax
            // 
            this.BtnMax.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMax.Location = new System.Drawing.Point(252, 179);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(103, 47);
            this.BtnMax.TabIndex = 5;
            this.BtnMax.Text = "MAX";
            this.BtnMax.UseVisualStyleBackColor = true;
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // BtnMin
            // 
            this.BtnMin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMin.Location = new System.Drawing.Point(361, 179);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(103, 47);
            this.BtnMin.TabIndex = 6;
            this.BtnMin.Text = "MIN";
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // LblResult
            // 
            this.LblResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblResult.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblResult.Location = new System.Drawing.Point(108, 261);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(627, 43);
            this.LblResult.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(49, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Velikost pole:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 342);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.BtnMin);
            this.Controls.Add(this.BtnMax);
            this.Controls.Add(this.BtnMul);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LblGeneratedArray);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.NumericArraySize);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumericArraySize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown NumericArraySize;
        private Button BtnGenerate;
        private Label LblGeneratedArray;
        private Button BtnAdd;
        private Button BtnMul;
        private Button BtnMax;
        private Button BtnMin;
        private Label LblResult;
        private Label label2;
        private Label label1;
    }
}