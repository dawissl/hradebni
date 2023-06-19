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
            this.PanelDraw = new System.Windows.Forms.Panel();
            this.TimerMove = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PanelDraw
            // 
            this.PanelDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelDraw.Location = new System.Drawing.Point(25, 12);
            this.PanelDraw.Name = "PanelDraw";
            this.PanelDraw.Size = new System.Drawing.Size(500, 500);
            this.PanelDraw.TabIndex = 0;
            this.PanelDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDraw_Paint);
            this.PanelDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelDraw_MouseDown);
            // 
            // TimerMove
            // 
            this.TimerMove.Enabled = true;
            this.TimerMove.Tick += new System.EventHandler(this.TimerMove_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 523);
            this.Controls.Add(this.PanelDraw);
            this.Name = "Form1";
            this.Text = "Navádění";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelDraw;
        private System.Windows.Forms.Timer TimerMove;
    }
}