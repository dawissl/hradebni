namespace _22_GrafCeny
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
            this.PanelGraph = new System.Windows.Forms.Panel();
            this.CheckWheat = new System.Windows.Forms.CheckBox();
            this.CheckCooper = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PanelGraph
            // 
            this.PanelGraph.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelGraph.Location = new System.Drawing.Point(8, 30);
            this.PanelGraph.Name = "PanelGraph";
            this.PanelGraph.Size = new System.Drawing.Size(850, 350);
            this.PanelGraph.TabIndex = 0;
            // 
            // CheckWheat
            // 
            this.CheckWheat.AutoSize = true;
            this.CheckWheat.BackColor = System.Drawing.Color.Orange;
            this.CheckWheat.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckWheat.ForeColor = System.Drawing.Color.Black;
            this.CheckWheat.Location = new System.Drawing.Point(12, 404);
            this.CheckWheat.Name = "CheckWheat";
            this.CheckWheat.Size = new System.Drawing.Size(83, 36);
            this.CheckWheat.TabIndex = 1;
            this.CheckWheat.Text = "Obilí";
            this.CheckWheat.UseVisualStyleBackColor = false;
            // 
            // CheckCooper
            // 
            this.CheckCooper.AutoSize = true;
            this.CheckCooper.BackColor = System.Drawing.Color.OrangeRed;
            this.CheckCooper.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckCooper.ForeColor = System.Drawing.Color.Black;
            this.CheckCooper.Location = new System.Drawing.Point(121, 404);
            this.CheckCooper.Name = "CheckCooper";
            this.CheckCooper.Size = new System.Drawing.Size(84, 36);
            this.CheckCooper.TabIndex = 2;
            this.CheckCooper.Text = "Měď";
            this.CheckCooper.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Red;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(226, 404);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 36);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Hovězí";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // BtnDraw
            // 
            this.BtnDraw.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDraw.Location = new System.Drawing.Point(361, 403);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(157, 37);
            this.BtnDraw.TabIndex = 4;
            this.BtnDraw.Text = "Překresli";
            this.BtnDraw.UseVisualStyleBackColor = true;
            this.BtnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 468);
            this.Controls.Add(this.BtnDraw);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.CheckCooper);
            this.Controls.Add(this.CheckWheat);
            this.Controls.Add(this.PanelGraph);
            this.Name = "Form1";
            this.Text = "Graf vývoje ceny";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel PanelGraph;
        private CheckBox CheckWheat;
        private CheckBox CheckCooper;
        private CheckBox checkBox1;
        private Button BtnDraw;
    }
}