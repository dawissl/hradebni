namespace _16_Trezor
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
            LblPassword = new Label();
            RadFirst = new RadioButton();
            RadSecond = new RadioButton();
            RadThird = new RadioButton();
            RadFourth = new RadioButton();
            NumEnter = new NumericUpDown();
            LblStatus = new Label();
            BtnInsert = new Button();
            BtnOpen = new Button();
            BtnClose = new Button();
            BtnSetNew = new Button();
            ((System.ComponentModel.ISupportInitialize)NumEnter).BeginInit();
            SuspendLayout();
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblPassword.Location = new Point(45, 35);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(154, 47);
            LblPassword.TabIndex = 0;
            LblPassword.Text = "X-X-X-X";
            // 
            // RadFirst
            // 
            RadFirst.AutoSize = true;
            RadFirst.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            RadFirst.Location = new Point(34, 112);
            RadFirst.Name = "RadFirst";
            RadFirst.Size = new Size(51, 29);
            RadFirst.TabIndex = 1;
            RadFirst.TabStop = true;
            RadFirst.Text = "#1";
            RadFirst.UseVisualStyleBackColor = true;
            // 
            // RadSecond
            // 
            RadSecond.AutoSize = true;
            RadSecond.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            RadSecond.Location = new Point(91, 112);
            RadSecond.Name = "RadSecond";
            RadSecond.Size = new Size(51, 29);
            RadSecond.TabIndex = 2;
            RadSecond.TabStop = true;
            RadSecond.Text = "#2";
            RadSecond.UseVisualStyleBackColor = true;
            // 
            // RadThird
            // 
            RadThird.AutoSize = true;
            RadThird.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            RadThird.Location = new Point(148, 112);
            RadThird.Name = "RadThird";
            RadThird.Size = new Size(51, 29);
            RadThird.TabIndex = 3;
            RadThird.TabStop = true;
            RadThird.Text = "#3";
            RadThird.UseVisualStyleBackColor = true;
            // 
            // RadFourth
            // 
            RadFourth.AutoSize = true;
            RadFourth.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            RadFourth.Location = new Point(205, 112);
            RadFourth.Name = "RadFourth";
            RadFourth.Size = new Size(51, 29);
            RadFourth.TabIndex = 4;
            RadFourth.TabStop = true;
            RadFourth.Text = "#4";
            RadFourth.UseVisualStyleBackColor = true;
            // 
            // NumEnter
            // 
            NumEnter.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NumEnter.Location = new Point(45, 164);
            NumEnter.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            NumEnter.Name = "NumEnter";
            NumEnter.Size = new Size(112, 39);
            NumEnter.TabIndex = 5;
            NumEnter.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // LblStatus
            // 
            LblStatus.BackColor = Color.Red;
            LblStatus.BorderStyle = BorderStyle.Fixed3D;
            LblStatus.Location = new Point(219, 34);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(50, 48);
            LblStatus.TabIndex = 6;
            // 
            // BtnInsert
            // 
            BtnInsert.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnInsert.Location = new Point(175, 164);
            BtnInsert.Name = "BtnInsert";
            BtnInsert.Size = new Size(94, 39);
            BtnInsert.TabIndex = 7;
            BtnInsert.Text = "Vložit";
            BtnInsert.UseVisualStyleBackColor = true;
            BtnInsert.Click += BtnInsert_Click;
            // 
            // BtnOpen
            // 
            BtnOpen.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnOpen.Location = new Point(45, 225);
            BtnOpen.Name = "BtnOpen";
            BtnOpen.Size = new Size(94, 39);
            BtnOpen.TabIndex = 8;
            BtnOpen.Text = "Otevřít";
            BtnOpen.UseVisualStyleBackColor = true;
            BtnOpen.Click += BtnOpen_Click;
            // 
            // BtnClose
            // 
            BtnClose.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnClose.Location = new Point(175, 225);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(94, 39);
            BtnClose.TabIndex = 9;
            BtnClose.Text = "Zavřít";
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // BtnSetNew
            // 
            BtnSetNew.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSetNew.Location = new Point(45, 288);
            BtnSetNew.Name = "BtnSetNew";
            BtnSetNew.Size = new Size(224, 39);
            BtnSetNew.TabIndex = 10;
            BtnSetNew.Text = "Vložit heslo";
            BtnSetNew.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 363);
            Controls.Add(BtnSetNew);
            Controls.Add(BtnClose);
            Controls.Add(BtnOpen);
            Controls.Add(BtnInsert);
            Controls.Add(LblStatus);
            Controls.Add(NumEnter);
            Controls.Add(RadFourth);
            Controls.Add(RadThird);
            Controls.Add(RadSecond);
            Controls.Add(RadFirst);
            Controls.Add(LblPassword);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumEnter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblPassword;
        private RadioButton RadFirst;
        private RadioButton RadSecond;
        private RadioButton RadThird;
        private RadioButton RadFourth;
        private NumericUpDown NumEnter;
        private Label LblStatus;
        private Button BtnInsert;
        private Button BtnOpen;
        private Button BtnClose;
        private Button BtnSetNew;
    }
}