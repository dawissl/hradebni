namespace Resistors
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
            this.BtnCompute = new System.Windows.Forms.Button();
            this.TxtR1 = new System.Windows.Forms.TextBox();
            this.TxtR2 = new System.Windows.Forms.TextBox();
            this.RadioSerial = new System.Windows.Forms.RadioButton();
            this.RadioParalel = new System.Windows.Forms.RadioButton();
            this.LblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCompute
            // 
            this.BtnCompute.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCompute.Location = new System.Drawing.Point(71, 204);
            this.BtnCompute.Name = "BtnCompute";
            this.BtnCompute.Size = new System.Drawing.Size(195, 107);
            this.BtnCompute.TabIndex = 0;
            this.BtnCompute.Text = "Vypočti odpor";
            this.BtnCompute.UseVisualStyleBackColor = true;
            this.BtnCompute.Click += new System.EventHandler(this.BtnCompute_Click);
            // 
            // TxtR1
            // 
            this.TxtR1.Location = new System.Drawing.Point(51, 37);
            this.TxtR1.Name = "TxtR1";
            this.TxtR1.Size = new System.Drawing.Size(100, 23);
            this.TxtR1.TabIndex = 1;
            // 
            // TxtR2
            // 
            this.TxtR2.Location = new System.Drawing.Point(229, 37);
            this.TxtR2.Name = "TxtR2";
            this.TxtR2.Size = new System.Drawing.Size(100, 23);
            this.TxtR2.TabIndex = 2;
            // 
            // RadioSerial
            // 
            this.RadioSerial.AutoSize = true;
            this.RadioSerial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RadioSerial.Location = new System.Drawing.Point(12, 91);
            this.RadioSerial.Name = "RadioSerial";
            this.RadioSerial.Size = new System.Drawing.Size(155, 25);
            this.RadioSerial.TabIndex = 3;
            this.RadioSerial.TabStop = true;
            this.RadioSerial.Text = "Seriové zapojení";
            this.RadioSerial.UseVisualStyleBackColor = true;
            // 
            // RadioParalel
            // 
            this.RadioParalel.AutoSize = true;
            this.RadioParalel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RadioParalel.Location = new System.Drawing.Point(173, 91);
            this.RadioParalel.Name = "RadioParalel";
            this.RadioParalel.Size = new System.Drawing.Size(166, 25);
            this.RadioParalel.TabIndex = 4;
            this.RadioParalel.TabStop = true;
            this.RadioParalel.Text = "Paralelní zapojení";
            this.RadioParalel.UseVisualStyleBackColor = true;
            // 
            // LblResult
            // 
            this.LblResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblResult.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblResult.Location = new System.Drawing.Point(34, 133);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(295, 50);
            this.LblResult.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "R1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(190, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "R2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 343);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.RadioParalel);
            this.Controls.Add(this.RadioSerial);
            this.Controls.Add(this.TxtR2);
            this.Controls.Add(this.TxtR1);
            this.Controls.Add(this.BtnCompute);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnCompute;
        private TextBox TxtR1;
        private TextBox TxtR2;
        private RadioButton RadioSerial;
        private RadioButton RadioParalel;
        private Label LblResult;
        private Label label1;
        private Label label2;
    }
}