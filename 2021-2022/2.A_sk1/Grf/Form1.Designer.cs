
namespace Grf
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.axeX = new System.Windows.Forms.NumericUpDown();
            this.axeY = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axeY)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(15, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 417);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kresli";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // axeX
            // 
            this.axeX.Location = new System.Drawing.Point(634, 35);
            this.axeX.Name = "axeX";
            this.axeX.Size = new System.Drawing.Size(120, 23);
            this.axeX.TabIndex = 2;
            this.axeX.ValueChanged += new System.EventHandler(this.axeX_ValueChanged);
            // 
            // axeY
            // 
            this.axeY.Location = new System.Drawing.Point(634, 76);
            this.axeY.Name = "axeY";
            this.axeY.Size = new System.Drawing.Size(120, 23);
            this.axeY.TabIndex = 3;
            this.axeY.ValueChanged += new System.EventHandler(this.axeY_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.axeY);
            this.Controls.Add(this.axeX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axeY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown axeX;
        private System.Windows.Forms.NumericUpDown axeY;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

