namespace _02_Prevadeni_cislenych_soustav
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
            ComboOut = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LblOut = new Label();
            TxtInput = new TextBox();
            BtnConvert = new Button();
            SuspendLayout();
            // 
            // ComboOut
            // 
            ComboOut.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ComboOut.FormattingEnabled = true;
            ComboOut.Items.AddRange(new object[] { "Binární", "Oktalová", "Decimální", "Hexadecimální" });
            ComboOut.Location = new Point(294, 87);
            ComboOut.Name = "ComboOut";
            ComboOut.Size = new Size(226, 33);
            ComboOut.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 36);
            label1.Name = "label1";
            label1.Size = new Size(210, 32);
            label1.TabIndex = 1;
            label1.Text = "Výchozí soustava";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(37, 88);
            label2.Name = "label2";
            label2.Size = new Size(222, 32);
            label2.TabIndex = 2;
            label2.Text = "Výstupní soustava";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(294, 43);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 3;
            label3.Text = "Desítková";
            // 
            // LblOut
            // 
            LblOut.BackColor = SystemColors.ActiveCaption;
            LblOut.BorderStyle = BorderStyle.Fixed3D;
            LblOut.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LblOut.Location = new Point(37, 248);
            LblOut.Name = "LblOut";
            LblOut.Size = new Size(483, 39);
            LblOut.TabIndex = 4;
            LblOut.Text = "-";
            // 
            // TxtInput
            // 
            TxtInput.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtInput.Location = new Point(37, 136);
            TxtInput.Name = "TxtInput";
            TxtInput.Size = new Size(483, 39);
            TxtInput.TabIndex = 5;
            // 
            // BtnConvert
            // 
            BtnConvert.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnConvert.Location = new Point(37, 193);
            BtnConvert.Name = "BtnConvert";
            BtnConvert.Size = new Size(483, 35);
            BtnConvert.TabIndex = 6;
            BtnConvert.Text = "Převeď číslo";
            BtnConvert.UseVisualStyleBackColor = true;
            BtnConvert.Click += BtnConvert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 305);
            Controls.Add(BtnConvert);
            Controls.Add(TxtInput);
            Controls.Add(LblOut);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ComboOut);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboOut;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label LblOut;
        private TextBox TxtInput;
        private Button BtnConvert;
    }
}