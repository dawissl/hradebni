namespace SimpleCalcApp
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
            this.NumA = new System.Windows.Forms.NumericUpDown();
            this.NumB = new System.Windows.Forms.NumericUpDown();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnSub = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.BtnMul = new System.Windows.Forms.Button();
            this.Lblresult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumB)).BeginInit();
            this.SuspendLayout();
            // 
            // NumA
            // 
            this.NumA.DecimalPlaces = 1;
            this.NumA.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumA.Location = new System.Drawing.Point(60, 63);
            this.NumA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NumA.Name = "NumA";
            this.NumA.Size = new System.Drawing.Size(120, 20);
            this.NumA.TabIndex = 0;
            // 
            // NumB
            // 
            this.NumB.DecimalPlaces = 1;
            this.NumB.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumB.Location = new System.Drawing.Point(207, 63);
            this.NumB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NumB.Name = "NumB";
            this.NumB.Size = new System.Drawing.Size(120, 20);
            this.NumB.TabIndex = 1;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnAdd.Location = new System.Drawing.Point(41, 142);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 41);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnSub
            // 
            this.BtnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnSub.Location = new System.Drawing.Point(122, 142);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(75, 41);
            this.BtnSub.TabIndex = 3;
            this.BtnSub.Text = "-";
            this.BtnSub.UseVisualStyleBackColor = true;
            this.BtnSub.Click += new System.EventHandler(this.BtnSub_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnDiv.Location = new System.Drawing.Point(207, 142);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(75, 41);
            this.BtnDiv.TabIndex = 4;
            this.BtnDiv.Text = "*";
            this.BtnDiv.UseVisualStyleBackColor = true;
            this.BtnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // BtnMul
            // 
            this.BtnMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnMul.Location = new System.Drawing.Point(288, 142);
            this.BtnMul.Name = "BtnMul";
            this.BtnMul.Size = new System.Drawing.Size(75, 41);
            this.BtnMul.TabIndex = 5;
            this.BtnMul.Text = "/";
            this.BtnMul.UseVisualStyleBackColor = true;
            this.BtnMul.Click += new System.EventHandler(this.BtnMul_Click);
            // 
            // Lblresult
            // 
            this.Lblresult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lblresult.Location = new System.Drawing.Point(41, 209);
            this.Lblresult.Name = "Lblresult";
            this.Lblresult.Size = new System.Drawing.Size(321, 70);
            this.Lblresult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 294);
            this.Controls.Add(this.Lblresult);
            this.Controls.Add(this.BtnMul);
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.BtnSub);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.NumB);
            this.Controls.Add(this.NumA);
            this.Name = "Form1";
            this.Text = "SimpleCalcApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumA;
        private System.Windows.Forms.NumericUpDown NumB;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnSub;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Button BtnMul;
        private System.Windows.Forms.Label Lblresult;
    }
}

