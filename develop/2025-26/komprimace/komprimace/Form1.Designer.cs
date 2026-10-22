namespace komprimace
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
            BtnWork = new Button();
            TxtInput = new TextBox();
            label1 = new Label();
            LblVystup = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // BtnWork
            // 
            BtnWork.Font = new Font("Segoe UI", 18F);
            BtnWork.Location = new Point(12, 111);
            BtnWork.Name = "BtnWork";
            BtnWork.Size = new Size(364, 81);
            BtnWork.TabIndex = 0;
            BtnWork.Text = "Komprimace";
            BtnWork.UseVisualStyleBackColor = true;
            BtnWork.Click += BtnWork_Click;
            // 
            // TxtInput
            // 
            TxtInput.Font = new Font("Segoe UI", 18F);
            TxtInput.Location = new Point(12, 46);
            TxtInput.Name = "TxtInput";
            TxtInput.Size = new Size(650, 39);
            TxtInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(74, 32);
            label1.TabIndex = 2;
            label1.Text = "Vstup";
            // 
            // LblVystup
            // 
            LblVystup.BorderStyle = BorderStyle.Fixed3D;
            LblVystup.Font = new Font("Segoe UI", 18F);
            LblVystup.Location = new Point(12, 261);
            LblVystup.Name = "LblVystup";
            LblVystup.Size = new Size(650, 103);
            LblVystup.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(12, 218);
            label3.Name = "label3";
            label3.Size = new Size(87, 32);
            label3.TabIndex = 4;
            label3.Text = "Výstup";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 389);
            Controls.Add(label3);
            Controls.Add(LblVystup);
            Controls.Add(label1);
            Controls.Add(TxtInput);
            Controls.Add(BtnWork);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnWork;
        private TextBox TxtInput;
        private Label label1;
        private Label LblVystup;
        private Label label3;
    }
}
