namespace NahodnePole
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
            this.TxtSize = new System.Windows.Forms.TextBox();
            this.TxtMin = new System.Windows.Forms.TextBox();
            this.TxtMax = new System.Windows.Forms.TextBox();
            this.LblOut = new System.Windows.Forms.Label();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtSize
            // 
            this.TxtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtSize.Location = new System.Drawing.Point(185, 42);
            this.TxtSize.Name = "TxtSize";
            this.TxtSize.Size = new System.Drawing.Size(100, 44);
            this.TxtSize.TabIndex = 0;
            // 
            // TxtMin
            // 
            this.TxtMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtMin.Location = new System.Drawing.Point(451, 39);
            this.TxtMin.Name = "TxtMin";
            this.TxtMin.Size = new System.Drawing.Size(100, 44);
            this.TxtMin.TabIndex = 1;
            // 
            // TxtMax
            // 
            this.TxtMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtMax.Location = new System.Drawing.Point(655, 39);
            this.TxtMax.Name = "TxtMax";
            this.TxtMax.Size = new System.Drawing.Size(100, 44);
            this.TxtMax.TabIndex = 2;
            // 
            // LblOut
            // 
            this.LblOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblOut.Location = new System.Drawing.Point(12, 193);
            this.LblOut.Name = "LblOut";
            this.LblOut.Size = new System.Drawing.Size(776, 48);
            this.LblOut.TabIndex = 3;
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGenerate.Location = new System.Drawing.Point(216, 107);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(247, 60);
            this.BtnGenerate.TabIndex = 4;
            this.BtnGenerate.Text = "Generuj pole";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "velikost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(373, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(569, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "max";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 264);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.LblOut);
            this.Controls.Add(this.TxtMax);
            this.Controls.Add(this.TxtMin);
            this.Controls.Add(this.TxtSize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtSize;
        private TextBox TxtMin;
        private TextBox TxtMax;
        private Label LblOut;
        private Button BtnGenerate;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}