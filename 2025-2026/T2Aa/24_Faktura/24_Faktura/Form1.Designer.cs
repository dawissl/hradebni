namespace _24_Faktura
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F);
            textBox1.Location = new Point(127, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 35);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.Location = new Point(38, 36);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 1;
            label1.Text = "Název";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F);
            label2.Location = new Point(38, 86);
            label2.Name = "label2";
            label2.Size = new Size(85, 30);
            label2.TabIndex = 3;
            label2.Text = "Cena ks";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15.75F);
            textBox2.Location = new Point(127, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(176, 35);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F);
            label3.Location = new Point(38, 201);
            label3.Name = "label3";
            label3.Size = new Size(51, 30);
            label3.TabIndex = 5;
            label3.Text = "Daň";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F);
            label4.Location = new Point(38, 139);
            label4.Name = "label4";
            label4.Size = new Size(64, 30);
            label4.TabIndex = 6;
            label4.Text = "Počet";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            numericUpDown1.Location = new Point(136, 139);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(167, 35);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "snížená 15 %", "základní 21 %", "zvýšená 27 %" });
            comboBox1.Location = new Point(136, 201);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(167, 38);
            comboBox1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F);
            label5.Location = new Point(35, 345);
            label5.Name = "label5";
            label5.Size = new Size(81, 30);
            label5.TabIndex = 9;
            label5.Text = "Celkem";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F);
            label6.Location = new Point(39, 397);
            label6.Name = "label6";
            label6.Size = new Size(144, 30);
            label6.TabIndex = 10;
            label6.Text = "Celkem s DPH";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F);
            label7.Location = new Point(189, 345);
            label7.Name = "label7";
            label7.Size = new Size(81, 30);
            label7.TabIndex = 11;
            label7.Text = "Celkem";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F);
            label8.Location = new Point(189, 397);
            label8.Name = "label8";
            label8.Size = new Size(81, 30);
            label8.TabIndex = 12;
            label8.Text = "Celkem";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(395, 29);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(312, 394);
            listBox1.TabIndex = 13;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(66, 266);
            button1.Name = "button1";
            button1.Size = new Size(204, 65);
            button1.TabIndex = 14;
            button1.Text = "Přidat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ListBox listBox1;
        private Button button1;
    }
}