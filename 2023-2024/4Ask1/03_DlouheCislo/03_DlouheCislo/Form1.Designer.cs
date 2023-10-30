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
            TxtNumber = new TextBox();
            label1 = new Label();
            TxtOut = new TextBox();
            BtnAnalyze = new Button();
            SuspendLayout();
            // 
            // TxtNumber
            // 
            TxtNumber.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNumber.Location = new Point(152, 32);
            TxtNumber.Name = "TxtNumber";
            TxtNumber.Size = new Size(595, 39);
            TxtNumber.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 41);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 1;
            label1.Text = "Vstupní čislo";
            // 
            // TxtOut
            // 
            TxtOut.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtOut.Location = new Point(36, 131);
            TxtOut.Multiline = true;
            TxtOut.Name = "TxtOut";
            TxtOut.ReadOnly = true;
            TxtOut.ScrollBars = ScrollBars.Vertical;
            TxtOut.Size = new Size(722, 303);
            TxtOut.TabIndex = 2;
            // 
            // BtnAnalyze
            // 
            BtnAnalyze.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAnalyze.Location = new Point(582, 77);
            BtnAnalyze.Name = "BtnAnalyze";
            BtnAnalyze.Size = new Size(165, 37);
            BtnAnalyze.TabIndex = 3;
            BtnAnalyze.Text = "Analyzuj číslo";
            BtnAnalyze.UseVisualStyleBackColor = true;
            BtnAnalyze.Click += BtnAnalyze_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnAnalyze);
            Controls.Add(TxtOut);
            Controls.Add(label1);
            Controls.Add(TxtNumber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtNumber;
        private Label label1;
        private TextBox TxtOut;
        private Button BtnAnalyze;
    }
}