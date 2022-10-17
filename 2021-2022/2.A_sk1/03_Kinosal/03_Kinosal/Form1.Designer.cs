namespace _03_Kinosal
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
            this.BtnGeneruj = new System.Windows.Forms.Button();
            this.NumVelikostKina = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRezervace = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumVelikostKina)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGeneruj
            // 
            this.BtnGeneruj.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGeneruj.Location = new System.Drawing.Point(212, 12);
            this.BtnGeneruj.Name = "BtnGeneruj";
            this.BtnGeneruj.Size = new System.Drawing.Size(156, 42);
            this.BtnGeneruj.TabIndex = 1;
            this.BtnGeneruj.Text = "Vytvoř kino";
            this.BtnGeneruj.UseVisualStyleBackColor = true;
            this.BtnGeneruj.Click += new System.EventHandler(this.BtnGeneruj_Click);
            // 
            // NumVelikostKina
            // 
            this.NumVelikostKina.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumVelikostKina.Location = new System.Drawing.Point(122, 17);
            this.NumVelikostKina.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.NumVelikostKina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumVelikostKina.Name = "NumVelikostKina";
            this.NumVelikostKina.Size = new System.Drawing.Size(57, 35);
            this.NumVelikostKina.TabIndex = 2;
            this.NumVelikostKina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Velikost";
            // 
            // BtnRezervace
            // 
            this.BtnRezervace.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRezervace.Location = new System.Drawing.Point(385, 10);
            this.BtnRezervace.Name = "BtnRezervace";
            this.BtnRezervace.Size = new System.Drawing.Size(104, 42);
            this.BtnRezervace.TabIndex = 4;
            this.BtnRezervace.Text = "+";
            this.BtnRezervace.UseVisualStyleBackColor = true;
            this.BtnRezervace.Click += new System.EventHandler(this.BtnRezervace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRezervace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumVelikostKina);
            this.Controls.Add(this.BtnGeneruj);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumVelikostKina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnGeneruj;
        private NumericUpDown NumVelikostKina;
        private Label label1;
        private Button BtnRezervace;
    }
}