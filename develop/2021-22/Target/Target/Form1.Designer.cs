namespace Target
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
            this.components = new System.ComponentModel.Container();
            this.NumLayers = new System.Windows.Forms.NumericUpDown();
            this.BtnTarget = new System.Windows.Forms.Button();
            this.LblMajor = new System.Windows.Forms.Label();
            this.LblMinor = new System.Windows.Forms.Label();
            this.ColorMajor = new System.Windows.Forms.ColorDialog();
            this.ColorMinor = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NumLayers)).BeginInit();
            this.SuspendLayout();
            // 
            // NumLayers
            // 
            this.NumLayers.Location = new System.Drawing.Point(617, 54);
            this.NumLayers.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumLayers.Name = "NumLayers";
            this.NumLayers.Size = new System.Drawing.Size(120, 23);
            this.NumLayers.TabIndex = 0;
            this.NumLayers.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // BtnTarget
            // 
            this.BtnTarget.Location = new System.Drawing.Point(617, 98);
            this.BtnTarget.Name = "BtnTarget";
            this.BtnTarget.Size = new System.Drawing.Size(120, 28);
            this.BtnTarget.TabIndex = 1;
            this.BtnTarget.Text = "Vykresli terč";
            this.BtnTarget.UseVisualStyleBackColor = true;
            this.BtnTarget.Click += new System.EventHandler(this.BtnTarget_Click);
            // 
            // LblMajor
            // 
            this.LblMajor.BackColor = System.Drawing.Color.Red;
            this.LblMajor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMajor.Location = new System.Drawing.Point(617, 143);
            this.LblMajor.Name = "LblMajor";
            this.LblMajor.Size = new System.Drawing.Size(120, 23);
            this.LblMajor.TabIndex = 2;
            this.LblMajor.Click += new System.EventHandler(this.LblMajor_Click);
            // 
            // LblMinor
            // 
            this.LblMinor.BackColor = System.Drawing.Color.Lime;
            this.LblMinor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMinor.Location = new System.Drawing.Point(617, 181);
            this.LblMinor.Name = "LblMinor";
            this.LblMinor.Size = new System.Drawing.Size(120, 23);
            this.LblMinor.TabIndex = 3;
            this.LblMinor.Click += new System.EventHandler(this.LblMinor_Click);
            // 
            // ColorMajor
            // 
            this.ColorMajor.Color = System.Drawing.Color.Red;
            // 
            // ColorMinor
            // 
            this.ColorMinor.Color = System.Drawing.Color.Lime;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(19, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 400);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblMinor);
            this.Controls.Add(this.LblMajor);
            this.Controls.Add(this.BtnTarget);
            this.Controls.Add(this.NumLayers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumLayers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NumericUpDown NumLayers;
        private Button BtnTarget;
        private Label LblMajor;
        private Label LblMinor;
        private ColorDialog ColorMajor;
        private ColorDialog ColorMinor;
        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}