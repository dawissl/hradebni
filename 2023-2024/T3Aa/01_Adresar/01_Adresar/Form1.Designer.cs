namespace _01_Adresar
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtJmeno = new System.Windows.Forms.TextBox();
            this.TxtPrijmeni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnPridejKontakt = new System.Windows.Forms.Button();
            this.BtnVyhledat = new System.Windows.Forms.Button();
            this.TxtVyhledavac = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnExport = new System.Windows.Forms.Button();
            this.LblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jméno:";
            // 
            // TxtJmeno
            // 
            this.TxtJmeno.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtJmeno.Location = new System.Drawing.Point(94, 24);
            this.TxtJmeno.Name = "TxtJmeno";
            this.TxtJmeno.Size = new System.Drawing.Size(233, 35);
            this.TxtJmeno.TabIndex = 1;
            // 
            // TxtPrijmeni
            // 
            this.TxtPrijmeni.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPrijmeni.Location = new System.Drawing.Point(94, 65);
            this.TxtPrijmeni.Name = "TxtPrijmeni";
            this.TxtPrijmeni.Size = new System.Drawing.Size(233, 35);
            this.TxtPrijmeni.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(2, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prijmeni:";
            // 
            // TxtTelefon
            // 
            this.TxtTelefon.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTelefon.Location = new System.Drawing.Point(94, 106);
            this.TxtTelefon.Name = "TxtTelefon";
            this.TxtTelefon.Size = new System.Drawing.Size(233, 35);
            this.TxtTelefon.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefon:";
            // 
            // TxtMail
            // 
            this.TxtMail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtMail.Location = new System.Drawing.Point(94, 147);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(233, 35);
            this.TxtMail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
            // 
            // BtnPridejKontakt
            // 
            this.BtnPridejKontakt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnPridejKontakt.Location = new System.Drawing.Point(94, 197);
            this.BtnPridejKontakt.Name = "BtnPridejKontakt";
            this.BtnPridejKontakt.Size = new System.Drawing.Size(233, 42);
            this.BtnPridejKontakt.TabIndex = 8;
            this.BtnPridejKontakt.Text = "Přidat kontakt";
            this.BtnPridejKontakt.UseVisualStyleBackColor = true;
            this.BtnPridejKontakt.Click += new System.EventHandler(this.BtnPridejKontakt_Click);
            // 
            // BtnVyhledat
            // 
            this.BtnVyhledat.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnVyhledat.Location = new System.Drawing.Point(94, 295);
            this.BtnVyhledat.Name = "BtnVyhledat";
            this.BtnVyhledat.Size = new System.Drawing.Size(233, 42);
            this.BtnVyhledat.TabIndex = 9;
            this.BtnVyhledat.Text = "Vyhledat kontakty";
            this.BtnVyhledat.UseVisualStyleBackColor = true;
            this.BtnVyhledat.Click += new System.EventHandler(this.BtnVyhledat_Click);
            // 
            // TxtVyhledavac
            // 
            this.TxtVyhledavac.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtVyhledavac.Location = new System.Drawing.Point(94, 254);
            this.TxtVyhledavac.Name = "TxtVyhledavac";
            this.TxtVyhledavac.Size = new System.Drawing.Size(233, 35);
            this.TxtVyhledavac.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(2, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Prijmeni:";
            // 
            // BtnExport
            // 
            this.BtnExport.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnExport.Location = new System.Drawing.Point(94, 343);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(233, 42);
            this.BtnExport.TabIndex = 12;
            this.BtnExport.Text = "Exportovat kontakty";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCount.Location = new System.Drawing.Point(42, 197);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(30, 34);
            this.LblCount.TabIndex = 13;
            this.LblCount.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 408);
            this.Controls.Add(this.LblCount);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.TxtVyhledavac);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnVyhledat);
            this.Controls.Add(this.BtnPridejKontakt);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtTelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPrijmeni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtJmeno);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Adresář";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TxtJmeno;
        private TextBox TxtPrijmeni;
        private Label label2;
        private TextBox TxtTelefon;
        private Label label3;
        private TextBox TxtMail;
        private Label label4;
        private Button BtnPridejKontakt;
        private Button BtnVyhledat;
        private TextBox TxtVyhledavac;
        private Label label5;
        private Button BtnExport;
        private Label LblCount;
    }
}