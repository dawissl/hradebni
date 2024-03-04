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
            BtnSplitToTeams = new Button();
            NumTeams = new NumericUpDown();
            LblTeamCount = new Label();
            TxtTeams = new TextBox();
            ((System.ComponentModel.ISupportInitialize)NumTeams).BeginInit();
            SuspendLayout();
            // 
            // BtnSplitToTeams
            // 
            BtnSplitToTeams.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSplitToTeams.Location = new Point(12, 61);
            BtnSplitToTeams.Name = "BtnSplitToTeams";
            BtnSplitToTeams.Size = new Size(233, 59);
            BtnSplitToTeams.TabIndex = 0;
            BtnSplitToTeams.Text = "Rozděl hráče";
            BtnSplitToTeams.UseVisualStyleBackColor = true;
            BtnSplitToTeams.Click += BtnSplitToTeams_Click;
            // 
            // NumTeams
            // 
            NumTeams.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NumTeams.Location = new Point(155, 16);
            NumTeams.Name = "NumTeams";
            NumTeams.Size = new Size(90, 39);
            NumTeams.TabIndex = 1;
            // 
            // LblTeamCount
            // 
            LblTeamCount.AutoSize = true;
            LblTeamCount.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblTeamCount.Location = new Point(15, 23);
            LblTeamCount.Name = "LblTeamCount";
            LblTeamCount.Size = new Size(134, 32);
            LblTeamCount.TabIndex = 2;
            LblTeamCount.Text = "Počet týmů";
            // 
            // TxtTeams
            // 
            TxtTeams.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTeams.Location = new Point(298, 18);
            TxtTeams.Multiline = true;
            TxtTeams.Name = "TxtTeams";
            TxtTeams.ScrollBars = ScrollBars.Vertical;
            TxtTeams.Size = new Size(316, 414);
            TxtTeams.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 450);
            Controls.Add(TxtTeams);
            Controls.Add(LblTeamCount);
            Controls.Add(NumTeams);
            Controls.Add(BtnSplitToTeams);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumTeams).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSplitToTeams;
        private NumericUpDown NumTeams;
        private Label LblTeamCount;
        private TextBox TxtTeams;
    }
}