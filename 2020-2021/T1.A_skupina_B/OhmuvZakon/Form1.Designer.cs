
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
            this.BtnOdpor = new System.Windows.Forms.Button();
            this.BtnNapeti = new System.Windows.Forms.Button();
            this.BtnProud = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNapeti = new System.Windows.Forms.TextBox();
            this.TxtProud = new System.Windows.Forms.TextBox();
            this.TxtOdpor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnOdpor
            // 
            this.BtnOdpor.Location = new System.Drawing.Point(12, 145);
            this.BtnOdpor.Name = "BtnOdpor";
            this.BtnOdpor.Size = new System.Drawing.Size(75, 23);
            this.BtnOdpor.TabIndex = 0;
            this.BtnOdpor.Text = "Odpor";
            this.BtnOdpor.UseVisualStyleBackColor = true;
            this.BtnOdpor.Click += new System.EventHandler(this.BtnOdpor_Click);
            // 
            // BtnNapeti
            // 
            this.BtnNapeti.Location = new System.Drawing.Point(106, 145);
            this.BtnNapeti.Name = "BtnNapeti";
            this.BtnNapeti.Size = new System.Drawing.Size(75, 23);
            this.BtnNapeti.TabIndex = 1;
            this.BtnNapeti.Text = "Napětí";
            this.BtnNapeti.UseVisualStyleBackColor = true;
            this.BtnNapeti.Click += new System.EventHandler(this.BtnNapeti_Click);
            // 
            // BtnProud
            // 
            this.BtnProud.Location = new System.Drawing.Point(203, 145);
            this.BtnProud.Name = "BtnProud";
            this.BtnProud.Size = new System.Drawing.Size(75, 23);
            this.BtnProud.TabIndex = 2;
            this.BtnProud.Text = "Proud";
            this.BtnProud.UseVisualStyleBackColor = true;
            this.BtnProud.Click += new System.EventHandler(this.BtnProud_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Napětí (U)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Proud (I)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Odpor (R)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "V";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ohm";
            // 
            // TxtNapeti
            // 
            this.TxtNapeti.Location = new System.Drawing.Point(112, 20);
            this.TxtNapeti.Name = "TxtNapeti";
            this.TxtNapeti.Size = new System.Drawing.Size(100, 23);
            this.TxtNapeti.TabIndex = 9;
            // 
            // TxtProud
            // 
            this.TxtProud.Location = new System.Drawing.Point(112, 55);
            this.TxtProud.Name = "TxtProud";
            this.TxtProud.Size = new System.Drawing.Size(100, 23);
            this.TxtProud.TabIndex = 10;
            // 
            // TxtOdpor
            // 
            this.TxtOdpor.Location = new System.Drawing.Point(112, 91);
            this.TxtOdpor.Name = "TxtOdpor";
            this.TxtOdpor.Size = new System.Drawing.Size(100, 23);
            this.TxtOdpor.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 211);
            this.Controls.Add(this.TxtOdpor);
            this.Controls.Add(this.TxtProud);
            this.Controls.Add(this.TxtNapeti);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnProud);
            this.Controls.Add(this.BtnNapeti);
            this.Controls.Add(this.BtnOdpor);
            this.Name = "Form1";
            this.Text = "Ohmuv Zakon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOdpor;
        private System.Windows.Forms.Button BtnNapeti;
        private System.Windows.Forms.Button BtnProud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtNapeti;
        private System.Windows.Forms.TextBox TxtProud;
        private System.Windows.Forms.TextBox TxtOdpor;
    }
}

