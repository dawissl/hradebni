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
            BtnAdd = new Button();
            TxtVystup = new TextBox();
            BtnLoad = new Button();
            BtnExport = new Button();
            CheckNemoci = new CheckBox();
            CheckAges = new CheckBox();
            OpenFileReports = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)NumVek).BeginInit();
            SuspendLayout();
            // 
            // TxtPricina
            // 
            TxtPricina.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPricina.Location = new Point(14, 25);
            TxtPricina.Name = "TxtPricina";
            TxtPricina.PlaceholderText = "Příčina smrti";
            TxtPricina.Size = new Size(250, 39);
            TxtPricina.TabIndex = 0;
            // 
            // NumVek
            // 
            NumVek.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NumVek.Location = new Point(286, 25);
            NumVek.Name = "NumVek";
            NumVek.Size = new Size(120, 39);
            NumVek.TabIndex = 1;
            // 
            // BtnAdd
            // 
            BtnAdd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAdd.Location = new Point(429, 25);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(199, 39);
            BtnAdd.TabIndex = 2;
            BtnAdd.Text = "Přidat pacienta";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // TxtVystup
            // 
            TxtVystup.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtVystup.Location = new Point(14, 84);
            TxtVystup.Multiline = true;
            TxtVystup.Name = "TxtVystup";
            TxtVystup.ReadOnly = true;
            TxtVystup.ScrollBars = ScrollBars.Vertical;
            TxtVystup.Size = new Size(614, 354);
            TxtVystup.TabIndex = 3;
            // 
            // BtnLoad
            // 
            BtnLoad.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnLoad.Location = new Point(666, 25);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(123, 39);
            BtnLoad.TabIndex = 4;
            BtnLoad.Text = "Načti";
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // BtnExport
            // 
            BtnExport.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnExport.Location = new Point(806, 24);
            BtnExport.Name = "BtnExport";
            BtnExport.Size = new Size(123, 39);
            BtnExport.TabIndex = 5;
            BtnExport.Text = "Export";
            BtnExport.UseVisualStyleBackColor = true;
            BtnExport.Click += BtnExport_Click;
            // 
            // CheckNemoci
            // 
            CheckNemoci.AutoSize = true;
            CheckNemoci.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CheckNemoci.Location = new Point(806, 84);
            CheckNemoci.Name = "CheckNemoci";
            CheckNemoci.Size = new Size(103, 36);
            CheckNemoci.TabIndex = 6;
            CheckNemoci.Text = "Příčiny";
            CheckNemoci.UseVisualStyleBackColor = true;
            // 
            // CheckAges
            // 
            CheckAges.AutoSize = true;
            CheckAges.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CheckAges.Location = new Point(806, 126);
            CheckAges.Name = "CheckAges";
            CheckAges.Size = new Size(217, 36);
            CheckAges.TabIndex = 7;
            CheckAges.Text = "Věkové kategorie";
            CheckAges.UseVisualStyleBackColor = true;
            // 
            // OpenFileReports
            // 
            OpenFileReports.FileName = "file.txt";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 450);
            Controls.Add(CheckAges);
            Controls.Add(CheckNemoci);
            Controls.Add(BtnExport);
            Controls.Add(BtnLoad);
            Controls.Add(TxtVystup);
            Controls.Add(BtnAdd);
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
        private Button BtnAdd;
        private TextBox TxtVystup;
        private Button BtnLoad;
        private Button BtnExport;
        private CheckBox CheckNemoci;
        private CheckBox CheckAges;
        private OpenFileDialog OpenFileReports;
    }
}