namespace Impl
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
            NumPulsCounter = new NumericUpDown();
            TimerGenPulses = new System.Windows.Forms.Timer(components);
            PanelPulses = new Panel();
            ((System.ComponentModel.ISupportInitialize)NumPulsCounter).BeginInit();
            SuspendLayout();
            // 
            // NumPulsCounter
            // 
            NumPulsCounter.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NumPulsCounter.Location = new Point(12, 12);
            NumPulsCounter.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            NumPulsCounter.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            NumPulsCounter.Name = "NumPulsCounter";
            NumPulsCounter.Size = new Size(120, 39);
            NumPulsCounter.TabIndex = 0;
            NumPulsCounter.Value = new decimal(new int[] { 10, 0, 0, 0 });
            NumPulsCounter.ValueChanged += NumPulsCounter_ValueChanged;
            // 
            // TimerGenPulses
            // 
            TimerGenPulses.Tick += TimerGenPulses_Tick;
            // 
            // PanelPulses
            // 
            PanelPulses.BackColor = Color.White;
            PanelPulses.Location = new Point(12, 66);
            PanelPulses.Name = "PanelPulses";
            PanelPulses.Size = new Size(800, 300);
            PanelPulses.TabIndex = 1;
            PanelPulses.Paint += PanelPulses_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 393);
            Controls.Add(PanelPulses);
            Controls.Add(NumPulsCounter);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumPulsCounter).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown NumPulsCounter;
        private System.Windows.Forms.Timer TimerGenPulses;
        private Panel PanelPulses;
    }
}