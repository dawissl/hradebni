namespace HelloWFA
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
            this.BtnWork = new System.Windows.Forms.Button();
            this.TxtVstup = new System.Windows.Forms.TextBox();
            this.BtnRed = new System.Windows.Forms.Button();
            this.BtnGreen = new System.Windows.Forms.Button();
            this.BtnBlue = new System.Windows.Forms.Button();
            this.LblVystup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnWork
            // 
            this.BtnWork.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnWork.Location = new System.Drawing.Point(174, 116);
            this.BtnWork.Name = "BtnWork";
            this.BtnWork.Size = new System.Drawing.Size(253, 124);
            this.BtnWork.TabIndex = 0;
            this.BtnWork.Text = "Makej šmudlo!";
            this.BtnWork.UseVisualStyleBackColor = true;
            this.BtnWork.Click += new System.EventHandler(this.BtnWork_Click);
            // 
            // TxtVstup
            // 
            this.TxtVstup.Location = new System.Drawing.Point(174, 64);
            this.TxtVstup.Name = "TxtVstup";
            this.TxtVstup.Size = new System.Drawing.Size(253, 23);
            this.TxtVstup.TabIndex = 1;
            // 
            // BtnRed
            // 
            this.BtnRed.Location = new System.Drawing.Point(552, 77);
            this.BtnRed.Name = "BtnRed";
            this.BtnRed.Size = new System.Drawing.Size(75, 23);
            this.BtnRed.TabIndex = 2;
            this.BtnRed.Text = "Červená";
            this.BtnRed.UseVisualStyleBackColor = true;
            this.BtnRed.Click += new System.EventHandler(this.BtnRed_Click);
            // 
            // BtnGreen
            // 
            this.BtnGreen.Location = new System.Drawing.Point(552, 116);
            this.BtnGreen.Name = "BtnGreen";
            this.BtnGreen.Size = new System.Drawing.Size(75, 23);
            this.BtnGreen.TabIndex = 3;
            this.BtnGreen.Text = "Zelená";
            this.BtnGreen.UseVisualStyleBackColor = true;
            this.BtnGreen.Click += new System.EventHandler(this.BtnGreen_Click);
            // 
            // BtnBlue
            // 
            this.BtnBlue.Location = new System.Drawing.Point(552, 161);
            this.BtnBlue.Name = "BtnBlue";
            this.BtnBlue.Size = new System.Drawing.Size(75, 23);
            this.BtnBlue.TabIndex = 4;
            this.BtnBlue.Text = "Modrá";
            this.BtnBlue.UseVisualStyleBackColor = true;
            this.BtnBlue.Click += new System.EventHandler(this.BtnBlue_Click);
            // 
            // LblVystup
            // 
            this.LblVystup.BackColor = System.Drawing.Color.Gainsboro;
            this.LblVystup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblVystup.Location = new System.Drawing.Point(80, 277);
            this.LblVystup.Name = "LblVystup";
            this.LblVystup.Size = new System.Drawing.Size(466, 75);
            this.LblVystup.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblVystup);
            this.Controls.Add(this.BtnBlue);
            this.Controls.Add(this.BtnGreen);
            this.Controls.Add(this.BtnRed);
            this.Controls.Add(this.TxtVstup);
            this.Controls.Add(this.BtnWork);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnWork;
        private TextBox TxtVstup;
        private Button BtnRed;
        private Button BtnGreen;
        private Button BtnBlue;
        private Label LblVystup;
    }
}