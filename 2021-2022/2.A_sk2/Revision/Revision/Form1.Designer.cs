
namespace Revision
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
            this.TxtRetezec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCislo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblVystup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnWork
            // 
            this.BtnWork.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnWork.Location = new System.Drawing.Point(54, 174);
            this.BtnWork.Name = "BtnWork";
            this.BtnWork.Size = new System.Drawing.Size(360, 44);
            this.BtnWork.TabIndex = 0;
            this.BtnWork.Text = "Makej šmudlo";
            this.BtnWork.UseVisualStyleBackColor = true;
            this.BtnWork.Click += new System.EventHandler(this.BtnWork_Click);
            // 
            // TxtRetezec
            // 
            this.TxtRetezec.Location = new System.Drawing.Point(54, 66);
            this.TxtRetezec.Name = "TxtRetezec";
            this.TxtRetezec.Size = new System.Drawing.Size(378, 23);
            this.TxtRetezec.TabIndex = 1;
            this.TxtRetezec.TextChanged += new System.EventHandler(this.TxtRetezec_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vstupní řetězec";
            // 
            // TxtCislo
            // 
            this.TxtCislo.Location = new System.Drawing.Point(54, 127);
            this.TxtCislo.Name = "TxtCislo";
            this.TxtCislo.Size = new System.Drawing.Size(76, 23);
            this.TxtCislo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(54, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Počet opakování";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(54, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Výstup programu";
            // 
            // LblVystup
            // 
            this.LblVystup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblVystup.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblVystup.Location = new System.Drawing.Point(54, 292);
            this.LblVystup.Name = "LblVystup";
            this.LblVystup.Size = new System.Drawing.Size(378, 510);
            this.LblVystup.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 828);
            this.Controls.Add(this.LblVystup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCislo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtRetezec);
            this.Controls.Add(this.BtnWork);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnWork;
        private System.Windows.Forms.TextBox TxtRetezec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCislo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblVystup;
    }
}

