namespace _21_KvadratickaFunkce
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
            TxtA = new TextBox();
            TxtB = new TextBox();
            TxtC = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtX2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            TxtD = new TextBox();
            label6 = new Label();
            TxtX1 = new TextBox();
            BtnCompute = new Button();
            SuspendLayout();
            // 
            // TxtA
            // 
            TxtA.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            TxtA.Location = new Point(42, 36);
            TxtA.Name = "TxtA";
            TxtA.Size = new Size(100, 31);
            TxtA.TabIndex = 0;
            // 
            // TxtB
            // 
            TxtB.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            TxtB.Location = new Point(238, 36);
            TxtB.Name = "TxtB";
            TxtB.Size = new Size(100, 31);
            TxtB.TabIndex = 1;
            // 
            // TxtC
            // 
            TxtC.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            TxtC.Location = new Point(398, 36);
            TxtC.Name = "TxtC";
            TxtC.Size = new Size(100, 31);
            TxtC.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label1.Location = new Point(157, 36);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 3;
            label1.Text = "x^2 + ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label2.Location = new Point(344, 36);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 4;
            label2.Text = "x + ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label3.Location = new Point(504, 36);
            label3.Name = "label3";
            label3.Size = new Size(45, 25);
            label3.TabIndex = 5;
            label3.Text = "= 0";
            // 
            // TxtX2
            // 
            TxtX2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            TxtX2.Location = new Point(181, 180);
            TxtX2.Name = "TxtX2";
            TxtX2.Size = new Size(100, 31);
            TxtX2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label4.Location = new Point(114, 183);
            label4.Name = "label4";
            label4.Size = new Size(37, 25);
            label4.TabIndex = 7;
            label4.Text = "x2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label5.Location = new Point(114, 112);
            label5.Name = "label5";
            label5.Size = new Size(28, 25);
            label5.TabIndex = 9;
            label5.Text = "D";
            // 
            // TxtD
            // 
            TxtD.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            TxtD.Location = new Point(181, 106);
            TxtD.Name = "TxtD";
            TxtD.Size = new Size(100, 31);
            TxtD.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label6.Location = new Point(114, 149);
            label6.Name = "label6";
            label6.Size = new Size(37, 25);
            label6.TabIndex = 11;
            label6.Text = "x1";
            // 
            // TxtX1
            // 
            TxtX1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            TxtX1.Location = new Point(181, 143);
            TxtX1.Name = "TxtX1";
            TxtX1.Size = new Size(100, 31);
            TxtX1.TabIndex = 10;
            // 
            // BtnCompute
            // 
            BtnCompute.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            BtnCompute.Location = new Point(362, 114);
            BtnCompute.Name = "BtnCompute";
            BtnCompute.Size = new Size(186, 80);
            BtnCompute.TabIndex = 12;
            BtnCompute.Text = "Spočítej";
            BtnCompute.UseVisualStyleBackColor = true;
            BtnCompute.Click += BtnCompute_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 225);
            Controls.Add(BtnCompute);
            Controls.Add(label6);
            Controls.Add(TxtX1);
            Controls.Add(label5);
            Controls.Add(TxtD);
            Controls.Add(label4);
            Controls.Add(TxtX2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtC);
            Controls.Add(TxtB);
            Controls.Add(TxtA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox TxtA;
        private TextBox TxtB;
        private TextBox TxtC;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtX2;
        private Label label4;
        private Label label5;
        private TextBox TxtD;
        private Label label6;
        private TextBox TxtX1;
        private Button BtnCompute;
    }
}