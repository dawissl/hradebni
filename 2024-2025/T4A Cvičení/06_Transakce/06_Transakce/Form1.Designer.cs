namespace _06_Transakce
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
            TxtFromAcc = new TextBox();
            TxtToAcc = new TextBox();
            label2 = new Label();
            ListAccs = new ListBox();
            BtnTransaction = new Button();
            TxtMoney = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 35);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Účet odesílatele";
            // 
            // TxtFromAcc
            // 
            TxtFromAcc.Location = new Point(152, 32);
            TxtFromAcc.Name = "TxtFromAcc";
            TxtFromAcc.Size = new Size(223, 23);
            TxtFromAcc.TabIndex = 1;
            // 
            // TxtToAcc
            // 
            TxtToAcc.Location = new Point(152, 75);
            TxtToAcc.Name = "TxtToAcc";
            TxtToAcc.Size = new Size(223, 23);
            TxtToAcc.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 78);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 2;
            label2.Text = "Účet příjemce";
            // 
            // ListAccs
            // 
            ListAccs.FormattingEnabled = true;
            ListAccs.ItemHeight = 15;
            ListAccs.Location = new Point(447, 34);
            ListAccs.Name = "ListAccs";
            ListAccs.Size = new Size(300, 379);
            ListAccs.TabIndex = 4;
            // 
            // BtnTransaction
            // 
            BtnTransaction.Location = new Point(194, 160);
            BtnTransaction.Name = "BtnTransaction";
            BtnTransaction.Size = new Size(132, 23);
            BtnTransaction.TabIndex = 5;
            BtnTransaction.Text = "Odeslat peníze";
            BtnTransaction.UseVisualStyleBackColor = true;
            BtnTransaction.Click += BtnTransaction_Click;
            // 
            // TxtMoney
            // 
            TxtMoney.Location = new Point(152, 119);
            TxtMoney.Name = "TxtMoney";
            TxtMoney.Size = new Size(223, 23);
            TxtMoney.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 122);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "Částka";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtMoney);
            Controls.Add(label3);
            Controls.Add(BtnTransaction);
            Controls.Add(ListAccs);
            Controls.Add(TxtToAcc);
            Controls.Add(label2);
            Controls.Add(TxtFromAcc);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtFromAcc;
        private TextBox TxtToAcc;
        private Label label2;
        private ListBox ListAccs;
        private Button BtnTransaction;
        private TextBox TxtMoney;
        private Label label3;
    }
}
