namespace Who_prakitcka
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
            BtnManualAdd = new Button();
            TxtVystup = new TextBox();
            BtnExport = new Button();
            FileDialog = new OpenFileDialog();
            BtnAddFromFile = new Button();
            CheckPriciny = new CheckBox();
            CheckVeky = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)NumVek).BeginInit();
            SuspendLayout();
            // 
            // TxtPricina
            // 
            TxtPricina.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPricina.Location = new Point(24, 13);
            TxtPricina.Name = "TxtPricina";
            TxtPricina.PlaceholderText = "Příčina úmrtí";
            TxtPricina.Size = new Size(208, 39);
            TxtPricina.TabIndex = 0;
            // 
            // NumVek
            // 
            NumVek.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NumVek.Location = new Point(296, 14);
            NumVek.Name = "NumVek";
            NumVek.Size = new Size(111, 39);
            NumVek.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(238, 16);
            label1.Name = "label1";
            label1.Size = new Size(52, 32);
            label1.TabIndex = 2;
            label1.Text = "Věk";
            // 
            // BtnManualAdd
            // 
            BtnManualAdd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnManualAdd.Location = new Point(428, 12);
            BtnManualAdd.Name = "BtnManualAdd";
            BtnManualAdd.Size = new Size(173, 40);
            BtnManualAdd.TabIndex = 3;
            BtnManualAdd.Text = "Přidat";
            BtnManualAdd.UseVisualStyleBackColor = true;
            BtnManualAdd.Click += BtnManualAdd_Click;
            // 
            // TxtVystup
            // 
            TxtVystup.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtVystup.Location = new Point(23, 68);
            TxtVystup.Multiline = true;
            TxtVystup.Name = "TxtVystup";
            TxtVystup.ReadOnly = true;
            TxtVystup.ScrollBars = ScrollBars.Vertical;
            TxtVystup.Size = new Size(578, 370);
            TxtVystup.TabIndex = 4;
            // 
            // BtnExport
            // 
            BtnExport.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnExport.Location = new Point(615, 58);
            BtnExport.Name = "BtnExport";
            BtnExport.Size = new Size(173, 40);
            BtnExport.TabIndex = 5;
            BtnExport.Text = "Export";
            BtnExport.UseVisualStyleBackColor = true;
            BtnExport.Click += BtnExport_Click;
            // 
            // FileDialog
            // 
            FileDialog.FileName = "openFileDialog1";
            // 
            // BtnAddFromFile
            // 
            BtnAddFromFile.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAddFromFile.Location = new Point(615, 12);
            BtnAddFromFile.Name = "BtnAddFromFile";
            BtnAddFromFile.Size = new Size(173, 40);
            BtnAddFromFile.TabIndex = 6;
            BtnAddFromFile.Text = "Ze souboru";
            BtnAddFromFile.UseVisualStyleBackColor = true;
            BtnAddFromFile.Click += BtnAddFromFile_Click;
            // 
            // CheckPriciny
            // 
            CheckPriciny.AutoSize = true;
            CheckPriciny.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CheckPriciny.Location = new Point(615, 118);
            CheckPriciny.Name = "CheckPriciny";
            CheckPriciny.Size = new Size(103, 36);
            CheckPriciny.TabIndex = 7;
            CheckPriciny.Text = "Příčiny";
            CheckPriciny.UseVisualStyleBackColor = true;
            // 
            // CheckVeky
            // 
            CheckVeky.AutoSize = true;
            CheckVeky.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CheckVeky.Location = new Point(615, 160);
            CheckVeky.Name = "CheckVeky";
            CheckVeky.Size = new Size(217, 36);
            CheckVeky.TabIndex = 8;
            CheckVeky.Text = "Věkové kategorie";
            CheckVeky.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 450);
            Controls.Add(CheckVeky);
            Controls.Add(CheckPriciny);
            Controls.Add(BtnAddFromFile);
            Controls.Add(BtnExport);
            Controls.Add(TxtVystup);
            Controls.Add(BtnManualAdd);
            Controls.Add(label1);
            Controls.Add(NumVek);
            Controls.Add(TxtPricina);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumVek).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtPricina;
        private NumericUpDown NumVek;
        private Label label1;
        private Button BtnManualAdd;
        private TextBox TxtVystup;
        private Button BtnExport;
        private OpenFileDialog FileDialog;
        private Button BtnAddFromFile;
        private CheckBox CheckPriciny;
        private CheckBox CheckVeky;
    }
}