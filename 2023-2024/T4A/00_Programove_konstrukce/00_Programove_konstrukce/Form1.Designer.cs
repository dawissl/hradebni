namespace _00_Programove_konstrukce
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
            LblVystup = new Label();
            SuspendLayout();
            // 
            // BtnWork
            // 
            BtnWork.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnWork.Location = new Point(12, 12);
            BtnWork.Name = "BtnWork";
            BtnWork.Size = new Size(212, 47);
            BtnWork.TabIndex = 0;
            BtnWork.Text = "Work";
            BtnWork.UseVisualStyleBackColor = true;
            BtnWork.Click += BtnWork_Click;
            // 
            // LblVystup
            // 
            LblVystup.BorderStyle = BorderStyle.Fixed3D;
            LblVystup.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LblVystup.Location = new Point(12, 71);
            LblVystup.Name = "LblVystup";
            LblVystup.Size = new Size(645, 272);
            LblVystup.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 382);
            Controls.Add(LblVystup);
            Controls.Add(BtnWork);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnWork;
        private Label LblVystup;
    }
}