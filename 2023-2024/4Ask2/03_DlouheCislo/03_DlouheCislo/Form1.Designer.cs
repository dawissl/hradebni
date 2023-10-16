namespace _03_DlouheCislo
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
            TxtLongNumber = new TextBox();
            label1 = new Label();
            BtnAnalyze = new Button();
            TxtResult = new TextBox();
            SuspendLayout();
            // 
            // TxtLongNumber
            // 
            TxtLongNumber.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtLongNumber.Location = new Point(178, 16);
            TxtLongNumber.Name = "TxtLongNumber";
            TxtLongNumber.Size = new Size(435, 39);
            TxtLongNumber.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(160, 32);
            label1.TabIndex = 1;
            label1.Text = "Vstupní číslo";
            // 
            // BtnAnalyze
            // 
            BtnAnalyze.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAnalyze.Location = new Point(178, 70);
            BtnAnalyze.Name = "BtnAnalyze";
            BtnAnalyze.Size = new Size(166, 47);
            BtnAnalyze.TabIndex = 2;
            BtnAnalyze.Text = "Zpracuj";
            BtnAnalyze.UseVisualStyleBackColor = true;
            BtnAnalyze.Click += BtnAnalyze_Click;
            // 
            // TxtResult
            // 
            TxtResult.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TxtResult.Location = new Point(32, 156);
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.ReadOnly = true;
            TxtResult.ScrollBars = ScrollBars.Vertical;
            TxtResult.Size = new Size(580, 266);
            TxtResult.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 450);
            Controls.Add(TxtResult);
            Controls.Add(BtnAnalyze);
            Controls.Add(label1);
            Controls.Add(TxtLongNumber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtLongNumber;
        private Label label1;
        private Button BtnAnalyze;
        private TextBox TxtResult;
    }
}