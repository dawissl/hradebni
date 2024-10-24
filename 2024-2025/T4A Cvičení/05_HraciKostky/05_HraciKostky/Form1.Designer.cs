namespace _05_HraciKostky
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
            NumD = new NumericUpDown();
            label1 = new Label();
            lblColor = new Label();
            CheckListDices = new CheckedListBox();
            label3 = new Label();
            ColorDiag = new ColorDialog();
            BtnAdd = new Button();
            BtnRoll = new Button();
            ((System.ComponentModel.ISupportInitialize)NumD).BeginInit();
            SuspendLayout();
            // 
            // NumD
            // 
            NumD.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            NumD.Location = new Point(127, 15);
            NumD.Name = "NumD";
            NumD.Size = new Size(103, 33);
            NumD.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(23, 23);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 1;
            label1.Text = "Počet stěn";
            // 
            // lblColor
            // 
            lblColor.BackColor = Color.White;
            lblColor.BorderStyle = BorderStyle.Fixed3D;
            lblColor.Location = new Point(127, 78);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(103, 23);
            lblColor.TabIndex = 2;
            lblColor.Click += lblColor_Click;
            // 
            // CheckListDices
            // 
            CheckListDices.FormattingEnabled = true;
            CheckListDices.Location = new Point(23, 168);
            CheckListDices.Name = "CheckListDices";
            CheckListDices.Size = new Size(207, 292);
            CheckListDices.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(23, 70);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 5;
            label3.Text = "Barva";
            // 
            // BtnAdd
            // 
            BtnAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            BtnAdd.Location = new Point(23, 115);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(59, 47);
            BtnAdd.TabIndex = 6;
            BtnAdd.Text = "+";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnRoll
            // 
            BtnRoll.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BtnRoll.Location = new Point(23, 472);
            BtnRoll.Name = "BtnRoll";
            BtnRoll.Size = new Size(207, 36);
            BtnRoll.TabIndex = 7;
            BtnRoll.Text = "Hoď zvolenými kostkami";
            BtnRoll.UseVisualStyleBackColor = true;
            BtnRoll.Click += BtnRoll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 520);
            Controls.Add(BtnRoll);
            Controls.Add(BtnAdd);
            Controls.Add(label3);
            Controls.Add(CheckListDices);
            Controls.Add(lblColor);
            Controls.Add(label1);
            Controls.Add(NumD);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown NumD;
        private Label label1;
        private Label lblColor;
        private CheckedListBox CheckListDices;
        private Label label3;
        private ColorDialog ColorDiag;
        private Button BtnAdd;
        private Button BtnRoll;
    }
}
