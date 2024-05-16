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
            MenuMain = new MenuStrip();
            MenuLoad = new ToolStripMenuItem();
            MenuHistogram = new ToolStripMenuItem();
            PictureImage = new PictureBox();
            PanelHist = new Panel();
            TresholdBar = new TrackBar();
            BtnReset = new Button();
            MenuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TresholdBar).BeginInit();
            SuspendLayout();
            // 
            // MenuMain
            // 
            MenuMain.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            MenuMain.Items.AddRange(new ToolStripItem[] { MenuLoad, MenuHistogram });
            MenuMain.Location = new Point(0, 0);
            MenuMain.Name = "MenuMain";
            MenuMain.Size = new Size(800, 29);
            MenuMain.TabIndex = 0;
            MenuMain.Text = "menuStrip1";
            // 
            // MenuLoad
            // 
            MenuLoad.Name = "MenuLoad";
            MenuLoad.Size = new Size(63, 25);
            MenuLoad.Text = "Načti";
            MenuLoad.Click += MenuLoad_Click;
            // 
            // MenuHistogram
            // 
            MenuHistogram.Name = "MenuHistogram";
            MenuHistogram.Size = new Size(102, 25);
            MenuHistogram.Text = "Histogram";
            MenuHistogram.Click += MenuHistogram_Click;
            // 
            // PictureImage
            // 
            PictureImage.BorderStyle = BorderStyle.Fixed3D;
            PictureImage.Location = new Point(12, 32);
            PictureImage.Name = "PictureImage";
            PictureImage.Size = new Size(256, 256);
            PictureImage.TabIndex = 1;
            PictureImage.TabStop = false;
            // 
            // PanelHist
            // 
            PanelHist.BackColor = Color.White;
            PanelHist.BorderStyle = BorderStyle.FixedSingle;
            PanelHist.Location = new Point(274, 32);
            PanelHist.Name = "PanelHist";
            PanelHist.Size = new Size(515, 256);
            PanelHist.TabIndex = 2;
            PanelHist.Paint += PanelHist_Paint;
            // 
            // TresholdBar
            // 
            TresholdBar.Location = new Point(274, 294);
            TresholdBar.Maximum = 255;
            TresholdBar.Name = "TresholdBar";
            TresholdBar.Size = new Size(514, 45);
            TresholdBar.TabIndex = 3;
            TresholdBar.TickStyle = TickStyle.TopLeft;
            TresholdBar.Scroll += TresholdBar_Scroll;
            // 
            // BtnReset
            // 
            BtnReset.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            BtnReset.Location = new Point(38, 294);
            BtnReset.Name = "BtnReset";
            BtnReset.Size = new Size(181, 35);
            BtnReset.TabIndex = 4;
            BtnReset.Text = "Zrušit prahování";
            BtnReset.UseVisualStyleBackColor = true;
            BtnReset.Click += BtnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 337);
            Controls.Add(BtnReset);
            Controls.Add(TresholdBar);
            Controls.Add(PanelHist);
            Controls.Add(PictureImage);
            Controls.Add(MenuMain);
            MainMenuStrip = MenuMain;
            Name = "Form1";
            Text = "Historgram 8bit";
            MenuMain.ResumeLayout(false);
            MenuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)TresholdBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuMain;
        private ToolStripMenuItem MenuLoad;
        private ToolStripMenuItem MenuHistogram;
        private PictureBox PictureImage;
        private Panel PanelHist;
        private TrackBar TresholdBar;
        private Button BtnReset;
    }
}
