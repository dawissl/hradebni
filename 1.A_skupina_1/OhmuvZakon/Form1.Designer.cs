
namespace OhmuvZakon
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
            this.TxtNapeti = new System.Windows.Forms.TextBox();
            this.TxtProud = new System.Windows.Forms.TextBox();
            this.TxtOdpor = new System.Windows.Forms.TextBox();
            this.BtnOdpor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnNapeti = new System.Windows.Forms.Button();
            this.BtnProud = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNapeti
            // 
            this.TxtNapeti.Location = new System.Drawing.Point(85, 16);
            this.TxtNapeti.Name = "TxtNapeti";
            this.TxtNapeti.Size = new System.Drawing.Size(203, 23);
            this.TxtNapeti.TabIndex = 0;
            // 
            // TxtProud
            // 
            this.TxtProud.Location = new System.Drawing.Point(85, 45);
            this.TxtProud.Name = "TxtProud";
            this.TxtProud.Size = new System.Drawing.Size(203, 23);
            this.TxtProud.TabIndex = 1;
            // 
            // TxtOdpor
            // 
            this.TxtOdpor.Location = new System.Drawing.Point(85, 74);
            this.TxtOdpor.Name = "TxtOdpor";
            this.TxtOdpor.Size = new System.Drawing.Size(203, 23);
            this.TxtOdpor.TabIndex = 2;
            // 
            // BtnOdpor
            // 
            this.BtnOdpor.Location = new System.Drawing.Point(12, 127);
            this.BtnOdpor.Name = "BtnOdpor";
            this.BtnOdpor.Size = new System.Drawing.Size(125, 31);
            this.BtnOdpor.TabIndex = 3;
            this.BtnOdpor.Text = "Výpočet odporu";
            this.BtnOdpor.UseVisualStyleBackColor = true;
            this.BtnOdpor.Click += new System.EventHandler(this.BtnOdpor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Napětí";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Odpor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Proud";
            // 
            // BtnNapeti
            // 
            this.BtnNapeti.Location = new System.Drawing.Point(143, 127);
            this.BtnNapeti.Name = "BtnNapeti";
            this.BtnNapeti.Size = new System.Drawing.Size(125, 31);
            this.BtnNapeti.TabIndex = 7;
            this.BtnNapeti.Text = "Výpočet napěti";
            this.BtnNapeti.UseVisualStyleBackColor = true;
            this.BtnNapeti.Click += new System.EventHandler(this.BtnNapeti_Click);
            // 
            // BtnProud
            // 
            this.BtnProud.Location = new System.Drawing.Point(274, 127);
            this.BtnProud.Name = "BtnProud";
            this.BtnProud.Size = new System.Drawing.Size(125, 31);
            this.BtnProud.TabIndex = 8;
            this.BtnProud.Text = "Výpočet proudu";
            this.BtnProud.UseVisualStyleBackColor = true;
            this.BtnProud.Click += new System.EventHandler(this.BtnProud_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 175);
            this.Controls.Add(this.BtnProud);
            this.Controls.Add(this.BtnNapeti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnOdpor);
            this.Controls.Add(this.TxtOdpor);
            this.Controls.Add(this.TxtProud);
            this.Controls.Add(this.TxtNapeti);
            this.Name = "Form1";
            this.Text = "Ohmův zákon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNapeti;
        private System.Windows.Forms.TextBox TxtProud;
        private System.Windows.Forms.TextBox TxtOdpor;
        private System.Windows.Forms.Button BtnOdpor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnNapeti;
        private System.Windows.Forms.Button BtnProud;
    }
}

