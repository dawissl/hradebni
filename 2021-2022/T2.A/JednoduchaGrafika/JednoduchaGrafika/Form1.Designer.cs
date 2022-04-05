namespace JednoduchaGrafika
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
            this.Panel = new System.Windows.Forms.Panel();
            this.CheckTriangle = new System.Windows.Forms.CheckBox();
            this.CheckSquare = new System.Windows.Forms.CheckBox();
            this.CheckCircle = new System.Windows.Forms.CheckBox();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.White;
            this.Panel.Location = new System.Drawing.Point(1, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(400, 560);
            this.Panel.TabIndex = 0;
            this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // CheckTriangle
            // 
            this.CheckTriangle.AutoSize = true;
            this.CheckTriangle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckTriangle.Location = new System.Drawing.Point(422, 50);
            this.CheckTriangle.Name = "CheckTriangle";
            this.CheckTriangle.Size = new System.Drawing.Size(132, 34);
            this.CheckTriangle.TabIndex = 1;
            this.CheckTriangle.Text = "Trojúhelník";
            this.CheckTriangle.UseVisualStyleBackColor = true;
            // 
            // CheckSquare
            // 
            this.CheckSquare.AutoSize = true;
            this.CheckSquare.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckSquare.Location = new System.Drawing.Point(422, 114);
            this.CheckSquare.Name = "CheckSquare";
            this.CheckSquare.Size = new System.Drawing.Size(101, 34);
            this.CheckSquare.TabIndex = 2;
            this.CheckSquare.Text = "Čtverec";
            this.CheckSquare.UseVisualStyleBackColor = true;
            // 
            // CheckCircle
            // 
            this.CheckCircle.AutoSize = true;
            this.CheckCircle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckCircle.Location = new System.Drawing.Point(422, 179);
            this.CheckCircle.Name = "CheckCircle";
            this.CheckCircle.Size = new System.Drawing.Size(75, 34);
            this.CheckCircle.TabIndex = 3;
            this.CheckCircle.Text = "Kruh";
            this.CheckCircle.UseVisualStyleBackColor = true;
            // 
            // BtnDraw
            // 
            this.BtnDraw.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDraw.Location = new System.Drawing.Point(407, 256);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(150, 62);
            this.BtnDraw.TabIndex = 4;
            this.BtnDraw.Text = "Překreslit";
            this.BtnDraw.UseVisualStyleBackColor = true;
            this.BtnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.BtnDraw);
            this.Controls.Add(this.CheckCircle);
            this.Controls.Add(this.CheckSquare);
            this.Controls.Add(this.CheckTriangle);
            this.Controls.Add(this.Panel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel Panel;
        private CheckBox CheckTriangle;
        private CheckBox CheckSquare;
        private CheckBox CheckCircle;
        private Button BtnDraw;
    }
}