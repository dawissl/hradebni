namespace _05_MortalKombat
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
            this.ComboPlayerOne = new System.Windows.Forms.ComboBox();
            this.ComboPlayerTwo = new System.Windows.Forms.ComboBox();
            this.BtnFight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtLog = new System.Windows.Forms.TextBox();
            this.BtnAddPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboPlayerOne
            // 
            this.ComboPlayerOne.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ComboPlayerOne.FormattingEnabled = true;
            this.ComboPlayerOne.Location = new System.Drawing.Point(45, 29);
            this.ComboPlayerOne.Name = "ComboPlayerOne";
            this.ComboPlayerOne.Size = new System.Drawing.Size(229, 40);
            this.ComboPlayerOne.TabIndex = 0;
            // 
            // ComboPlayerTwo
            // 
            this.ComboPlayerTwo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ComboPlayerTwo.FormattingEnabled = true;
            this.ComboPlayerTwo.Location = new System.Drawing.Point(301, 29);
            this.ComboPlayerTwo.Name = "ComboPlayerTwo";
            this.ComboPlayerTwo.Size = new System.Drawing.Size(229, 40);
            this.ComboPlayerTwo.TabIndex = 1;
            // 
            // BtnFight
            // 
            this.BtnFight.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnFight.Location = new System.Drawing.Point(113, 75);
            this.BtnFight.Name = "BtnFight";
            this.BtnFight.Size = new System.Drawing.Size(161, 38);
            this.BtnFight.TabIndex = 2;
            this.BtnFight.Text = "Souboj";
            this.BtnFight.UseVisualStyleBackColor = true;
            this.BtnFight.Click += new System.EventHandler(this.BtnFight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Soubojový záznam";
            // 
            // TxtLog
            // 
            this.TxtLog.Location = new System.Drawing.Point(12, 167);
            this.TxtLog.Multiline = true;
            this.TxtLog.Name = "TxtLog";
            this.TxtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtLog.Size = new System.Drawing.Size(373, 584);
            this.TxtLog.TabIndex = 5;
            // 
            // BtnAddPlayer
            // 
            this.BtnAddPlayer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAddPlayer.Location = new System.Drawing.Point(329, 75);
            this.BtnAddPlayer.Name = "BtnAddPlayer";
            this.BtnAddPlayer.Size = new System.Drawing.Size(161, 38);
            this.BtnAddPlayer.TabIndex = 6;
            this.BtnAddPlayer.Text = "Nový hráč";
            this.BtnAddPlayer.UseVisualStyleBackColor = true;
            this.BtnAddPlayer.Click += new System.EventHandler(this.BtnAddPlayer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 780);
            this.Controls.Add(this.BtnAddPlayer);
            this.Controls.Add(this.TxtLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFight);
            this.Controls.Add(this.ComboPlayerTwo);
            this.Controls.Add(this.ComboPlayerOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox ComboPlayerOne;
        private ComboBox ComboPlayerTwo;
        private Button BtnFight;
        private Label label1;
        private TextBox TxtLog;
        private Button BtnAddPlayer;
    }
}