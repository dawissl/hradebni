namespace _02_Transakce
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
            TxtOutput = new TextBox();
            ComboUserA = new ComboBox();
            NumMoney = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            ComboAccountA = new ComboBox();
            ComboAccountB = new ComboBox();
            ComboUserB = new ComboBox();
            label3 = new Label();
            BtnTransfer = new Button();
            ((System.ComponentModel.ISupportInitialize)NumMoney).BeginInit();
            SuspendLayout();
            // 
            // TxtOutput
            // 
            TxtOutput.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtOutput.Location = new Point(712, 12);
            TxtOutput.Multiline = true;
            TxtOutput.Name = "TxtOutput";
            TxtOutput.ReadOnly = true;
            TxtOutput.ScrollBars = ScrollBars.Vertical;
            TxtOutput.Size = new Size(461, 426);
            TxtOutput.TabIndex = 0;
            // 
            // ComboUserA
            // 
            ComboUserA.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ComboUserA.FormattingEnabled = true;
            ComboUserA.Location = new Point(12, 63);
            ComboUserA.Name = "ComboUserA";
            ComboUserA.Size = new Size(286, 40);
            ComboUserA.TabIndex = 1;
            ComboUserA.SelectedIndexChanged += ComboUserA_SelectedIndexChanged;
            // 
            // NumMoney
            // 
            NumMoney.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NumMoney.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            NumMoney.Location = new Point(473, 126);
            NumMoney.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            NumMoney.Name = "NumMoney";
            NumMoney.Size = new Size(187, 39);
            NumMoney.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(159, 32);
            label1.TabIndex = 6;
            label1.Text = "Výchozí účet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 169);
            label2.Name = "label2";
            label2.Size = new Size(140, 32);
            label2.TabIndex = 7;
            label2.Text = "Cílový účet";
            // 
            // ComboAccountA
            // 
            ComboAccountA.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ComboAccountA.FormattingEnabled = true;
            ComboAccountA.Location = new Point(304, 63);
            ComboAccountA.Name = "ComboAccountA";
            ComboAccountA.Size = new Size(356, 40);
            ComboAccountA.TabIndex = 8;
            ComboAccountA.SelectedIndexChanged += ComboAccountA_SelectedIndexChanged;
            // 
            // ComboAccountB
            // 
            ComboAccountB.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ComboAccountB.FormattingEnabled = true;
            ComboAccountB.Location = new Point(304, 204);
            ComboAccountB.Name = "ComboAccountB";
            ComboAccountB.Size = new Size(356, 40);
            ComboAccountB.TabIndex = 10;
            // 
            // ComboUserB
            // 
            ComboUserB.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ComboUserB.FormattingEnabled = true;
            ComboUserB.Location = new Point(12, 204);
            ComboUserB.Name = "ComboUserB";
            ComboUserB.Size = new Size(286, 40);
            ComboUserB.TabIndex = 9;
            ComboUserB.SelectedIndexChanged += ComboUserB_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(349, 133);
            label3.Name = "label3";
            label3.Size = new Size(88, 32);
            label3.TabIndex = 11;
            label3.Text = "Částka";
            // 
            // BtnTransfer
            // 
            BtnTransfer.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnTransfer.Location = new Point(12, 271);
            BtnTransfer.Name = "BtnTransfer";
            BtnTransfer.Size = new Size(170, 55);
            BtnTransfer.TabIndex = 12;
            BtnTransfer.Text = "Převeď";
            BtnTransfer.UseVisualStyleBackColor = true;
            BtnTransfer.Click += BtnTransfer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 450);
            Controls.Add(BtnTransfer);
            Controls.Add(label3);
            Controls.Add(ComboAccountB);
            Controls.Add(ComboUserB);
            Controls.Add(ComboAccountA);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NumMoney);
            Controls.Add(ComboUserA);
            Controls.Add(TxtOutput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)NumMoney).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtOutput;
        private ComboBox ComboUserA;
        private NumericUpDown NumMoney;
        private Label label1;
        private Label label2;
        private ComboBox ComboAccountA;
        private ComboBox ComboAccountB;
        private ComboBox ComboUserB;
        private Label label3;
        private Button BtnTransfer;
    }
}