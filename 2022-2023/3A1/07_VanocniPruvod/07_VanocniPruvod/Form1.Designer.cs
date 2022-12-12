namespace _07_VanocniPruvod
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
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.BtnSearch1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblOut = new System.Windows.Forms.Label();
            this.BtnSearch2 = new System.Windows.Forms.Button();
            this.BtnSearch3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtInput
            // 
            this.TxtInput.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtInput.Location = new System.Drawing.Point(12, 12);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(826, 39);
            this.TxtInput.TabIndex = 0;
            // 
            // BtnSearch1
            // 
            this.BtnSearch1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSearch1.Location = new System.Drawing.Point(862, 12);
            this.BtnSearch1.Name = "BtnSearch1";
            this.BtnSearch1.Size = new System.Drawing.Size(134, 39);
            this.BtnSearch1.TabIndex = 1;
            this.BtnSearch1.Text = "Hledej elfa 1";
            this.BtnSearch1.UseVisualStyleBackColor = true;
            this.BtnSearch1.Click += new System.EventHandler(this.BtnSearch1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Výstup";
            // 
            // LblOut
            // 
            this.LblOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblOut.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblOut.Location = new System.Drawing.Point(99, 73);
            this.LblOut.Name = "LblOut";
            this.LblOut.Size = new System.Drawing.Size(739, 30);
            this.LblOut.TabIndex = 3;
            // 
            // BtnSearch2
            // 
            this.BtnSearch2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSearch2.Location = new System.Drawing.Point(861, 70);
            this.BtnSearch2.Name = "BtnSearch2";
            this.BtnSearch2.Size = new System.Drawing.Size(134, 39);
            this.BtnSearch2.TabIndex = 4;
            this.BtnSearch2.Text = "Hledej elfa 2";
            this.BtnSearch2.UseVisualStyleBackColor = true;
            this.BtnSearch2.Click += new System.EventHandler(this.BtnSearch2_Click);
            // 
            // BtnSearch3
            // 
            this.BtnSearch3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSearch3.Location = new System.Drawing.Point(862, 126);
            this.BtnSearch3.Name = "BtnSearch3";
            this.BtnSearch3.Size = new System.Drawing.Size(134, 39);
            this.BtnSearch3.TabIndex = 5;
            this.BtnSearch3.Text = "Hledej elfa 3";
            this.BtnSearch3.UseVisualStyleBackColor = true;
//            this.BtnSearch3.Click += new System.EventHandler(this.BtnSearch3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 216);
            this.Controls.Add(this.BtnSearch3);
            this.Controls.Add(this.BtnSearch2);
            this.Controls.Add(this.LblOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSearch1);
            this.Controls.Add(this.TxtInput);
            this.Name = "Form1";
            this.Text = "Advent of Code #1 ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtInput;
        private Button BtnSearch1;
        private Label label1;
        private Label LblOut;
        private Button BtnSearch2;
        private Button BtnSearch3;
    }
}