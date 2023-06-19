namespace _15_GrafyKomodit
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
            this.CheckWheat = new System.Windows.Forms.CheckBox();
            this.CheckBeef = new System.Windows.Forms.CheckBox();
            this.CheckCooper = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // PanelGraf
            // 
            this.PanelGraf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelGraf.Location = new System.Drawing.Point(12, 12);
            this.PanelGraf.Name = "PanelGraf";
            this.PanelGraf.Size = new System.Drawing.Size(458, 494);
            this.PanelGraf.TabIndex = 0;
            this.PanelGraf.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelGraf_Paint);
            // 
            // CheckWheat
            // 
            this.CheckWheat.AutoSize = true;
            this.CheckWheat.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckWheat.Location = new System.Drawing.Point(476, 12);
            this.CheckWheat.Name = "CheckWheat";
            this.CheckWheat.Size = new System.Drawing.Size(83, 36);
            this.CheckWheat.TabIndex = 1;
            this.CheckWheat.Text = "Obilí";
            this.CheckWheat.UseVisualStyleBackColor = true;
            this.CheckWheat.CheckedChanged += new System.EventHandler(this.CheckWheat_CheckedChanged);
            // 
            // CheckBeef
            // 
            this.CheckBeef.AutoSize = true;
            this.CheckBeef.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBeef.Location = new System.Drawing.Point(476, 54);
            this.CheckBeef.Name = "CheckBeef";
            this.CheckBeef.Size = new System.Drawing.Size(106, 36);
            this.CheckBeef.TabIndex = 2;
            this.CheckBeef.Text = "Hovězí";
            this.CheckBeef.UseVisualStyleBackColor = true;
            this.CheckBeef.CheckedChanged += new System.EventHandler(this.CheckBeef_CheckedChanged);
            // 
            // CheckCooper
            // 
            this.CheckCooper.AutoSize = true;
            this.CheckCooper.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckCooper.Location = new System.Drawing.Point(476, 96);
            this.CheckCooper.Name = "CheckCooper";
            this.CheckCooper.Size = new System.Drawing.Size(84, 36);
            this.CheckCooper.TabIndex = 3;
            this.CheckCooper.Text = "Měď";
            this.CheckCooper.UseVisualStyleBackColor = true;
            this.CheckCooper.CheckedChanged += new System.EventHandler(this.CheckCooper_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 552);
            this.Controls.Add(this.CheckCooper);
            this.Controls.Add(this.CheckBeef);
            this.Controls.Add(this.CheckWheat);
            this.Controls.Add(this.PanelGraf);
            this.Name = "Form1";
            this.Text = "Grafy cen komodit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel PanelGraf;
        private CheckBox CheckWheat;
        private CheckBox CheckBeef;
        private CheckBox CheckCooper;
    }
}