using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ZOO_OOP
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
            TxtFood = new TextBox();
            CheckPlaz = new CheckBox();
            SuspendLayout();
            // 
            // ListZvirata
            // 
            ListZvirata.Font = new System.Drawing.Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ListZvirata.FormattingEnabled = true;
            ListZvirata.ItemHeight = 32;
            ListZvirata.Location = new Point(39, 26);
            ListZvirata.Name = "ListZvirata";
            ListZvirata.Size = new Size(223, 356);
            ListZvirata.TabIndex = 0;
            // 
            // BtnAdd
            // 
            BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            BtnAdd.Location = new Point(278, 170);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(157, 53);
            BtnAdd.TabIndex = 1;
            BtnAdd.Text = "Přidat zvíře";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // TxtName
            // 
            TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            TxtName.Location = new Point(278, 35);
            TxtName.Name = "TxtName";
            TxtName.PlaceholderText = "Jméno zvířete";
            TxtName.Size = new Size(157, 31);
            TxtName.TabIndex = 2;
            // 
            // TxtWeight
            // 
            TxtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            TxtWeight.Location = new Point(278, 82);
            TxtWeight.Name = "TxtWeight";
            TxtWeight.PlaceholderText = "Porodní váha";
            TxtWeight.Size = new Size(157, 31);
            TxtWeight.TabIndex = 3;
            // 
            // BtnAging
            // 
            BtnAging.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            BtnAging.Location = new Point(278, 229);
            BtnAging.Name = "BtnAging";
            BtnAging.Size = new Size(157, 56);
            BtnAging.TabIndex = 4;
            BtnAging.Text = "Stárnutí";
            BtnAging.UseVisualStyleBackColor = true;
            BtnAging.Click += BtnAging_Click;
            // 
            // BtnFeed
            // 
            BtnFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            BtnFeed.Location = new Point(278, 330);
            BtnFeed.Name = "BtnFeed";
            BtnFeed.Size = new Size(157, 45);
            BtnFeed.TabIndex = 5;
            BtnFeed.Text = "Nakrm";
            BtnFeed.UseVisualStyleBackColor = true;
            BtnFeed.Click += BtnFeed_Click;
            // 
            // TxtFood
            // 
            TxtFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            TxtFood.Location = new Point(278, 291);
            TxtFood.Name = "TxtFood";
            TxtFood.PlaceholderText = "Hmotnost jidla";
            TxtFood.Size = new Size(157, 31);
            TxtFood.TabIndex = 6;
            // 
            // CheckPlaz
            // 
            CheckPlaz.AutoSize = true;
            CheckPlaz.Font = new System.Drawing.Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            CheckPlaz.Location = new Point(278, 130);
            CheckPlaz.Name = "CheckPlaz";
            CheckPlaz.Size = new Size(70, 34);
            CheckPlaz.TabIndex = 7;
            CheckPlaz.Text = "Plaz";
            CheckPlaz.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 450);
            Controls.Add(CheckPlaz);
            Controls.Add(TxtFood);
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
        private TextBox TxtFood;
        private CheckBox CheckPlaz;
    }
}