namespace Triangle
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumericA = new System.Windows.Forms.NumericUpDown();
            this.NumericC = new System.Windows.Forms.NumericUpDown();
            this.NumericB = new System.Windows.Forms.NumericUpDown();
            this.LblResult = new System.Windows.Forms.Label();
            this.BtnWork = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericB)).BeginInit();
            this.SuspendLayout();
            // 
            // NumericA
            // 
            this.NumericA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumericA.Location = new System.Drawing.Point(107, 43);
            this.NumericA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericA.Name = "NumericA";
            this.NumericA.Size = new System.Drawing.Size(131, 31);
            this.NumericA.TabIndex = 0;
            this.NumericA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumericC
            // 
            this.NumericC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumericC.Location = new System.Drawing.Point(107, 117);
            this.NumericC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericC.Name = "NumericC";
            this.NumericC.Size = new System.Drawing.Size(131, 31);
            this.NumericC.TabIndex = 1;
            this.NumericC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumericB
            // 
            this.NumericB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumericB.Location = new System.Drawing.Point(107, 80);
            this.NumericB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericB.Name = "NumericB";
            this.NumericB.Size = new System.Drawing.Size(131, 31);
            this.NumericB.TabIndex = 2;
            this.NumericB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LblResult
            // 
            this.LblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblResult.Location = new System.Drawing.Point(82, 177);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(373, 47);
            this.LblResult.TabIndex = 3;
            // 
            // BtnWork
            // 
            this.BtnWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnWork.Location = new System.Drawing.Point(286, 43);
            this.BtnWork.Name = "BtnWork";
            this.BtnWork.Size = new System.Drawing.Size(181, 81);
            this.BtnWork.TabIndex = 4;
            this.BtnWork.Text = "Makej";
            this.BtnWork.UseVisualStyleBackColor = true;
            this.BtnWork.Click += new System.EventHandler(this.BtnWork_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnWork);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.NumericB);
            this.Controls.Add(this.NumericC);
            this.Controls.Add(this.NumericA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumericA;
        private System.Windows.Forms.NumericUpDown NumericC;
        private System.Windows.Forms.NumericUpDown NumericB;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Button BtnWork;
    }
}

