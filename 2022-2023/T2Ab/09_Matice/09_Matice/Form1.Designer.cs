namespace _09_Matice
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblMatrix = new System.Windows.Forms.Label();
            this.RadioSimple = new System.Windows.Forms.RadioButton();
            this.RadioRows = new System.Windows.Forms.RadioButton();
            this.RadioColumns = new System.Windows.Forms.RadioButton();
            this.BtnPrin = new System.Windows.Forms.Button();
            this.CheckDiagonal = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matice";
            // 
            // LblMatrix
            // 
            this.LblMatrix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMatrix.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblMatrix.Location = new System.Drawing.Point(41, 84);
            this.LblMatrix.Name = "LblMatrix";
            this.LblMatrix.Size = new System.Drawing.Size(378, 327);
            this.LblMatrix.TabIndex = 1;
            // 
            // RadioSimple
            // 
            this.RadioSimple.AutoSize = true;
            this.RadioSimple.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RadioSimple.Location = new System.Drawing.Point(477, 45);
            this.RadioSimple.Name = "RadioSimple";
            this.RadioSimple.Size = new System.Drawing.Size(216, 34);
            this.RadioSimple.TabIndex = 2;
            this.RadioSimple.TabStop = true;
            this.RadioSimple.Text = "Jednotková matice";
            this.RadioSimple.UseVisualStyleBackColor = true;
            // 
            // RadioRows
            // 
            this.RadioRows.AutoSize = true;
            this.RadioRows.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RadioRows.Location = new System.Drawing.Point(477, 106);
            this.RadioRows.Name = "RadioRows";
            this.RadioRows.Size = new System.Drawing.Size(152, 34);
            this.RadioRows.TabIndex = 3;
            this.RadioRows.TabStop = true;
            this.RadioRows.Text = "Stejné řádky";
            this.RadioRows.UseVisualStyleBackColor = true;
            // 
            // RadioColumns
            // 
            this.RadioColumns.AutoSize = true;
            this.RadioColumns.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RadioColumns.Location = new System.Drawing.Point(477, 166);
            this.RadioColumns.Name = "RadioColumns";
            this.RadioColumns.Size = new System.Drawing.Size(172, 34);
            this.RadioColumns.TabIndex = 4;
            this.RadioColumns.TabStop = true;
            this.RadioColumns.Text = "Stejné sloupce";
            this.RadioColumns.UseVisualStyleBackColor = true;
            // 
            // BtnPrin
            // 
            this.BtnPrin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnPrin.Location = new System.Drawing.Point(477, 297);
            this.BtnPrin.Name = "BtnPrin";
            this.BtnPrin.Size = new System.Drawing.Size(190, 86);
            this.BtnPrin.TabIndex = 5;
            this.BtnPrin.Text = "Vypiš matici";
            this.BtnPrin.UseVisualStyleBackColor = true;
            this.BtnPrin.Click += new System.EventHandler(this.BtnPrin_Click);
            // 
            // CheckDiagonal
            // 
            this.CheckDiagonal.AutoSize = true;
            this.CheckDiagonal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckDiagonal.Location = new System.Drawing.Point(477, 233);
            this.CheckDiagonal.Name = "CheckDiagonal";
            this.CheckDiagonal.Size = new System.Drawing.Size(252, 34);
            this.CheckDiagonal.TabIndex = 6;
            this.CheckDiagonal.Text = "Hodnoty na diágonále";
            this.CheckDiagonal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckDiagonal);
            this.Controls.Add(this.BtnPrin);
            this.Controls.Add(this.RadioColumns);
            this.Controls.Add(this.RadioRows);
            this.Controls.Add(this.RadioSimple);
            this.Controls.Add(this.LblMatrix);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Zobrazení matice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label LblMatrix;
        private RadioButton RadioSimple;
        private RadioButton RadioRows;
        private RadioButton RadioColumns;
        private Button BtnPrin;
        private CheckBox CheckDiagonal;
    }
}