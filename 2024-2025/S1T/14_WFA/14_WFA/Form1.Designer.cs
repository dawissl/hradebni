namespace _14_WFA
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
            BtnFirst = new Button();
            TxtVstup = new TextBox();
            BtnSecond = new Button();
            LblOut = new Label();
            SuspendLayout();
            // 
            // BtnFirst
            // 
            BtnFirst.BackColor = Color.IndianRed;
            BtnFirst.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            BtnFirst.Location = new Point(164, 156);
            BtnFirst.Name = "BtnFirst";
            BtnFirst.Size = new Size(179, 133);
            BtnFirst.TabIndex = 0;
            BtnFirst.Text = "První tlačítko";
            BtnFirst.UseVisualStyleBackColor = false;
            BtnFirst.Click += BtnFirst_Click;
            BtnFirst.MouseHover += BtnFirst_MouseHover;
            // 
            // TxtVstup
            // 
            TxtVstup.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TxtVstup.Location = new Point(164, 69);
            TxtVstup.Name = "TxtVstup";
            TxtVstup.Size = new Size(179, 35);
            TxtVstup.TabIndex = 1;
            // 
            // BtnSecond
            // 
            BtnSecond.BackColor = Color.IndianRed;
            BtnSecond.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSecond.Location = new Point(349, 156);
            BtnSecond.Name = "BtnSecond";
            BtnSecond.Size = new Size(179, 133);
            BtnSecond.TabIndex = 2;
            BtnSecond.Text = "Druhé tlačítko";
            BtnSecond.UseVisualStyleBackColor = false;
            BtnSecond.Click += BtnSecond_Click;
            // 
            // LblOut
            // 
            LblOut.BorderStyle = BorderStyle.Fixed3D;
            LblOut.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblOut.Location = new Point(349, 69);
            LblOut.Name = "LblOut";
            LblOut.Size = new Size(179, 35);
            LblOut.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblOut);
            Controls.Add(BtnSecond);
            Controls.Add(TxtVstup);
            Controls.Add(BtnFirst);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnFirst;
        private TextBox TxtVstup;
        private Button BtnSecond;
        private Label LblOut;
    }
}