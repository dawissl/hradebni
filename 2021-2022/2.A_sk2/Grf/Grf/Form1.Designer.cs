
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.coordX = new System.Windows.Forms.NumericUpDown();
            this.coordY = new System.Windows.Forms.NumericUpDown();
            this.BtnRepaint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.coordX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordY)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(15, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 416);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // coordX
            // 
            this.coordX.Location = new System.Drawing.Point(761, 40);
            this.coordX.Name = "coordX";
            this.coordX.Size = new System.Drawing.Size(120, 23);
            this.coordX.TabIndex = 1;
            this.coordX.ValueChanged += new System.EventHandler(this.coordX_ValueChanged);
            // 
            // coordY
            // 
            this.coordY.Location = new System.Drawing.Point(761, 86);
            this.coordY.Name = "coordY";
            this.coordY.Size = new System.Drawing.Size(120, 23);
            this.coordY.TabIndex = 2;
            this.coordY.ValueChanged += new System.EventHandler(this.coordY_ValueChanged);
            // 
            // BtnRepaint
            // 
            this.BtnRepaint.Location = new System.Drawing.Point(759, 132);
            this.BtnRepaint.Name = "BtnRepaint";
            this.BtnRepaint.Size = new System.Drawing.Size(121, 42);
            this.BtnRepaint.TabIndex = 3;
            this.BtnRepaint.Text = "Překresli";
            this.BtnRepaint.UseVisualStyleBackColor = true;
            this.BtnRepaint.Click += new System.EventHandler(this.BtnRepaint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 442);
            this.Controls.Add(this.BtnRepaint);
            this.Controls.Add(this.coordY);
            this.Controls.Add(this.coordX);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.coordX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown coordX;
        private System.Windows.Forms.NumericUpDown coordY;
        private System.Windows.Forms.Button BtnRepaint;
    }
}

