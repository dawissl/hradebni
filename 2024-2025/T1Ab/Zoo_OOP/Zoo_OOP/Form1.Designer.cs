namespace Zoo_OOP
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
            ListZvirata = new ListBox();
            BtnAdd = new Button();
            TxtName = new TextBox();
            TxtWeight = new TextBox();
            BtnAging = new Button();
            BtnFeed = new Button();
            textBox1 = new TextBox();
            CheckSavec = new CheckBox();
            SuspendLayout();
            // 
            // ListZvirata
            // 
            ListZvirata.FormattingEnabled = true;
            ListZvirata.ItemHeight = 15;
            ListZvirata.Location = new Point(39, 26);
            ListZvirata.Name = "ListZvirata";
            ListZvirata.Size = new Size(223, 364);
            ListZvirata.TabIndex = 0;
            // 
            // BtnAdd
            // 
            BtnAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BtnAdd.Location = new Point(278, 162);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(157, 53);
            BtnAdd.TabIndex = 1;
            BtnAdd.Text = "Přidat zvíře";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // TxtName
            // 
            TxtName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TxtName.Location = new Point(278, 35);
            TxtName.Name = "TxtName";
            TxtName.PlaceholderText = "Jméno zvířete";
            TxtName.Size = new Size(157, 33);
            TxtName.TabIndex = 2;
            // 
            // TxtWeight
            // 
            TxtWeight.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TxtWeight.Location = new Point(278, 82);
            TxtWeight.Name = "TxtWeight";
            TxtWeight.PlaceholderText = "Porodní váha";
            TxtWeight.Size = new Size(157, 33);
            TxtWeight.TabIndex = 3;
            // 
            // BtnAging
            // 
            BtnAging.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BtnAging.Location = new Point(278, 221);
            BtnAging.Name = "BtnAging";
            BtnAging.Size = new Size(157, 56);
            BtnAging.TabIndex = 4;
            BtnAging.Text = "Stárnutí";
            BtnAging.UseVisualStyleBackColor = true;
            BtnAging.Click += BtnAging_Click;
            // 
            // BtnFeed
            // 
            BtnFeed.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BtnFeed.Location = new Point(278, 322);
            BtnFeed.Name = "BtnFeed";
            BtnFeed.Size = new Size(157, 45);
            BtnFeed.TabIndex = 5;
            BtnFeed.Text = "Nakrm";
            BtnFeed.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox1.Location = new Point(278, 283);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Hmotnost jidla";
            textBox1.Size = new Size(157, 33);
            textBox1.TabIndex = 6;
            // 
            // CheckSavec
            // 
            CheckSavec.AutoSize = true;
            CheckSavec.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            CheckSavec.Location = new Point(278, 131);
            CheckSavec.Name = "CheckSavec";
            CheckSavec.Size = new Size(69, 25);
            CheckSavec.TabIndex = 7;
            CheckSavec.Text = "Savec";
            CheckSavec.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 450);
            Controls.Add(CheckSavec);
            Controls.Add(textBox1);
            Controls.Add(BtnFeed);
            Controls.Add(BtnAging);
            Controls.Add(TxtWeight);
            Controls.Add(TxtName);
            Controls.Add(BtnAdd);
            Controls.Add(ListZvirata);
            Name = "Form1";
            Text = "Zoo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListZvirata;
        private Button BtnAdd;
        private TextBox TxtName;
        private TextBox TxtWeight;
        private Button BtnAging;
        private Button BtnFeed;
        private TextBox textBox1;
        private CheckBox CheckSavec;
    }
}
