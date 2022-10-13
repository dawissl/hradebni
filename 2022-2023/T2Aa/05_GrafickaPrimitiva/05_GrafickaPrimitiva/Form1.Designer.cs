
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
            this.CheckBoxTriangle = new System.Windows.Forms.CheckBox();
            this.CheckBoxSquare = new System.Windows.Forms.CheckBox();
            this.CheckBoxCircle = new System.Windows.Forms.CheckBox();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PanelDraw
            // 
            this.PanelDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelDraw.Location = new System.Drawing.Point(25, 44);
            this.PanelDraw.Name = "PanelDraw";
            this.PanelDraw.Size = new System.Drawing.Size(512, 381);
            this.PanelDraw.TabIndex = 0;
            this.PanelDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDraw_Paint);
            // 
            // CheckBoxTriangle
            // 
            this.CheckBoxTriangle.AutoSize = true;
            this.CheckBoxTriangle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxTriangle.Location = new System.Drawing.Point(591, 54);
            this.CheckBoxTriangle.Name = "CheckBoxTriangle";
            this.CheckBoxTriangle.Size = new System.Drawing.Size(114, 34);
            this.CheckBoxTriangle.TabIndex = 1;
            this.CheckBoxTriangle.Text = "polygon";
            this.CheckBoxTriangle.UseVisualStyleBackColor = true;
            // 
            // CheckBoxSquare
            // 
            this.CheckBoxSquare.AutoSize = true;
            this.CheckBoxSquare.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxSquare.Location = new System.Drawing.Point(591, 111);
            this.CheckBoxSquare.Name = "CheckBoxSquare";
            this.CheckBoxSquare.Size = new System.Drawing.Size(101, 34);
            this.CheckBoxSquare.TabIndex = 2;
            this.CheckBoxSquare.Text = "čtverec";
            this.CheckBoxSquare.UseVisualStyleBackColor = true;
            // 
            // CheckBoxCircle
            // 
            this.CheckBoxCircle.AutoSize = true;
            this.CheckBoxCircle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxCircle.Location = new System.Drawing.Point(591, 166);
            this.CheckBoxCircle.Name = "CheckBoxCircle";
            this.CheckBoxCircle.Size = new System.Drawing.Size(78, 34);
            this.CheckBoxCircle.TabIndex = 3;
            this.CheckBoxCircle.Text = "kruh";
            this.CheckBoxCircle.UseVisualStyleBackColor = true;
            // 
            // BtnDraw
            // 
            this.BtnDraw.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDraw.Location = new System.Drawing.Point(591, 224);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(125, 79);
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
            this.Controls.Add(this.CheckBoxCircle);
            this.Controls.Add(this.CheckBoxSquare);
            this.Controls.Add(this.CheckBoxTriangle);
            this.Controls.Add(this.PanelDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelDraw;
        private System.Windows.Forms.CheckBox CheckBoxTriangle;
        private System.Windows.Forms.CheckBox CheckBoxSquare;
        private System.Windows.Forms.CheckBox CheckBoxCircle;
        private System.Windows.Forms.Button BtnDraw;
    }
}

