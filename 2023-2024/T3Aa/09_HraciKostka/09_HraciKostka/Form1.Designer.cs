namespace _09_HraciKostka
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
            TxtLabel = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            NumSides = new NumericUpDown();
            LblClr = new Label();
            ClrDialog = new ColorDialog();
            BtnAdd = new Button();
            BtnRoll = new Button();
            ((System.ComponentModel.ISupportInitialize)NumSides).BeginInit();
            SuspendLayout();
            // 
            // TxtLabel
            // 
            TxtLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtLabel.Location = new Point(100, 17);
            TxtLabel.Name = "TxtLabel";
            TxtLabel.Size = new Size(253, 43);
            TxtLabel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(82, 37);
            label1.TabIndex = 1;
            label1.Text = "Štítek";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(138, 37);
            label2.TabIndex = 3;
            label2.Text = "Počet stěn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 118);
            label3.Name = "label3";
            label3.Size = new Size(82, 37);
            label3.TabIndex = 5;
            label3.Text = "Barva";
            // 
            // NumSides
            // 
            NumSides.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NumSides.Location = new Point(156, 71);
            NumSides.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            NumSides.Name = "NumSides";
            NumSides.Size = new Size(197, 39);
            NumSides.TabIndex = 6;
            NumSides.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // LblClr
            // 
            LblClr.BackColor = Color.Black;
            LblClr.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblClr.Location = new Point(122, 118);
            LblClr.Name = "LblClr";
            LblClr.Size = new Size(82, 37);
            LblClr.TabIndex = 7;
            LblClr.Click += LblClr_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAdd.Location = new Point(9, 175);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(265, 68);
            BtnAdd.TabIndex = 8;
            BtnAdd.Text = "Přidat";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnRoll
            // 
            BtnRoll.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnRoll.Location = new Point(12, 249);
            BtnRoll.Name = "BtnRoll";
            BtnRoll.Size = new Size(262, 68);
            BtnRoll.TabIndex = 9;
            BtnRoll.Text = "Hod kostkami (0)";
            BtnRoll.UseVisualStyleBackColor = true;
            BtnRoll.Click += BtnRoll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnRoll);
            Controls.Add(BtnAdd);
            Controls.Add(LblClr);
            Controls.Add(NumSides);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtLabel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumSides).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown NumSides;
        private Label LblClr;
        private ColorDialog ClrDialog;
        private Button BtnAdd;
        private Button BtnRoll;
    }
}