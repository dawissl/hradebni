namespace ScreenSaver
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
            TimerScreen = new System.Windows.Forms.Timer(components);
            TimerAnimation = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // TimerScreen
            // 
            TimerScreen.Enabled = true;
            TimerScreen.Interval = 1000;
            TimerScreen.Tick += TimerScreen_Tick;
            // 
            // TimerAnimation
            // 
            TimerAnimation.Enabled = true;
            TimerAnimation.Tick += TimerAnimation_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(184, 161);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            MouseHover += Form1_MouseHover;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer TimerScreen;
        private System.Windows.Forms.Timer TimerAnimation;
    }
}