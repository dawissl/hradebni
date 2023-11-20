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
            ((System.ComponentModel.ISupportInitialize)NumVek).BeginInit();
            SuspendLayout();
            // 
            // TxtPricina
            // 
            TxtPricina.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPricina.Location = new Point(12, 12);
            TxtPricina.Name = "TxtPricina";
            TxtPricina.PlaceholderText = "Příčina onemocnění";
            TxtPricina.Size = new Size(239, 39);
            TxtPricina.TabIndex = 0;
            // 
            // NumVek
            // 
            NumVek.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NumVek.Location = new Point(354, 13);
            NumVek.Name = "NumVek";
            NumVek.Size = new Size(120, 39);
            NumVek.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(293, 15);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(55, 32);
            label1.TabIndex = 2;
            label1.Text = "Věk";
            // 
            // BtnAdd
            // 
            BtnAdd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAdd.Location = new Point(495, 12);
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
            TxtVystup.Location = new Point(16, 63);
            TxtVystup.Multiline = true;
            TxtVystup.Name = "TxtVystup";
            TxtVystup.ReadOnly = true;
            TxtVystup.ScrollBars = ScrollBars.Vertical;
            TxtVystup.Size = new Size(626, 362);
            TxtVystup.TabIndex = 4;
            // 
            // CheckPriciny
            // 
            CheckPriciny.AutoSize = true;
            CheckPriciny.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CheckPriciny.Location = new Point(674, 66);
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
            CheckVeky.Location = new Point(674, 106);
            CheckVeky.Name = "CheckVeky";
            CheckVeky.Size = new Size(190, 34);
            CheckVeky.TabIndex = 6;
            CheckVeky.Text = "Věkové kategorie";
            CheckVeky.UseVisualStyleBackColor = true;
            // 
            // BtnFile
            // 
            BtnFile.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnFile.Location = new Point(665, 11);
            BtnFile.Name = "BtnFile";
            BtnFile.Size = new Size(245, 40);
            BtnFile.TabIndex = 7;
            BtnFile.Text = "Vypsat do souboru";
            BtnFile.UseVisualStyleBackColor = true;
            BtnFile.Click += BtnFile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 458);
            Controls.Add(BtnFile);
            Controls.Add(CheckVeky);
            Controls.Add(CheckPriciny);
            Controls.Add(TxtVystup);
            Controls.Add(BtnAdd);
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
        private Button BtnAdd;
        private TextBox TxtVystup;
        private CheckBox CheckPriciny;
        private CheckBox CheckVeky;
        private Button BtnFile;
    }
}