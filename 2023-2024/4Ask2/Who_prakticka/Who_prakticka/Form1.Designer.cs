namespace Who_prakticka
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
            TxtPricina = new TextBox();
            NumVek = new NumericUpDown();
            label1 = new Label();
            BtnAdd = new Button();
            TxtVystup = new TextBox();
            CheckPriciny = new CheckBox();
            CheckVeky = new CheckBox();
            BtnFile = new Button();
            button1 = new Button();
            FileDialogLoadPacients = new OpenFileDialog();
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            programToolStripMenuItem = new ToolStripMenuItem();
            restToolStripMenuItem = new ToolStripMenuItem();
            zavřítToolStripMenuItem = new ToolStripMenuItem();
            nápovědaToolStripMenuItem = new ToolStripMenuItem();
            oProgramuToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)NumVek).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TxtPricina
            // 
            TxtPricina.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPricina.Location = new Point(12, 41);
            TxtPricina.Name = "TxtPricina";
            TxtPricina.PlaceholderText = "Příčina onemocnění";
            TxtPricina.Size = new Size(239, 39);
            TxtPricina.TabIndex = 0;
            // 
            // NumVek
            // 
            NumVek.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NumVek.Location = new Point(354, 42);
            NumVek.Name = "NumVek";
            NumVek.Size = new Size(120, 39);
            NumVek.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(293, 44);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(55, 32);
            label1.TabIndex = 2;
            label1.Text = "Věk";
            // 
            // BtnAdd
            // 
            BtnAdd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAdd.Location = new Point(495, 41);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(140, 40);
            BtnAdd.TabIndex = 3;
            BtnAdd.Text = "Přidat";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // TxtVystup
            // 
            TxtVystup.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtVystup.Location = new Point(16, 92);
            TxtVystup.Multiline = true;
            TxtVystup.Name = "TxtVystup";
            TxtVystup.ReadOnly = true;
            TxtVystup.ScrollBars = ScrollBars.Vertical;
            TxtVystup.Size = new Size(626, 207);
            TxtVystup.TabIndex = 4;
            // 
            // CheckPriciny
            // 
            CheckPriciny.AutoSize = true;
            CheckPriciny.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CheckPriciny.Location = new Point(672, 147);
            CheckPriciny.Name = "CheckPriciny";
            CheckPriciny.Size = new Size(93, 34);
            CheckPriciny.TabIndex = 5;
            CheckPriciny.Text = "Příčiny";
            CheckPriciny.UseVisualStyleBackColor = true;
            // 
            // CheckVeky
            // 
            CheckVeky.AutoSize = true;
            CheckVeky.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CheckVeky.Location = new Point(672, 187);
            CheckVeky.Name = "CheckVeky";
            CheckVeky.Size = new Size(190, 34);
            CheckVeky.TabIndex = 6;
            CheckVeky.Text = "Věkové kategorie";
            CheckVeky.UseVisualStyleBackColor = true;
            // 
            // BtnFile
            // 
            BtnFile.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnFile.Location = new Point(663, 92);
            BtnFile.Name = "BtnFile";
            BtnFile.Size = new Size(245, 40);
            BtnFile.TabIndex = 7;
            BtnFile.Text = "Vypsat do souboru";
            BtnFile.UseVisualStyleBackColor = true;
            BtnFile.Click += BtnFile_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(663, 36);
            button1.Name = "button1";
            button1.Size = new Size(245, 40);
            button1.TabIndex = 8;
            button1.Text = "Načíst ze souboru";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FileDialogLoadPacients
            // 
            FileDialogLoadPacients.FileName = "pacienti.txt";
            // 
            // panel1
            // 
            panel1.Location = new Point(19, 322);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 264);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { programToolStripMenuItem, nápovědaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(948, 40);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            programToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { restToolStripMenuItem, zavřítToolStripMenuItem });
            programToolStripMenuItem.Name = "programToolStripMenuItem";
            programToolStripMenuItem.Size = new Size(116, 36);
            programToolStripMenuItem.Text = "Program";
            programToolStripMenuItem.Click += programToolStripMenuItem_Click;
            // 
            // restToolStripMenuItem
            // 
            restToolStripMenuItem.Name = "restToolStripMenuItem";
            restToolStripMenuItem.Size = new Size(180, 36);
            restToolStripMenuItem.Text = "Reset";
            restToolStripMenuItem.Click += restToolStripMenuItem_Click;
            // 
            // zavřítToolStripMenuItem
            // 
            zavřítToolStripMenuItem.Name = "zavřítToolStripMenuItem";
            zavřítToolStripMenuItem.Size = new Size(180, 36);
            zavřítToolStripMenuItem.Text = "Zavřít";
            zavřítToolStripMenuItem.Click += zavřítToolStripMenuItem_Click;
            // 
            // nápovědaToolStripMenuItem
            // 
            nápovědaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oProgramuToolStripMenuItem });
            nápovědaToolStripMenuItem.Name = "nápovědaToolStripMenuItem";
            nápovědaToolStripMenuItem.Size = new Size(135, 36);
            nápovědaToolStripMenuItem.Text = "Nápověda";
            // 
            // oProgramuToolStripMenuItem
            // 
            oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            oProgramuToolStripMenuItem.Size = new Size(218, 36);
            oProgramuToolStripMenuItem.Text = "O programu";
            oProgramuToolStripMenuItem.Click += oProgramuToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 632);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(BtnFile);
            Controls.Add(CheckVeky);
            Controls.Add(CheckPriciny);
            Controls.Add(TxtVystup);
            Controls.Add(BtnAdd);
            Controls.Add(label1);
            Controls.Add(NumVek);
            Controls.Add(TxtPricina);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumVek).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtPricina;
        private NumericUpDown NumVek;
        private Label label1;
        private Button BtnAdd;
        private TextBox TxtVystup;
        private CheckBox CheckPriciny;
        private CheckBox CheckVeky;
        private Button BtnFile;
        private Button button1;
        private OpenFileDialog FileDialogLoadPacients;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem programToolStripMenuItem;
        private ToolStripMenuItem nápovědaToolStripMenuItem;
        private ToolStripMenuItem restToolStripMenuItem;
        private ToolStripMenuItem oProgramuToolStripMenuItem;
        private ToolStripMenuItem zavřítToolStripMenuItem;
    }
}