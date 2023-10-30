namespace _04_Kino
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
            this.NumSizeX = new System.Windows.Forms.NumericUpDown();
            this.BtnGenerete = new System.Windows.Forms.Button();
            this.NumSizeY = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumSizeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSizeY)).BeginInit();
            this.SuspendLayout();
            // 
            // NumSizeX
            // 
            this.NumSizeX.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumSizeX.Location = new System.Drawing.Point(12, 12);
            this.NumSizeX.Name = "NumSizeX";
            this.NumSizeX.Size = new System.Drawing.Size(120, 35);
            this.NumSizeX.TabIndex = 0;
            // 
            // BtnGenerete
            // 
            this.BtnGenerete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGenerete.Location = new System.Drawing.Point(264, 12);
            this.BtnGenerete.Name = "BtnGenerete";
            this.BtnGenerete.Size = new System.Drawing.Size(171, 35);
            this.BtnGenerete.TabIndex = 1;
            this.BtnGenerete.Text = "Generuj sál";
            this.BtnGenerete.UseVisualStyleBackColor = true;
            this.BtnGenerete.Click += new System.EventHandler(this.BtnGenerete_Click);
            // 
            // NumSizeY
            // 
            this.NumSizeY.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumSizeY.Location = new System.Drawing.Point(138, 12);
            this.NumSizeY.Name = "NumSizeY";
            this.NumSizeY.Size = new System.Drawing.Size(120, 35);
            this.NumSizeY.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumSizeY);
            this.Controls.Add(this.BtnGenerete);
            this.Controls.Add(this.NumSizeX);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumSizeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSizeY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NumericUpDown NumSizeX;
        private Button BtnGenerete;
        private NumericUpDown NumSizeY;
    }
}