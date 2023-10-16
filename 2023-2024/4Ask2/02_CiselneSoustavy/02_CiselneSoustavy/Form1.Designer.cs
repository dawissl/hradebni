namespace _02_CiselneSoustavy
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
            BtnConvert = new Button();
            LblOutput = new Label();
            comboBox1 = new ComboBox();
            TxtInput = new TextBox();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // BtnConvert
            // 
            BtnConvert.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            BtnConvert.Location = new Point(64, 165);
            BtnConvert.Name = "BtnConvert";
            BtnConvert.Size = new Size(211, 74);
            BtnConvert.TabIndex = 0;
            BtnConvert.Text = "Převeď";
            BtnConvert.UseVisualStyleBackColor = true;
            BtnConvert.Click += BtnConvert_Click;
            // 
            // LblOutput
            // 
            LblOutput.BorderStyle = BorderStyle.Fixed3D;
            LblOutput.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblOutput.Location = new Point(64, 98);
            LblOutput.Name = "LblOutput";
            LblOutput.Size = new Size(246, 43);
            LblOutput.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Binární", "Osmičková", "Desítková", "Hexadecimální" });
            comboBox1.Location = new Point(336, 96);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(223, 40);
            comboBox1.TabIndex = 2;
            // 
            // TxtInput
            // 
            TxtInput.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtInput.Location = new Point(64, 40);
            TxtInput.Name = "TxtInput";
            TxtInput.Size = new Size(246, 39);
            TxtInput.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Binární", "Osmičková", "Desítková", "Hexadecimální" });
            comboBox2.Location = new Point(336, 39);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(223, 40);
            comboBox2.TabIndex = 4;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 266);
            Controls.Add(comboBox2);
            Controls.Add(TxtInput);
            Controls.Add(comboBox1);
            Controls.Add(LblOutput);
            Controls.Add(BtnConvert);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnConvert;
        private Label LblOutput;
        private ComboBox comboBox1;
        private TextBox TxtInput;
        private ComboBox comboBox2;
    }
}