
namespace _03_NovyTrojuhelnik
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
            this.TxtEdgeA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtEdgeC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtEdgeB = new System.Windows.Forms.TextBox();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.LblResult = new System.Windows.Forms.Label();
            this.BtnArea = new System.Windows.Forms.Button();
            this.BtnObvod = new System.Windows.Forms.Button();
            this.LblCalcul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtEdgeA
            // 
            this.TxtEdgeA.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtEdgeA.Location = new System.Drawing.Point(150, 36);
            this.TxtEdgeA.Name = "TxtEdgeA";
            this.TxtEdgeA.Size = new System.Drawing.Size(49, 35);
            this.TxtEdgeA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "strana A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "strana C:";
            // 
            // TxtEdgeC
            // 
            this.TxtEdgeC.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtEdgeC.Location = new System.Drawing.Point(150, 118);
            this.TxtEdgeC.Name = "TxtEdgeC";
            this.TxtEdgeC.Size = new System.Drawing.Size(49, 35);
            this.TxtEdgeC.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "strana B:";
            // 
            // TxtEdgeB
            // 
            this.TxtEdgeB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtEdgeB.Location = new System.Drawing.Point(150, 77);
            this.TxtEdgeB.Name = "TxtEdgeB";
            this.TxtEdgeB.Size = new System.Drawing.Size(49, 35);
            this.TxtEdgeB.TabIndex = 4;
            // 
            // BtnCheck
            // 
            this.BtnCheck.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCheck.Location = new System.Drawing.Point(229, 36);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(150, 48);
            this.BtnCheck.TabIndex = 6;
            this.BtnCheck.Text = "Kontrola";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // LblResult
            // 
            this.LblResult.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblResult.Location = new System.Drawing.Point(229, 97);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(150, 55);
            this.LblResult.TabIndex = 7;
            this.LblResult.Text = "---";
            this.LblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnArea
            // 
            this.BtnArea.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnArea.Location = new System.Drawing.Point(40, 199);
            this.BtnArea.Name = "BtnArea";
            this.BtnArea.Size = new System.Drawing.Size(150, 48);
            this.BtnArea.TabIndex = 8;
            this.BtnArea.Text = "Plocha";
            this.BtnArea.UseVisualStyleBackColor = true;
            this.BtnArea.Click += new System.EventHandler(this.BtnArea_Click);
            // 
            // BtnObvod
            // 
            this.BtnObvod.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnObvod.Location = new System.Drawing.Point(209, 199);
            this.BtnObvod.Name = "BtnObvod";
            this.BtnObvod.Size = new System.Drawing.Size(150, 48);
            this.BtnObvod.TabIndex = 9;
            this.BtnObvod.Text = "Obvod";
            this.BtnObvod.UseVisualStyleBackColor = true;
            this.BtnObvod.Click += new System.EventHandler(this.BtnObvod_Click);
            // 
            // LblCalcul
            // 
            this.LblCalcul.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LblCalcul.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCalcul.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCalcul.Location = new System.Drawing.Point(40, 286);
            this.LblCalcul.Name = "LblCalcul";
            this.LblCalcul.Size = new System.Drawing.Size(319, 55);
            this.LblCalcul.TabIndex = 10;
            this.LblCalcul.Text = "---";
            this.LblCalcul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 368);
            this.Controls.Add(this.LblCalcul);
            this.Controls.Add(this.BtnObvod);
            this.Controls.Add(this.BtnArea);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtEdgeB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtEdgeC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtEdgeA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEdgeA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtEdgeC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtEdgeB;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Button BtnArea;
        private System.Windows.Forms.Button BtnObvod;
        private System.Windows.Forms.Label LblCalcul;
    }
}

