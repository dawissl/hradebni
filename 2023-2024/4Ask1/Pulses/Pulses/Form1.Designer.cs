namespace Pulses
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
            NumPulseCount = new NumericUpDown();
            PanelPulses = new Panel();
            TimerPulseGenerator = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)NumPulseCount).BeginInit();
            SuspendLayout();
            // 
            // NumPulseCount
            // 
            NumPulseCount.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NumPulseCount.Location = new Point(12, 12);
            NumPulseCount.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            NumPulseCount.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            NumPulseCount.Name = "NumPulseCount";
            NumPulseCount.Size = new Size(120, 39);
            NumPulseCount.TabIndex = 0;
            NumPulseCount.Value = new decimal(new int[] { 10, 0, 0, 0 });
            NumPulseCount.ValueChanged += NumPulseCount_ValueChanged;
            // 
            // PanelPulses
            // 
            PanelPulses.BackColor = Color.White;
            PanelPulses.BorderStyle = BorderStyle.Fixed3D;
            PanelPulses.Location = new Point(16, 63);
            PanelPulses.Name = "PanelPulses";
            PanelPulses.Size = new Size(800, 300);
            PanelPulses.TabIndex = 1;
            PanelPulses.Paint += PanelPulses_Paint;
            // 
            // TimerPulseGenerator
            // 
            TimerPulseGenerator.Tick += TimerPulseGenerator_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 378);
            Controls.Add(PanelPulses);
            Controls.Add(NumPulseCount);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumPulseCount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown NumPulseCount;
        private Panel PanelPulses;
        private System.Windows.Forms.Timer TimerPulseGenerator;
    }
}