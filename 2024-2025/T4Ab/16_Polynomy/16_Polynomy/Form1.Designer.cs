namespace _16_Polynomy
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
            txtA = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TxtB = new TextBox();
            label3 = new Label();
            TxtC = new TextBox();
            TxtD = new TextBox();
            label4 = new Label();
            BtnAdd = new Button();
            panel1 = new Panel();
            ListPolynoms = new CheckedListBox();
            BtnDraw = new Button();
            SuspendLayout();
            // 
            // txtA
            // 
            txtA.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtA.Location = new Point(100, 12);
            txtA.Name = "txtA";
            txtA.Size = new Size(76, 39);
            txtA.TabIndex = 0;
            txtA.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(182, 19);
            label1.Name = "label1";
            label1.Size = new Size(84, 32);
            label1.TabIndex = 1;
            label1.Text = "x^3 + ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(337, 19);
            label2.Name = "label2";
            label2.Size = new Size(84, 32);
            label2.TabIndex = 3;
            label2.Text = "x^2 + ";
            // 
            // TxtB
            // 
            TxtB.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TxtB.Location = new Point(255, 12);
            TxtB.Name = "TxtB";
            TxtB.Size = new Size(76, 39);
            TxtB.TabIndex = 2;
            TxtB.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(490, 23);
            label3.Name = "label3";
            label3.Size = new Size(55, 32);
            label3.TabIndex = 5;
            label3.Text = "x + ";
            // 
            // TxtC
            // 
            TxtC.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TxtC.Location = new Point(408, 12);
            TxtC.Name = "TxtC";
            TxtC.Size = new Size(76, 39);
            TxtC.TabIndex = 4;
            TxtC.Text = "0";
            // 
            // TxtD
            // 
            TxtD.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TxtD.Location = new Point(542, 16);
            TxtD.Name = "TxtD";
            TxtD.Size = new Size(76, 39);
            TxtD.TabIndex = 6;
            TxtD.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(24, 15);
            label4.Name = "label4";
            label4.Size = new Size(70, 32);
            label4.TabIndex = 7;
            label4.Text = "f(x) =";
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(644, 18);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(130, 41);
            BtnAdd.TabIndex = 8;
            BtnAdd.Text = "Přidat";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(45, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 400);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // ListPolynoms
            // 
            ListPolynoms.FormattingEnabled = true;
            ListPolynoms.Location = new Point(506, 78);
            ListPolynoms.Name = "ListPolynoms";
            ListPolynoms.Size = new Size(268, 346);
            ListPolynoms.TabIndex = 10;
            // 
            // BtnDraw
            // 
            BtnDraw.Location = new Point(506, 435);
            BtnDraw.Name = "BtnDraw";
            BtnDraw.Size = new Size(268, 41);
            BtnDraw.TabIndex = 11;
            BtnDraw.Text = "Vykresli";
            BtnDraw.UseVisualStyleBackColor = true;
            BtnDraw.Click += BtnDraw_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 503);
            Controls.Add(BtnDraw);
            Controls.Add(ListPolynoms);
            Controls.Add(panel1);
            Controls.Add(BtnAdd);
            Controls.Add(label4);
            Controls.Add(TxtD);
            Controls.Add(label3);
            Controls.Add(TxtC);
            Controls.Add(label2);
            Controls.Add(TxtB);
            Controls.Add(label1);
            Controls.Add(txtA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtA;
        private Label label1;
        private Label label2;
        private TextBox TxtB;
        private Label label3;
        private TextBox TxtC;
        private TextBox TxtD;
        private Label label4;
        private Button BtnAdd;
        private Panel panel1;
        private CheckedListBox ListPolynoms;
        private Button BtnDraw;
    }
}
