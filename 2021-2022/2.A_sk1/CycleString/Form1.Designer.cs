
namespace CycleString
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
            this.TxtCislo = new System.Windows.Forms.TextBox();
            this.TxtRetezec = new System.Windows.Forms.TextBox();
            this.LblResulr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnWork
            // 
            this.BtnWork.Location = new System.Drawing.Point(327, 40);
            this.BtnWork.Name = "BtnWork";
            this.BtnWork.Size = new System.Drawing.Size(114, 76);
            this.BtnWork.TabIndex = 0;
            this.BtnWork.Text = "Makej";
            this.BtnWork.UseVisualStyleBackColor = true;
            this.BtnWork.Click += new System.EventHandler(this.BtnWork_Click);
            // 
            // TxtCislo
            // 
            this.TxtCislo.Location = new System.Drawing.Point(12, 68);
            this.TxtCislo.Name = "TxtCislo";
            this.TxtCislo.Size = new System.Drawing.Size(100, 23);
            this.TxtCislo.TabIndex = 1;
            // 
            // TxtRetezec
            // 
            this.TxtRetezec.Location = new System.Drawing.Point(12, 129);
            this.TxtRetezec.Name = "TxtRetezec";
            this.TxtRetezec.Size = new System.Drawing.Size(441, 23);
            this.TxtRetezec.TabIndex = 2;
            // 
            // LblResulr
            // 
            this.LblResulr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblResulr.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblResulr.Location = new System.Drawing.Point(31, 200);
            this.LblResulr.Name = "LblResulr";
            this.LblResulr.Size = new System.Drawing.Size(327, 289);
            this.LblResulr.TabIndex = 3;
            this.LblResulr.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "číslo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "řetězec";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 498);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblResulr);
            this.Controls.Add(this.TxtRetezec);
            this.Controls.Add(this.TxtCislo);
            this.Controls.Add(this.BtnWork);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnWork;
        private System.Windows.Forms.TextBox TxtCislo;
        private System.Windows.Forms.TextBox TxtRetezec;
        private System.Windows.Forms.Label LblResulr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

