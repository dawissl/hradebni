namespace _00_ProgramoveKonstrukce
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
            LblOutput = new Label();
            SuspendLayout();
            // 
            // BtnWork
            // 
            BtnWork.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnWork.Location = new Point(17, 5);
            BtnWork.Name = "BtnWork";
            BtnWork.Size = new Size(146, 41);
            BtnWork.TabIndex = 0;
            BtnWork.Text = "Pracuj";
            BtnWork.UseVisualStyleBackColor = true;
            BtnWork.Click += BtnWork_Click;
            // 
            // LblOutput
            // 
            LblOutput.BorderStyle = BorderStyle.FixedSingle;
            LblOutput.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LblOutput.Location = new Point(17, 59);
            LblOutput.Name = "LblOutput";
            LblOutput.Size = new Size(754, 382);
            LblOutput.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblOutput);
            Controls.Add(BtnWork);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnWork;
        private Label LblOutput;
    }
}