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
            this.PanelRect = new System.Windows.Forms.Panel();
            this.LblForeground = new System.Windows.Forms.Label();
            this.LblBackground = new System.Windows.Forms.Label();
            this.ClrDialog = new System.Windows.Forms.ColorDialog();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelRect
            // 
            this.PanelRect.Location = new System.Drawing.Point(28, 19);
            this.PanelRect.Name = "PanelRect";
            this.PanelRect.Size = new System.Drawing.Size(400, 400);
            this.PanelRect.TabIndex = 0;
            this.PanelRect.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelRect_Paint);
            // 
            // LblForeground
            // 
            this.LblForeground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblForeground.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblForeground.Location = new System.Drawing.Point(458, 19);
            this.LblForeground.Name = "LblForeground";
            this.LblForeground.Size = new System.Drawing.Size(135, 47);
            this.LblForeground.TabIndex = 1;
            this.LblForeground.Text = "Popředí";
            this.LblForeground.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblForeground.Click += new System.EventHandler(this.LblForeground_Click);
            // 
            // LblBackground
            // 
            this.LblBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblBackground.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblBackground.Location = new System.Drawing.Point(458, 76);
            this.LblBackground.Name = "LblBackground";
            this.LblBackground.Size = new System.Drawing.Size(135, 47);
            this.LblBackground.TabIndex = 2;
            this.LblBackground.Text = "Pozadí";
            this.LblBackground.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblBackground.Click += new System.EventHandler(this.LblBackground_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown1.Location = new System.Drawing.Point(482, 169);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(73, 39);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(458, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rozestup";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.LblBackground);
            this.Controls.Add(this.LblForeground);
            this.Controls.Add(this.PanelRect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel PanelRect;
        private Label LblForeground;
        private Label LblBackground;
        private ColorDialog ClrDialog;
        private NumericUpDown numericUpDown1;
        private Label label1;
    }
}