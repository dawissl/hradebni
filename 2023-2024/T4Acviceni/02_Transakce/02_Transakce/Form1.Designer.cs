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
            Tabs = new TabControl();
            TabTransfer = new TabPage();
            BtnTransfer = new Button();
            label3 = new Label();
            ComboAccountB = new ComboBox();
            ComboUserB = new ComboBox();
            ComboAccountA = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            NumMoney = new NumericUpDown();
            ComboUserA = new ComboBox();
            TabOverview = new TabPage();
            BtnUpdate = new Button();
            TxtDepositSum = new TextBox();
            TxtInvestDeposit = new TextBox();
            TxtClasicDeposit = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            Tabs.SuspendLayout();
            TabTransfer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumMoney).BeginInit();
            TabOverview.SuspendLayout();
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
            // Tabs
            // 
            Tabs.Controls.Add(TabTransfer);
            Tabs.Controls.Add(TabOverview);
            Tabs.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Tabs.Location = new Point(1, 12);
            Tabs.Name = "Tabs";
            Tabs.SelectedIndex = 0;
            Tabs.Size = new Size(691, 426);
            Tabs.TabIndex = 13;
            // 
            // TabTransfer
            // 
            TabTransfer.Controls.Add(BtnTransfer);
            TabTransfer.Controls.Add(label3);
            TabTransfer.Controls.Add(ComboAccountB);
            TabTransfer.Controls.Add(ComboUserB);
            TabTransfer.Controls.Add(ComboAccountA);
            TabTransfer.Controls.Add(label2);
            TabTransfer.Controls.Add(label1);
            TabTransfer.Controls.Add(NumMoney);
            TabTransfer.Controls.Add(ComboUserA);
            TabTransfer.Location = new Point(4, 34);
            TabTransfer.Name = "TabTransfer";
            TabTransfer.Padding = new Padding(3);
            TabTransfer.Size = new Size(683, 388);
            TabTransfer.TabIndex = 0;
            TabTransfer.Text = "Převody";
            TabTransfer.UseVisualStyleBackColor = true;
            // 
            // BtnTransfer
            // 
            BtnTransfer.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnTransfer.Location = new Point(7, 262);
            BtnTransfer.Name = "BtnTransfer";
            BtnTransfer.Size = new Size(170, 55);
            BtnTransfer.TabIndex = 21;
            BtnTransfer.Text = "Převeď";
            BtnTransfer.UseVisualStyleBackColor = true;
            BtnTransfer.Click += BtnTransfer_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(344, 124);
            label3.Name = "label3";
            label3.Size = new Size(88, 32);
            label3.TabIndex = 20;
            label3.Text = "Částka";
            // 
            // ComboAccountB
            // 
            ComboAccountB.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ComboAccountB.FormattingEnabled = true;
            ComboAccountB.Location = new Point(299, 195);
            ComboAccountB.Name = "ComboAccountB";
            ComboAccountB.Size = new Size(356, 40);
            ComboAccountB.TabIndex = 19;
            // 
            // ComboUserB
            // 
            ComboUserB.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ComboUserB.FormattingEnabled = true;
            ComboUserB.Location = new Point(7, 195);
            ComboUserB.Name = "ComboUserB";
            ComboUserB.Size = new Size(286, 40);
            ComboUserB.TabIndex = 18;
            ComboUserB.SelectedIndexChanged += ComboUserB_SelectedIndexChanged_1;
            // 
            // ComboAccountA
            // 
            ComboAccountA.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ComboAccountA.FormattingEnabled = true;
            ComboAccountA.Location = new Point(299, 54);
            ComboAccountA.Name = "ComboAccountA";
            ComboAccountA.Size = new Size(356, 40);
            ComboAccountA.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(7, 160);
            label2.Name = "label2";
            label2.Size = new Size(140, 32);
            label2.TabIndex = 16;
            label2.Text = "Cílový účet";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(7, 19);
            label1.Name = "label1";
            label1.Size = new Size(159, 32);
            label1.TabIndex = 15;
            label1.Text = "Výchozí účet";
            // 
            // NumMoney
            // 
            NumMoney.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NumMoney.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            NumMoney.Location = new Point(468, 117);
            NumMoney.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            NumMoney.Name = "NumMoney";
            NumMoney.Size = new Size(187, 39);
            NumMoney.TabIndex = 14;
            // 
            // ComboUserA
            // 
            ComboUserA.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ComboUserA.FormattingEnabled = true;
            ComboUserA.Location = new Point(7, 54);
            ComboUserA.Name = "ComboUserA";
            ComboUserA.Size = new Size(286, 40);
            ComboUserA.TabIndex = 13;
            ComboUserA.SelectedIndexChanged += ComboUserA_SelectedIndexChanged_1;
            // 
            // TabOverview
            // 
            TabOverview.Controls.Add(BtnUpdate);
            TabOverview.Controls.Add(TxtDepositSum);
            TabOverview.Controls.Add(TxtInvestDeposit);
            TabOverview.Controls.Add(TxtClasicDeposit);
            TabOverview.Controls.Add(label6);
            TabOverview.Controls.Add(label5);
            TabOverview.Controls.Add(label4);
            TabOverview.Location = new Point(4, 34);
            TabOverview.Name = "TabOverview";
            TabOverview.Padding = new Padding(3);
            TabOverview.Size = new Size(683, 388);
            TabOverview.TabIndex = 1;
            TabOverview.Text = "Přehled";
            TabOverview.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(537, 345);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(140, 37);
            BtnUpdate.TabIndex = 6;
            BtnUpdate.Text = "Aktualizace";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // TxtDepositSum
            // 
            TxtDepositSum.Location = new Point(183, 262);
            TxtDepositSum.Name = "TxtDepositSum";
            TxtDepositSum.ReadOnly = true;
            TxtDepositSum.Size = new Size(380, 33);
            TxtDepositSum.TabIndex = 5;
            // 
            // TxtInvestDeposit
            // 
            TxtInvestDeposit.Location = new Point(183, 173);
            TxtInvestDeposit.Name = "TxtInvestDeposit";
            TxtInvestDeposit.ReadOnly = true;
            TxtInvestDeposit.Size = new Size(380, 33);
            TxtInvestDeposit.TabIndex = 4;
            // 
            // TxtClasicDeposit
            // 
            TxtClasicDeposit.Location = new Point(183, 71);
            TxtClasicDeposit.Name = "TxtClasicDeposit";
            TxtClasicDeposit.ReadOnly = true;
            TxtClasicDeposit.Size = new Size(380, 33);
            TxtClasicDeposit.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(29, 209);
            label6.Name = "label6";
            label6.Size = new Size(145, 25);
            label6.TabIndex = 2;
            label6.Text = "Suma depositů";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(29, 123);
            label5.Name = "label5";
            label5.Size = new Size(167, 25);
            label5.TabIndex = 1;
            label5.Text = "Investiční deposit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(29, 28);
            label4.Name = "label4";
            label4.Size = new Size(153, 25);
            label4.TabIndex = 0;
            label4.Text = "Klasický deposit";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 450);
            Controls.Add(Tabs);
            Controls.Add(TxtOutput);
            Name = "Form1";
            Text = "SimpleBank";
            Load += Form1_Load;
            Tabs.ResumeLayout(false);
            TabTransfer.ResumeLayout(false);
            TabTransfer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumMoney).EndInit();
            TabOverview.ResumeLayout(false);
            TabOverview.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtOutput;
        private TabControl Tabs;
        private TabPage TabTransfer;
        private TabPage TabOverview;
        private Button BtnTransfer;
        private Label label3;
        private ComboBox ComboAccountB;
        private ComboBox ComboUserB;
        private ComboBox ComboAccountA;
        private Label label2;
        private Label label1;
        private NumericUpDown NumMoney;
        private ComboBox ComboUserA;
        private TextBox TxtDepositSum;
        private TextBox TxtInvestDeposit;
        private TextBox TxtClasicDeposit;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button BtnUpdate;
    }
}