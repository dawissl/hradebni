namespace _08_Sporeni
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
            this.BtnNewEnvelope = new System.Windows.Forms.Button();
            this.TxtProcenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMoney = new System.Windows.Forms.TextBox();
            this.BtnAddMoney = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LblAmount = new System.Windows.Forms.Label();
            this.LblOut = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnNewEnvelope
            // 
            this.BtnNewEnvelope.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnNewEnvelope.Location = new System.Drawing.Point(454, 44);
            this.BtnNewEnvelope.Name = "BtnNewEnvelope";
            this.BtnNewEnvelope.Size = new System.Drawing.Size(258, 41);
            this.BtnNewEnvelope.TabIndex = 0;
            this.BtnNewEnvelope.Text = "Přidat obálku";
            this.BtnNewEnvelope.UseVisualStyleBackColor = true;
            this.BtnNewEnvelope.Click += new System.EventHandler(this.BtnNewEnvelope_Click);
            // 
            // TxtProcenta
            // 
            this.TxtProcenta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtProcenta.Location = new System.Drawing.Point(178, 24);
            this.TxtProcenta.Name = "TxtProcenta";
            this.TxtProcenta.Size = new System.Drawing.Size(211, 39);
            this.TxtProcenta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(77, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Procenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(77, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Popisek";
            // 
            // TxtNote
            // 
            this.TxtNote.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNote.Location = new System.Drawing.Point(178, 69);
            this.TxtNote.Name = "TxtNote";
            this.TxtNote.Size = new System.Drawing.Size(211, 39);
            this.TxtNote.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(77, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Částka";
            // 
            // TxtMoney
            // 
            this.TxtMoney.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtMoney.Location = new System.Drawing.Point(178, 209);
            this.TxtMoney.Name = "TxtMoney";
            this.TxtMoney.Size = new System.Drawing.Size(211, 39);
            this.TxtMoney.TabIndex = 6;
            // 
            // BtnAddMoney
            // 
            this.BtnAddMoney.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAddMoney.Location = new System.Drawing.Point(454, 207);
            this.BtnAddMoney.Name = "BtnAddMoney";
            this.BtnAddMoney.Size = new System.Drawing.Size(258, 41);
            this.BtnAddMoney.TabIndex = 5;
            this.BtnAddMoney.Text = "Vložit peníze";
            this.BtnAddMoney.UseVisualStyleBackColor = true;
            this.BtnAddMoney.Click += new System.EventHandler(this.BtnAddMoney_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(77, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Suma";
            // 
            // LblAmount
            // 
            this.LblAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAmount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblAmount.Location = new System.Drawing.Point(178, 291);
            this.LblAmount.Name = "LblAmount";
            this.LblAmount.Size = new System.Drawing.Size(211, 30);
            this.LblAmount.TabIndex = 9;
            // 
            // LblOut
            // 
            this.LblOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblOut.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblOut.Location = new System.Drawing.Point(178, 336);
            this.LblOut.Name = "LblOut";
            this.LblOut.Size = new System.Drawing.Size(561, 347);
            this.LblOut.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(31, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "Výpis obálek";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 692);
            this.Controls.Add(this.LblOut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtMoney);
            this.Controls.Add(this.BtnAddMoney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtProcenta);
            this.Controls.Add(this.BtnNewEnvelope);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnNewEnvelope;
        private TextBox TxtProcenta;
        private Label label1;
        private Label label2;
        private TextBox TxtNote;
        private Label label3;
        private TextBox TxtMoney;
        private Button BtnAddMoney;
        private Label label4;
        private Label LblAmount;
        private Label LblOut;
        private Label label6;
    }
}