namespace _04_ElektronickeVolby
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
            this.RadioCandX = new System.Windows.Forms.RadioButton();
            this.RadioCandY = new System.Windows.Forms.RadioButton();
            this.RadioCandZ = new System.Windows.Forms.RadioButton();
            this.BtnVote = new System.Windows.Forms.Button();
            this.TimerVoter = new System.Windows.Forms.Timer(this.components);
            this.BtnRandomVote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PanelResult
            // 
            this.PanelResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PanelResult.Location = new System.Drawing.Point(22, 12);
            this.PanelResult.Name = "PanelResult";
            this.PanelResult.Size = new System.Drawing.Size(366, 424);
            this.PanelResult.TabIndex = 0;
            this.PanelResult.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelResult_Paint);
            // 
            // RadioCandX
            // 
            this.RadioCandX.AutoSize = true;
            this.RadioCandX.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RadioCandX.Location = new System.Drawing.Point(478, 46);
            this.RadioCandX.Name = "RadioCandX";
            this.RadioCandX.Size = new System.Drawing.Size(140, 34);
            this.RadioCandX.TabIndex = 1;
            this.RadioCandX.TabStop = true;
            this.RadioCandX.Text = "Kandidát X";
            this.RadioCandX.UseVisualStyleBackColor = true;
            // 
            // RadioCandY
            // 
            this.RadioCandY.AutoSize = true;
            this.RadioCandY.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RadioCandY.Location = new System.Drawing.Point(478, 86);
            this.RadioCandY.Name = "RadioCandY";
            this.RadioCandY.Size = new System.Drawing.Size(139, 34);
            this.RadioCandY.TabIndex = 2;
            this.RadioCandY.TabStop = true;
            this.RadioCandY.Text = "Kandidát Y";
            this.RadioCandY.UseVisualStyleBackColor = true;
            // 
            // RadioCandZ
            // 
            this.RadioCandZ.AutoSize = true;
            this.RadioCandZ.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RadioCandZ.Location = new System.Drawing.Point(478, 136);
            this.RadioCandZ.Name = "RadioCandZ";
            this.RadioCandZ.Size = new System.Drawing.Size(139, 34);
            this.RadioCandZ.TabIndex = 3;
            this.RadioCandZ.TabStop = true;
            this.RadioCandZ.Text = "Kandidát Z";
            this.RadioCandZ.UseVisualStyleBackColor = true;
            // 
            // BtnVote
            // 
            this.BtnVote.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnVote.Location = new System.Drawing.Point(450, 186);
            this.BtnVote.Name = "BtnVote";
            this.BtnVote.Size = new System.Drawing.Size(177, 72);
            this.BtnVote.TabIndex = 4;
            this.BtnVote.Text = "Hlasuj";
            this.BtnVote.UseVisualStyleBackColor = true;
            this.BtnVote.Click += new System.EventHandler(this.BtnVote_Click);
            // 
            // TimerVoter
            // 
            this.TimerVoter.Tick += new System.EventHandler(this.TimerVoter_Tick);
            // 
            // BtnRandomVote
            // 
            this.BtnRandomVote.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRandomVote.Location = new System.Drawing.Point(450, 278);
            this.BtnRandomVote.Name = "BtnRandomVote";
            this.BtnRandomVote.Size = new System.Drawing.Size(177, 72);
            this.BtnRandomVote.TabIndex = 5;
            this.BtnRandomVote.Text = "Náhodné volby";
            this.BtnRandomVote.UseVisualStyleBackColor = true;
            this.BtnRandomVote.Click += new System.EventHandler(this.BtnRandomVote_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.BtnRandomVote);
            this.Controls.Add(this.BtnVote);
            this.Controls.Add(this.RadioCandZ);
            this.Controls.Add(this.RadioCandY);
            this.Controls.Add(this.RadioCandX);
            this.Controls.Add(this.PanelResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel PanelResult;
        private RadioButton RadioCandX;
        private RadioButton RadioCandY;
        private RadioButton RadioCandZ;
        private Button BtnVote;
        private System.Windows.Forms.Timer TimerVoter;
        private Button BtnRandomVote;
    }
}