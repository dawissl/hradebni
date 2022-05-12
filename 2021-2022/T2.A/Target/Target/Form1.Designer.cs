namespace Target
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
            this.LblCol1 = new System.Windows.Forms.Label();
            this.LblCol2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(36, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 382);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LblCol1
            // 
            this.LblCol1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LblCol1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblCol1.Location = new System.Drawing.Point(596, 68);
            this.LblCol1.Name = "LblCol1";
            this.LblCol1.Size = new System.Drawing.Size(176, 43);
            this.LblCol1.TabIndex = 1;
            // 
            // LblCol2
            // 
            this.LblCol2.BackColor = System.Drawing.Color.Blue;
            this.LblCol2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblCol2.Location = new System.Drawing.Point(596, 139);
            this.LblCol2.Name = "LblCol2";
            this.LblCol2.Size = new System.Drawing.Size(176, 43);
            this.LblCol2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.LblCol2);
            this.Controls.Add(this.LblCol1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label LblCol1;
        private Label LblCol2;
    }
}