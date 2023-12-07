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
            this.components = new System.ComponentModel.Container();
            this.MenuCustom = new System.Windows.Forms.MenuStrip();
            this.aplikaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otevřítSouborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zvolitBarvuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nápovědaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ovládáníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusCustom = new System.Windows.Forms.StatusStrip();
            this.StatusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimerActive = new System.Windows.Forms.Timer(this.components);
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.PanelDrawings = new System.Windows.Forms.Panel();
            this.MenuCustom.SuspendLayout();
            this.StatusCustom.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuCustom
            // 
            this.MenuCustom.BackColor = System.Drawing.Color.Gold;
            this.MenuCustom.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuCustom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplikaceToolStripMenuItem,
            this.nápovědaToolStripMenuItem});
            this.MenuCustom.Location = new System.Drawing.Point(0, 0);
            this.MenuCustom.Name = "MenuCustom";
            this.MenuCustom.Size = new System.Drawing.Size(800, 40);
            this.MenuCustom.TabIndex = 0;
            this.MenuCustom.Text = "menuStrip1";
            // 
            // aplikaceToolStripMenuItem
            // 
            this.aplikaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otevřítSouborToolStripMenuItem,
            this.zvolitBarvuToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.aplikaceToolStripMenuItem.Name = "aplikaceToolStripMenuItem";
            this.aplikaceToolStripMenuItem.Size = new System.Drawing.Size(115, 36);
            this.aplikaceToolStripMenuItem.Text = "Aplikace";
            // 
            // otevřítSouborToolStripMenuItem
            // 
            this.otevřítSouborToolStripMenuItem.Name = "otevřítSouborToolStripMenuItem";
            this.otevřítSouborToolStripMenuItem.Size = new System.Drawing.Size(242, 36);
            this.otevřítSouborToolStripMenuItem.Text = "Otevřít soubor";
            this.otevřítSouborToolStripMenuItem.Click += new System.EventHandler(this.otevřítSouborToolStripMenuItem_Click);
            // 
            // zvolitBarvuToolStripMenuItem
            // 
            this.zvolitBarvuToolStripMenuItem.Name = "zvolitBarvuToolStripMenuItem";
            this.zvolitBarvuToolStripMenuItem.Size = new System.Drawing.Size(242, 36);
            this.zvolitBarvuToolStripMenuItem.Text = "Zvolit barvu";
            this.zvolitBarvuToolStripMenuItem.Click += new System.EventHandler(this.zvolitBarvuToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(242, 36);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // nápovědaToolStripMenuItem
            // 
            this.nápovědaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramuToolStripMenuItem,
            this.ovládáníToolStripMenuItem});
            this.nápovědaToolStripMenuItem.Name = "nápovědaToolStripMenuItem";
            this.nápovědaToolStripMenuItem.Size = new System.Drawing.Size(135, 36);
            this.nápovědaToolStripMenuItem.Text = "Nápověda";
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(218, 36);
            this.oProgramuToolStripMenuItem.Text = "O programu";
            // 
            // ovládáníToolStripMenuItem
            // 
            this.ovládáníToolStripMenuItem.Name = "ovládáníToolStripMenuItem";
            this.ovládáníToolStripMenuItem.Size = new System.Drawing.Size(218, 36);
            this.ovládáníToolStripMenuItem.Text = "Ovládání";
            // 
            // StatusCustom
            // 
            this.StatusCustom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusTime,
            this.StatusColor});
            this.StatusCustom.Location = new System.Drawing.Point(0, 415);
            this.StatusCustom.Name = "StatusCustom";
            this.StatusCustom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StatusCustom.Size = new System.Drawing.Size(800, 35);
            this.StatusCustom.TabIndex = 1;
            this.StatusCustom.Text = "statusStrip1";
            // 
            // StatusTime
            // 
            this.StatusTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusTime.Name = "StatusTime";
            this.StatusTime.Size = new System.Drawing.Size(62, 30);
            this.StatusTime.Text = "00:00";
            // 
            // StatusColor
            // 
            this.StatusColor.AutoSize = false;
            this.StatusColor.BackColor = System.Drawing.Color.Black;
            this.StatusColor.Name = "StatusColor";
            this.StatusColor.Size = new System.Drawing.Size(100, 30);
            // 
            // TimerActive
            // 
            this.TimerActive.Enabled = true;
            this.TimerActive.Interval = 1000;
            this.TimerActive.Tick += new System.EventHandler(this.TimerActive_Tick);
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "obrazce.txt";
            // 
            // PanelDrawings
            // 
            this.PanelDrawings.Location = new System.Drawing.Point(0, 43);
            this.PanelDrawings.Name = "PanelDrawings";
            this.PanelDrawings.Size = new System.Drawing.Size(800, 371);
            this.PanelDrawings.TabIndex = 2;
            this.PanelDrawings.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDrawings_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelDrawings);
            this.Controls.Add(this.StatusCustom);
            this.Controls.Add(this.MenuCustom);
            this.MainMenuStrip = this.MenuCustom;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MenuCustom.ResumeLayout(false);
            this.MenuCustom.PerformLayout();
            this.StatusCustom.ResumeLayout(false);
            this.StatusCustom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip MenuCustom;
        private ToolStripMenuItem aplikaceToolStripMenuItem;
        private ToolStripMenuItem otevřítSouborToolStripMenuItem;
        private ToolStripMenuItem zvolitBarvuToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem nápovědaToolStripMenuItem;
        private ToolStripMenuItem oProgramuToolStripMenuItem;
        private ToolStripMenuItem ovládáníToolStripMenuItem;
        private StatusStrip StatusCustom;
        private ToolStripStatusLabel StatusTime;
        private ToolStripStatusLabel StatusColor;
        private System.Windows.Forms.Timer TimerActive;
        private OpenFileDialog FileDialog;
        private ColorDialog ColorDialog;
        private Panel PanelDrawings;
    }
}