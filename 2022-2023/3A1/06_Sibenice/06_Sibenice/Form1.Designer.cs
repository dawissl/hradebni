namespace _06_Sibenice
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
            this.LblResult = new System.Windows.Forms.Label();
            this.BtnGuess = new System.Windows.Forms.Button();
            this.LblLives = new System.Windows.Forms.Label();
            this.TxtLetter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblResult
            // 
            this.LblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblResult.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblResult.Location = new System.Drawing.Point(52, 107);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(513, 56);
            this.LblResult.TabIndex = 0;
            this.LblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnGuess
            // 
            this.BtnGuess.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuess.Location = new System.Drawing.Point(174, 37);
            this.BtnGuess.Name = "BtnGuess";
            this.BtnGuess.Size = new System.Drawing.Size(115, 40);
            this.BtnGuess.TabIndex = 1;
            this.BtnGuess.Text = "Hádej";
            this.BtnGuess.UseVisualStyleBackColor = true;
            this.BtnGuess.Click += new System.EventHandler(this.BtnGuess_Click);
            // 
            // LblLives
            // 
            this.LblLives.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblLives.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblLives.Location = new System.Drawing.Point(455, 25);
            this.LblLives.Name = "LblLives";
            this.LblLives.Size = new System.Drawing.Size(79, 51);
            this.LblLives.TabIndex = 2;
            this.LblLives.Text = "13";
            this.LblLives.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtLetter
            // 
            this.TxtLetter.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtLetter.Location = new System.Drawing.Point(68, 37);
            this.TxtLetter.Name = "TxtLetter";
            this.TxtLetter.Size = new System.Drawing.Size(100, 39);
            this.TxtLetter.TabIndex = 3;
            this.TxtLetter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtLetter_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 450);
            this.Controls.Add(this.TxtLetter);
            this.Controls.Add(this.LblLives);
            this.Controls.Add(this.BtnGuess);
            this.Controls.Add(this.LblResult);
            this.Name = "Form1";
            this.Text = "Šibenice";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblResult;
        private Button BtnGuess;
        private Label LblLives;
        private TextBox TxtLetter;
    }
}