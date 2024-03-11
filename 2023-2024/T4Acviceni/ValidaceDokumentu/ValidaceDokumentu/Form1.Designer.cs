namespace ValidaceDokumentu
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
            BtnValidate = new Button();
            LblFiles = new Label();
            FolderBrowserDialog = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // BtnValidate
            // 
            BtnValidate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnValidate.Location = new Point(12, 12);
            BtnValidate.Name = "BtnValidate";
            BtnValidate.Size = new Size(245, 49);
            BtnValidate.TabIndex = 0;
            BtnValidate.Text = "Validuj Dokumenty";
            BtnValidate.UseVisualStyleBackColor = true;
            BtnValidate.Click += BtnValidate_Click;
            // 
            // LblFiles
            // 
            LblFiles.BorderStyle = BorderStyle.Fixed3D;
            LblFiles.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblFiles.Location = new Point(15, 80);
            LblFiles.Name = "LblFiles";
            LblFiles.Size = new Size(476, 349);
            LblFiles.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblFiles);
            Controls.Add(BtnValidate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnValidate;
        private Label LblFiles;
        private FolderBrowserDialog FolderBrowserDialog;
    }
}