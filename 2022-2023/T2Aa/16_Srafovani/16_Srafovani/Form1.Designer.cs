namespace _16_Srafovani
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblBackground = new System.Windows.Forms.Label();
            this.LblForeground = new System.Windows.Forms.Label();
            this.ClrDialog = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(25, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 200);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LblBackground
            // 
            this.LblBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblBackground.Location = new System.Drawing.Point(263, 29);
            this.LblBackground.Name = "LblBackground";
            this.LblBackground.Size = new System.Drawing.Size(84, 24);
            this.LblBackground.TabIndex = 1;
            this.LblBackground.Text = "pozadí";
            this.LblBackground.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblBackground.Click += new System.EventHandler(this.LblBackground_Click);
            // 
            // LblForeground
            // 
            this.LblForeground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblForeground.Location = new System.Drawing.Point(263, 67);
            this.LblForeground.Name = "LblForeground";
            this.LblForeground.Size = new System.Drawing.Size(84, 24);
            this.LblForeground.TabIndex = 2;
            this.LblForeground.Text = "popředí";
            this.LblForeground.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblForeground.Click += new System.EventHandler(this.LblForeground_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 291);
            this.Controls.Add(this.LblForeground);
            this.Controls.Add(this.LblBackground);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label LblBackground;
        private Label LblForeground;
        private ColorDialog ClrDialog;
    }
}