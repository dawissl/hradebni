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
            BtnHi = new Button();
            TxtVstup = new TextBox();
            LblVystup = new Label();
            BtnWrite = new Button();
            SuspendLayout();
            // 
            // BtnHi
            // 
            BtnHi.BackColor = Color.DarkOrange;
            BtnHi.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnHi.Location = new Point(114, 218);
            BtnHi.Name = "BtnHi";
            BtnHi.Size = new Size(200, 106);
            BtnHi.TabIndex = 0;
            BtnHi.Text = "Tlačítko";
            BtnHi.UseVisualStyleBackColor = false;
            BtnHi.Click += BtnHi_Click;
            // 
            // TxtVstup
            // 
            TxtVstup.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtVstup.Location = new Point(217, 67);
            TxtVstup.Name = "TxtVstup";
            TxtVstup.Size = new Size(201, 39);
            TxtVstup.TabIndex = 1;
            // 
            // LblVystup
            // 
            LblVystup.BorderStyle = BorderStyle.Fixed3D;
            LblVystup.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblVystup.Location = new Point(217, 115);
            LblVystup.Name = "LblVystup";
            LblVystup.Size = new Size(201, 89);
            LblVystup.TabIndex = 2;
            // 
            // BtnWrite
            // 
            BtnWrite.BackColor = Color.DarkOrange;
            BtnWrite.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnWrite.Location = new Point(320, 218);
            BtnWrite.Name = "BtnWrite";
            BtnWrite.Size = new Size(200, 106);
            BtnWrite.TabIndex = 3;
            BtnWrite.Text = "Vypiš";
            BtnWrite.UseVisualStyleBackColor = false;
            BtnWrite.Click += BtnWrite_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnWrite);
            Controls.Add(LblVystup);
            Controls.Add(TxtVstup);
            Controls.Add(BtnHi);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnHi;
        private TextBox TxtVstup;
        private Label LblVystup;
        private Button BtnWrite;
    }
}