namespace _02_Statisticka_analyza
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
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.LblData = new System.Windows.Forms.Label();
            this.BtnAnalyze = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblMin = new System.Windows.Forms.Label();
            this.LblMax = new System.Windows.Forms.Label();
            this.LblAvg = new System.Windows.Forms.Label();
            this.LblModus = new System.Windows.Forms.Label();
            this.LblMedian = new System.Windows.Forms.Label();
            this.Lbl1Q = new System.Windows.Forms.Label();
            this.Lbl3Q = new System.Windows.Forms.Label();
            this.NumDataSize = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumDataSize)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGenerate.Location = new System.Drawing.Point(387, 12);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(221, 50);
            this.BtnGenerate.TabIndex = 0;
            this.BtnGenerate.Text = "Generuj data";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // LblData
            // 
            this.LblData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblData.Location = new System.Drawing.Point(21, 116);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(755, 29);
            this.LblData.TabIndex = 1;
            // 
            // BtnAnalyze
            // 
            this.BtnAnalyze.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAnalyze.Location = new System.Drawing.Point(293, 157);
            this.BtnAnalyze.Name = "BtnAnalyze";
            this.BtnAnalyze.Size = new System.Drawing.Size(221, 50);
            this.BtnAnalyze.TabIndex = 2;
            this.BtnAnalyze.Text = "Analýza nad daty";
            this.BtnAnalyze.UseVisualStyleBackColor = true;
            this.BtnAnalyze.Click += new System.EventHandler(this.BtnAnalyze_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Minimum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(140, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Maximum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(140, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Medián";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(259, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "Průměr";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(259, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "1. kvartil";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(378, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 30);
            this.label7.TabIndex = 9;
            this.label7.Text = "3. kvartil";
            // 
            // LblMin
            // 
            this.LblMin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LblMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblMin.Location = new System.Drawing.Point(25, 278);
            this.LblMin.Name = "LblMin";
            this.LblMin.Size = new System.Drawing.Size(100, 23);
            this.LblMin.TabIndex = 10;
            this.LblMin.Text = "-";
            // 
            // LblMax
            // 
            this.LblMax.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LblMax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMax.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblMax.Location = new System.Drawing.Point(140, 278);
            this.LblMax.Name = "LblMax";
            this.LblMax.Size = new System.Drawing.Size(100, 23);
            this.LblMax.TabIndex = 11;
            this.LblMax.Text = "-";
            // 
            // LblAvg
            // 
            this.LblAvg.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LblAvg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblAvg.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblAvg.Location = new System.Drawing.Point(259, 278);
            this.LblAvg.Name = "LblAvg";
            this.LblAvg.Size = new System.Drawing.Size(100, 23);
            this.LblAvg.TabIndex = 12;
            this.LblAvg.Text = "-";
            // 
            // LblModus
            // 
            this.LblModus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LblModus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblModus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblModus.Location = new System.Drawing.Point(21, 356);
            this.LblModus.Name = "LblModus";
            this.LblModus.Size = new System.Drawing.Size(100, 23);
            this.LblModus.TabIndex = 13;
            this.LblModus.Text = "-";
            // 
            // LblMedian
            // 
            this.LblMedian.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LblMedian.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMedian.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblMedian.Location = new System.Drawing.Point(140, 356);
            this.LblMedian.Name = "LblMedian";
            this.LblMedian.Size = new System.Drawing.Size(100, 23);
            this.LblMedian.TabIndex = 14;
            this.LblMedian.Text = "-";
            // 
            // Lbl1Q
            // 
            this.Lbl1Q.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Lbl1Q.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl1Q.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl1Q.Location = new System.Drawing.Point(259, 356);
            this.Lbl1Q.Name = "Lbl1Q";
            this.Lbl1Q.Size = new System.Drawing.Size(100, 23);
            this.Lbl1Q.TabIndex = 15;
            this.Lbl1Q.Text = "-";
            // 
            // Lbl3Q
            // 
            this.Lbl3Q.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Lbl3Q.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl3Q.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl3Q.Location = new System.Drawing.Point(378, 356);
            this.Lbl3Q.Name = "Lbl3Q";
            this.Lbl3Q.Size = new System.Drawing.Size(100, 23);
            this.Lbl3Q.TabIndex = 16;
            this.Lbl3Q.Text = "-";
            // 
            // NumDataSize
            // 
            this.NumDataSize.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumDataSize.Location = new System.Drawing.Point(232, 24);
            this.NumDataSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumDataSize.Name = "NumDataSize";
            this.NumDataSize.Size = new System.Drawing.Size(120, 33);
            this.NumDataSize.TabIndex = 17;
            this.NumDataSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 30);
            this.label8.TabIndex = 18;
            this.label8.Text = "Velikost datové sady";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(324, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 30);
            this.label9.TabIndex = 19;
            this.label9.Text = "Datová sada";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NumDataSize);
            this.Controls.Add(this.Lbl3Q);
            this.Controls.Add(this.Lbl1Q);
            this.Controls.Add(this.LblMedian);
            this.Controls.Add(this.LblModus);
            this.Controls.Add(this.LblAvg);
            this.Controls.Add(this.LblMax);
            this.Controls.Add(this.LblMin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAnalyze);
            this.Controls.Add(this.LblData);
            this.Controls.Add(this.BtnGenerate);
            this.Name = "Form1";
            this.Text = "Statistická analýza";
            ((System.ComponentModel.ISupportInitialize)(this.NumDataSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnGenerate;
        private Label LblData;
        private Button BtnAnalyze;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label LblMin;
        private Label LblMax;
        private Label LblAvg;
        private Label LblModus;
        private Label LblMedian;
        private Label Lbl1Q;
        private Label Lbl3Q;
        private NumericUpDown NumDataSize;
        private Label label8;
        private Label label9;
    }
}