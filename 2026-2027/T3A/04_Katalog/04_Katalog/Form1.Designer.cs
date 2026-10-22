namespace _04_Katalog
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lbOdmeny = new ListBox();
            chkVyčerpané = new CheckBox();
            btnPridat = new Button();
            btnUpravit = new Button();
            btnSmazat = new Button();
            btnVybrat = new Button();
            lblInfo = new Label();
            SuspendLayout();
            // 
            // lbOdmeny
            // 
            lbOdmeny.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbOdmeny.FormattingEnabled = true;
            lbOdmeny.Location = new Point(12, 12);
            lbOdmeny.Name = "lbOdmeny";
            lbOdmeny.Size = new Size(340, 214);
            lbOdmeny.TabIndex = 0;
            // 
            // chkVyčerpané
            // 
            chkVyčerpané.AutoSize = true;
            chkVyčerpané.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            chkVyčerpané.Location = new Point(12, 236);
            chkVyčerpané.Name = "chkVyčerpané";
            chkVyčerpané.Size = new Size(163, 24);
            chkVyčerpané.TabIndex = 1;
            chkVyčerpané.Text = "Zobrazit i vyčerpané";
            chkVyčerpané.UseVisualStyleBackColor = true;
            // 
            // btnPridat
            // 
            btnPridat.Font = new Font("Segoe UI", 12F);
            btnPridat.Location = new Point(364, 12);
            btnPridat.Name = "btnPridat";
            btnPridat.Size = new Size(144, 34);
            btnPridat.TabIndex = 2;
            btnPridat.Text = "Přidat";
            btnPridat.UseVisualStyleBackColor = true;
            btnPridat.Click += btnPridat_Click;
            // 
            // btnUpravit
            // 
            btnUpravit.Enabled = false;
            btnUpravit.Font = new Font("Segoe UI", 12F);
            btnUpravit.Location = new Point(364, 56);
            btnUpravit.Name = "btnUpravit";
            btnUpravit.Size = new Size(144, 34);
            btnUpravit.TabIndex = 3;
            btnUpravit.Text = "Upravit";
            btnUpravit.UseVisualStyleBackColor = true;
            // 
            // btnSmazat
            // 
            btnSmazat.Enabled = false;
            btnSmazat.Font = new Font("Segoe UI", 12F);
            btnSmazat.Location = new Point(364, 100);
            btnSmazat.Name = "btnSmazat";
            btnSmazat.Size = new Size(144, 34);
            btnSmazat.TabIndex = 4;
            btnSmazat.Text = "Smazat";
            btnSmazat.UseVisualStyleBackColor = true;
            btnSmazat.Click += btnSmazat_Click;
            // 
            // btnVybrat
            // 
            btnVybrat.Enabled = false;
            btnVybrat.Font = new Font("Segoe UI", 12F);
            btnVybrat.Location = new Point(364, 154);
            btnVybrat.Name = "btnVybrat";
            btnVybrat.Size = new Size(144, 34);
            btnVybrat.TabIndex = 5;
            btnVybrat.Text = "Vybrat odměnu";
            btnVybrat.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            lblInfo.BorderStyle = BorderStyle.FixedSingle;
            lblInfo.ForeColor = Color.Black;
            lblInfo.Location = new Point(12, 268);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(496, 40);
            lblInfo.TabIndex = 6;
            lblInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 320);
            Controls.Add(lblInfo);
            Controls.Add(btnVybrat);
            Controls.Add(btnSmazat);
            Controls.Add(btnUpravit);
            Controls.Add(btnPridat);
            Controls.Add(chkVyčerpané);
            Controls.Add(lbOdmeny);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Katalog odměn";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lbOdmeny;
        private System.Windows.Forms.CheckBox chkVyčerpané;
        private System.Windows.Forms.Button btnPridat;
        private System.Windows.Forms.Button btnUpravit;
        private System.Windows.Forms.Button btnSmazat;
        private System.Windows.Forms.Button btnVybrat;
        private System.Windows.Forms.Label lblInfo;
    }
}