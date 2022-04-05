namespace PasswordCheck
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
            this.BtnCheck = new System.Windows.Forms.Button();
            this.TxtHeslo = new System.Windows.Forms.TextBox();
            this.LblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCheck
            // 
            this.BtnCheck.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCheck.Location = new System.Drawing.Point(22, 83);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(205, 99);
            this.BtnCheck.TabIndex = 0;
            this.BtnCheck.Text = "Kontrola hesla";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // TxtHeslo
            // 
            this.TxtHeslo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtHeslo.Location = new System.Drawing.Point(22, 28);
            this.TxtHeslo.Name = "TxtHeslo";
            this.TxtHeslo.PlaceholderText = "Heslo pro kontrolu";
            this.TxtHeslo.Size = new System.Drawing.Size(381, 35);
            this.TxtHeslo.TabIndex = 1;
            // 
            // LblResult
            // 
            this.LblResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblResult.Location = new System.Drawing.Point(250, 83);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(153, 99);
            this.LblResult.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 211);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.TxtHeslo);
            this.Controls.Add(this.BtnCheck);
            this.Name = "Form1";
            this.Text = "Kontrola hesla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnCheck;
        private TextBox TxtHeslo;
        private Label LblResult;
    }
}