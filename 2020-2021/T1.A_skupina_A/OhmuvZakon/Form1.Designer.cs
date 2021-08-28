
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNapeti = new System.Windows.Forms.TextBox();
            this.txtProud = new System.Windows.Forms.TextBox();
            this.txtOdpor = new System.Windows.Forms.TextBox();
            this.btnOdpor = new System.Windows.Forms.Button();
            this.btnNapeti = new System.Windows.Forms.Button();
            this.btnProud = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Napětí (U)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Proud (I)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Odpor (R)";
            // 
            // txtNapeti
            // 
            this.txtNapeti.Location = new System.Drawing.Point(160, 38);
            this.txtNapeti.Name = "txtNapeti";
            this.txtNapeti.Size = new System.Drawing.Size(100, 23);
            this.txtNapeti.TabIndex = 3;
            // 
            // txtProud
            // 
            this.txtProud.Location = new System.Drawing.Point(160, 67);
            this.txtProud.Name = "txtProud";
            this.txtProud.Size = new System.Drawing.Size(100, 23);
            this.txtProud.TabIndex = 4;
            // 
            // txtOdpor
            // 
            this.txtOdpor.Location = new System.Drawing.Point(160, 96);
            this.txtOdpor.Name = "txtOdpor";
            this.txtOdpor.Size = new System.Drawing.Size(100, 23);
            this.txtOdpor.TabIndex = 5;
            // 
            // btnOdpor
            // 
            this.btnOdpor.Location = new System.Drawing.Point(45, 181);
            this.btnOdpor.Name = "btnOdpor";
            this.btnOdpor.Size = new System.Drawing.Size(75, 23);
            this.btnOdpor.TabIndex = 6;
            this.btnOdpor.Text = "Odpor";
            this.btnOdpor.UseVisualStyleBackColor = true;
            this.btnOdpor.Click += new System.EventHandler(this.btnOdpor_Click);
            // 
            // btnNapeti
            // 
            this.btnNapeti.Location = new System.Drawing.Point(130, 181);
            this.btnNapeti.Name = "btnNapeti";
            this.btnNapeti.Size = new System.Drawing.Size(75, 23);
            this.btnNapeti.TabIndex = 7;
            this.btnNapeti.Text = "Napětí";
            this.btnNapeti.UseVisualStyleBackColor = true;
            this.btnNapeti.Click += new System.EventHandler(this.btnNapeti_Click);
            // 
            // btnProud
            // 
            this.btnProud.Location = new System.Drawing.Point(211, 181);
            this.btnProud.Name = "btnProud";
            this.btnProud.Size = new System.Drawing.Size(75, 23);
            this.btnProud.TabIndex = 8;
            this.btnProud.Text = "Proud";
            this.btnProud.UseVisualStyleBackColor = true;
            this.btnProud.Click += new System.EventHandler(this.btnProud_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "V";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ohm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 216);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnProud);
            this.Controls.Add(this.btnNapeti);
            this.Controls.Add(this.btnOdpor);
            this.Controls.Add(this.txtOdpor);
            this.Controls.Add(this.txtProud);
            this.Controls.Add(this.txtNapeti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ohmův zákon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNapeti;
        private System.Windows.Forms.TextBox txtProud;
        private System.Windows.Forms.TextBox txtOdpor;
        private System.Windows.Forms.Button btnOdpor;
        private System.Windows.Forms.Button btnNapeti;
        private System.Windows.Forms.Button btnProud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

