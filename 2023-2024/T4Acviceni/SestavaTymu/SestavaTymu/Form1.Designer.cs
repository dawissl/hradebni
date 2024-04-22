namespace SestavaTymu
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            Rad221 = new RadioButton();
            Rad311 = new RadioButton();
            Rad131 = new RadioButton();
            button2 = new Button();
            button3 = new Button();
            lblDefault = new TextBox();
            lblSorted = new TextBox();
            PanelTeam = new Panel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(755, 30);
            button1.Name = "button1";
            button1.Size = new Size(118, 59);
            button1.TabIndex = 0;
            button1.Text = "Try it!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 12);
            label1.Name = "label1";
            label1.Size = new Size(85, 30);
            label1.TabIndex = 3;
            label1.Text = "Vychozi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(373, 9);
            label2.Name = "label2";
            label2.Size = new Size(97, 30);
            label2.TabIndex = 4;
            label2.Text = "Serazene";
            // 
            // Rad221
            // 
            Rad221.AutoSize = true;
            Rad221.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Rad221.Location = new Point(373, 402);
            Rad221.Name = "Rad221";
            Rad221.Size = new Size(80, 34);
            Rad221.TabIndex = 5;
            Rad221.TabStop = true;
            Rad221.Text = "2-2-1";
            Rad221.UseVisualStyleBackColor = true;
            // 
            // Rad311
            // 
            Rad311.AutoSize = true;
            Rad311.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Rad311.Location = new Point(373, 442);
            Rad311.Name = "Rad311";
            Rad311.Size = new Size(80, 34);
            Rad311.TabIndex = 6;
            Rad311.TabStop = true;
            Rad311.Text = "3-1-1";
            Rad311.UseVisualStyleBackColor = true;
            // 
            // Rad131
            // 
            Rad131.AutoSize = true;
            Rad131.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Rad131.Location = new Point(373, 482);
            Rad131.Name = "Rad131";
            Rad131.Size = new Size(80, 34);
            Rad131.TabIndex = 7;
            Rad131.TabStop = true;
            Rad131.Text = "1-3-1";
            Rad131.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(483, 430);
            button2.Name = "button2";
            button2.Size = new Size(118, 59);
            button2.TabIndex = 8;
            button2.Text = "Sestava";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(755, 105);
            button3.Name = "button3";
            button3.Size = new Size(118, 59);
            button3.TabIndex = 9;
            button3.Text = "From File";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lblDefault
            // 
            lblDefault.Location = new Point(17, 54);
            lblDefault.Multiline = true;
            lblDefault.Name = "lblDefault";
            lblDefault.ScrollBars = ScrollBars.Vertical;
            lblDefault.Size = new Size(318, 254);
            lblDefault.TabIndex = 10;
            // 
            // lblSorted
            // 
            lblSorted.Location = new Point(373, 53);
            lblSorted.Multiline = true;
            lblSorted.Name = "lblSorted";
            lblSorted.ScrollBars = ScrollBars.Vertical;
            lblSorted.Size = new Size(318, 254);
            lblSorted.TabIndex = 11;
            // 
            // PanelTeam
            // 
            PanelTeam.BackColor = Color.White;
            PanelTeam.BorderStyle = BorderStyle.Fixed3D;
            PanelTeam.Location = new Point(17, 331);
            PanelTeam.Name = "PanelTeam";
            PanelTeam.Size = new Size(318, 250);
            PanelTeam.TabIndex = 12;
            PanelTeam.Paint += PanelTeam_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 600);
            Controls.Add(PanelTeam);
            Controls.Add(lblSorted);
            Controls.Add(lblDefault);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Rad131);
            Controls.Add(Rad311);
            Controls.Add(Rad221);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private RadioButton Rad221;
        private RadioButton Rad311;
        private RadioButton Rad131;
        private Button button2;
        private Button button3;
        private TextBox lblDefault;
        private TextBox lblSorted;
        private Panel PanelTeam;
    }
}