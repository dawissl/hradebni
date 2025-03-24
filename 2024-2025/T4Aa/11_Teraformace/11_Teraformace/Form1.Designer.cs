namespace _11_Teraformace
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
            axeX = new NumericUpDown();
            axeY = new NumericUpDown();
            ComboUnit = new ComboBox();
            BtnAdd = new Button();
            BtnNext = new Button();
            label1 = new Label();
            LblStatus = new Label();
            LblYear = new Label();
            ((System.ComponentModel.ISupportInitialize)axeX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)axeY).BeginInit();
            SuspendLayout();
            // 
            // axeX
            // 
            axeX.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            axeX.Location = new Point(382, 19);
            axeX.Name = "axeX";
            axeX.Size = new Size(74, 39);
            axeX.TabIndex = 0;
            // 
            // axeY
            // 
            axeY.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            axeY.Location = new Point(462, 19);
            axeY.Name = "axeY";
            axeY.Size = new Size(74, 39);
            axeY.TabIndex = 1;
            // 
            // ComboUnit
            // 
            ComboUnit.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ComboUnit.FormattingEnabled = true;
            ComboUnit.Items.AddRange(new object[] { "WATER", "OXYGEN", "TEMP" });
            ComboUnit.Location = new Point(542, 17);
            ComboUnit.Name = "ComboUnit";
            ComboUnit.Size = new Size(138, 40);
            ComboUnit.TabIndex = 2;
            // 
            // BtnAdd
            // 
            BtnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BtnAdd.Location = new Point(686, 19);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(102, 39);
            BtnAdd.TabIndex = 3;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnNext
            // 
            BtnNext.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BtnNext.Location = new Point(380, 72);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new Size(347, 48);
            BtnNext.TabIndex = 4;
            BtnNext.Text = "Next year";
            BtnNext.UseVisualStyleBackColor = true;
            BtnNext.Click += BtnNext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(382, 134);
            label1.Name = "label1";
            label1.Size = new Size(132, 30);
            label1.TabIndex = 5;
            label1.Text = "Planet status";
            // 
            // LblStatus
            // 
            LblStatus.BorderStyle = BorderStyle.Fixed3D;
            LblStatus.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            LblStatus.Location = new Point(382, 174);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(406, 195);
            LblStatus.TabIndex = 6;
            // 
            // LblYear
            // 
            LblYear.BorderStyle = BorderStyle.Fixed3D;
            LblYear.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            LblYear.Location = new Point(733, 72);
            LblYear.Name = "LblYear";
            LblYear.Size = new Size(55, 48);
            LblYear.TabIndex = 7;
            LblYear.Text = "0";
            LblYear.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblYear);
            Controls.Add(LblStatus);
            Controls.Add(label1);
            Controls.Add(BtnNext);
            Controls.Add(BtnAdd);
            Controls.Add(ComboUnit);
            Controls.Add(axeY);
            Controls.Add(axeX);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)axeX).EndInit();
            ((System.ComponentModel.ISupportInitialize)axeY).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown axeX;
        private NumericUpDown axeY;
        private ComboBox ComboUnit;
        private Button BtnAdd;
        private Button BtnNext;
        private Label label1;
        private Label LblStatus;
        private Label LblYear;
    }
}
