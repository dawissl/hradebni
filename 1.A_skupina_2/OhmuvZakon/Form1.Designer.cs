
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
            this.TxtOdpor = new System.Windows.Forms.TextBox();
            this.TxtProud = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnVypocetOdporu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnNapeti = new System.Windows.Forms.Button();
            this.BtnProud = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNapeti
            // 
            this.TxtNapeti.Location = new System.Drawing.Point(108, 29);
            this.TxtNapeti.Name = "TxtNapeti";
            this.TxtNapeti.Size = new System.Drawing.Size(100, 23);
            this.TxtNapeti.TabIndex = 0;
            // 
            // TxtOdpor
            // 
            this.TxtOdpor.Location = new System.Drawing.Point(108, 87);
            this.TxtOdpor.Name = "TxtOdpor";
            this.TxtOdpor.Size = new System.Drawing.Size(100, 23);
            this.TxtOdpor.TabIndex = 1;
            // 
            // TxtProud
            // 
            this.TxtProud.Location = new System.Drawing.Point(108, 58);
            this.TxtProud.Name = "TxtProud";
            this.TxtProud.Size = new System.Drawing.Size(100, 23);
            this.TxtProud.TabIndex = 2;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(56, 29);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(42, 15);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "Napětí";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Proud";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Odpor";
            // 
            // BtnVypocetOdporu
            // 
            this.BtnVypocetOdporu.Location = new System.Drawing.Point(56, 132);
            this.BtnVypocetOdporu.Name = "BtnVypocetOdporu";
            this.BtnVypocetOdporu.Size = new System.Drawing.Size(162, 32);
            this.BtnVypocetOdporu.TabIndex = 6;
            this.BtnVypocetOdporu.Text = "Výpočet Odporu";
            this.BtnVypocetOdporu.UseVisualStyleBackColor = true;
            this.BtnVypocetOdporu.Click += new System.EventHandler(this.BtnVypocetOdporu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "V";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ohm";
            // 
            // BtnNapeti
            // 
            this.BtnNapeti.Location = new System.Drawing.Point(56, 170);
            this.BtnNapeti.Name = "BtnNapeti";
            this.BtnNapeti.Size = new System.Drawing.Size(162, 32);
            this.BtnNapeti.TabIndex = 10;
            this.BtnNapeti.Text = "Výpočet Napětí";
            this.BtnNapeti.UseVisualStyleBackColor = true;
            this.BtnNapeti.Click += new System.EventHandler(this.BtnNapeti_Click);
            // 
            // BtnProud
            // 
            this.BtnProud.Location = new System.Drawing.Point(56, 208);
            this.BtnProud.Name = "BtnProud";
            this.BtnProud.Size = new System.Drawing.Size(162, 32);
            this.BtnProud.TabIndex = 11;
            this.BtnProud.Text = "Výpočet Proudu";
            this.BtnProud.UseVisualStyleBackColor = true;
            this.BtnProud.Click += new System.EventHandler(this.BtnProud_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 272);
            this.Controls.Add(this.BtnProud);
            this.Controls.Add(this.BtnNapeti);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnVypocetOdporu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.TxtProud);
            this.Controls.Add(this.TxtOdpor);
            this.Controls.Add(this.TxtNapeti);
            this.Name = "Form1";
            this.Text = "Ohmův zákon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNapeti;
        private System.Windows.Forms.TextBox TxtOdpor;
        private System.Windows.Forms.TextBox TxtProud;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnVypocetOdporu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnNapeti;
        private System.Windows.Forms.Button BtnProud;
    }
}

