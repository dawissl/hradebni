namespace AnalyzaCisla
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
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.BtnAnalyze = new System.Windows.Forms.Button();
            this.LblAnalyze = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtNumber
            // 
            this.TxtNumber.Location = new System.Drawing.Point(130, 28);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(188, 20);
            this.TxtNumber.TabIndex = 0;
            // 
            // BtnAnalyze
            // 
            this.BtnAnalyze.Location = new System.Drawing.Point(130, 75);
            this.BtnAnalyze.Name = "BtnAnalyze";
            this.BtnAnalyze.Size = new System.Drawing.Size(196, 86);
            this.BtnAnalyze.TabIndex = 1;
            this.BtnAnalyze.Text = "Analyzuj číslo";
            this.BtnAnalyze.UseVisualStyleBackColor = true;
            this.BtnAnalyze.Click += new System.EventHandler(this.BtnAnalyze_Click);
            // 
            // LblAnalyze
            // 
            this.LblAnalyze.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblAnalyze.Location = new System.Drawing.Point(29, 181);
            this.LblAnalyze.Name = "LblAnalyze";
            this.LblAnalyze.Size = new System.Drawing.Size(400, 129);
            this.LblAnalyze.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 358);
            this.Controls.Add(this.LblAnalyze);
            this.Controls.Add(this.BtnAnalyze);
            this.Controls.Add(this.TxtNumber);
            this.Name = "Form1";
            this.Text = "Analyzátor čísla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNumber;
        private System.Windows.Forms.Button BtnAnalyze;
        private System.Windows.Forms.Label LblAnalyze;
    }
}

