
namespace cycles
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
            this.LblVyskedek = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnWork
            // 
            this.BtnWork.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnWork.Location = new System.Drawing.Point(508, 22);
            this.BtnWork.Name = "BtnWork";
            this.BtnWork.Size = new System.Drawing.Size(113, 74);
            this.BtnWork.TabIndex = 0;
            this.BtnWork.Text = "Makej";
            this.BtnWork.UseVisualStyleBackColor = true;
            this.BtnWork.Click += new System.EventHandler(this.BtnWork_Click);
            // 
            // TxtCislo
            // 
            this.TxtCislo.Location = new System.Drawing.Point(70, 38);
            this.TxtCislo.Name = "TxtCislo";
            this.TxtCislo.Size = new System.Drawing.Size(100, 23);
            this.TxtCislo.TabIndex = 1;
            // 
            // TxtRetezec
            // 
            this.TxtRetezec.Location = new System.Drawing.Point(70, 93);
            this.TxtRetezec.Name = "TxtRetezec";
            this.TxtRetezec.Size = new System.Drawing.Size(212, 23);
            this.TxtRetezec.TabIndex = 2;
            // 
            // LblVyskedek
            // 
            this.LblVyskedek.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblVyskedek.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblVyskedek.Location = new System.Drawing.Point(70, 142);
            this.LblVyskedek.Name = "LblVyskedek";
            this.LblVyskedek.Size = new System.Drawing.Size(393, 279);
            this.LblVyskedek.TabIndex = 3;
            this.LblVyskedek.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vstupní číslo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "vstupní řetězec";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblVyskedek);
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
        private System.Windows.Forms.Label LblVyskedek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

