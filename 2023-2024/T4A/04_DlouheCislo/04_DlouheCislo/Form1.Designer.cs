namespace _04_DlouheCislo
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
            BtnAnalyze = new Button();
            TxtOut = new TextBox();
            SuspendLayout();
            // 
            // TxtNumber
            // 
            TxtNumber.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNumber.Location = new Point(156, 14);
            TxtNumber.Name = "TxtNumber";
            TxtNumber.Size = new Size(251, 35);
            TxtNumber.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(129, 30);
            label1.TabIndex = 1;
            label1.Text = "Vstupní číslo";
            // 
            // BtnAnalyze
            // 
            BtnAnalyze.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAnalyze.Location = new Point(426, 7);
            BtnAnalyze.Name = "BtnAnalyze";
            BtnAnalyze.Size = new Size(152, 50);
            BtnAnalyze.TabIndex = 2;
            BtnAnalyze.Text = "Zpracuj číslo";
            BtnAnalyze.UseVisualStyleBackColor = true;
            BtnAnalyze.Click += BtnAnalyze_Click;
            // 
            // TxtOut
            // 
            TxtOut.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TxtOut.Location = new Point(12, 70);
            TxtOut.Multiline = true;
            TxtOut.Name = "TxtOut";
            TxtOut.ReadOnly = true;
            TxtOut.ScrollBars = ScrollBars.Vertical;
            TxtOut.Size = new Size(566, 368);
            TxtOut.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 450);
            Controls.Add(TxtOut);
            Controls.Add(BtnAnalyze);
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
        private Button BtnAnalyze;
        private TextBox TxtOut;
    }
}