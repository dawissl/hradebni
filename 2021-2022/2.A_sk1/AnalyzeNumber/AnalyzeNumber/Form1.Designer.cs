namespace AnalyzeNumber
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
            this.LblResult = new System.Windows.Forms.Label();
            this.BtnAnalyze = new System.Windows.Forms.Button();
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblResult
            // 
            this.LblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblResult.Location = new System.Drawing.Point(51, 249);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(406, 122);
            this.LblResult.TabIndex = 0;
            // 
            // BtnAnalyze
            // 
            this.BtnAnalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnAnalyze.Location = new System.Drawing.Point(76, 113);
            this.BtnAnalyze.Name = "BtnAnalyze";
            this.BtnAnalyze.Size = new System.Drawing.Size(326, 107);
            this.BtnAnalyze.TabIndex = 1;
            this.BtnAnalyze.Text = "Analýza čísla";
            this.BtnAnalyze.UseVisualStyleBackColor = true;
            this.BtnAnalyze.Click += new System.EventHandler(this.BtnAnalyze_Click);
            // 
            // TxtNumber
            // 
            this.TxtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtNumber.Location = new System.Drawing.Point(63, 49);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(367, 31);
            this.TxtNumber.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 411);
            this.Controls.Add(this.TxtNumber);
            this.Controls.Add(this.BtnAnalyze);
            this.Controls.Add(this.LblResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Button BtnAnalyze;
        private System.Windows.Forms.TextBox TxtNumber;
    }
}

