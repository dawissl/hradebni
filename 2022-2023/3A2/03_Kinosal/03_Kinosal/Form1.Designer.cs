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
            this.NumCinemaSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.CheckReservation = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumCinemaSize)).BeginInit();
            this.SuspendLayout();
            // 
            // NumCinemaSize
            // 
            this.NumCinemaSize.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumCinemaSize.Location = new System.Drawing.Point(156, 25);
            this.NumCinemaSize.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NumCinemaSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumCinemaSize.Name = "NumCinemaSize";
            this.NumCinemaSize.Size = new System.Drawing.Size(120, 33);
            this.NumCinemaSize.TabIndex = 0;
            this.NumCinemaSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Velikost kina";
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGenerate.Location = new System.Drawing.Point(299, 15);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(214, 47);
            this.BtnGenerate.TabIndex = 2;
            this.BtnGenerate.Text = "Generuj kino";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // CheckReservation
            // 
            this.CheckReservation.AutoSize = true;
            this.CheckReservation.Checked = true;
            this.CheckReservation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckReservation.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckReservation.Location = new System.Drawing.Point(548, 24);
            this.CheckReservation.Name = "CheckReservation";
            this.CheckReservation.Size = new System.Drawing.Size(125, 34);
            this.CheckReservation.TabIndex = 3;
            this.CheckReservation.Text = "Rezervace";
            this.CheckReservation.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckReservation);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumCinemaSize);
            this.Name = "Form1";
            this.Text = "Kinsál";
            ((System.ComponentModel.ISupportInitialize)(this.NumCinemaSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown NumCinemaSize;
        private Label label1;
        private Button BtnGenerate;
        private CheckBox CheckReservation;
    }
}