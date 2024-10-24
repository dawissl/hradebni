namespace _04_Faktorial
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
            label1 = new Label();
            TxtInput = new TextBox();
            BtnFact = new Button();
            LblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Vstup";
            // 
            // TxtInput
            // 
            TxtInput.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TxtInput.Location = new Point(100, 26);
            TxtInput.Name = "TxtInput";
            TxtInput.Size = new Size(173, 35);
            TxtInput.TabIndex = 1;
            // 
            // BtnFact
            // 
            BtnFact.Location = new Point(290, 27);
            BtnFact.Name = "BtnFact";
            BtnFact.Size = new Size(158, 36);
            BtnFact.TabIndex = 2;
            BtnFact.Text = "Faktoriál";
            BtnFact.UseVisualStyleBackColor = true;
            BtnFact.Click += BtnFact_Click;
            // 
            // LblResult
            // 
            LblResult.BorderStyle = BorderStyle.Fixed3D;
            LblResult.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            LblResult.Location = new Point(454, 30);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(262, 33);
            LblResult.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 89);
            Controls.Add(LblResult);
            Controls.Add(BtnFact);
            Controls.Add(TxtInput);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtInput;
        private Button BtnFact;
        private Label LblResult;
    }
}
