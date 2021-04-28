
namespace BarvyFormulare
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
            this.BtnGreen = new System.Windows.Forms.Button();
            this.BtnBlue = new System.Windows.Forms.Button();
            this.BtnOwn = new System.Windows.Forms.Button();
            this.NumericRed = new System.Windows.Forms.NumericUpDown();
            this.NumericGreen = new System.Windows.Forms.NumericUpDown();
            this.NumericBlue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRed
            // 
            this.BtnRed.BackColor = System.Drawing.Color.Red;
            this.BtnRed.Location = new System.Drawing.Point(44, 28);
            this.BtnRed.Name = "BtnRed";
            this.BtnRed.Size = new System.Drawing.Size(75, 23);
            this.BtnRed.TabIndex = 0;
            this.BtnRed.Text = "Červená";
            this.BtnRed.UseVisualStyleBackColor = false;
            this.BtnRed.Click += new System.EventHandler(this.BtnRed_Click);
            // 
            // BtnGreen
            // 
            this.BtnGreen.BackColor = System.Drawing.Color.Lime;
            this.BtnGreen.Location = new System.Drawing.Point(148, 28);
            this.BtnGreen.Name = "BtnGreen";
            this.BtnGreen.Size = new System.Drawing.Size(75, 23);
            this.BtnGreen.TabIndex = 1;
            this.BtnGreen.Text = "Zelená";
            this.BtnGreen.UseVisualStyleBackColor = false;
            this.BtnGreen.Click += new System.EventHandler(this.BtnGreen_Click);
            // 
            // BtnBlue
            // 
            this.BtnBlue.BackColor = System.Drawing.Color.Blue;
            this.BtnBlue.Location = new System.Drawing.Point(260, 28);
            this.BtnBlue.Name = "BtnBlue";
            this.BtnBlue.Size = new System.Drawing.Size(75, 23);
            this.BtnBlue.TabIndex = 2;
            this.BtnBlue.Text = "Modrá";
            this.BtnBlue.UseVisualStyleBackColor = false;
            this.BtnBlue.Click += new System.EventHandler(this.BtnBlue_Click);
            // 
            // BtnOwn
            // 
            this.BtnOwn.Location = new System.Drawing.Point(44, 110);
            this.BtnOwn.Name = "BtnOwn";
            this.BtnOwn.Size = new System.Drawing.Size(75, 23);
            this.BtnOwn.TabIndex = 3;
            this.BtnOwn.Text = "Vlastní";
            this.BtnOwn.UseVisualStyleBackColor = true;
            this.BtnOwn.Click += new System.EventHandler(this.BtnOwn_Click);
            // 
            // NumericRed
            // 
            this.NumericRed.Location = new System.Drawing.Point(159, 110);
            this.NumericRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericRed.Name = "NumericRed";
            this.NumericRed.Size = new System.Drawing.Size(83, 23);
            this.NumericRed.TabIndex = 4;
            // 
            // NumericGreen
            // 
            this.NumericGreen.Location = new System.Drawing.Point(159, 139);
            this.NumericGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericGreen.Name = "NumericGreen";
            this.NumericGreen.Size = new System.Drawing.Size(83, 23);
            this.NumericGreen.TabIndex = 5;
            // 
            // NumericBlue
            // 
            this.NumericBlue.Location = new System.Drawing.Point(159, 168);
            this.NumericBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericBlue.Name = "NumericBlue";
            this.NumericBlue.Size = new System.Drawing.Size(83, 23);
            this.NumericBlue.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Červená";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Modrá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Zelená";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 214);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumericBlue);
            this.Controls.Add(this.NumericGreen);
            this.Controls.Add(this.NumericRed);
            this.Controls.Add(this.BtnOwn);
            this.Controls.Add(this.BtnBlue);
            this.Controls.Add(this.BtnGreen);
            this.Controls.Add(this.BtnRed);
            this.Name = "Form1";
            this.Text = "Barvy formuláře";
            ((System.ComponentModel.ISupportInitialize)(this.NumericRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRed;
        private System.Windows.Forms.Button BtnGreen;
        private System.Windows.Forms.Button BtnBlue;
        private System.Windows.Forms.Button BtnOwn;
        private System.Windows.Forms.NumericUpDown NumericRed;
        private System.Windows.Forms.NumericUpDown NumericGreen;
        private System.Windows.Forms.NumericUpDown NumericBlue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

