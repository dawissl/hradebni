namespace TriangleCheck
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
            this.BtnAnalyze = new System.Windows.Forms.Button();
            this.NumericSideA = new System.Windows.Forms.NumericUpDown();
            this.NumericSideC = new System.Windows.Forms.NumericUpDown();
            this.NumericSideB = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblCheck = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSideA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSideC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSideB)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAnalyze
            // 
            this.BtnAnalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnAnalyze.Location = new System.Drawing.Point(312, 88);
            this.BtnAnalyze.Name = "BtnAnalyze";
            this.BtnAnalyze.Size = new System.Drawing.Size(222, 88);
            this.BtnAnalyze.TabIndex = 0;
            this.BtnAnalyze.Text = "Analýza trojúhelníku";
            this.BtnAnalyze.UseVisualStyleBackColor = true;
            this.BtnAnalyze.Click += new System.EventHandler(this.BtnAnalyze_Click);
            // 
            // NumericSideA
            // 
            this.NumericSideA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumericSideA.Location = new System.Drawing.Point(138, 87);
            this.NumericSideA.Name = "NumericSideA";
            this.NumericSideA.Size = new System.Drawing.Size(120, 31);
            this.NumericSideA.TabIndex = 1;
            // 
            // NumericSideC
            // 
            this.NumericSideC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumericSideC.Location = new System.Drawing.Point(138, 163);
            this.NumericSideC.Name = "NumericSideC";
            this.NumericSideC.Size = new System.Drawing.Size(120, 31);
            this.NumericSideC.TabIndex = 2;
            // 
            // NumericSideB
            // 
            this.NumericSideB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumericSideB.Location = new System.Drawing.Point(138, 124);
            this.NumericSideB.Name = "NumericSideB";
            this.NumericSideB.Size = new System.Drawing.Size(120, 31);
            this.NumericSideB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(34, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "strana a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(34, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "strana c";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(34, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "strana b";
            // 
            // LblCheck
            // 
            this.LblCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblCheck.Location = new System.Drawing.Point(48, 233);
            this.LblCheck.Name = "LblCheck";
            this.LblCheck.Size = new System.Drawing.Size(472, 66);
            this.LblCheck.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 346);
            this.Controls.Add(this.LblCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumericSideB);
            this.Controls.Add(this.NumericSideC);
            this.Controls.Add(this.NumericSideA);
            this.Controls.Add(this.BtnAnalyze);
            this.Name = "Form1";
            this.Text = "Analýza trojúhelníku";
            ((System.ComponentModel.ISupportInitialize)(this.NumericSideA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSideC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSideB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAnalyze;
        private System.Windows.Forms.NumericUpDown NumericSideA;
        private System.Windows.Forms.NumericUpDown NumericSideC;
        private System.Windows.Forms.NumericUpDown NumericSideB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblCheck;
    }
}

