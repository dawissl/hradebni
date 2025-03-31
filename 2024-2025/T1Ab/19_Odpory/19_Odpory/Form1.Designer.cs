namespace _19_Odpory
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
            TxtPocet = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TxtMinR = new TextBox();
            label3 = new Label();
            TxtMaxR = new TextBox();
            ComboConnection = new ComboBox();
            label4 = new Label();
            BtnVypocet = new Button();
            LblRs = new Label();
            LblResult = new Label();
            SuspendLayout();
            // 
            // TxtPocet
            // 
            TxtPocet.Font = new Font("Segoe UI", 18F);
            TxtPocet.Location = new Point(198, 38);
            TxtPocet.Name = "TxtPocet";
            TxtPocet.Size = new Size(233, 39);
            TxtPocet.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(28, 38);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(72, 32);
            label1.TabIndex = 1;
            label1.Text = "Počet";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(28, 88);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(142, 32);
            label2.TabIndex = 3;
            label2.Text = "Minimální R";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtMinR
            // 
            TxtMinR.Font = new Font("Segoe UI", 18F);
            TxtMinR.Location = new Point(198, 85);
            TxtMinR.Name = "TxtMinR";
            TxtMinR.Size = new Size(233, 39);
            TxtMinR.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(28, 145);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(145, 32);
            label3.TabIndex = 5;
            label3.Text = "Maximální R";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtMaxR
            // 
            TxtMaxR.Font = new Font("Segoe UI", 18F);
            TxtMaxR.Location = new Point(198, 138);
            TxtMaxR.Name = "TxtMaxR";
            TxtMaxR.Size = new Size(233, 39);
            TxtMaxR.TabIndex = 4;
            // 
            // ComboConnection
            // 
            ComboConnection.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ComboConnection.FormattingEnabled = true;
            ComboConnection.Items.AddRange(new object[] { "sériové", "paralelní" });
            ComboConnection.Location = new Point(198, 200);
            ComboConnection.Name = "ComboConnection";
            ComboConnection.Size = new Size(230, 40);
            ComboConnection.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(28, 203);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(107, 32);
            label4.TabIndex = 7;
            label4.Text = "Zapojení";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnVypocet
            // 
            BtnVypocet.Location = new Point(28, 256);
            BtnVypocet.Name = "BtnVypocet";
            BtnVypocet.Size = new Size(400, 53);
            BtnVypocet.TabIndex = 8;
            BtnVypocet.Text = "Výpočet";
            BtnVypocet.UseVisualStyleBackColor = true;
            BtnVypocet.Click += BtnVypocet_Click;
            // 
            // LblRs
            // 
            LblRs.BorderStyle = BorderStyle.FixedSingle;
            LblRs.Font = new Font("Segoe UI", 18F);
            LblRs.Location = new Point(28, 326);
            LblRs.Name = "LblRs";
            LblRs.RightToLeft = RightToLeft.No;
            LblRs.Size = new Size(400, 32);
            LblRs.TabIndex = 9;
            LblRs.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblResult
            // 
            LblResult.BorderStyle = BorderStyle.FixedSingle;
            LblResult.Font = new Font("Segoe UI", 18F);
            LblResult.Location = new Point(28, 384);
            LblResult.Name = "LblResult";
            LblResult.RightToLeft = RightToLeft.No;
            LblResult.Size = new Size(400, 32);
            LblResult.TabIndex = 10;
            LblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 450);
            Controls.Add(LblResult);
            Controls.Add(LblRs);
            Controls.Add(BtnVypocet);
            Controls.Add(label4);
            Controls.Add(ComboConnection);
            Controls.Add(label3);
            Controls.Add(TxtMaxR);
            Controls.Add(label2);
            Controls.Add(TxtMinR);
            Controls.Add(label1);
            Controls.Add(TxtPocet);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtPocet;
        private Label label1;
        private Label label2;
        private TextBox TxtMinR;
        private Label label3;
        private TextBox TxtMaxR;
        private ComboBox ComboConnection;
        private Label label4;
        private Button BtnVypocet;
        private Label LblRs;
        private Label LblResult;
    }
}
