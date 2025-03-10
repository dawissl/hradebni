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
            LblVystup = new Label();
            BtnThird = new Button();
            SuspendLayout();
            // 
            // BtnFirst
            // 
            BtnFirst.BackColor = SystemColors.ActiveCaption;
            BtnFirst.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnFirst.Location = new Point(78, 172);
            BtnFirst.Name = "BtnFirst";
            BtnFirst.Size = new Size(218, 139);
            BtnFirst.TabIndex = 0;
            BtnFirst.Text = "První tlačítko";
            BtnFirst.UseVisualStyleBackColor = false;
            BtnFirst.Click += BtnFirst_Click;
            // 
            // TxtVstup
            // 
            TxtVstup.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TxtVstup.Location = new Point(231, 41);
            TxtVstup.Name = "TxtVstup";
            TxtVstup.Size = new Size(207, 35);
            TxtVstup.TabIndex = 1;
            // 
            // BtnSecond
            // 
            BtnSecond.BackColor = Color.Salmon;
            BtnSecond.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSecond.Location = new Point(319, 172);
            BtnSecond.Name = "BtnSecond";
            BtnSecond.Size = new Size(218, 139);
            BtnSecond.TabIndex = 2;
            BtnSecond.Text = "Druhé tlačítko";
            BtnSecond.UseVisualStyleBackColor = false;
            BtnSecond.Click += BtnSecond_Click;
            // 
            // LblVystup
            // 
            LblVystup.BorderStyle = BorderStyle.Fixed3D;
            LblVystup.Location = new Point(231, 96);
            LblVystup.Name = "LblVystup";
            LblVystup.Size = new Size(207, 46);
            LblVystup.TabIndex = 3;
            // 
            // BtnThird
            // 
            BtnThird.BackColor = Color.Khaki;
            BtnThird.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnThird.Location = new Point(543, 172);
            BtnThird.Name = "BtnThird";
            BtnThird.Size = new Size(218, 139);
            BtnThird.TabIndex = 4;
            BtnThird.Text = "Třetí tlačítko";
            BtnThird.UseVisualStyleBackColor = false;
            BtnThird.Click += BtnThird_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnThird);
            Controls.Add(LblVystup);
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
        private Label LblVystup;
        private Button BtnThird;
    }
}