namespace _04_Kinosal
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
            NumSize = new NumericUpDown();
            BtnCreate = new Button();
            ((System.ComponentModel.ISupportInitialize)NumSize).BeginInit();
            SuspendLayout();
            // 
            // NumSize
            // 
            NumSize.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NumSize.Location = new Point(12, 12);
            NumSize.Name = "NumSize";
            NumSize.Size = new Size(165, 39);
            NumSize.TabIndex = 0;
            // 
            // BtnCreate
            // 
            BtnCreate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCreate.Location = new Point(183, 12);
            BtnCreate.Name = "BtnCreate";
            BtnCreate.Size = new Size(187, 39);
            BtnCreate.TabIndex = 1;
            BtnCreate.Text = "Nový sál";
            BtnCreate.UseVisualStyleBackColor = true;
            BtnCreate.Click += BtnCreate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnCreate);
            Controls.Add(NumSize);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumSize).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown NumSize;
        private Button BtnCreate;
    }
}