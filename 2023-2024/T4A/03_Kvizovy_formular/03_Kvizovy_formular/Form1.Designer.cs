namespace _03_Kvizovy_formular
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
            components = new System.ComponentModel.Container();
            TimerQuiz = new System.Windows.Forms.Timer(components);
            LblTime = new Label();
            GroupQ1 = new GroupBox();
            RadioQ1C = new RadioButton();
            RadioQ1B = new RadioButton();
            RadioQ1A = new RadioButton();
            GroupQ2 = new GroupBox();
            RadioQ2C = new RadioButton();
            RadioQ2B = new RadioButton();
            RadioQ2A = new RadioButton();
            ProgressFill = new ProgressBar();
            TimerProgress = new System.Windows.Forms.Timer(components);
            groupBox1 = new GroupBox();
            RadioQ3C = new RadioButton();
            RadioQ3B = new RadioButton();
            RadioQ3A = new RadioButton();
            GroupQ1.SuspendLayout();
            GroupQ2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // TimerQuiz
            // 
            TimerQuiz.Enabled = true;
            TimerQuiz.Interval = 1000;
            TimerQuiz.Tick += TimerQuiz_Tick;
            // 
            // LblTime
            // 
            LblTime.BorderStyle = BorderStyle.Fixed3D;
            LblTime.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblTime.ForeColor = Color.Red;
            LblTime.Location = new Point(12, 9);
            LblTime.Name = "LblTime";
            LblTime.Size = new Size(276, 50);
            LblTime.TabIndex = 0;
            LblTime.Text = "Zbývající čas:";
            // 
            // GroupQ1
            // 
            GroupQ1.BackColor = SystemColors.ActiveCaption;
            GroupQ1.Controls.Add(RadioQ1C);
            GroupQ1.Controls.Add(RadioQ1B);
            GroupQ1.Controls.Add(RadioQ1A);
            GroupQ1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            GroupQ1.Location = new Point(12, 72);
            GroupQ1.Name = "GroupQ1";
            GroupQ1.Size = new Size(453, 100);
            GroupQ1.TabIndex = 1;
            GroupQ1.TabStop = false;
            GroupQ1.Text = "Otázka 1 - Jaký je dnes den v týdnu?";
            // 
            // RadioQ1C
            // 
            RadioQ1C.AutoSize = true;
            RadioQ1C.Location = new Point(220, 46);
            RadioQ1C.Name = "RadioQ1C";
            RadioQ1C.Size = new Size(89, 29);
            RadioQ1C.TabIndex = 2;
            RadioQ1C.TabStop = true;
            RadioQ1C.Text = "Čtvrtek";
            RadioQ1C.UseVisualStyleBackColor = true;
            // 
            // RadioQ1B
            // 
            RadioQ1B.AutoSize = true;
            RadioQ1B.Location = new Point(112, 46);
            RadioQ1B.Name = "RadioQ1B";
            RadioQ1B.Size = new Size(83, 29);
            RadioQ1B.TabIndex = 1;
            RadioQ1B.TabStop = true;
            RadioQ1B.Text = "Středa";
            RadioQ1B.UseVisualStyleBackColor = true;
            // 
            // RadioQ1A
            // 
            RadioQ1A.AutoSize = true;
            RadioQ1A.Location = new Point(22, 46);
            RadioQ1A.Name = "RadioQ1A";
            RadioQ1A.Size = new Size(75, 29);
            RadioQ1A.TabIndex = 0;
            RadioQ1A.TabStop = true;
            RadioQ1A.Text = "Úterý";
            RadioQ1A.UseVisualStyleBackColor = true;
            // 
            // GroupQ2
            // 
            GroupQ2.BackColor = SystemColors.ActiveCaption;
            GroupQ2.Controls.Add(RadioQ2C);
            GroupQ2.Controls.Add(RadioQ2B);
            GroupQ2.Controls.Add(RadioQ2A);
            GroupQ2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            GroupQ2.Location = new Point(12, 188);
            GroupQ2.Name = "GroupQ2";
            GroupQ2.Size = new Size(453, 100);
            GroupQ2.TabIndex = 3;
            GroupQ2.TabStop = false;
            GroupQ2.Text = "Otázka 2 - Která barva se nenachází na vlajce ČR";
            // 
            // RadioQ2C
            // 
            RadioQ2C.AutoSize = true;
            RadioQ2C.Location = new Point(220, 46);
            RadioQ2C.Name = "RadioQ2C";
            RadioQ2C.Size = new Size(99, 29);
            RadioQ2C.TabIndex = 2;
            RadioQ2C.TabStop = true;
            RadioQ2C.Text = "Červená";
            RadioQ2C.UseVisualStyleBackColor = true;
            // 
            // RadioQ2B
            // 
            RadioQ2B.AutoSize = true;
            RadioQ2B.Location = new Point(112, 46);
            RadioQ2B.Name = "RadioQ2B";
            RadioQ2B.Size = new Size(86, 29);
            RadioQ2B.TabIndex = 1;
            RadioQ2B.TabStop = true;
            RadioQ2B.Text = "Modrá";
            RadioQ2B.UseVisualStyleBackColor = true;
            // 
            // RadioQ2A
            // 
            RadioQ2A.AutoSize = true;
            RadioQ2A.Location = new Point(22, 46);
            RadioQ2A.Name = "RadioQ2A";
            RadioQ2A.Size = new Size(73, 29);
            RadioQ2A.TabIndex = 0;
            RadioQ2A.TabStop = true;
            RadioQ2A.Text = "Žlutá";
            RadioQ2A.UseVisualStyleBackColor = true;
            // 
            // ProgressFill
            // 
            ProgressFill.ForeColor = Color.FromArgb(255, 128, 0);
            ProgressFill.Location = new Point(302, 9);
            ProgressFill.Name = "ProgressFill";
            ProgressFill.Size = new Size(479, 49);
            ProgressFill.Step = 1;
            ProgressFill.TabIndex = 4;
            // 
            // TimerProgress
            // 
            TimerProgress.Enabled = true;
            TimerProgress.Tick += TimerProgress_Tick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(RadioQ3C);
            groupBox1.Controls.Add(RadioQ3B);
            groupBox1.Controls.Add(RadioQ3A);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 307);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(453, 100);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Otázka 2 - Která barva se nenachází na vlajce ČR";
            // 
            // RadioQ3C
            // 
            RadioQ3C.AutoSize = true;
            RadioQ3C.Location = new Point(220, 46);
            RadioQ3C.Name = "RadioQ3C";
            RadioQ3C.Size = new Size(99, 29);
            RadioQ3C.TabIndex = 2;
            RadioQ3C.TabStop = true;
            RadioQ3C.Text = "Červená";
            RadioQ3C.UseVisualStyleBackColor = true;
            // 
            // RadioQ3B
            // 
            RadioQ3B.AutoSize = true;
            RadioQ3B.Location = new Point(112, 46);
            RadioQ3B.Name = "RadioQ3B";
            RadioQ3B.Size = new Size(86, 29);
            RadioQ3B.TabIndex = 1;
            RadioQ3B.TabStop = true;
            RadioQ3B.Text = "Modrá";
            RadioQ3B.UseVisualStyleBackColor = true;
            // 
            // RadioQ3A
            // 
            RadioQ3A.AutoSize = true;
            RadioQ3A.Location = new Point(22, 46);
            RadioQ3A.Name = "RadioQ3A";
            RadioQ3A.Size = new Size(73, 29);
            RadioQ3A.TabIndex = 0;
            RadioQ3A.TabStop = true;
            RadioQ3A.Text = "Žlutá";
            RadioQ3A.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(ProgressFill);
            Controls.Add(GroupQ2);
            Controls.Add(GroupQ1);
            Controls.Add(LblTime);
            Name = "Form1";
            Text = "Form1";
            GroupQ1.ResumeLayout(false);
            GroupQ1.PerformLayout();
            GroupQ2.ResumeLayout(false);
            GroupQ2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer TimerQuiz;
        private Label LblTime;
        private GroupBox GroupQ1;
        private RadioButton RadioQ1C;
        private RadioButton RadioQ1B;
        private RadioButton RadioQ1A;
        private GroupBox GroupQ2;
        private RadioButton RadioQ2C;
        private RadioButton RadioQ2B;
        private RadioButton RadioQ2A;
        private ProgressBar ProgressFill;
        private System.Windows.Forms.Timer TimerProgress;
        private GroupBox groupBox1;
        private RadioButton RadioQ3C;
        private RadioButton RadioQ3B;
        private RadioButton RadioQ3A;
    }
}