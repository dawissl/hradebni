namespace _07_Jizdy
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
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.BtnLoadData = new System.Windows.Forms.Button();
            this.TxtRides = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGenerate.Location = new System.Drawing.Point(10, 10);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(190, 57);
            this.BtnGenerate.TabIndex = 0;
            this.BtnGenerate.Text = "Genrovani dat";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // BtnLoadData
            // 
            this.BtnLoadData.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnLoadData.Location = new System.Drawing.Point(206, 10);
            this.BtnLoadData.Name = "BtnLoadData";
            this.BtnLoadData.Size = new System.Drawing.Size(190, 57);
            this.BtnLoadData.TabIndex = 1;
            this.BtnLoadData.Text = "Nahrávání dat";
            this.BtnLoadData.UseVisualStyleBackColor = true;
            this.BtnLoadData.Click += new System.EventHandler(this.BtnLoadData_Click);
            // 
            // TxtRides
            // 
            this.TxtRides.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtRides.Location = new System.Drawing.Point(13, 77);
            this.TxtRides.Multiline = true;
            this.TxtRides.Name = "TxtRides";
            this.TxtRides.ReadOnly = true;
            this.TxtRides.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtRides.Size = new System.Drawing.Size(921, 360);
            this.TxtRides.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 450);
            this.Controls.Add(this.TxtRides);
            this.Controls.Add(this.BtnLoadData);
            this.Controls.Add(this.BtnGenerate);
            this.Name = "Form1";
            this.Text = "07_Jizdy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnGenerate;
        private Button BtnLoadData;
        private TextBox TxtRides;
    }
}