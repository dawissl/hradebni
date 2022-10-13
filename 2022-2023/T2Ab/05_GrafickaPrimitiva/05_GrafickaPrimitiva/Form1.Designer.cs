
namespace _05_GrafickaPrimitiva
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
            this.PanelDraw = new System.Windows.Forms.Panel();
            this.CheckPolygon = new System.Windows.Forms.CheckBox();
            this.CheckEllipse = new System.Windows.Forms.CheckBox();
            this.CheckRectangle = new System.Windows.Forms.CheckBox();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PanelDraw
            // 
            this.PanelDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelDraw.Location = new System.Drawing.Point(12, 12);
            this.PanelDraw.Name = "PanelDraw";
            this.PanelDraw.Size = new System.Drawing.Size(530, 426);
            this.PanelDraw.TabIndex = 0;
            this.PanelDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDraw_Paint);
            // 
            // CheckPolygon
            // 
            this.CheckPolygon.AutoSize = true;
            this.CheckPolygon.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckPolygon.Location = new System.Drawing.Point(585, 36);
            this.CheckPolygon.Name = "CheckPolygon";
            this.CheckPolygon.Size = new System.Drawing.Size(114, 34);
            this.CheckPolygon.TabIndex = 1;
            this.CheckPolygon.Text = "polygon";
            this.CheckPolygon.UseVisualStyleBackColor = true;
            // 
            // CheckEllipse
            // 
            this.CheckEllipse.AutoSize = true;
            this.CheckEllipse.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckEllipse.Location = new System.Drawing.Point(585, 90);
            this.CheckEllipse.Name = "CheckEllipse";
            this.CheckEllipse.Size = new System.Drawing.Size(88, 34);
            this.CheckEllipse.TabIndex = 2;
            this.CheckEllipse.Text = "elipsa";
            this.CheckEllipse.UseVisualStyleBackColor = true;
            // 
            // CheckRectangle
            // 
            this.CheckRectangle.AutoSize = true;
            this.CheckRectangle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckRectangle.Location = new System.Drawing.Point(585, 149);
            this.CheckRectangle.Name = "CheckRectangle";
            this.CheckRectangle.Size = new System.Drawing.Size(119, 34);
            this.CheckRectangle.TabIndex = 3;
            this.CheckRectangle.Text = "obdelnik";
            this.CheckRectangle.UseVisualStyleBackColor = true;
            // 
            // BtnDraw
            // 
            this.BtnDraw.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDraw.Location = new System.Drawing.Point(585, 225);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(141, 73);
            this.BtnDraw.TabIndex = 4;
            this.BtnDraw.Text = "Vykresli";
            this.BtnDraw.UseVisualStyleBackColor = true;
            this.BtnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDraw);
            this.Controls.Add(this.CheckRectangle);
            this.Controls.Add(this.CheckEllipse);
            this.Controls.Add(this.CheckPolygon);
            this.Controls.Add(this.PanelDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelDraw;
        private System.Windows.Forms.CheckBox CheckPolygon;
        private System.Windows.Forms.CheckBox CheckEllipse;
        private System.Windows.Forms.CheckBox CheckRectangle;
        private System.Windows.Forms.Button BtnDraw;
    }
}

