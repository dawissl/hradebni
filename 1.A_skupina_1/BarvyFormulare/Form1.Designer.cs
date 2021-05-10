
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
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.numericRed = new System.Windows.Forms.NumericUpDown();
            this.numericGreen = new System.Windows.Forms.NumericUpDown();
            this.numericBlue = new System.Windows.Forms.NumericUpDown();
            this.btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGreen
            // 
            this.btnGreen.Location = new System.Drawing.Point(169, 21);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(94, 31);
            this.btnGreen.TabIndex = 0;
            this.btnGreen.Text = "Zelená";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(41, 21);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(94, 31);
            this.btnRed.TabIndex = 1;
            this.btnRed.Text = "Červená";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(298, 21);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(94, 31);
            this.btnBlue.TabIndex = 2;
            this.btnBlue.Text = "Modrá";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // numericRed
            // 
            this.numericRed.Location = new System.Drawing.Point(281, 91);
            this.numericRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericRed.Name = "numericRed";
            this.numericRed.Size = new System.Drawing.Size(38, 23);
            this.numericRed.TabIndex = 3;
            // 
            // numericGreen
            // 
            this.numericGreen.Location = new System.Drawing.Point(281, 120);
            this.numericGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericGreen.Name = "numericGreen";
            this.numericGreen.Size = new System.Drawing.Size(38, 23);
            this.numericGreen.TabIndex = 4;
            // 
            // numericBlue
            // 
            this.numericBlue.Location = new System.Drawing.Point(281, 149);
            this.numericBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericBlue.Name = "numericBlue";
            this.numericBlue.Size = new System.Drawing.Size(38, 23);
            this.numericBlue.TabIndex = 5;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(87, 110);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(128, 39);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Vlastní";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 225);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.numericBlue);
            this.Controls.Add(this.numericGreen);
            this.Controls.Add(this.numericRed);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnGreen);
            this.Name = "Form1";
            this.Text = "Barvy formuláře";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.NumericUpDown numericRed;
        private System.Windows.Forms.NumericUpDown numericGreen;
        private System.Windows.Forms.NumericUpDown numericBlue;
        private System.Windows.Forms.Button btnCreate;
    }
}

