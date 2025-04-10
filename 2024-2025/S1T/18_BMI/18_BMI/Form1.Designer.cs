namespace _18_BMI
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
            TxtVaha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TxtVyska = new TextBox();
            BtnBMI = new Button();
            label5 = new Label();
            label6 = new Label();
            LblResult = new Label();
            LblInfo = new Label();
            SuspendLayout();
            // 
            // TxtVaha
            // 
            TxtVaha.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TxtVaha.Location = new Point(97, 29);
            TxtVaha.Name = "TxtVaha";
            TxtVaha.PlaceholderText = "váha";
            TxtVaha.Size = new Size(126, 39);
            TxtVaha.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(26, 36);
            label1.Name = "label1";
            label1.Size = new Size(65, 32);
            label1.TabIndex = 1;
            label1.Text = "Váha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(229, 36);
            label2.Name = "label2";
            label2.Size = new Size(40, 32);
            label2.TabIndex = 2;
            label2.Text = "kg";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(229, 91);
            label3.Name = "label3";
            label3.Size = new Size(46, 32);
            label3.TabIndex = 5;
            label3.Text = "cm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(26, 91);
            label4.Name = "label4";
            label4.Size = new Size(75, 32);
            label4.TabIndex = 4;
            label4.Text = "Výška";
            // 
            // TxtVyska
            // 
            TxtVyska.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TxtVyska.Location = new Point(97, 84);
            TxtVyska.Name = "TxtVyska";
            TxtVyska.PlaceholderText = "výška";
            TxtVyska.Size = new Size(126, 39);
            TxtVyska.TabIndex = 3;
            // 
            // BtnBMI
            // 
            BtnBMI.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BtnBMI.Location = new Point(296, 36);
            BtnBMI.Name = "BtnBMI";
            BtnBMI.Size = new Size(165, 90);
            BtnBMI.TabIndex = 6;
            BtnBMI.Text = "BMI";
            BtnBMI.UseVisualStyleBackColor = true;
            BtnBMI.Click += BtnBMI_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(26, 168);
            label5.Name = "label5";
            label5.Size = new Size(107, 32);
            label5.TabIndex = 7;
            label5.Text = "Hodnota";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.Location = new Point(26, 216);
            label6.Name = "label6";
            label6.Size = new Size(56, 32);
            label6.TabIndex = 8;
            label6.Text = "Info";
            // 
            // LblResult
            // 
            LblResult.BorderStyle = BorderStyle.Fixed3D;
            LblResult.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            LblResult.Location = new Point(139, 168);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(322, 32);
            LblResult.TabIndex = 9;
            // 
            // LblInfo
            // 
            LblInfo.BorderStyle = BorderStyle.Fixed3D;
            LblInfo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            LblInfo.Location = new Point(139, 216);
            LblInfo.Name = "LblInfo";
            LblInfo.Size = new Size(322, 32);
            LblInfo.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 282);
            Controls.Add(LblInfo);
            Controls.Add(LblResult);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(BtnBMI);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(TxtVyska);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtVaha);
            Name = "Form1";
            Text = "BMI kalkulačka";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtVaha;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TxtVyska;
        private Button BtnBMI;
        private Label label5;
        private Label label6;
        private Label LblResult;
        private Label LblInfo;
    }
}