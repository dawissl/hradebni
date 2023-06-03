namespace _11_CaesarovaSifra
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
            this.BtnEncrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.NumMove = new System.Windows.Forms.NumericUpDown();
            this.LblOut = new System.Windows.Forms.Label();
            this.BtnDecrypt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumMove)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEncrypt
            // 
            this.BtnEncrypt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEncrypt.Location = new System.Drawing.Point(532, 25);
            this.BtnEncrypt.Name = "BtnEncrypt";
            this.BtnEncrypt.Size = new System.Drawing.Size(169, 40);
            this.BtnEncrypt.TabIndex = 0;
            this.BtnEncrypt.Text = "Zašifruj";
            this.BtnEncrypt.UseVisualStyleBackColor = true;
            this.BtnEncrypt.Click += new System.EventHandler(this.BtnEncrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Výstup";
            // 
            // TxtInput
            // 
            this.TxtInput.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtInput.Location = new System.Drawing.Point(28, 25);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(420, 39);
            this.TxtInput.TabIndex = 2;
            // 
            // NumMove
            // 
            this.NumMove.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumMove.Location = new System.Drawing.Point(454, 24);
            this.NumMove.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.NumMove.Minimum = new decimal(new int[] {
            26,
            0,
            0,
            -2147483648});
            this.NumMove.Name = "NumMove";
            this.NumMove.Size = new System.Drawing.Size(72, 39);
            this.NumMove.TabIndex = 3;
            // 
            // LblOut
            // 
            this.LblOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblOut.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblOut.Location = new System.Drawing.Point(127, 86);
            this.LblOut.Name = "LblOut";
            this.LblOut.Size = new System.Drawing.Size(749, 50);
            this.LblOut.TabIndex = 4;
            // 
            // BtnDecrypt
            // 
            this.BtnDecrypt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDecrypt.Location = new System.Drawing.Point(707, 25);
            this.BtnDecrypt.Name = "BtnDecrypt";
            this.BtnDecrypt.Size = new System.Drawing.Size(169, 40);
            this.BtnDecrypt.TabIndex = 5;
            this.BtnDecrypt.Text = "Dešifruj";
            this.BtnDecrypt.UseVisualStyleBackColor = true;
            this.BtnDecrypt.Click += new System.EventHandler(this.BtnDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 166);
            this.Controls.Add(this.BtnDecrypt);
            this.Controls.Add(this.LblOut);
            this.Controls.Add(this.NumMove);
            this.Controls.Add(this.TxtInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEncrypt);
            this.Name = "Form1";
            this.Text = "Ceasarova šifra";
            ((System.ComponentModel.ISupportInitialize)(this.NumMove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnEncrypt;
        private Label label1;
        private TextBox TxtInput;
        private NumericUpDown NumMove;
        private Label LblOut;
        private Button BtnDecrypt;
    }
}