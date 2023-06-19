namespace _23_AnimaceNavadeni
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
            this.PanelMotion = new System.Windows.Forms.Panel();
            this.TimerMotion = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PanelMotion
            // 
            this.PanelMotion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMotion.Location = new System.Drawing.Point(8, 4);
            this.PanelMotion.Name = "PanelMotion";
            this.PanelMotion.Size = new System.Drawing.Size(500, 400);
            this.PanelMotion.TabIndex = 0;
            this.PanelMotion.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMotion_Paint);
            this.PanelMotion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelMotion_MouseDown);
            // 
            // TimerMotion
            // 
            this.TimerMotion.Enabled = true;
            this.TimerMotion.Interval = 10;
            this.TimerMotion.Tick += new System.EventHandler(this.TimerMotion_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 417);
            this.Controls.Add(this.PanelMotion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelMotion;
        private System.Windows.Forms.Timer TimerMotion;
    }
}