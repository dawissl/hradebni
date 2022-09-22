
namespace _02_RozdelTym
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnTeam = new System.Windows.Forms.Button();
            this.NumTeamSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.LblTeams = new System.Windows.Forms.Label();
            this.LblPlayers = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumTeamSize)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jméno";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtName.Location = new System.Drawing.Point(131, 25);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(169, 39);
            this.TxtName.TabIndex = 1;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAdd.Location = new System.Drawing.Point(322, 26);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 39);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRemove.Location = new System.Drawing.Point(403, 26);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(75, 39);
            this.BtnRemove.TabIndex = 3;
            this.BtnRemove.Text = "-";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnTeam
            // 
            this.BtnTeam.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnTeam.Location = new System.Drawing.Point(322, 99);
            this.BtnTeam.Name = "BtnTeam";
            this.BtnTeam.Size = new System.Drawing.Size(156, 39);
            this.BtnTeam.TabIndex = 4;
            this.BtnTeam.Text = "Rozděl týmy";
            this.BtnTeam.UseVisualStyleBackColor = true;
            this.BtnTeam.Click += new System.EventHandler(this.BtnTeam_Click);
            // 
            // NumTeamSize
            // 
            this.NumTeamSize.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumTeamSize.Location = new System.Drawing.Point(166, 103);
            this.NumTeamSize.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumTeamSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumTeamSize.Name = "NumTeamSize";
            this.NumTeamSize.Size = new System.Drawing.Size(119, 35);
            this.NumTeamSize.TabIndex = 5;
            this.NumTeamSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Počet týmů";
            // 
            // LblTeams
            // 
            this.LblTeams.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblTeams.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTeams.Location = new System.Drawing.Point(36, 174);
            this.LblTeams.Name = "LblTeams";
            this.LblTeams.Size = new System.Drawing.Size(442, 267);
            this.LblTeams.TabIndex = 7;
            // 
            // LblPlayers
            // 
            this.LblPlayers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblPlayers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblPlayers.Location = new System.Drawing.Point(525, 67);
            this.LblPlayers.Name = "LblPlayers";
            this.LblPlayers.Size = new System.Drawing.Size(197, 374);
            this.LblPlayers.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(525, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Seznam hráčů";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(36, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rozdělení týmů";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblPlayers);
            this.Controls.Add(this.LblTeams);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumTeamSize);
            this.Controls.Add(this.BtnTeam);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumTeamSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnTeam;
        private System.Windows.Forms.NumericUpDown NumTeamSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblTeams;
        private System.Windows.Forms.Label LblPlayers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

