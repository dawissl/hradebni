namespace _05_KnihaJizd
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
            this.BtnReadFile = new System.Windows.Forms.Button();
            this.TxtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblDriver = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblMachine = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblSPZ = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblGood = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ButtonLeft = new System.Windows.Forms.Button();
            this.BtnRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnReadFile
            // 
            this.BtnReadFile.Location = new System.Drawing.Point(356, 35);
            this.BtnReadFile.Name = "BtnReadFile";
            this.BtnReadFile.Size = new System.Drawing.Size(166, 23);
            this.BtnReadFile.TabIndex = 0;
            this.BtnReadFile.Text = "Načti soubor";
            this.BtnReadFile.UseVisualStyleBackColor = true;
            this.BtnReadFile.Click += new System.EventHandler(this.BtnReadFile_Click_1);
            // 
            // TxtFileName
            // 
            this.TxtFileName.Location = new System.Drawing.Point(120, 35);
            this.TxtFileName.Name = "TxtFileName";
            this.TxtFileName.Size = new System.Drawing.Size(197, 23);
            this.TxtFileName.TabIndex = 2;
            this.TxtFileName.Text = "jizdy.csv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datum";
            // 
            // LblDate
            // 
            this.LblDate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblDate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDate.Location = new System.Drawing.Point(126, 89);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(191, 32);
            this.LblDate.TabIndex = 4;
            // 
            // LblDriver
            // 
            this.LblDriver.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LblDriver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblDriver.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDriver.Location = new System.Drawing.Point(126, 138);
            this.LblDriver.Name = "LblDriver";
            this.LblDriver.Size = new System.Drawing.Size(191, 32);
            this.LblDriver.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Řidič";
            // 
            // LblMachine
            // 
            this.LblMachine.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LblMachine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMachine.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblMachine.Location = new System.Drawing.Point(126, 183);
            this.LblMachine.Name = "LblMachine";
            this.LblMachine.Size = new System.Drawing.Size(191, 32);
            this.LblMachine.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(29, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Stroj";
            // 
            // LblSPZ
            // 
            this.LblSPZ.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LblSPZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblSPZ.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblSPZ.Location = new System.Drawing.Point(126, 233);
            this.LblSPZ.Name = "LblSPZ";
            this.LblSPZ.Size = new System.Drawing.Size(191, 32);
            this.LblSPZ.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(29, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 32);
            this.label7.TabIndex = 9;
            this.label7.Text = "SPZ";
            // 
            // LblGood
            // 
            this.LblGood.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LblGood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblGood.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblGood.Location = new System.Drawing.Point(126, 280);
            this.LblGood.Name = "LblGood";
            this.LblGood.Size = new System.Drawing.Size(191, 32);
            this.LblGood.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(29, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 32);
            this.label9.TabIndex = 11;
            this.label9.Text = "Náklad";
            // 
            // ButtonLeft
            // 
            this.ButtonLeft.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonLeft.Location = new System.Drawing.Point(29, 340);
            this.ButtonLeft.Name = "ButtonLeft";
            this.ButtonLeft.Size = new System.Drawing.Size(169, 33);
            this.ButtonLeft.TabIndex = 13;
            this.ButtonLeft.Text = "předchozí";
            this.ButtonLeft.UseVisualStyleBackColor = true;
            this.ButtonLeft.Click += new System.EventHandler(this.ButtonLeft_Click);
            // 
            // BtnRight
            // 
            this.BtnRight.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRight.Location = new System.Drawing.Point(204, 340);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(169, 33);
            this.BtnRight.TabIndex = 14;
            this.BtnRight.Text = "následující";
            this.BtnRight.UseVisualStyleBackColor = true;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 385);
            this.Controls.Add(this.BtnRight);
            this.Controls.Add(this.ButtonLeft);
            this.Controls.Add(this.LblGood);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LblSPZ);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblMachine);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblDriver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtFileName);
            this.Controls.Add(this.BtnReadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Button BtnReadFile;
        private TextBox TxtFileName;
        private Label label1;
        private Label LblDate;
        private Label LblDriver;
        private Label label3;
        private Label LblMachine;
        private Label label5;
        private Label LblSPZ;
        private Label label7;
        private Label LblGood;
        private Label label9;
        private Button ButtonLeft;
        private Button BtnRight;
    }
}