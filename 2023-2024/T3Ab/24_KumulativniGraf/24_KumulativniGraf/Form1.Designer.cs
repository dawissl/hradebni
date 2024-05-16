namespace _24_KumulativniGraf
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
            this.PanelGraf = new System.Windows.Forms.Panel();
            this.BtnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PanelGraf
            // 
            this.PanelGraf.BackColor = System.Drawing.Color.White;
            this.PanelGraf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelGraf.Location = new System.Drawing.Point(12, 15);
            this.PanelGraf.Name = "PanelGraf";
            this.PanelGraf.Size = new System.Drawing.Size(524, 231);
            this.PanelGraf.TabIndex = 0;
            this.PanelGraf.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelGraf_Paint);
            // 
            // BtnRun
            // 
            this.BtnRun.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRun.Location = new System.Drawing.Point(603, 24);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(130, 57);
            this.BtnRun.TabIndex = 1;
            this.BtnRun.Text = "Start";
            this.BtnRun.UseVisualStyleBackColor = true;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 279);
            this.Controls.Add(this.BtnRun);
            this.Controls.Add(this.PanelGraf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelGraf;
        private Button BtnRun;
    }
}