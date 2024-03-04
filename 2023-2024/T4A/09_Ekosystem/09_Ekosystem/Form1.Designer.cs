namespace _09_Ekosystem
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
            NumArea = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            NumRiver = new NumericUpDown();
            label3 = new Label();
            NumSheep = new NumericUpDown();
            label4 = new Label();
            NumWolf = new NumericUpDown();
            ButtonSimulate = new Button();
            TxtSimulation = new TextBox();
            ((System.ComponentModel.ISupportInitialize)NumArea).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumRiver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumSheep).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumWolf).BeginInit();
            SuspendLayout();
            // 
            // NumArea
            // 
            NumArea.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NumArea.Location = new Point(148, 29);
            NumArea.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            NumArea.Name = "NumArea";
            NumArea.Size = new Size(161, 39);
            NumArea.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(72, 30);
            label1.TabIndex = 1;
            label1.Text = "Pastva";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(57, 30);
            label2.TabIndex = 3;
            label2.Text = "Řeka";
            // 
            // NumRiver
            // 
            NumRiver.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NumRiver.Location = new Point(148, 74);
            NumRiver.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            NumRiver.Name = "NumRiver";
            NumRiver.Size = new Size(161, 39);
            NumRiver.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 128);
            label3.Name = "label3";
            label3.Size = new Size(60, 30);
            label3.TabIndex = 5;
            label3.Text = "Ovce";
            // 
            // NumSheep
            // 
            NumSheep.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NumSheep.Location = new Point(148, 119);
            NumSheep.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            NumSheep.Name = "NumSheep";
            NumSheep.Size = new Size(161, 39);
            NumSheep.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 173);
            label4.Name = "label4";
            label4.Size = new Size(46, 30);
            label4.TabIndex = 7;
            label4.Text = "Vlci";
            // 
            // NumWolf
            // 
            NumWolf.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NumWolf.Location = new Point(148, 164);
            NumWolf.Name = "NumWolf";
            NumWolf.Size = new Size(161, 39);
            NumWolf.TabIndex = 6;
            // 
            // ButtonSimulate
            // 
            ButtonSimulate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSimulate.Location = new Point(37, 247);
            ButtonSimulate.Name = "ButtonSimulate";
            ButtonSimulate.Size = new Size(217, 61);
            ButtonSimulate.TabIndex = 8;
            ButtonSimulate.Text = "Simulace";
            ButtonSimulate.UseVisualStyleBackColor = true;
            ButtonSimulate.Click += ButtonSimulate_Click;
            // 
            // TxtSimulation
            // 
            TxtSimulation.Location = new Point(340, 27);
            TxtSimulation.Multiline = true;
            TxtSimulation.Name = "TxtSimulation";
            TxtSimulation.ReadOnly = true;
            TxtSimulation.ScrollBars = ScrollBars.Vertical;
            TxtSimulation.Size = new Size(420, 409);
            TxtSimulation.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtSimulation);
            Controls.Add(ButtonSimulate);
            Controls.Add(label4);
            Controls.Add(NumWolf);
            Controls.Add(label3);
            Controls.Add(NumSheep);
            Controls.Add(label2);
            Controls.Add(NumRiver);
            Controls.Add(label1);
            Controls.Add(NumArea);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumArea).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumRiver).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumSheep).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumWolf).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown NumArea;
        private Label label1;
        private Label label2;
        private NumericUpDown NumRiver;
        private Label label3;
        private NumericUpDown NumSheep;
        private Label label4;
        private NumericUpDown NumWolf;
        private Button ButtonSimulate;
        private TextBox TxtSimulation;
    }
}