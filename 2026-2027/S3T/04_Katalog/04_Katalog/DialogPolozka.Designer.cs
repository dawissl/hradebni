namespace _04_Katalog
{
    partial class DialogPolozka
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
            lblNazev = new Label();
            txtNazev = new TextBox();
            lblPocet = new Label();
            txtPocet = new TextBox();
            lblPopis = new Label();
            txtPopis = new TextBox();
            btnOk = new Button();
            btnZrusit = new Button();
            SuspendLayout();
            // 
            // lblNazev
            // 
            lblNazev.AutoSize = true;
            lblNazev.Location = new Point(12, 15);
            lblNazev.Name = "lblNazev";
            lblNazev.Size = new Size(42, 15);
            lblNazev.TabIndex = 0;
            lblNazev.Text = "Název:";
            // 
            // txtNazev
            // 
            txtNazev.Location = new Point(90, 12);
            txtNazev.Name = "txtNazev";
            txtNazev.Size = new Size(282, 23);
            txtNazev.TabIndex = 1;
            // 
            // lblPocet
            // 
            lblPocet.AutoSize = true;
            lblPocet.Location = new Point(12, 48);
            lblPocet.Name = "lblPocet";
            lblPocet.Size = new Size(68, 15);
            lblPocet.TabIndex = 2;
            lblPocet.Text = "Počet kusů:";
            // 
            // txtPocet
            // 
            txtPocet.Location = new Point(90, 45);
            txtPocet.Name = "txtPocet";
            txtPocet.Size = new Size(100, 23);
            txtPocet.TabIndex = 3;
            // 
            // lblPopis
            // 
            lblPopis.AutoSize = true;
            lblPopis.Location = new Point(12, 81);
            lblPopis.Name = "lblPopis";
            lblPopis.Size = new Size(39, 15);
            lblPopis.TabIndex = 4;
            lblPopis.Text = "Popis:";
            // 
            // txtPopis
            // 
            txtPopis.AcceptsReturn = true;
            txtPopis.Location = new Point(90, 78);
            txtPopis.Multiline = true;
            txtPopis.Name = "txtPopis";
            txtPopis.ScrollBars = ScrollBars.Vertical;
            txtPopis.Size = new Size(282, 100);
            txtPopis.TabIndex = 5;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(216, 194);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 30);
            btnOk.TabIndex = 6;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnZrusit
            // 
            btnZrusit.DialogResult = DialogResult.Cancel;
            btnZrusit.Location = new Point(297, 194);
            btnZrusit.Name = "btnZrusit";
            btnZrusit.Size = new Size(75, 30);
            btnZrusit.TabIndex = 7;
            btnZrusit.Text = "Zrušit";
            btnZrusit.UseVisualStyleBackColor = true;
            // 
            // DialogPolozka
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnZrusit;
            ClientSize = new Size(384, 236);
            Controls.Add(btnZrusit);
            Controls.Add(btnOk);
            Controls.Add(txtPopis);
            Controls.Add(lblPopis);
            Controls.Add(txtPocet);
            Controls.Add(lblPocet);
            Controls.Add(txtNazev);
            Controls.Add(lblNazev);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DialogPolozka";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Odměna";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNazev;
        private System.Windows.Forms.TextBox txtNazev;
        private System.Windows.Forms.Label lblPocet;
        private System.Windows.Forms.TextBox txtPocet;
        private System.Windows.Forms.Label lblPopis;
        private System.Windows.Forms.TextBox txtPopis;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnZrusit;
    }
}