namespace _23_FutsalovyTym
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
            this.TxtDefault = new System.Windows.Forms.TextBox();
            this.TxtSorted = new System.Windows.Forms.TextBox();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.Rad131 = new System.Windows.Forms.RadioButton();
            this.Rad311 = new System.Windows.Forms.RadioButton();
            this.Rad221 = new System.Windows.Forms.RadioButton();
            this.BtnSquad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtDefault
            // 
            this.TxtDefault.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDefault.Location = new System.Drawing.Point(21, 24);
            this.TxtDefault.Multiline = true;
            this.TxtDefault.Name = "TxtDefault";
            this.TxtDefault.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDefault.Size = new System.Drawing.Size(383, 405);
            this.TxtDefault.TabIndex = 0;
            // 
            // TxtSorted
            // 
            this.TxtSorted.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSorted.Location = new System.Drawing.Point(445, 24);
            this.TxtSorted.Multiline = true;
            this.TxtSorted.Name = "TxtSorted";
            this.TxtSorted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtSorted.Size = new System.Drawing.Size(383, 405);
            this.TxtSorted.TabIndex = 1;
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGenerate.Location = new System.Drawing.Point(860, 32);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(195, 72);
            this.BtnGenerate.TabIndex = 2;
            this.BtnGenerate.Text = "Generuj tým";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // Rad131
            // 
            this.Rad131.AutoSize = true;
            this.Rad131.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Rad131.Location = new System.Drawing.Point(860, 163);
            this.Rad131.Name = "Rad131";
            this.Rad131.Size = new System.Drawing.Size(122, 36);
            this.Rad131.TabIndex = 3;
            this.Rad131.TabStop = true;
            this.Rad131.Text = "1 - 3 - 1";
            this.Rad131.UseVisualStyleBackColor = true;
            // 
            // Rad311
            // 
            this.Rad311.AutoSize = true;
            this.Rad311.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Rad311.Location = new System.Drawing.Point(860, 205);
            this.Rad311.Name = "Rad311";
            this.Rad311.Size = new System.Drawing.Size(122, 36);
            this.Rad311.TabIndex = 4;
            this.Rad311.TabStop = true;
            this.Rad311.Text = "3 - 1 - 1";
            this.Rad311.UseVisualStyleBackColor = true;
            // 
            // Rad221
            // 
            this.Rad221.AutoSize = true;
            this.Rad221.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Rad221.Location = new System.Drawing.Point(860, 247);
            this.Rad221.Name = "Rad221";
            this.Rad221.Size = new System.Drawing.Size(122, 36);
            this.Rad221.TabIndex = 5;
            this.Rad221.TabStop = true;
            this.Rad221.Text = "2 - 2 - 1";
            this.Rad221.UseVisualStyleBackColor = true;
            // 
            // BtnSquad
            // 
            this.BtnSquad.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSquad.Location = new System.Drawing.Point(860, 303);
            this.BtnSquad.Name = "BtnSquad";
            this.BtnSquad.Size = new System.Drawing.Size(195, 72);
            this.BtnSquad.TabIndex = 6;
            this.BtnSquad.Text = "Soupiska";
            this.BtnSquad.UseVisualStyleBackColor = true;
            this.BtnSquad.Click += new System.EventHandler(this.BtnSquad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 460);
            this.Controls.Add(this.BtnSquad);
            this.Controls.Add(this.Rad221);
            this.Controls.Add(this.Rad311);
            this.Controls.Add(this.Rad131);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.TxtSorted);
            this.Controls.Add(this.TxtDefault);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtDefault;
        private TextBox TxtSorted;
        private Button BtnGenerate;
        private RadioButton Rad131;
        private RadioButton Rad311;
        private RadioButton Rad221;
        private Button BtnSquad;
    }
}