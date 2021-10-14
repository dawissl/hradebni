
namespace Kvadraticka
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
            this.BtnCompute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtA = new System.Windows.Forms.TextBox();
            this.TxtC = new System.Windows.Forms.TextBox();
            this.TxtB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblX1 = new System.Windows.Forms.Label();
            this.LblX2 = new System.Windows.Forms.Label();
            this.LblD = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCompute
            // 
            this.BtnCompute.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCompute.Location = new System.Drawing.Point(138, 184);
            this.BtnCompute.Name = "BtnCompute";
            this.BtnCompute.Size = new System.Drawing.Size(211, 48);
            this.BtnCompute.TabIndex = 0;
            this.BtnCompute.Text = "Řešení rovnice";
            this.BtnCompute.UseVisualStyleBackColor = true;
            this.BtnCompute.Click += new System.EventHandler(this.BtnCompute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(64, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(64, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "C";
            // 
            // TxtA
            // 
            this.TxtA.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtA.Location = new System.Drawing.Point(138, 47);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(211, 35);
            this.TxtA.TabIndex = 4;
            // 
            // TxtC
            // 
            this.TxtC.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtC.Location = new System.Drawing.Point(138, 129);
            this.TxtC.Name = "TxtC";
            this.TxtC.Size = new System.Drawing.Size(211, 35);
            this.TxtC.TabIndex = 5;
            // 
            // TxtB
            // 
            this.TxtB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtB.Location = new System.Drawing.Point(138, 88);
            this.TxtB.Name = "TxtB";
            this.TxtB.Size = new System.Drawing.Size(211, 35);
            this.TxtB.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(64, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "X1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(64, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "X2";
            // 
            // LblX1
            // 
            this.LblX1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblX1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblX1.Location = new System.Drawing.Point(138, 249);
            this.LblX1.Name = "LblX1";
            this.LblX1.Size = new System.Drawing.Size(211, 30);
            this.LblX1.TabIndex = 9;
            // 
            // LblX2
            // 
            this.LblX2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblX2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblX2.Location = new System.Drawing.Point(138, 291);
            this.LblX2.Name = "LblX2";
            this.LblX2.Size = new System.Drawing.Size(211, 30);
            this.LblX2.TabIndex = 10;
            // 
            // LblD
            // 
            this.LblD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblD.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblD.Location = new System.Drawing.Point(138, 331);
            this.LblD.Name = "LblD";
            this.LblD.Size = new System.Drawing.Size(211, 30);
            this.LblD.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(64, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 30);
            this.label9.TabIndex = 11;
            this.label9.Text = "Diskr.";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(138, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 30);
            this.label10.TabIndex = 13;
            this.label10.Text = "Ax^2 + Bx + C = 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 402);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LblD);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LblX2);
            this.Controls.Add(this.LblX1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtB);
            this.Controls.Add(this.TxtC);
            this.Controls.Add(this.TxtA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCompute);
            this.Name = "Form1";
            this.Text = "Kvadratická rovnice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCompute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtA;
        private System.Windows.Forms.TextBox TxtC;
        private System.Windows.Forms.TextBox TxtB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblX1;
        private System.Windows.Forms.Label LblX2;
        private System.Windows.Forms.Label LblD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

