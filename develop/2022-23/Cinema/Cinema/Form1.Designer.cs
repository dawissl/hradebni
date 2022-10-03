namespace Cinema
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
            this.TxtSize = new System.Windows.Forms.TextBox();
            this.BtnCinema = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtSize
            // 
            this.TxtSize.Location = new System.Drawing.Point(108, 12);
            this.TxtSize.Name = "TxtSize";
            this.TxtSize.Size = new System.Drawing.Size(100, 23);
            this.TxtSize.TabIndex = 0;
            // 
            // BtnCinema
            // 
            this.BtnCinema.Location = new System.Drawing.Point(239, 12);
            this.BtnCinema.Name = "BtnCinema";
            this.BtnCinema.Size = new System.Drawing.Size(75, 23);
            this.BtnCinema.TabIndex = 1;
            this.BtnCinema.Text = "Nové kino";
            this.BtnCinema.UseVisualStyleBackColor = true;
            this.BtnCinema.Click += new System.EventHandler(this.BtnCinema_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Velikost sálu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 310);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCinema);
            this.Controls.Add(this.TxtSize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtSize;
        private Button BtnCinema;
        private Label label1;
    }
}