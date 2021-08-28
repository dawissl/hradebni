
namespace ColouredForm
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
            this.btnRed = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.numRed = new System.Windows.Forms.NumericUpDown();
            this.numGreen = new System.Windows.Forms.NumericUpDown();
            this.numBlue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(25, 13);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(86, 27);
            this.btnRed.TabIndex = 0;
            this.btnRed.Text = "Červená";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.Location = new System.Drawing.Point(117, 13);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(86, 27);
            this.btnGreen.TabIndex = 1;
            this.btnGreen.Text = "Zelená";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(209, 13);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(86, 27);
            this.btnBlue.TabIndex = 2;
            this.btnBlue.Text = "Modrá";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(25, 85);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(86, 27);
            this.btnDefault.TabIndex = 3;
            this.btnDefault.Text = "Vlastní";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // numRed
            // 
            this.numRed.Location = new System.Drawing.Point(139, 90);
            this.numRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numRed.Name = "numRed";
            this.numRed.Size = new System.Drawing.Size(50, 23);
            this.numRed.TabIndex = 4;
            // 
            // numGreen
            // 
            this.numGreen.Location = new System.Drawing.Point(139, 119);
            this.numGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numGreen.Name = "numGreen";
            this.numGreen.Size = new System.Drawing.Size(50, 23);
            this.numGreen.TabIndex = 5;
            // 
            // numBlue
            // 
            this.numBlue.Location = new System.Drawing.Point(139, 148);
            this.numBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numBlue.Name = "numBlue";
            this.numBlue.Size = new System.Drawing.Size(50, 23);
            this.numBlue.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Červená";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Zelená";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Modrá";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 199);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numBlue);
            this.Controls.Add(this.numGreen);
            this.Controls.Add(this.numRed);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnRed);
            this.Name = "Form1";
            this.Text = "Barvy formuláře";
            ((System.ComponentModel.ISupportInitialize)(this.numRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.NumericUpDown numRed;
        private System.Windows.Forms.NumericUpDown numGreen;
        private System.Windows.Forms.NumericUpDown numBlue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

