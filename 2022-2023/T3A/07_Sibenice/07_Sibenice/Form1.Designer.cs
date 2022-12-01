namespace _07_Sibenice
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
            this.TxtPismeno = new System.Windows.Forms.TextBox();
            this.BtnHadeji = new System.Windows.Forms.Button();
            this.LblResult = new System.Windows.Forms.Label();
            this.LblZivoty = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtPismeno
            // 
            this.TxtPismeno.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPismeno.Location = new System.Drawing.Point(455, 23);
            this.TxtPismeno.Name = "TxtPismeno";
            this.TxtPismeno.Size = new System.Drawing.Size(76, 35);
            this.TxtPismeno.TabIndex = 1;
            // 
            // BtnHadeji
            // 
            this.BtnHadeji.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnHadeji.Location = new System.Drawing.Point(560, 23);
            this.BtnHadeji.Name = "BtnHadeji";
            this.BtnHadeji.Size = new System.Drawing.Size(102, 35);
            this.BtnHadeji.TabIndex = 2;
            this.BtnHadeji.Text = "Hádej";
            this.BtnHadeji.UseVisualStyleBackColor = true;
            this.BtnHadeji.Click += new System.EventHandler(this.BtnHadeji_Click);
            // 
            // LblResult
            // 
            this.LblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblResult.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblResult.Location = new System.Drawing.Point(70, 140);
            this.LblResult.Name = "LblResult";
            this.LblResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblResult.Size = new System.Drawing.Size(406, 78);
            this.LblResult.TabIndex = 3;
            // 
            // LblZivoty
            // 
            this.LblZivoty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblZivoty.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblZivoty.Location = new System.Drawing.Point(560, 140);
            this.LblZivoty.Name = "LblZivoty";
            this.LblZivoty.Size = new System.Drawing.Size(137, 77);
            this.LblZivoty.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(279, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hádané písmeno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(70, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hádané slovo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(560, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Životy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 237);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblZivoty);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.BtnHadeji);
            this.Controls.Add(this.TxtPismeno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox TxtPismeno;
        private Button BtnHadeji;
        private Label LblResult;
        private Label LblZivoty;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}