namespace _03_MotoGP
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
            this.NumTimeMin = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumRaceLength = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.NumTimeMax = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnRace = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NumXP = new System.Windows.Forms.NumericUpDown();
            this.BtnAddRider = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumTimeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRaceLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTimeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumXP)).BeginInit();
            this.SuspendLayout();
            // 
            // NumTimeMin
            // 
            this.NumTimeMin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumTimeMin.Location = new System.Drawing.Point(167, 83);
            this.NumTimeMin.Name = "NumTimeMin";
            this.NumTimeMin.Size = new System.Drawing.Size(120, 35);
            this.NumTimeMin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nejrychlejší čas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Počet kol";
            // 
            // NumRaceLength
            // 
            this.NumRaceLength.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumRaceLength.Location = new System.Drawing.Point(167, 40);
            this.NumRaceLength.Name = "NumRaceLength";
            this.NumRaceLength.Size = new System.Drawing.Size(120, 35);
            this.NumRaceLength.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nejpomalejší čas";
            // 
            // NumTimeMax
            // 
            this.NumTimeMax.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumTimeMax.Location = new System.Drawing.Point(167, 127);
            this.NumTimeMax.Name = "NumTimeMax";
            this.NumTimeMax.Size = new System.Drawing.Size(120, 35);
            this.NumTimeMax.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Specifikace závodu";
            // 
            // BtnRace
            // 
            this.BtnRace.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRace.Location = new System.Drawing.Point(17, 173);
            this.BtnRace.Name = "BtnRace";
            this.BtnRace.Size = new System.Drawing.Size(270, 37);
            this.BtnRace.TabIndex = 7;
            this.BtnRace.Text = "Zahájit závod";
            this.BtnRace.UseVisualStyleBackColor = true;
            this.BtnRace.Click += new System.EventHandler(this.BtnRace_Click);
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtName.Location = new System.Drawing.Point(504, 49);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(247, 35);
            this.TxtName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(399, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nový jezdec";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(399, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Jméno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(399, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Startovní číslo";
            // 
            // TxtNumber
            // 
            this.TxtNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNumber.Location = new System.Drawing.Point(534, 90);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(217, 35);
            this.TxtNumber.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(399, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Kvalita";
            // 
            // NumXP
            // 
            this.NumXP.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumXP.Location = new System.Drawing.Point(504, 134);
            this.NumXP.Name = "NumXP";
            this.NumXP.Size = new System.Drawing.Size(247, 35);
            this.NumXP.TabIndex = 15;
            // 
            // BtnAddRider
            // 
            this.BtnAddRider.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddRider.Location = new System.Drawing.Point(399, 175);
            this.BtnAddRider.Name = "BtnAddRider";
            this.BtnAddRider.Size = new System.Drawing.Size(352, 37);
            this.BtnAddRider.TabIndex = 16;
            this.BtnAddRider.Text = "Přidat jezdce";
            this.BtnAddRider.UseVisualStyleBackColor = true;
            this.BtnAddRider.Click += new System.EventHandler(this.BtnAddRider_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(17, 269);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(731, 210);
            this.textBox1.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 32);
            this.label9.TabIndex = 18;
            this.label9.Text = "Výsledek závodu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnAddRider);
            this.Controls.Add(this.NumXP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.BtnRace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumTimeMax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumRaceLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumTimeMin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumTimeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRaceLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTimeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumXP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown NumTimeMin;
        private Label label1;
        private Label label2;
        private NumericUpDown NumRaceLength;
        private Label label3;
        private NumericUpDown NumTimeMax;
        private Label label4;
        private Button BtnRace;
        private TextBox TxtName;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TxtNumber;
        private Label label8;
        private NumericUpDown NumXP;
        private Button BtnAddRider;
        private TextBox textBox1;
        private Label label9;
    }
}