namespace Defense
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
            this.L1 = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            this.L3 = new System.Windows.Forms.Label();
            this.L4 = new System.Windows.Forms.Label();
            this.L5 = new System.Windows.Forms.Label();
            this.BtnFireA = new System.Windows.Forms.Button();
            this.BtnFireB = new System.Windows.Forms.Button();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.RadioEasy = new System.Windows.Forms.RadioButton();
            this.RadioMedium = new System.Windows.Forms.RadioButton();
            this.RadioHard = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelAmmoA = new System.Windows.Forms.Label();
            this.LblAmmoB = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // L1
            // 
            this.L1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.L1.Location = new System.Drawing.Point(49, 39);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(63, 68);
            this.L1.TabIndex = 0;
            this.L1.Text = "-";
            this.L1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L2
            // 
            this.L2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.L2.Location = new System.Drawing.Point(135, 39);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(63, 68);
            this.L2.TabIndex = 1;
            this.L2.Text = "-";
            this.L2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L3
            // 
            this.L3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.L3.Location = new System.Drawing.Point(222, 39);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(63, 68);
            this.L3.TabIndex = 2;
            this.L3.Text = "-";
            this.L3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L4
            // 
            this.L4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.L4.Location = new System.Drawing.Point(308, 39);
            this.L4.Name = "L4";
            this.L4.Size = new System.Drawing.Size(63, 68);
            this.L4.TabIndex = 3;
            this.L4.Text = "-";
            this.L4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L5
            // 
            this.L5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.L5.Location = new System.Drawing.Point(389, 39);
            this.L5.Name = "L5";
            this.L5.Size = new System.Drawing.Size(63, 68);
            this.L5.TabIndex = 4;
            this.L5.Text = "-";
            this.L5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnFireA
            // 
            this.BtnFireA.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnFireA.Location = new System.Drawing.Point(49, 181);
            this.BtnFireA.Name = "BtnFireA";
            this.BtnFireA.Size = new System.Drawing.Size(133, 63);
            this.BtnFireA.TabIndex = 5;
            this.BtnFireA.Text = "střela A";
            this.BtnFireA.UseVisualStyleBackColor = true;
            this.BtnFireA.Click += new System.EventHandler(this.BtnFireA_Click);
            // 
            // BtnFireB
            // 
            this.BtnFireB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnFireB.Location = new System.Drawing.Point(267, 181);
            this.BtnFireB.Name = "BtnFireB";
            this.BtnFireB.Size = new System.Drawing.Size(133, 63);
            this.BtnFireB.TabIndex = 6;
            this.BtnFireB.Text = "střela B";
            this.BtnFireB.UseVisualStyleBackColor = true;
            this.BtnFireB.Click += new System.EventHandler(this.BtnFireB_Click);
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGenerate.Location = new System.Drawing.Point(87, 331);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(275, 53);
            this.BtnGenerate.TabIndex = 7;
            this.BtnGenerate.Text = "Generuj novou hru";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // RadioEasy
            // 
            this.RadioEasy.AutoSize = true;
            this.RadioEasy.Checked = true;
            this.RadioEasy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RadioEasy.Location = new System.Drawing.Point(87, 284);
            this.RadioEasy.Name = "RadioEasy";
            this.RadioEasy.Size = new System.Drawing.Size(77, 29);
            this.RadioEasy.TabIndex = 8;
            this.RadioEasy.TabStop = true;
            this.RadioEasy.Text = "lehká";
            this.RadioEasy.UseVisualStyleBackColor = true;
            // 
            // RadioMedium
            // 
            this.RadioMedium.AutoSize = true;
            this.RadioMedium.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RadioMedium.Location = new System.Drawing.Point(194, 284);
            this.RadioMedium.Name = "RadioMedium";
            this.RadioMedium.Size = new System.Drawing.Size(92, 29);
            this.RadioMedium.TabIndex = 9;
            this.RadioMedium.Text = "střední";
            this.RadioMedium.UseVisualStyleBackColor = true;
            // 
            // RadioHard
            // 
            this.RadioHard.AutoSize = true;
            this.RadioHard.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RadioHard.Location = new System.Drawing.Point(308, 284);
            this.RadioHard.Name = "RadioHard";
            this.RadioHard.Size = new System.Drawing.Size(77, 29);
            this.RadioHard.TabIndex = 10;
            this.RadioHard.Text = "těžká";
            this.RadioHard.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(469, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // LabelAmmoA
            // 
            this.LabelAmmoA.AutoSize = true;
            this.LabelAmmoA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelAmmoA.Location = new System.Drawing.Point(188, 224);
            this.LabelAmmoA.Name = "LabelAmmoA";
            this.LabelAmmoA.Size = new System.Drawing.Size(15, 20);
            this.LabelAmmoA.TabIndex = 12;
            this.LabelAmmoA.Text = "-";
            // 
            // LblAmmoB
            // 
            this.LblAmmoB.AutoSize = true;
            this.LblAmmoB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAmmoB.Location = new System.Drawing.Point(406, 224);
            this.LblAmmoB.Name = "LblAmmoB";
            this.LblAmmoB.Size = new System.Drawing.Size(15, 20);
            this.LblAmmoB.TabIndex = 13;
            this.LblAmmoB.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 450);
            this.Controls.Add(this.LblAmmoB);
            this.Controls.Add(this.LabelAmmoA);
            this.Controls.Add(this.RadioHard);
            this.Controls.Add(this.RadioMedium);
            this.Controls.Add(this.RadioEasy);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.BtnFireB);
            this.Controls.Add(this.BtnFireA);
            this.Controls.Add(this.L5);
            this.Controls.Add(this.L4);
            this.Controls.Add(this.L3);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label L1;
        private Label L2;
        private Label L3;
        private Label L4;
        private Label L5;
        private Button BtnFireA;
        private Button BtnFireB;
        private Button BtnGenerate;
        private RadioButton RadioEasy;
        private RadioButton RadioMedium;
        private RadioButton RadioHard;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label LabelAmmoA;
        private Label LblAmmoB;
    }
}