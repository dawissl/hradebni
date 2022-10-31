namespace _05_KnihaJizd
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
            this.BtnReadFile = new System.Windows.Forms.Button();
            this.LblOut = new System.Windows.Forms.Label();
            this.TxtFileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnReadFile
            // 
            this.BtnReadFile.Location = new System.Drawing.Point(356, 35);
            this.BtnReadFile.Name = "BtnReadFile";
            this.BtnReadFile.Size = new System.Drawing.Size(166, 23);
            this.BtnReadFile.TabIndex = 0;
            this.BtnReadFile.Text = "Načti soubor";
            this.BtnReadFile.UseVisualStyleBackColor = true;
            this.BtnReadFile.Click += new System.EventHandler(this.BtnReadFile_Click_1);
            // 
            // LblOut
            // 
            this.LblOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblOut.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.LblOut.Location = new System.Drawing.Point(25, 86);
            this.LblOut.Name = "LblOut";
            this.LblOut.Size = new System.Drawing.Size(497, 247);
            this.LblOut.TabIndex = 1;
            // 
            // TxtFileName
            // 
            this.TxtFileName.Location = new System.Drawing.Point(120, 35);
            this.TxtFileName.Name = "TxtFileName";
            this.TxtFileName.Size = new System.Drawing.Size(197, 23);
            this.TxtFileName.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 342);
            this.Controls.Add(this.TxtFileName);
            this.Controls.Add(this.LblOut);
            this.Controls.Add(this.BtnReadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Button BtnReadFile;
        private Label LblOut;
        private TextBox TxtFileName;
    }
}