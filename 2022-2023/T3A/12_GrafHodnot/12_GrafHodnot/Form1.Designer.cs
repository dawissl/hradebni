namespace _12_GrafHodnot
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
            this.CheckCooper = new System.Windows.Forms.CheckBox();
            this.CheckBeef = new System.Windows.Forms.CheckBox();
            this.BtnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PanelGraf
            // 
            this.PanelGraf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelGraf.Location = new System.Drawing.Point(32, 9);
            this.PanelGraf.Name = "PanelGraf";
            this.PanelGraf.Size = new System.Drawing.Size(500, 409);
            this.PanelGraf.TabIndex = 0;
            this.PanelGraf.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelGraf_Paint);
            // 
            // CheckWheat
            // 
            this.CheckWheat.AutoSize = true;
            this.CheckWheat.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckWheat.Location = new System.Drawing.Point(41, 449);
            this.CheckWheat.Name = "CheckWheat";
            this.CheckWheat.Size = new System.Drawing.Size(83, 36);
            this.CheckWheat.TabIndex = 1;
            this.CheckWheat.Text = "Obilí";
            this.CheckWheat.UseVisualStyleBackColor = true;
            // 
            // CheckCooper
            // 
            this.CheckCooper.AutoSize = true;
            this.CheckCooper.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckCooper.Location = new System.Drawing.Point(144, 449);
            this.CheckCooper.Name = "CheckCooper";
            this.CheckCooper.Size = new System.Drawing.Size(84, 36);
            this.CheckCooper.TabIndex = 2;
            this.CheckCooper.Text = "Měď";
            this.CheckCooper.UseVisualStyleBackColor = true;
            // 
            // CheckBeef
            // 
            this.CheckBeef.AutoSize = true;
            this.CheckBeef.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBeef.Location = new System.Drawing.Point(234, 449);
            this.CheckBeef.Name = "CheckBeef";
            this.CheckBeef.Size = new System.Drawing.Size(106, 36);
            this.CheckBeef.TabIndex = 3;
            this.CheckBeef.Text = "Hovězí";
            this.CheckBeef.UseVisualStyleBackColor = true;
            // 
            // BtnShow
            // 
            this.BtnShow.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnShow.Location = new System.Drawing.Point(361, 436);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(131, 61);
            this.BtnShow.TabIndex = 4;
            this.BtnShow.Text = "Zobraz";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 521);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.CheckBeef);
            this.Controls.Add(this.CheckCooper);
            this.Controls.Add(this.CheckWheat);
            this.Controls.Add(this.PanelGraf);
            this.Name = "Form1";
            this.Text = "Graf komodit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel PanelGraf;
        private CheckBox CheckWheat;
        private CheckBox CheckCooper;
        private CheckBox CheckBeef;
        private Button BtnShow;
    }
}