namespace DnD
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
            components = new System.ComponentModel.Container();
            CheckedDicesList = new CheckedListBox();
            TxtLabel = new TextBox();
            NumSides = new NumericUpDown();
            LblColor = new Label();
            ClrDialog = new ColorDialog();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BtnRoll = new Button();
            button1 = new Button();
            label4 = new Label();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)NumSides).BeginInit();
            SuspendLayout();
            // 
            // CheckedDicesList
            // 
            CheckedDicesList.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CheckedDicesList.FormattingEnabled = true;
            CheckedDicesList.Location = new Point(12, 161);
            CheckedDicesList.Name = "CheckedDicesList";
            CheckedDicesList.Size = new Size(345, 378);
            CheckedDicesList.TabIndex = 0;
            CheckedDicesList.SelectedIndexChanged += CheckedDicesList_SelectedIndexChanged;
            // 
            // TxtLabel
            // 
            TxtLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtLabel.Location = new Point(163, 6);
            TxtLabel.Name = "TxtLabel";
            TxtLabel.Size = new Size(350, 39);
            TxtLabel.TabIndex = 1;
            // 
            // NumSides
            // 
            NumSides.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NumSides.Location = new Point(163, 53);
            NumSides.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            NumSides.Name = "NumSides";
            NumSides.Size = new Size(120, 39);
            NumSides.TabIndex = 2;
            NumSides.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // LblColor
            // 
            LblColor.BackColor = Color.Black;
            LblColor.BorderStyle = BorderStyle.Fixed3D;
            LblColor.Location = new Point(163, 114);
            LblColor.Name = "LblColor";
            LblColor.Size = new Size(30, 30);
            LblColor.TabIndex = 3;
            LblColor.Click += LblColor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(145, 32);
            label1.TabIndex = 4;
            label1.Text = "Popis kostky";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(124, 32);
            label2.TabIndex = 5;
            label2.Text = "Počet stěn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 114);
            label3.Name = "label3";
            label3.Size = new Size(147, 32);
            label3.TabIndex = 6;
            label3.Text = "Barva kostky";
            // 
            // BtnRoll
            // 
            BtnRoll.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnRoll.Location = new Point(13, 559);
            BtnRoll.Name = "BtnRoll";
            BtnRoll.Size = new Size(344, 52);
            BtnRoll.TabIndex = 7;
            BtnRoll.Text = "Hod kostkami";
            BtnRoll.UseVisualStyleBackColor = true;
            BtnRoll.Click += BtnRoll_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(377, 104);
            button1.Name = "button1";
            button1.Size = new Size(136, 52);
            button1.TabIndex = 8;
            button1.Text = "Přidat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(400, 237);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 9;
            label4.Text = "label4";
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 641);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(BtnRoll);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LblColor);
            Controls.Add(NumSides);
            Controls.Add(TxtLabel);
            Controls.Add(CheckedDicesList);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumSides).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox CheckedDicesList;
        private TextBox TxtLabel;
        private NumericUpDown NumSides;
        private Label LblColor;
        private ColorDialog ClrDialog;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BtnRoll;
        private Button button1;
        private Label label4;
        private ToolTip toolTip1;
    }
}