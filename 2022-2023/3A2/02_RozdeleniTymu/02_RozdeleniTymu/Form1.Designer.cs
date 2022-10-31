namespace _02_RozdeleniTymu
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblPlayers = new System.Windows.Forms.Label();
            this.BtnAddPlayer = new System.Windows.Forms.Button();
            this.BtnRemovePlayer = new System.Windows.Forms.Button();
            this.BtnTeam = new System.Windows.Forms.Button();
            this.NumTeam = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.LblTeam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtName.Location = new System.Drawing.Point(189, 22);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(145, 35);
            this.TxtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "jméno hráče";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(438, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "seznam hráčů";
            // 
            // LblPlayers
            // 
            this.LblPlayers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblPlayers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblPlayers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPlayers.Location = new System.Drawing.Point(438, 71);
            this.LblPlayers.Name = "LblPlayers";
            this.LblPlayers.Size = new System.Drawing.Size(171, 348);
            this.LblPlayers.TabIndex = 3;
            // 
            // BtnAddPlayer
            // 
            this.BtnAddPlayer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAddPlayer.Location = new System.Drawing.Point(340, 22);
            this.BtnAddPlayer.Name = "BtnAddPlayer";
            this.BtnAddPlayer.Size = new System.Drawing.Size(30, 33);
            this.BtnAddPlayer.TabIndex = 4;
            this.BtnAddPlayer.Text = "+";
            this.BtnAddPlayer.UseVisualStyleBackColor = true;
            this.BtnAddPlayer.Click += new System.EventHandler(this.BtnAddPlayer_Click);
            // 
            // BtnRemovePlayer
            // 
            this.BtnRemovePlayer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRemovePlayer.Location = new System.Drawing.Point(376, 22);
            this.BtnRemovePlayer.Name = "BtnRemovePlayer";
            this.BtnRemovePlayer.Size = new System.Drawing.Size(30, 33);
            this.BtnRemovePlayer.TabIndex = 5;
            this.BtnRemovePlayer.Text = "-";
            this.BtnRemovePlayer.UseVisualStyleBackColor = true;
            this.BtnRemovePlayer.Click += new System.EventHandler(this.BtnRemovePlayer_Click);
            // 
            // BtnTeam
            // 
            this.BtnTeam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnTeam.Location = new System.Drawing.Point(243, 71);
            this.BtnTeam.Name = "BtnTeam";
            this.BtnTeam.Size = new System.Drawing.Size(163, 33);
            this.BtnTeam.TabIndex = 6;
            this.BtnTeam.Text = "Vytvoř týmy";
            this.BtnTeam.UseVisualStyleBackColor = true;
            this.BtnTeam.Click += new System.EventHandler(this.BtnTeam_Click);
            // 
            // NumTeam
            // 
            this.NumTeam.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumTeam.Location = new System.Drawing.Point(178, 72);
            this.NumTeam.Name = "NumTeam";
            this.NumTeam.Size = new System.Drawing.Size(48, 33);
            this.NumTeam.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(28, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "počet týmů";
            // 
            // LblTeam
            // 
            this.LblTeam.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTeam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTeam.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTeam.Location = new System.Drawing.Point(26, 111);
            this.LblTeam.Name = "LblTeam";
            this.LblTeam.Size = new System.Drawing.Size(380, 308);
            this.LblTeam.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.LblTeam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumTeam);
            this.Controls.Add(this.BtnTeam);
            this.Controls.Add(this.BtnRemovePlayer);
            this.Controls.Add(this.BtnAddPlayer);
            this.Controls.Add(this.LblPlayers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtName);
            this.Name = "Form1";
            this.Text = "02 Rozdělení týmu";
            ((System.ComponentModel.ISupportInitialize)(this.NumTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtName;
        private Label label1;
        private Label label2;
        private Label LblPlayers;
        private Button BtnAddPlayer;
        private Button BtnRemovePlayer;
        private Button BtnTeam;
        private NumericUpDown NumTeam;
        private Label label3;
        private Label LblTeam;
    }
}