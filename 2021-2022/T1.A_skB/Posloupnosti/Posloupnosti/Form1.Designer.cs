
namespace Posloupnosti
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
            this.TxtA1 = new System.Windows.Forms.TextBox();
            this.TxtQD = new System.Windows.Forms.TextBox();
            this.NumericN = new System.Windows.Forms.NumericUpDown();
            this.BtnCompute = new System.Windows.Forms.Button();
            this.LblResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Aritmetic = new System.Windows.Forms.RadioButton();
            this.Geometric = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.NumericN)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtA1
            // 
            this.TxtA1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtA1.Location = new System.Drawing.Point(124, 33);
            this.TxtA1.Name = "TxtA1";
            this.TxtA1.Size = new System.Drawing.Size(225, 35);
            this.TxtA1.TabIndex = 0;
            // 
            // TxtQD
            // 
            this.TxtQD.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtQD.Location = new System.Drawing.Point(124, 84);
            this.TxtQD.Name = "TxtQD";
            this.TxtQD.Size = new System.Drawing.Size(222, 35);
            this.TxtQD.TabIndex = 1;
            // 
            // NumericN
            // 
            this.NumericN.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumericN.Location = new System.Drawing.Point(124, 139);
            this.NumericN.Name = "NumericN";
            this.NumericN.Size = new System.Drawing.Size(225, 35);
            this.NumericN.TabIndex = 2;
            // 
            // BtnCompute
            // 
            this.BtnCompute.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCompute.Location = new System.Drawing.Point(59, 224);
            this.BtnCompute.Name = "BtnCompute";
            this.BtnCompute.Size = new System.Drawing.Size(287, 55);
            this.BtnCompute.TabIndex = 3;
            this.BtnCompute.Text = "Urči číslo posloupnosti";
            this.BtnCompute.UseVisualStyleBackColor = true;
            this.BtnCompute.Click += new System.EventHandler(this.BtnCompute_Click);
            // 
            // LblResult
            // 
            this.LblResult.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblResult.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblResult.Location = new System.Drawing.Point(49, 309);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(300, 46);
            this.LblResult.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(59, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "a1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(59, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "q/d";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(59, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "n";
            // 
            // Aritmetic
            // 
            this.Aritmetic.AutoSize = true;
            this.Aritmetic.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Aritmetic.Location = new System.Drawing.Point(49, 184);
            this.Aritmetic.Name = "Aritmetic";
            this.Aritmetic.Size = new System.Drawing.Size(141, 34);
            this.Aritmetic.TabIndex = 8;
            this.Aritmetic.TabStop = true;
            this.Aritmetic.Text = "aritmetická";
            this.Aritmetic.UseVisualStyleBackColor = true;
            // 
            // Geometric
            // 
            this.Geometric.AutoSize = true;
            this.Geometric.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Geometric.Location = new System.Drawing.Point(196, 184);
            this.Geometric.Name = "Geometric";
            this.Geometric.Size = new System.Drawing.Size(153, 34);
            this.Geometric.TabIndex = 9;
            this.Geometric.TabStop = true;
            this.Geometric.Text = "geometrická";
            this.Geometric.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 406);
            this.Controls.Add(this.Geometric);
            this.Controls.Add(this.Aritmetic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.BtnCompute);
            this.Controls.Add(this.NumericN);
            this.Controls.Add(this.TxtQD);
            this.Controls.Add(this.TxtA1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumericN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtA1;
        private System.Windows.Forms.TextBox TxtQD;
        private System.Windows.Forms.NumericUpDown NumericN;
        private System.Windows.Forms.Button BtnCompute;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton Aritmetic;
        private System.Windows.Forms.RadioButton Geometric;
    }
}

