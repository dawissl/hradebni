namespace Who
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
            NumAge = new NumericUpDown();
            BtnAddPacient = new Button();
            LblWorst = new Label();
            LblPacients = new Label();
            CheckCause = new CheckBox();
            CheckPacient = new CheckBox();
            BtnExport = new Button();
            BtnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)NumAge).BeginInit();
            SuspendLayout();
            // 
            // TxtPricina
            // 
            TxtPricina.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPricina.Location = new Point(34, 28);
            TxtPricina.Name = "TxtPricina";
            TxtPricina.PlaceholderText = "Název příčiny";
            TxtPricina.Size = new Size(212, 39);
            TxtPricina.TabIndex = 0;
            // 
            // NumAge
            // 
            NumAge.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NumAge.Location = new Point(252, 29);
            NumAge.Name = "NumAge";
            NumAge.Size = new Size(154, 39);
            NumAge.TabIndex = 1;
            // 
            // BtnAddPacient
            // 
            BtnAddPacient.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAddPacient.Location = new Point(422, 29);
            BtnAddPacient.Name = "BtnAddPacient";
            BtnAddPacient.Size = new Size(178, 38);
            BtnAddPacient.TabIndex = 2;
            BtnAddPacient.Text = "Přidat pacienta";
            BtnAddPacient.UseVisualStyleBackColor = true;
            BtnAddPacient.Click += BtnAddPacient_Click;
            // 
            // LblWorst
            // 
            LblWorst.BackColor = Color.Peru;
            LblWorst.BorderStyle = BorderStyle.Fixed3D;
            LblWorst.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblWorst.Location = new Point(34, 80);
            LblWorst.Name = "LblWorst";
            LblWorst.Size = new Size(570, 82);
            LblWorst.TabIndex = 3;
            LblWorst.Text = "Nejčastější příčina";
            LblWorst.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblPacients
            // 
            LblPacients.BackColor = Color.YellowGreen;
            LblPacients.BorderStyle = BorderStyle.Fixed3D;
            LblPacients.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblPacients.Location = new Point(34, 178);
            LblPacients.Name = "LblPacients";
            LblPacients.Size = new Size(570, 82);
            LblPacients.TabIndex = 4;
            LblPacients.Text = "Věková statistika";
            LblPacients.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CheckCause
            // 
            CheckCause.AutoSize = true;
            CheckCause.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CheckCause.Location = new Point(38, 283);
            CheckCause.Name = "CheckCause";
            CheckCause.Size = new Size(103, 36);
            CheckCause.TabIndex = 5;
            CheckCause.Text = "Příčina";
            CheckCause.UseVisualStyleBackColor = true;
            // 
            // CheckPacient
            // 
            CheckPacient.AutoSize = true;
            CheckPacient.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CheckPacient.Location = new Point(147, 283);
            CheckPacient.Name = "CheckPacient";
            CheckPacient.Size = new Size(115, 36);
            CheckPacient.TabIndex = 6;
            CheckPacient.Text = "Pacienti";
            CheckPacient.UseVisualStyleBackColor = true;
            // 
            // BtnExport
            // 
            BtnExport.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnExport.Location = new Point(268, 283);
            BtnExport.Name = "BtnExport";
            BtnExport.Size = new Size(243, 38);
            BtnExport.TabIndex = 7;
            BtnExport.Text = "Exportovat statistiku";
            BtnExport.UseVisualStyleBackColor = true;
            BtnExport.Click += BtnExport_Click;
            // 
            // BtnLoad
            // 
            BtnLoad.Location = new Point(525, 283);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(79, 38);
            BtnLoad.TabIndex = 8;
            BtnLoad.Text = "Načti";
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 335);
            Controls.Add(BtnLoad);
            Controls.Add(BtnExport);
            Controls.Add(CheckPacient);
            Controls.Add(CheckCause);
            Controls.Add(LblPacients);
            Controls.Add(LblWorst);
            Controls.Add(BtnAddPacient);
            Controls.Add(NumAge);
            Controls.Add(TxtPricina);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtPricina;
        private NumericUpDown NumAge;
        private Button BtnAddPacient;
        private Label LblWorst;
        private Label LblPacients;
        private CheckBox CheckCause;
        private CheckBox CheckPacient;
        private Button BtnExport;
        private Button BtnLoad;
    }
}