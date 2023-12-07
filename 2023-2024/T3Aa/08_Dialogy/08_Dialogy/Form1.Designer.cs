namespace _08_Dialogy
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
            components = new System.ComponentModel.Container();
            MenuStripCustom = new MenuStrip();
            aplikaceToolStripMenuItem = new ToolStripMenuItem();
            MenuOpenFile = new ToolStripMenuItem();
            MenuPickColour = new ToolStripMenuItem();
            MenuReset = new ToolStripMenuItem();
            MenuControls = new ToolStripMenuItem();
            ovládáníToolStripMenuItem = new ToolStripMenuItem();
            MenuInfo = new ToolStripMenuItem();
            StatusStripCustom = new StatusStrip();
            StatusTime = new ToolStripStatusLabel();
            StripColor = new ToolStripStatusLabel();
            ColorCustom = new ToolStripStatusLabel();
            TimerRun = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            FileD = new OpenFileDialog();
            ColorD = new ColorDialog();
            statusStrip1 = new StatusStrip();
            MenuStripCustom.SuspendLayout();
            StatusStripCustom.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStripCustom
            // 
            MenuStripCustom.BackColor = SystemColors.ActiveCaption;
            MenuStripCustom.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            MenuStripCustom.Items.AddRange(new ToolStripItem[] { aplikaceToolStripMenuItem, MenuControls });
            MenuStripCustom.Location = new Point(0, 0);
            MenuStripCustom.Name = "MenuStripCustom";
            MenuStripCustom.Size = new Size(800, 40);
            MenuStripCustom.TabIndex = 0;
            MenuStripCustom.Text = "menuStrip1";
            // 
            // aplikaceToolStripMenuItem
            // 
            aplikaceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuOpenFile, MenuPickColour, MenuReset });
            aplikaceToolStripMenuItem.Name = "aplikaceToolStripMenuItem";
            aplikaceToolStripMenuItem.Size = new Size(115, 36);
            aplikaceToolStripMenuItem.Text = "Aplikace";
            // 
            // MenuOpenFile
            // 
            MenuOpenFile.BackColor = SystemColors.Control;
            MenuOpenFile.Name = "MenuOpenFile";
            MenuOpenFile.Size = new Size(242, 36);
            MenuOpenFile.Text = "Otevřít soubor";
            MenuOpenFile.Click += MenuOpenFile_Click;
            // 
            // MenuPickColour
            // 
            MenuPickColour.Name = "MenuPickColour";
            MenuPickColour.Size = new Size(242, 36);
            MenuPickColour.Text = "Vyber barvu";
            MenuPickColour.Click += MenuPickColour_Click;
            // 
            // MenuReset
            // 
            MenuReset.Name = "MenuReset";
            MenuReset.Size = new Size(242, 36);
            MenuReset.Text = "Reset";
            MenuReset.Click += MenuReset_Click;
            // 
            // MenuControls
            // 
            MenuControls.DropDownItems.AddRange(new ToolStripItem[] { ovládáníToolStripMenuItem, MenuInfo });
            MenuControls.Name = "MenuControls";
            MenuControls.Size = new Size(156, 36);
            MenuControls.Text = "O programu";
            // 
            // ovládáníToolStripMenuItem
            // 
            ovládáníToolStripMenuItem.Name = "ovládáníToolStripMenuItem";
            ovládáníToolStripMenuItem.Size = new Size(182, 36);
            ovládáníToolStripMenuItem.Text = "Ovládání";
            ovládáníToolStripMenuItem.Click += ovládáníToolStripMenuItem_Click;
            // 
            // MenuInfo
            // 
            MenuInfo.Name = "MenuInfo";
            MenuInfo.Size = new Size(182, 36);
            MenuInfo.Text = "Info";
            MenuInfo.Click += MenuInfo_Click;
            // 
            // StatusStripCustom
            // 
            StatusStripCustom.BackColor = SystemColors.ActiveCaption;
            StatusStripCustom.Items.AddRange(new ToolStripItem[] { StatusTime, StripColor, ColorCustom });
            StatusStripCustom.Location = new Point(0, 428);
            StatusStripCustom.Name = "StatusStripCustom";
            StatusStripCustom.RightToLeft = RightToLeft.Yes;
            StatusStripCustom.Size = new Size(800, 22);
            StatusStripCustom.TabIndex = 1;
            StatusStripCustom.Text = "statusStrip1";
            // 
            // StatusTime
            // 
            StatusTime.BackColor = SystemColors.Control;
            StatusTime.Name = "StatusTime";
            StatusTime.RightToLeft = RightToLeft.No;
            StatusTime.Size = new Size(34, 17);
            StatusTime.Text = "00:00";
            // 
            // StripColor
            // 
            StripColor.AutoSize = false;
            StripColor.Name = "StripColor";
            StripColor.Size = new Size(0, 17);
            // 
            // ColorCustom
            // 
            ColorCustom.AutoSize = false;
            ColorCustom.BackColor = SystemColors.Desktop;
            ColorCustom.Name = "ColorCustom";
            ColorCustom.Size = new Size(50, 17);
            // 
            // TimerRun
            // 
            TimerRun.Enabled = true;
            TimerRun.Interval = 1000;
            TimerRun.Tick += TimerRun_Tick;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 385);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // FileD
            // 
            FileD.FileName = "OFD";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 406);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Controls.Add(StatusStripCustom);
            Controls.Add(MenuStripCustom);
            MainMenuStrip = MenuStripCustom;
            Name = "Form1";
            Text = "Form1";
            MenuStripCustom.ResumeLayout(false);
            MenuStripCustom.PerformLayout();
            StatusStripCustom.ResumeLayout(false);
            StatusStripCustom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuStripCustom;
        private ToolStripMenuItem aplikaceToolStripMenuItem;
        private ToolStripMenuItem MenuOpenFile;
        private ToolStripMenuItem MenuPickColour;
        private ToolStripMenuItem MenuReset;
        private ToolStripMenuItem MenuControls;
        private ToolStripMenuItem ovládáníToolStripMenuItem;
        private ToolStripMenuItem MenuInfo;
        private StatusStrip StatusStripCustom;
        private ToolStripStatusLabel StatusTime;
        private System.Windows.Forms.Timer TimerRun;
        private ToolStripStatusLabel StripColor;
        private ToolStripStatusLabel ColorCustom;
        private Panel panel1;
        private OpenFileDialog FileD;
        private ColorDialog ColorD;
        private StatusStrip statusStrip1;
    }
}