namespace _09_VizualizacePulzu
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
            menuStrip1 = new MenuStrip();
            programToolStripMenuItem = new ToolStripMenuItem();
            paletaToolStripMenuItem = new ToolStripMenuItem();
            manuálníRežimToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            zavřítToolStripMenuItem = new ToolStripMenuItem();
            nápovědaToolStripMenuItem = new ToolStripMenuItem();
            nápovědaProOvládáníToolStripMenuItem = new ToolStripMenuItem();
            autorToolStripMenuItem = new ToolStripMenuItem();
            ProgressPulse = new ProgressBar();
            PanelVisualise = new Panel();
            BtnPulse = new Button();
            PulsGenerator = new System.Windows.Forms.Timer(components);
            NumImpulseCount = new NumericUpDown();
            label1 = new Label();
            ManualPulseGenerator = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumImpulseCount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { programToolStripMenuItem, nápovědaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(566, 38);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            programToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { paletaToolStripMenuItem, manuálníRežimToolStripMenuItem, resetToolStripMenuItem, zavřítToolStripMenuItem });
            programToolStripMenuItem.Name = "programToolStripMenuItem";
            programToolStripMenuItem.Size = new Size(104, 34);
            programToolStripMenuItem.Text = "Program";
            // 
            // paletaToolStripMenuItem
            // 
            paletaToolStripMenuItem.Name = "paletaToolStripMenuItem";
            paletaToolStripMenuItem.Size = new Size(230, 34);
            paletaToolStripMenuItem.Text = "Paleta";
            // 
            // manuálníRežimToolStripMenuItem
            // 
            manuálníRežimToolStripMenuItem.Name = "manuálníRežimToolStripMenuItem";
            manuálníRežimToolStripMenuItem.Size = new Size(230, 34);
            manuálníRežimToolStripMenuItem.Text = "Manuální režim";
            manuálníRežimToolStripMenuItem.Click += manuálníRežimToolStripMenuItem_Click;
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(230, 34);
            resetToolStripMenuItem.Text = "Restartovat";
            resetToolStripMenuItem.Click += resetToolStripMenuItem_Click;
            // 
            // zavřítToolStripMenuItem
            // 
            zavřítToolStripMenuItem.Name = "zavřítToolStripMenuItem";
            zavřítToolStripMenuItem.Size = new Size(230, 34);
            zavřítToolStripMenuItem.Text = "Zavřít";
            zavřítToolStripMenuItem.Click += zavřítToolStripMenuItem_Click;
            // 
            // nápovědaToolStripMenuItem
            // 
            nápovědaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nápovědaProOvládáníToolStripMenuItem, autorToolStripMenuItem });
            nápovědaToolStripMenuItem.Name = "nápovědaToolStripMenuItem";
            nápovědaToolStripMenuItem.Size = new Size(62, 34);
            nápovědaToolStripMenuItem.Text = "Info";
            // 
            // nápovědaProOvládáníToolStripMenuItem
            // 
            nápovědaProOvládáníToolStripMenuItem.Name = "nápovědaProOvládáníToolStripMenuItem";
            nápovědaProOvládáníToolStripMenuItem.Size = new Size(302, 34);
            nápovědaProOvládáníToolStripMenuItem.Text = "Nápověda pro ovládání";
            nápovědaProOvládáníToolStripMenuItem.Click += nápovědaProOvládáníToolStripMenuItem_Click;
            // 
            // autorToolStripMenuItem
            // 
            autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            autorToolStripMenuItem.Size = new Size(302, 34);
            autorToolStripMenuItem.Text = "Autor";
            autorToolStripMenuItem.Click += autorToolStripMenuItem_Click;
            // 
            // ProgressPulse
            // 
            ProgressPulse.Location = new Point(0, 297);
            ProgressPulse.Name = "ProgressPulse";
            ProgressPulse.Size = new Size(400, 23);
            ProgressPulse.Step = 1;
            ProgressPulse.TabIndex = 1;
            // 
            // PanelVisualise
            // 
            PanelVisualise.Location = new Point(0, 41);
            PanelVisualise.Name = "PanelVisualise";
            PanelVisualise.Size = new Size(400, 250);
            PanelVisualise.TabIndex = 2;
            PanelVisualise.Paint += PanelVisualise_Paint;
            // 
            // BtnPulse
            // 
            BtnPulse.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPulse.Location = new Point(406, 222);
            BtnPulse.Name = "BtnPulse";
            BtnPulse.Size = new Size(153, 69);
            BtnPulse.TabIndex = 3;
            BtnPulse.Text = "Manuální impulz";
            BtnPulse.UseVisualStyleBackColor = true;
            BtnPulse.Click += BtnPulse_Click;
            // 
            // PulsGenerator
            // 
            PulsGenerator.Tick += PulsGenerator_Tick;
            // 
            // NumImpulseCount
            // 
            NumImpulseCount.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            NumImpulseCount.Location = new Point(406, 71);
            NumImpulseCount.Name = "NumImpulseCount";
            NumImpulseCount.Size = new Size(153, 35);
            NumImpulseCount.TabIndex = 4;
            NumImpulseCount.ValueChanged += NumImpulseCount_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(406, 38);
            label1.Name = "label1";
            label1.Size = new Size(144, 30);
            label1.TabIndex = 5;
            label1.Text = "Počet impulzů";
            // 
            // ManualPulseGenerator
            // 
            ManualPulseGenerator.Interval = 1000;
            ManualPulseGenerator.Tick += ManualPulseGenerator_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 328);
            Controls.Add(label1);
            Controls.Add(NumImpulseCount);
            Controls.Add(BtnPulse);
            Controls.Add(PanelVisualise);
            Controls.Add(ProgressPulse);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumImpulseCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem programToolStripMenuItem;
        private ToolStripMenuItem paletaToolStripMenuItem;
        private ToolStripMenuItem manuálníRežimToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem zavřítToolStripMenuItem;
        private ToolStripMenuItem nápovědaToolStripMenuItem;
        private ToolStripMenuItem nápovědaProOvládáníToolStripMenuItem;
        private ToolStripMenuItem autorToolStripMenuItem;
        private ProgressBar ProgressPulse;
        private Panel PanelVisualise;
        private Button BtnPulse;
        private System.Windows.Forms.Timer PulsGenerator;
        private NumericUpDown NumImpulseCount;
        private Label label1;
        private System.Windows.Forms.Timer ManualPulseGenerator;
    }
}