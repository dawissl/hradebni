namespace _03_Hlavicky_funkci
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
            this.BtnF1 = new System.Windows.Forms.Button();
            this.BtnF2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnF1
            // 
            this.BtnF1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnF1.Location = new System.Drawing.Point(14, 15);
            this.BtnF1.Name = "BtnF1";
            this.BtnF1.Size = new System.Drawing.Size(171, 62);
            this.BtnF1.TabIndex = 0;
            this.BtnF1.Text = "Funkce 1";
            this.BtnF1.UseVisualStyleBackColor = true;
            this.BtnF1.Click += new System.EventHandler(this.BtnF1_Click);
            // 
            // BtnF2
            // 
            this.BtnF2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnF2.Location = new System.Drawing.Point(191, 15);
            this.BtnF2.Name = "BtnF2";
            this.BtnF2.Size = new System.Drawing.Size(171, 62);
            this.BtnF2.TabIndex = 1;
            this.BtnF2.Text = "Funkce 2";
            this.BtnF2.UseVisualStyleBackColor = true;
            this.BtnF2.Click += new System.EventHandler(this.BtnF2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnF2);
            this.Controls.Add(this.BtnF1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnF1;
        private Button BtnF2;
    }
}