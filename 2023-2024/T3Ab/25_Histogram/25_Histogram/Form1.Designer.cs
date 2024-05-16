namespace _25_Histogram
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.načtiObrázekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PicImg = new System.Windows.Forms.PictureBox();
            this.PanelHist = new System.Windows.Forms.Panel();
            this.TrackTreshold = new System.Windows.Forms.TrackBar();
            this.BtnReset = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackTreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.načtiObrázekToolStripMenuItem,
            this.histogramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // načtiObrázekToolStripMenuItem
            // 
            this.načtiObrázekToolStripMenuItem.Name = "načtiObrázekToolStripMenuItem";
            this.načtiObrázekToolStripMenuItem.Size = new System.Drawing.Size(147, 29);
            this.načtiObrázekToolStripMenuItem.Text = "Načti obrázek";
            this.načtiObrázekToolStripMenuItem.Click += new System.EventHandler(this.načtiObrázekToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // PicImg
            // 
            this.PicImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicImg.Location = new System.Drawing.Point(13, 44);
            this.PicImg.Name = "PicImg";
            this.PicImg.Size = new System.Drawing.Size(300, 300);
            this.PicImg.TabIndex = 1;
            this.PicImg.TabStop = false;
            // 
            // PanelHist
            // 
            this.PanelHist.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelHist.Location = new System.Drawing.Point(319, 44);
            this.PanelHist.Name = "PanelHist";
            this.PanelHist.Size = new System.Drawing.Size(512, 300);
            this.PanelHist.TabIndex = 2;
            this.PanelHist.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelHist_Paint);
            // 
            // TrackTreshold
            // 
            this.TrackTreshold.Location = new System.Drawing.Point(322, 359);
            this.TrackTreshold.Maximum = 255;
            this.TrackTreshold.Name = "TrackTreshold";
            this.TrackTreshold.Size = new System.Drawing.Size(509, 45);
            this.TrackTreshold.TabIndex = 3;
            this.TrackTreshold.Scroll += new System.EventHandler(this.TrackTreshold_Scroll);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(50, 353);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(206, 51);
            this.BtnReset.TabIndex = 4;
            this.BtnReset.Text = "Zrušit prahování";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 442);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.TrackTreshold);
            this.Controls.Add(this.PanelHist);
            this.Controls.Add(this.PicImg);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Histogram";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackTreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem načtiObrázekToolStripMenuItem;
        private ToolStripMenuItem histogramToolStripMenuItem;
        private PictureBox PicImg;
        private Panel PanelHist;
        private TrackBar TrackTreshold;
        private Button BtnReset;
    }
}