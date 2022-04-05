
namespace RandomObject
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
            this.CheckTriangle = new System.Windows.Forms.CheckBox();
            this.CheckCircle = new System.Windows.Forms.CheckBox();
            this.CheckSquare = new System.Windows.Forms.CheckBox();
            this.BtnAction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(14, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 425);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CheckTriangle
            // 
            this.CheckTriangle.AutoSize = true;
            this.CheckTriangle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckTriangle.Location = new System.Drawing.Point(640, 36);
            this.CheckTriangle.Name = "CheckTriangle";
            this.CheckTriangle.Size = new System.Drawing.Size(132, 34);
            this.CheckTriangle.TabIndex = 1;
            this.CheckTriangle.Text = "Trojúhelník";
            this.CheckTriangle.UseVisualStyleBackColor = true;
            // 
            // CheckCircle
            // 
            this.CheckCircle.AutoSize = true;
            this.CheckCircle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckCircle.Location = new System.Drawing.Point(640, 76);
            this.CheckCircle.Name = "CheckCircle";
            this.CheckCircle.Size = new System.Drawing.Size(75, 34);
            this.CheckCircle.TabIndex = 2;
            this.CheckCircle.Text = "Kruh";
            this.CheckCircle.UseVisualStyleBackColor = true;
            // 
            // CheckSquare
            // 
            this.CheckSquare.AutoSize = true;
            this.CheckSquare.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckSquare.Location = new System.Drawing.Point(640, 116);
            this.CheckSquare.Name = "CheckSquare";
            this.CheckSquare.Size = new System.Drawing.Size(101, 34);
            this.CheckSquare.TabIndex = 3;
            this.CheckSquare.Text = "Čtverec";
            this.CheckSquare.UseVisualStyleBackColor = true;
            // 
            // BtnAction
            // 
            this.BtnAction.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAction.Location = new System.Drawing.Point(641, 165);
            this.BtnAction.Name = "BtnAction";
            this.BtnAction.Size = new System.Drawing.Size(144, 48);
            this.BtnAction.TabIndex = 4;
            this.BtnAction.Text = "Vykresli";
            this.BtnAction.UseVisualStyleBackColor = true;
            this.BtnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAction);
            this.Controls.Add(this.CheckSquare);
            this.Controls.Add(this.CheckCircle);
            this.Controls.Add(this.CheckTriangle);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Náhodné obrazce";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox CheckTriangle;
        private System.Windows.Forms.CheckBox CheckCircle;
        private System.Windows.Forms.CheckBox CheckSquare;
        private System.Windows.Forms.Button BtnAction;
    }
}

