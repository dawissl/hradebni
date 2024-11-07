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
            label2 = new Label();
            ListAccs = new ListBox();
            BtnTransaction = new Button();
            TxtMoney = new TextBox();
            label3 = new Label();
            StatusStripApp = new StatusStrip();
            TransactionStatus = new ToolStripStatusLabel();
            ComboUserFrom = new ComboBox();
            ComboAccFrom = new ComboBox();
            ComboUserTo = new ComboBox();
            ComboAccTo = new ComboBox();
            StatusStripApp.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 60);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Účet odesílatele";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 142);
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
            BtnTransaction.Location = new Point(205, 268);
            BtnTransaction.Name = "BtnTransaction";
            BtnTransaction.Size = new Size(132, 23);
            BtnTransaction.TabIndex = 5;
            BtnTransaction.Text = "Odeslat peníze";
            BtnTransaction.UseVisualStyleBackColor = true;
            BtnTransaction.Click += BtnTransaction_Click;
            // 
            // TxtMoney
            // 
            TxtMoney.Location = new Point(163, 227);
            TxtMoney.Name = "TxtMoney";
            TxtMoney.Size = new Size(223, 23);
            TxtMoney.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 230);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "Částka";
            // 
            // StatusStripApp
            // 
            StatusStripApp.Items.AddRange(new ToolStripItem[] { TransactionStatus });
            StatusStripApp.Location = new Point(0, 428);
            StatusStripApp.Name = "StatusStripApp";
            StatusStripApp.Size = new Size(800, 22);
            StatusStripApp.TabIndex = 8;
            StatusStripApp.Text = "statusStrip1";
            // 
            // TransactionStatus
            // 
            TransactionStatus.AutoSize = false;
            TransactionStatus.BackColor = SystemColors.ActiveCaption;
            TransactionStatus.Name = "TransactionStatus";
            TransactionStatus.Size = new Size(100, 17);
            // 
            // ComboUserFrom
            // 
            ComboUserFrom.FormattingEnabled = true;
            ComboUserFrom.Location = new Point(165, 57);
            ComboUserFrom.Name = "ComboUserFrom";
            ComboUserFrom.Size = new Size(226, 23);
            ComboUserFrom.TabIndex = 9;
            ComboUserFrom.SelectedIndexChanged += ComboUserFrom_SelectedIndexChanged;
            // 
            // ComboAccFrom
            // 
            ComboAccFrom.FormattingEnabled = true;
            ComboAccFrom.Location = new Point(165, 86);
            ComboAccFrom.Name = "ComboAccFrom";
            ComboAccFrom.Size = new Size(226, 23);
            ComboAccFrom.TabIndex = 10;
            // 
            // ComboUserTo
            // 
            ComboUserTo.FormattingEnabled = true;
            ComboUserTo.Location = new Point(165, 142);
            ComboUserTo.Name = "ComboUserTo";
            ComboUserTo.Size = new Size(226, 23);
            ComboUserTo.TabIndex = 11;
            ComboUserTo.SelectedIndexChanged += ComboUserTo_SelectedIndexChanged;
            // 
            // ComboAccTo
            // 
            ComboAccTo.FormattingEnabled = true;
            ComboAccTo.Location = new Point(165, 171);
            ComboAccTo.Name = "ComboAccTo";
            ComboAccTo.Size = new Size(226, 23);
            ComboAccTo.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ComboAccTo);
            Controls.Add(ComboUserTo);
            Controls.Add(ComboAccFrom);
            Controls.Add(ComboUserFrom);
            Controls.Add(StatusStripApp);
            Controls.Add(TxtMoney);
            Controls.Add(label3);
            Controls.Add(BtnTransaction);
            Controls.Add(ListAccs);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            StatusStripApp.ResumeLayout(false);
            StatusStripApp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox ListAccs;
        private Button BtnTransaction;
        private TextBox TxtMoney;
        private Label label3;
        private StatusStrip StatusStripApp;
        private ToolStripStatusLabel TransactionStatus;
        private ComboBox ComboUserFrom;
        private ComboBox ComboAccFrom;
        private ComboBox ComboUserTo;
        private ComboBox ComboAccTo;
    }
}
