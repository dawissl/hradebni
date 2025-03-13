namespace _16_Trezor
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
            NumCislo = new NumericUpDown();
            RadGreen = new RadioButton();
            RadBlue = new RadioButton();
            LblVystup = new Label();
            BtnWork = new Button();
            ((System.ComponentModel.ISupportInitialize)NumCislo).BeginInit();
            SuspendLayout();
            // 
            // NumCislo
            // 
            NumCislo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            NumCislo.Location = new Point(79, 31);
            NumCislo.Name = "NumCislo";
            NumCislo.Size = new Size(100, 35);
            NumCislo.TabIndex = 0;
            // 
            // RadGreen
            // 
            RadGreen.AutoSize = true;
            RadGreen.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            RadGreen.Location = new Point(206, 35);
            RadGreen.Name = "RadGreen";
            RadGreen.Size = new Size(87, 29);
            RadGreen.TabIndex = 1;
            RadGreen.TabStop = true;
            RadGreen.Text = "Zelená";
            RadGreen.UseVisualStyleBackColor = true;
            // 
            // RadBlue
            // 
            RadBlue.AutoSize = true;
            RadBlue.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            RadBlue.Location = new Point(299, 35);
            RadBlue.Name = "RadBlue";
            RadBlue.Size = new Size(86, 29);
            RadBlue.TabIndex = 2;
            RadBlue.TabStop = true;
            RadBlue.Text = "Modrá";
            RadBlue.TextAlign = ContentAlignment.MiddleCenter;
            RadBlue.UseVisualStyleBackColor = true;
            // 
            // LblVystup
            // 
            LblVystup.BorderStyle = BorderStyle.Fixed3D;
            LblVystup.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblVystup.Location = new Point(79, 92);
            LblVystup.Name = "LblVystup";
            LblVystup.Size = new Size(173, 69);
            LblVystup.TabIndex = 3;
            // 
            // BtnWork
            // 
            BtnWork.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnWork.Location = new Point(413, 21);
            BtnWork.Name = "BtnWork";
            BtnWork.Size = new Size(115, 52);
            BtnWork.TabIndex = 4;
            BtnWork.Text = "Zobraz";
            BtnWork.UseVisualStyleBackColor = true;
            BtnWork.Click += BtnWork_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnWork);
            Controls.Add(LblVystup);
            Controls.Add(RadBlue);
            Controls.Add(RadGreen);
            Controls.Add(NumCislo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumCislo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown NumCislo;
        private RadioButton RadGreen;
        private RadioButton RadBlue;
        private Label LblVystup;
        private Button BtnWork;
    }
}