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
            BtnGenerate = new Button();
            BtnReadData = new Button();
            TxtRides = new TextBox();
            SuspendLayout();
            // 
            // BtnGenerate
            // 
            BtnGenerate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnGenerate.Location = new Point(13, 8);
            BtnGenerate.Name = "BtnGenerate";
            BtnGenerate.Size = new Size(178, 43);
            BtnGenerate.TabIndex = 0;
            BtnGenerate.Text = "Generuj data";
            BtnGenerate.UseVisualStyleBackColor = true;
            BtnGenerate.Click += BtnGenerate_Click;
            // 
            // BtnReadData
            // 
            BtnReadData.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnReadData.Location = new Point(197, 8);
            BtnReadData.Name = "BtnReadData";
            BtnReadData.Size = new Size(178, 43);
            BtnReadData.TabIndex = 1;
            BtnReadData.Text = "Čti data";
            BtnReadData.UseVisualStyleBackColor = true;
            BtnReadData.Click += BtnReadData_Click;
            // 
            // TxtRides
            // 
            TxtRides.Location = new Point(13, 60);
            TxtRides.Multiline = true;
            TxtRides.Name = "TxtRides";
            TxtRides.ReadOnly = true;
            TxtRides.ScrollBars = ScrollBars.Vertical;
            TxtRides.Size = new Size(366, 373);
            TxtRides.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 450);
            Controls.Add(TxtRides);
            Controls.Add(BtnReadData);
            Controls.Add(BtnGenerate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGenerate;
        private Button BtnReadData;
        private TextBox TxtRides;
    }
}