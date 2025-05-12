namespace _20_Opakovani
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
            label1 = new Label();
            CheckUpper = new CheckBox();
            BtnCreate = new Button();
            LblVystup = new Label();
            label3 = new Label();
            TxtCount = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(72, 32);
            label1.TabIndex = 1;
            label1.Text = "Počet";
            // 
            // CheckUpper
            // 
            CheckUpper.AutoSize = true;
            CheckUpper.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            CheckUpper.Location = new Point(16, 70);
            CheckUpper.Name = "CheckUpper";
            CheckUpper.Size = new Size(186, 36);
            CheckUpper.TabIndex = 3;
            CheckUpper.Text = "Velká písmena";
            CheckUpper.UseVisualStyleBackColor = true;
            // 
            // BtnCreate
            // 
            BtnCreate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BtnCreate.Location = new Point(16, 112);
            BtnCreate.Name = "BtnCreate";
            BtnCreate.Size = new Size(182, 50);
            BtnCreate.TabIndex = 4;
            BtnCreate.Text = "Vypiš seznam";
            BtnCreate.UseVisualStyleBackColor = true;
            BtnCreate.Click += BtnCreate_Click;
            // 
            // LblVystup
            // 
            LblVystup.BackColor = SystemColors.ActiveCaption;
            LblVystup.BorderStyle = BorderStyle.Fixed3D;
            LblVystup.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            LblVystup.Location = new Point(16, 238);
            LblVystup.Name = "LblVystup";
            LblVystup.Size = new Size(182, 363);
            LblVystup.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(12, 183);
            label3.Name = "label3";
            label3.Size = new Size(71, 32);
            label3.TabIndex = 6;
            label3.Text = "Výpis";
            // 
            // TxtCount
            // 
            TxtCount.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TxtCount.Location = new Point(90, 25);
            TxtCount.Name = "TxtCount";
            TxtCount.Size = new Size(100, 39);
            TxtCount.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(225, 632);
            Controls.Add(TxtCount);
            Controls.Add(label3);
            Controls.Add(LblVystup);
            Controls.Add(BtnCreate);
            Controls.Add(CheckUpper);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private CheckBox CheckUpper;
        private Button BtnCreate;
        private Label LblVystup;
        private Label label3;
        private TextBox TxtCount;
    }
}
