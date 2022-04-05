
namespace Linie
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
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnVykresli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtInput
            // 
            this.TxtInput.Location = new System.Drawing.Point(42, 27);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(641, 23);
            this.TxtInput.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(42, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 366);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtnVykresli
            // 
            this.BtnVykresli.Location = new System.Drawing.Point(700, 24);
            this.BtnVykresli.Name = "BtnVykresli";
            this.BtnVykresli.Size = new System.Drawing.Size(93, 25);
            this.BtnVykresli.TabIndex = 2;
            this.BtnVykresli.Text = "Vykresli";
            this.BtnVykresli.UseVisualStyleBackColor = true;
            this.BtnVykresli.Click += new System.EventHandler(this.BtnVykresli_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnVykresli);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnVykresli;
    }
}

