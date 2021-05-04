
namespace BarvyFormuláře
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
            this.BtnRed = new System.Windows.Forms.Button();
            this.BtnCustom = new System.Windows.Forms.Button();
            this.NumRed = new System.Windows.Forms.NumericUpDown();
            this.NumBlue = new System.Windows.Forms.NumericUpDown();
            this.NumGreen = new System.Windows.Forms.NumericUpDown();
            this.BtnGreen = new System.Windows.Forms.Button();
            this.BtnBlue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRed
            // 
            this.BtnRed.BackColor = System.Drawing.Color.Red;
            this.BtnRed.Location = new System.Drawing.Point(12, 12);
            this.BtnRed.Name = "BtnRed";
            this.BtnRed.Size = new System.Drawing.Size(118, 35);
            this.BtnRed.TabIndex = 0;
            this.BtnRed.Text = "Červená";
            this.BtnRed.UseVisualStyleBackColor = false;
            this.BtnRed.Click += new System.EventHandler(this.BtnRed_Click);
            // 
            // BtnCustom
            // 
            this.BtnCustom.Location = new System.Drawing.Point(12, 130);
            this.BtnCustom.Name = "BtnCustom";
            this.BtnCustom.Size = new System.Drawing.Size(129, 45);
            this.BtnCustom.TabIndex = 1;
            this.BtnCustom.Text = "Vlastní";
            this.BtnCustom.UseVisualStyleBackColor = true;
            this.BtnCustom.Click += new System.EventHandler(this.BtnCustom_Click);
            // 
            // NumRed
            // 
            this.NumRed.Location = new System.Drawing.Point(208, 112);
            this.NumRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumRed.Name = "NumRed";
            this.NumRed.Size = new System.Drawing.Size(97, 23);
            this.NumRed.TabIndex = 2;
            // 
            // NumBlue
            // 
            this.NumBlue.Location = new System.Drawing.Point(208, 170);
            this.NumBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumBlue.Name = "NumBlue";
            this.NumBlue.Size = new System.Drawing.Size(97, 23);
            this.NumBlue.TabIndex = 3;
            // 
            // NumGreen
            // 
            this.NumGreen.Location = new System.Drawing.Point(208, 141);
            this.NumGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumGreen.Name = "NumGreen";
            this.NumGreen.Size = new System.Drawing.Size(97, 23);
            this.NumGreen.TabIndex = 4;
            // 
            // BtnGreen
            // 
            this.BtnGreen.BackColor = System.Drawing.Color.Lime;
            this.BtnGreen.Location = new System.Drawing.Point(136, 12);
            this.BtnGreen.Name = "BtnGreen";
            this.BtnGreen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnGreen.Size = new System.Drawing.Size(118, 35);
            this.BtnGreen.TabIndex = 5;
            this.BtnGreen.Text = "Zelená";
            this.BtnGreen.UseVisualStyleBackColor = false;
            this.BtnGreen.Click += new System.EventHandler(this.BtnGreen_Click);
            // 
            // BtnBlue
            // 
            this.BtnBlue.BackColor = System.Drawing.Color.Blue;
            this.BtnBlue.Location = new System.Drawing.Point(260, 12);
            this.BtnBlue.Name = "BtnBlue";
            this.BtnBlue.Size = new System.Drawing.Size(118, 35);
            this.BtnBlue.TabIndex = 6;
            this.BtnBlue.Text = "Modrá";
            this.BtnBlue.UseVisualStyleBackColor = false;
            this.BtnBlue.Click += new System.EventHandler(this.BtnBlue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 226);
            this.Controls.Add(this.BtnBlue);
            this.Controls.Add(this.BtnGreen);
            this.Controls.Add(this.NumGreen);
            this.Controls.Add(this.NumBlue);
            this.Controls.Add(this.NumRed);
            this.Controls.Add(this.BtnCustom);
            this.Controls.Add(this.BtnRed);
            this.Name = "Form1";
            this.Text = "Barvy formuláře";
            ((System.ComponentModel.ISupportInitialize)(this.NumRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumGreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRed;
        private System.Windows.Forms.Button BtnCustom;
        private System.Windows.Forms.NumericUpDown NumRed;
        private System.Windows.Forms.NumericUpDown NumBlue;
        private System.Windows.Forms.NumericUpDown NumGreen;
        private System.Windows.Forms.Button BtnGreen;
        private System.Windows.Forms.Button BtnBlue;
    }
}

