namespace _17_DeliteleCisla
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
            TxtCislo = new TextBox();
            label1 = new Label();
            LblDelitele = new Label();
            BtnDelitele = new Button();
            SuspendLayout();
            // 
            // TxtCislo
            // 
            TxtCislo.Font = new Font("Segoe UI", 20.25F);
            TxtCislo.Location = new Point(12, 12);
            TxtCislo.Name = "TxtCislo";
            TxtCislo.PlaceholderText = "Vstupní číslo";
            TxtCislo.Size = new Size(423, 43);
            TxtCislo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.Location = new Point(12, 78);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(87, 30);
            label1.TabIndex = 1;
            label1.Text = "Dělitelé";
            // 
            // LblDelitele
            // 
            LblDelitele.BorderStyle = BorderStyle.Fixed3D;
            LblDelitele.Font = new Font("Segoe UI", 15.75F);
            LblDelitele.Location = new Point(12, 117);
            LblDelitele.Name = "LblDelitele";
            LblDelitele.RightToLeft = RightToLeft.No;
            LblDelitele.Size = new Size(624, 30);
            LblDelitele.TabIndex = 2;
            // 
            // BtnDelitele
            // 
            BtnDelitele.Font = new Font("Segoe UI", 15.75F);
            BtnDelitele.Location = new Point(441, 15);
            BtnDelitele.Name = "BtnDelitele";
            BtnDelitele.Size = new Size(195, 43);
            BtnDelitele.TabIndex = 3;
            BtnDelitele.Text = "Najdi dělitele čísla";
            BtnDelitele.UseVisualStyleBackColor = true;
            BtnDelitele.Click += BtnDelitele_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 174);
            Controls.Add(BtnDelitele);
            Controls.Add(LblDelitele);
            Controls.Add(label1);
            Controls.Add(TxtCislo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtCislo;
        private Label label1;
        private Label LblDelitele;
        private Button BtnDelitele;
    }
}