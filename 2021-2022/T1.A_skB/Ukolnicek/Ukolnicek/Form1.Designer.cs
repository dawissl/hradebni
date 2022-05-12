
namespace Ukolnicek
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
            this.LblOutput = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtList = new System.Windows.Forms.TextBox();
            this.ComboType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NumIndex = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.BtnDone = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // LblOutput
            // 
            this.LblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblOutput.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblOutput.Location = new System.Drawing.Point(405, 34);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(349, 395);
            this.LblOutput.TabIndex = 0;
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtName.Location = new System.Drawing.Point(113, 52);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(237, 35);
            this.TxtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "nazev";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "datum";
            // 
            // TxtDate
            // 
            this.TxtDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDate.Location = new System.Drawing.Point(113, 137);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(237, 35);
            this.TxtDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "seznam";
            // 
            // TxtList
            // 
            this.TxtList.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtList.Location = new System.Drawing.Point(113, 175);
            this.TxtList.Name = "TxtList";
            this.TxtList.Size = new System.Drawing.Size(237, 35);
            this.TxtList.TabIndex = 5;
            // 
            // ComboType
            // 
            this.ComboType.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboType.FormattingEnabled = true;
            this.ComboType.Items.AddRange(new object[] {
            "ukol",
            "dulezity ukol",
            "nakupni seznam"});
            this.ComboType.Location = new System.Drawing.Point(112, 93);
            this.ComboType.Name = "ComboType";
            this.ComboType.Size = new System.Drawing.Size(237, 38);
            this.ComboType.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "typ ukolu";
            // 
            // NumIndex
            // 
            this.NumIndex.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumIndex.Location = new System.Drawing.Point(113, 216);
            this.NumIndex.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.NumIndex.Name = "NumIndex";
            this.NumIndex.Size = new System.Drawing.Size(236, 35);
            this.NumIndex.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(44, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "index";
            // 
            // BtnInsert
            // 
            this.BtnInsert.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnInsert.Location = new System.Drawing.Point(23, 272);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(104, 50);
            this.BtnInsert.TabIndex = 11;
            this.BtnInsert.Text = "vložit";
            this.BtnInsert.UseVisualStyleBackColor = true;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnPrint.Location = new System.Drawing.Point(133, 272);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(115, 50);
            this.BtnPrint.TabIndex = 12;
            this.BtnPrint.Text = "výpis";
            this.BtnPrint.UseVisualStyleBackColor = true;
            // 
            // BtnDone
            // 
            this.BtnDone.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDone.Location = new System.Drawing.Point(254, 272);
            this.BtnDone.Name = "BtnDone";
            this.BtnDone.Size = new System.Drawing.Size(139, 50);
            this.BtnDone.TabIndex = 13;
            this.BtnDone.Text = "splněno";
            this.BtnDone.UseVisualStyleBackColor = true;
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnReset.Location = new System.Drawing.Point(23, 346);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(108, 60);
            this.BtnReset.TabIndex = 14;
            this.BtnReset.Text = "restart";
            this.BtnReset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnDone);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NumIndex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblOutput);
            this.Name = "Form1";
            this.Text = "Ukolnik";
            ((System.ComponentModel.ISupportInitialize)(this.NumIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblOutput;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtList;
        private System.Windows.Forms.ComboBox ComboType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumIndex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Button BtnDone;
        private System.Windows.Forms.Button BtnReset;
    }
}

