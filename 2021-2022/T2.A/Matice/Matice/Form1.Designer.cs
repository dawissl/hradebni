namespace Matice
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
            this.txtBoxMatrix = new System.Windows.Forms.TextBox();
            this.radioBtnDefault = new System.Windows.Forms.RadioButton();
            this.radioBtnSameRows = new System.Windows.Forms.RadioButton();
            this.radioBtnSameColumns = new System.Windows.Forms.RadioButton();
            this.radioBtnRandom = new System.Windows.Forms.RadioButton();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateMatrice = new System.Windows.Forms.Button();
            this.checkBoxDiagonal = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtBoxMatrix
            // 
            this.txtBoxMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxMatrix.Location = new System.Drawing.Point(18, 18);
            this.txtBoxMatrix.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxMatrix.Multiline = true;
            this.txtBoxMatrix.Name = "txtBoxMatrix";
            this.txtBoxMatrix.Size = new System.Drawing.Size(291, 288);
            this.txtBoxMatrix.TabIndex = 0;
            // 
            // radioBtnDefault
            // 
            this.radioBtnDefault.AutoSize = true;
            this.radioBtnDefault.Checked = true;
            this.radioBtnDefault.Location = new System.Drawing.Point(342, 25);
            this.radioBtnDefault.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioBtnDefault.Name = "radioBtnDefault";
            this.radioBtnDefault.Size = new System.Drawing.Size(63, 19);
            this.radioBtnDefault.TabIndex = 1;
            this.radioBtnDefault.TabStop = true;
            this.radioBtnDefault.Text = "Default";
            this.radioBtnDefault.UseVisualStyleBackColor = true;
            // 
            // radioBtnSameRows
            // 
            this.radioBtnSameRows.AutoSize = true;
            this.radioBtnSameRows.Location = new System.Drawing.Point(342, 52);
            this.radioBtnSameRows.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioBtnSameRows.Name = "radioBtnSameRows";
            this.radioBtnSameRows.Size = new System.Drawing.Size(89, 19);
            this.radioBtnSameRows.TabIndex = 2;
            this.radioBtnSameRows.Text = "Stejné řádky";
            this.radioBtnSameRows.UseVisualStyleBackColor = true;
            // 
            // radioBtnSameColumns
            // 
            this.radioBtnSameColumns.AutoSize = true;
            this.radioBtnSameColumns.Location = new System.Drawing.Point(342, 78);
            this.radioBtnSameColumns.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioBtnSameColumns.Name = "radioBtnSameColumns";
            this.radioBtnSameColumns.Size = new System.Drawing.Size(101, 19);
            this.radioBtnSameColumns.TabIndex = 3;
            this.radioBtnSameColumns.Text = "Stejné sloupce";
            this.radioBtnSameColumns.UseVisualStyleBackColor = true;
            // 
            // radioBtnRandom
            // 
            this.radioBtnRandom.AutoSize = true;
            this.radioBtnRandom.Location = new System.Drawing.Point(342, 105);
            this.radioBtnRandom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioBtnRandom.Name = "radioBtnRandom";
            this.radioBtnRandom.Size = new System.Drawing.Size(126, 19);
            this.radioBtnRandom.TabIndex = 4;
            this.radioBtnRandom.Text = "Náhodné z rozsahu";
            this.radioBtnRandom.UseVisualStyleBackColor = true;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(392, 132);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(48, 23);
            this.txtFrom.TabIndex = 5;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(481, 132);
            this.txtTo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(48, 23);
            this.txtTo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Od";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Do";
            // 
            // btnCreateMatrice
            // 
            this.btnCreateMatrice.Location = new System.Drawing.Point(342, 242);
            this.btnCreateMatrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCreateMatrice.Name = "btnCreateMatrice";
            this.btnCreateMatrice.Size = new System.Drawing.Size(188, 65);
            this.btnCreateMatrice.TabIndex = 9;
            this.btnCreateMatrice.Text = "Vytvoř matici";
            this.btnCreateMatrice.UseVisualStyleBackColor = true;
            this.btnCreateMatrice.Click += new System.EventHandler(this.btnCreateMatrice_Click);
            // 
            // checkBoxDiagonal
            // 
            this.checkBoxDiagonal.AutoSize = true;
            this.checkBoxDiagonal.Location = new System.Drawing.Point(342, 173);
            this.checkBoxDiagonal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxDiagonal.Name = "checkBoxDiagonal";
            this.checkBoxDiagonal.Size = new System.Drawing.Size(152, 19);
            this.checkBoxDiagonal.TabIndex = 10;
            this.checkBoxDiagonal.Text = "Vypsat pouze diagonálu";
            this.checkBoxDiagonal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 328);
            this.Controls.Add(this.checkBoxDiagonal);
            this.Controls.Add(this.btnCreateMatrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.radioBtnRandom);
            this.Controls.Add(this.radioBtnSameColumns);
            this.Controls.Add(this.radioBtnSameRows);
            this.Controls.Add(this.radioBtnDefault);
            this.Controls.Add(this.txtBoxMatrix);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Aplikace pro práci s maticemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxMatrix;
        private System.Windows.Forms.RadioButton radioBtnDefault;
        private System.Windows.Forms.RadioButton radioBtnSameRows;
        private System.Windows.Forms.RadioButton radioBtnSameColumns;
        private System.Windows.Forms.RadioButton radioBtnRandom;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateMatrice;
        private System.Windows.Forms.CheckBox checkBoxDiagonal;
    }
}

