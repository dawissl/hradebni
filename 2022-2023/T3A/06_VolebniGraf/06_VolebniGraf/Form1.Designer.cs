namespace _06_VolebniGraf
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
            this.BtnVote = new System.Windows.Forms.Button();
            this.RadCandidateX = new System.Windows.Forms.RadioButton();
            this.RadCandidateY = new System.Windows.Forms.RadioButton();
            this.RadCandidateZ = new System.Windows.Forms.RadioButton();
            this.BtnRandomVote = new System.Windows.Forms.Button();
            this.TimeToVote = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PanelResult
            // 
            this.PanelResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PanelResult.Location = new System.Drawing.Point(29, 22);
            this.PanelResult.Name = "PanelResult";
            this.PanelResult.Size = new System.Drawing.Size(400, 500);
            this.PanelResult.TabIndex = 0;
            this.PanelResult.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelResult_Paint);
            // 
            // BtnVote
            // 
            this.BtnVote.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnVote.Location = new System.Drawing.Point(465, 189);
            this.BtnVote.Name = "BtnVote";
            this.BtnVote.Size = new System.Drawing.Size(216, 79);
            this.BtnVote.TabIndex = 1;
            this.BtnVote.Text = "Hlasuj";
            this.BtnVote.UseVisualStyleBackColor = true;
            this.BtnVote.Click += new System.EventHandler(this.BtnVote_Click);
            // 
            // RadCandidateX
            // 
            this.RadCandidateX.AutoSize = true;
            this.RadCandidateX.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RadCandidateX.Location = new System.Drawing.Point(503, 35);
            this.RadCandidateX.Name = "RadCandidateX";
            this.RadCandidateX.Size = new System.Drawing.Size(124, 29);
            this.RadCandidateX.TabIndex = 2;
            this.RadCandidateX.TabStop = true;
            this.RadCandidateX.Text = "Kandidát X";
            this.RadCandidateX.UseVisualStyleBackColor = true;
            // 
            // RadCandidateY
            // 
            this.RadCandidateY.AutoSize = true;
            this.RadCandidateY.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RadCandidateY.Location = new System.Drawing.Point(503, 82);
            this.RadCandidateY.Name = "RadCandidateY";
            this.RadCandidateY.Size = new System.Drawing.Size(123, 29);
            this.RadCandidateY.TabIndex = 3;
            this.RadCandidateY.TabStop = true;
            this.RadCandidateY.Text = "Kandidát Y";
            this.RadCandidateY.UseVisualStyleBackColor = true;
            // 
            // RadCandidateZ
            // 
            this.RadCandidateZ.AutoSize = true;
            this.RadCandidateZ.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RadCandidateZ.Location = new System.Drawing.Point(503, 128);
            this.RadCandidateZ.Name = "RadCandidateZ";
            this.RadCandidateZ.Size = new System.Drawing.Size(123, 29);
            this.RadCandidateZ.TabIndex = 4;
            this.RadCandidateZ.TabStop = true;
            this.RadCandidateZ.Text = "Kandidát Z";
            this.RadCandidateZ.UseVisualStyleBackColor = true;
            // 
            // BtnRandomVote
            // 
            this.BtnRandomVote.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRandomVote.Location = new System.Drawing.Point(465, 295);
            this.BtnRandomVote.Name = "BtnRandomVote";
            this.BtnRandomVote.Size = new System.Drawing.Size(216, 79);
            this.BtnRandomVote.TabIndex = 5;
            this.BtnRandomVote.Text = "Náhodné volby";
            this.BtnRandomVote.UseVisualStyleBackColor = true;
            this.BtnRandomVote.Click += new System.EventHandler(this.BtnRandomVote_Click);
            // 
            // TimeToVote
            // 
            this.TimeToVote.Interval = 200;
            this.TimeToVote.Tick += new System.EventHandler(this.TimeToVote_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 549);
            this.Controls.Add(this.BtnRandomVote);
            this.Controls.Add(this.RadCandidateZ);
            this.Controls.Add(this.RadCandidateY);
            this.Controls.Add(this.RadCandidateX);
            this.Controls.Add(this.BtnVote);
            this.Controls.Add(this.PanelResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel PanelResult;
        private Button BtnVote;
        private RadioButton RadCandidateX;
        private RadioButton RadCandidateY;
        private RadioButton RadCandidateZ;
        private Button BtnRandomVote;
        private System.Windows.Forms.Timer TimeToVote;
    }
}