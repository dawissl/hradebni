namespace _04_VolebniVysledky
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
            this.components = new System.ComponentModel.Container();
            this.PanelResult = new System.Windows.Forms.Panel();
            this.RadioCandidateX = new System.Windows.Forms.RadioButton();
            this.RadioCandidateY = new System.Windows.Forms.RadioButton();
            this.RadioCandidateZ = new System.Windows.Forms.RadioButton();
            this.BtnVote = new System.Windows.Forms.Button();
            this.BtnRandom = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PanelResult
            // 
            this.PanelResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PanelResult.Location = new System.Drawing.Point(38, 34);
            this.PanelResult.Name = "PanelResult";
            this.PanelResult.Size = new System.Drawing.Size(400, 500);
            this.PanelResult.TabIndex = 0;
            this.PanelResult.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelResult_Paint);
            // 
            // RadioCandidateX
            // 
            this.RadioCandidateX.AutoSize = true;
            this.RadioCandidateX.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RadioCandidateX.Location = new System.Drawing.Point(487, 47);
            this.RadioCandidateX.Name = "RadioCandidateX";
            this.RadioCandidateX.Size = new System.Drawing.Size(158, 36);
            this.RadioCandidateX.TabIndex = 1;
            this.RadioCandidateX.TabStop = true;
            this.RadioCandidateX.Text = "Kandidát X";
            this.RadioCandidateX.UseVisualStyleBackColor = true;
            // 
            // RadioCandidateY
            // 
            this.RadioCandidateY.AutoSize = true;
            this.RadioCandidateY.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RadioCandidateY.Location = new System.Drawing.Point(487, 105);
            this.RadioCandidateY.Name = "RadioCandidateY";
            this.RadioCandidateY.Size = new System.Drawing.Size(157, 36);
            this.RadioCandidateY.TabIndex = 2;
            this.RadioCandidateY.TabStop = true;
            this.RadioCandidateY.Text = "Kandidát Y";
            this.RadioCandidateY.UseVisualStyleBackColor = true;
            // 
            // RadioCandidateZ
            // 
            this.RadioCandidateZ.AutoSize = true;
            this.RadioCandidateZ.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RadioCandidateZ.Location = new System.Drawing.Point(487, 162);
            this.RadioCandidateZ.Name = "RadioCandidateZ";
            this.RadioCandidateZ.Size = new System.Drawing.Size(157, 36);
            this.RadioCandidateZ.TabIndex = 3;
            this.RadioCandidateZ.TabStop = true;
            this.RadioCandidateZ.Text = "Kandidát Z";
            this.RadioCandidateZ.UseVisualStyleBackColor = true;
            // 
            // BtnVote
            // 
            this.BtnVote.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnVote.Location = new System.Drawing.Point(487, 231);
            this.BtnVote.Name = "BtnVote";
            this.BtnVote.Size = new System.Drawing.Size(185, 97);
            this.BtnVote.TabIndex = 4;
            this.BtnVote.Text = "Hlasuj!";
            this.BtnVote.UseVisualStyleBackColor = true;
            this.BtnVote.Click += new System.EventHandler(this.BtnVote_Click);
            // 
            // BtnRandom
            // 
            this.BtnRandom.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRandom.Location = new System.Drawing.Point(487, 370);
            this.BtnRandom.Name = "BtnRandom";
            this.BtnRandom.Size = new System.Drawing.Size(185, 97);
            this.BtnRandom.TabIndex = 5;
            this.BtnRandom.Text = "Náhodné volby";
            this.BtnRandom.UseVisualStyleBackColor = true;
            this.BtnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.BtnRandom);
            this.Controls.Add(this.BtnVote);
            this.Controls.Add(this.RadioCandidateZ);
            this.Controls.Add(this.RadioCandidateY);
            this.Controls.Add(this.RadioCandidateX);
            this.Controls.Add(this.PanelResult);
            this.Name = "Form1";
            this.Text = "Volební výsledky";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel PanelResult;
        private RadioButton RadioCandidateX;
        private RadioButton RadioCandidateY;
        private RadioButton RadioCandidateZ;
        private Button BtnVote;
        private Button BtnRandom;
        private System.Windows.Forms.Timer timer1;
    }
}