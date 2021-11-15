
namespace DummyCalc
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
            this.BtnSoucet = new System.Windows.Forms.Button();
            this.BtnRozdíl = new System.Windows.Forms.Button();
            this.BtnSoucin = new System.Windows.Forms.Button();
            this.NumericA = new System.Windows.Forms.NumericUpDown();
            this.NumericB = new System.Windows.Forms.NumericUpDown();
            this.LblVysledek = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericB)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSoucet
            // 
            this.BtnSoucet.Location = new System.Drawing.Point(12, 79);
            this.BtnSoucet.Name = "BtnSoucet";
            this.BtnSoucet.Size = new System.Drawing.Size(75, 23);
            this.BtnSoucet.TabIndex = 0;
            this.BtnSoucet.Text = "Sečti";
            this.BtnSoucet.UseVisualStyleBackColor = true;
            this.BtnSoucet.Click += new System.EventHandler(this.BtnSoucet_Click);
            // 
            // BtnRozdíl
            // 
            this.BtnRozdíl.Location = new System.Drawing.Point(93, 79);
            this.BtnRozdíl.Name = "BtnRozdíl";
            this.BtnRozdíl.Size = new System.Drawing.Size(75, 23);
            this.BtnRozdíl.TabIndex = 1;
            this.BtnRozdíl.Text = "Odečti";
            this.BtnRozdíl.UseVisualStyleBackColor = true;
            this.BtnRozdíl.Click += new System.EventHandler(this.BtnRozdíl_Click);
            // 
            // BtnSoucin
            // 
            this.BtnSoucin.Location = new System.Drawing.Point(174, 79);
            this.BtnSoucin.Name = "BtnSoucin";
            this.BtnSoucin.Size = new System.Drawing.Size(75, 23);
            this.BtnSoucin.TabIndex = 2;
            this.BtnSoucin.Text = "Vynásob";
            this.BtnSoucin.UseVisualStyleBackColor = true;
            this.BtnSoucin.Click += new System.EventHandler(this.BtnSoucin_Click);
            // 
            // NumericA
            // 
            this.NumericA.Location = new System.Drawing.Point(76, 14);
            this.NumericA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NumericA.Name = "NumericA";
            this.NumericA.Size = new System.Drawing.Size(173, 23);
            this.NumericA.TabIndex = 3;
            // 
            // NumericB
            // 
            this.NumericB.Location = new System.Drawing.Point(76, 43);
            this.NumericB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NumericB.Name = "NumericB";
            this.NumericB.Size = new System.Drawing.Size(173, 23);
            this.NumericB.TabIndex = 4;
            // 
            // LblVysledek
            // 
            this.LblVysledek.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblVysledek.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblVysledek.Location = new System.Drawing.Point(12, 117);
            this.LblVysledek.Name = "LblVysledek";
            this.LblVysledek.Size = new System.Drawing.Size(237, 48);
            this.LblVysledek.TabIndex = 5;
            this.LblVysledek.Text = "Zde se zobrazí výsledek";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "NumericA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "NumericB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 178);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblVysledek);
            this.Controls.Add(this.NumericB);
            this.Controls.Add(this.NumericA);
            this.Controls.Add(this.BtnSoucin);
            this.Controls.Add(this.BtnRozdíl);
            this.Controls.Add(this.BtnSoucet);
            this.Name = "Form1";
            this.Text = "Jednoduchá kalkulačka";
            ((System.ComponentModel.ISupportInitialize)(this.NumericA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSoucet;
        private System.Windows.Forms.Button BtnRozdíl;
        private System.Windows.Forms.Button BtnSoucin;
        private System.Windows.Forms.NumericUpDown NumericA;
        private System.Windows.Forms.NumericUpDown NumericB;
        private System.Windows.Forms.Label LblVysledek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

