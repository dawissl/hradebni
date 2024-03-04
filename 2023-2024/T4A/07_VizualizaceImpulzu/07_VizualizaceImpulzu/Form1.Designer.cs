namespace _07_VizualizaceImpulzu
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
            GenPulseTimer = new System.Windows.Forms.Timer(components);
            BtnStart = new Button();
            TxtIntervals = new TextBox();
            PanelPulses = new Panel();
            NumPulses = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)NumPulses).BeginInit();
            SuspendLayout();
            // 
            // GenPulseTimer
            // 
            GenPulseTimer.Tick += GenPulseTimer_Tick;
            // 
            // BtnStart
            // 
            BtnStart.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnStart.Location = new Point(12, 12);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(191, 67);
            BtnStart.TabIndex = 0;
            BtnStart.Text = "Start";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // TxtIntervals
            // 
            TxtIntervals.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtIntervals.Location = new Point(14, 87);
            TxtIntervals.Multiline = true;
            TxtIntervals.Name = "TxtIntervals";
            TxtIntervals.ReadOnly = true;
            TxtIntervals.ScrollBars = ScrollBars.Vertical;
            TxtIntervals.Size = new Size(187, 353);
            TxtIntervals.TabIndex = 1;
            // 
            // PanelPulses
            // 
            PanelPulses.BackColor = Color.White;
            PanelPulses.Location = new Point(238, 87);
            PanelPulses.Name = "PanelPulses";
            PanelPulses.Size = new Size(1000, 500);
            PanelPulses.TabIndex = 2;
            PanelPulses.Paint += PanelPulses_Paint;
            // 
            // NumPulses
            // 
            NumPulses.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NumPulses.Location = new Point(238, 41);
            NumPulses.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            NumPulses.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            NumPulses.Name = "NumPulses";
            NumPulses.Size = new Size(277, 39);
            NumPulses.TabIndex = 3;
            NumPulses.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 596);
            Controls.Add(NumPulses);
            Controls.Add(PanelPulses);
            Controls.Add(TxtIntervals);
            Controls.Add(BtnStart);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumPulses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer GenPulseTimer;
        private Button BtnStart;
        private TextBox TxtIntervals;
        private Panel PanelPulses;
        private NumericUpDown NumPulses;
    }
}