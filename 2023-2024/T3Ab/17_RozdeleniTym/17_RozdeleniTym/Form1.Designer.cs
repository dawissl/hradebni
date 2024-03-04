namespace _17_RozdeleniTym
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
            this.NumTeamCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCreateTeams = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RadioBoy = new System.Windows.Forms.RadioButton();
            this.RadioGirl = new System.Windows.Forms.RadioButton();
            this.TxtTeams = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumTeamCount)).BeginInit();
            this.SuspendLayout();
            // 
            // NumTeamCount
            // 
            this.NumTeamCount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumTeamCount.Location = new System.Drawing.Point(152, 169);
            this.NumTeamCount.Name = "NumTeamCount";
            this.NumTeamCount.Size = new System.Drawing.Size(147, 35);
            this.NumTeamCount.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Počet týmů";
            // 
            // BtnCreateTeams
            // 
            this.BtnCreateTeams.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCreateTeams.Location = new System.Drawing.Point(12, 226);
            this.BtnCreateTeams.Name = "BtnCreateTeams";
            this.BtnCreateTeams.Size = new System.Drawing.Size(287, 61);
            this.BtnCreateTeams.TabIndex = 2;
            this.BtnCreateTeams.Text = "Vytvoř týmy";
            this.BtnCreateTeams.UseVisualStyleBackColor = true;
            this.BtnCreateTeams.Click += new System.EventHandler(this.BtnCreateTeams_Click);
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtName.Location = new System.Drawing.Point(80, 12);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(219, 35);
            this.TxtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hráč";
            // 
            // RadioBoy
            // 
            this.RadioBoy.AutoSize = true;
            this.RadioBoy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioBoy.Location = new System.Drawing.Point(22, 64);
            this.RadioBoy.Name = "RadioBoy";
            this.RadioBoy.Size = new System.Drawing.Size(98, 29);
            this.RadioBoy.TabIndex = 5;
            this.RadioBoy.TabStop = true;
            this.RadioBoy.Text = "Chlapec";
            this.RadioBoy.UseVisualStyleBackColor = true;
            // 
            // RadioGirl
            // 
            this.RadioGirl.AutoSize = true;
            this.RadioGirl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioGirl.Location = new System.Drawing.Point(152, 63);
            this.RadioGirl.Name = "RadioGirl";
            this.RadioGirl.Size = new System.Drawing.Size(76, 29);
            this.RadioGirl.TabIndex = 6;
            this.RadioGirl.TabStop = true;
            this.RadioGirl.Text = "Dívka";
            this.RadioGirl.UseVisualStyleBackColor = true;
            // 
            // TxtTeams
            // 
            this.TxtTeams.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTeams.Location = new System.Drawing.Point(305, 12);
            this.TxtTeams.Multiline = true;
            this.TxtTeams.Name = "TxtTeams";
            this.TxtTeams.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtTeams.Size = new System.Drawing.Size(373, 413);
            this.TxtTeams.TabIndex = 7;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAdd.Location = new System.Drawing.Point(12, 105);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(287, 61);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "Přidej hráče";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtTeams);
            this.Controls.Add(this.RadioGirl);
            this.Controls.Add(this.RadioBoy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.BtnCreateTeams);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumTeamCount);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumTeamCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown NumTeamCount;
        private Label label1;
        private Button BtnCreateTeams;
        private TextBox TxtName;
        private Label label2;
        private RadioButton RadioBoy;
        private RadioButton RadioGirl;
        private TextBox TxtTeams;
        private Button BtnAdd;
    }
}