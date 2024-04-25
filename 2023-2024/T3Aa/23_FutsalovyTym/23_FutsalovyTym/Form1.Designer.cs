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
            TxtDefault = new TextBox();
            TxtSorted = new TextBox();
            BtnWork = new Button();
            Rad131 = new RadioButton();
            Rad311 = new RadioButton();
            Rad221 = new RadioButton();
            BtnSquad = new Button();
            SuspendLayout();
            // 
            // TxtDefault
            // 
            TxtDefault.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TxtDefault.Location = new Point(17, 36);
            TxtDefault.Multiline = true;
            TxtDefault.Name = "TxtDefault";
            TxtDefault.ScrollBars = ScrollBars.Vertical;
            TxtDefault.Size = new Size(247, 385);
            TxtDefault.TabIndex = 0;
            // 
            // TxtSorted
            // 
            TxtSorted.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TxtSorted.Location = new Point(282, 36);
            TxtSorted.Multiline = true;
            TxtSorted.Name = "TxtSorted";
            TxtSorted.ScrollBars = ScrollBars.Vertical;
            TxtSorted.Size = new Size(247, 385);
            TxtSorted.TabIndex = 1;
            // 
            // BtnWork
            // 
            BtnWork.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BtnWork.Location = new Point(568, 36);
            BtnWork.Name = "BtnWork";
            BtnWork.Size = new Size(195, 62);
            BtnWork.TabIndex = 2;
            BtnWork.Text = "Vygeneruj a seřaď";
            BtnWork.UseVisualStyleBackColor = true;
            BtnWork.Click += BtnWork_Click;
            // 
            // Rad131
            // 
            Rad131.AutoSize = true;
            Rad131.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Rad131.Location = new Point(609, 163);
            Rad131.Name = "Rad131";
            Rad131.Size = new Size(99, 29);
            Rad131.TabIndex = 3;
            Rad131.TabStop = true;
            Rad131.Text = "1 - 3 - 1";
            Rad131.UseVisualStyleBackColor = true;
            // 
            // Rad311
            // 
            Rad311.AutoSize = true;
            Rad311.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Rad311.Location = new Point(609, 198);
            Rad311.Name = "Rad311";
            Rad311.Size = new Size(99, 29);
            Rad311.TabIndex = 4;
            Rad311.TabStop = true;
            Rad311.Text = "3 - 1 - 1";
            Rad311.UseVisualStyleBackColor = true;
            // 
            // Rad221
            // 
            Rad221.AutoSize = true;
            Rad221.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Rad221.Location = new Point(609, 233);
            Rad221.Name = "Rad221";
            Rad221.Size = new Size(99, 29);
            Rad221.TabIndex = 5;
            Rad221.TabStop = true;
            Rad221.Text = "2 - 2 - 1";
            Rad221.UseVisualStyleBackColor = true;
            // 
            // BtnSquad
            // 
            BtnSquad.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BtnSquad.Location = new Point(559, 287);
            BtnSquad.Name = "BtnSquad";
            BtnSquad.Size = new Size(195, 62);
            BtnSquad.TabIndex = 6;
            BtnSquad.Text = "Sestava";
            BtnSquad.UseVisualStyleBackColor = true;
            BtnSquad.Click += BtnSquad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSquad);
            Controls.Add(Rad221);
            Controls.Add(Rad311);
            Controls.Add(Rad131);
            Controls.Add(BtnWork);
            Controls.Add(TxtSorted);
            Controls.Add(TxtDefault);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtDefault;
        private TextBox TxtSorted;
        private Button BtnWork;
        private RadioButton Rad131;
        private RadioButton Rad311;
        private RadioButton Rad221;
        private Button BtnSquad;
    }
}
