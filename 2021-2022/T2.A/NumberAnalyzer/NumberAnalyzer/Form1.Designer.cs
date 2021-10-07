
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
            this.TxtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtNumber.Location = new System.Drawing.Point(96, 39);
            this.TxtNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(327, 35);
            this.TxtNumber.TabIndex = 0;
            // 
            // BtnAnalyze
            // 
            this.BtnAnalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAnalyze.Location = new System.Drawing.Point(152, 87);
            this.BtnAnalyze.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnAnalyze.Name = "BtnAnalyze";
            this.BtnAnalyze.Size = new System.Drawing.Size(229, 99);
            this.BtnAnalyze.TabIndex = 1;
            this.BtnAnalyze.Text = "Analyzuj číslo";
            this.BtnAnalyze.UseVisualStyleBackColor = true;
            this.BtnAnalyze.Click += new System.EventHandler(this.BtnAnalyze_Click);
            // 
            // LblAnalyze
            // 
            this.LblAnalyze.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblAnalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAnalyze.Location = new System.Drawing.Point(34, 209);
            this.LblAnalyze.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAnalyze.Name = "LblAnalyze";
            this.LblAnalyze.Size = new System.Drawing.Size(467, 149);
            this.LblAnalyze.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 413);
            this.Controls.Add(this.LblAnalyze);
            this.Controls.Add(this.BtnAnalyze);
            this.Controls.Add(this.TxtNumber);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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

