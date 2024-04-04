namespace _20_SifrovaniTextu
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
            this.TxtVychozi = new System.Windows.Forms.TextBox();
            this.TxtVystup = new System.Windows.Forms.TextBox();
            this.NumShift = new System.Windows.Forms.NumericUpDown();
            this.BtnCaesar = new System.Windows.Forms.Button();
            this.BtnMorse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumShift)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtVychozi
            // 
            this.TxtVychozi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtVychozi.Location = new System.Drawing.Point(20, 14);
            this.TxtVychozi.Multiline = true;
            this.TxtVychozi.Name = "TxtVychozi";
            this.TxtVychozi.Size = new System.Drawing.Size(261, 424);
            this.TxtVychozi.TabIndex = 0;
            // 
            // TxtVystup
            // 
            this.TxtVystup.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtVystup.Location = new System.Drawing.Point(511, 14);
            this.TxtVystup.Multiline = true;
            this.TxtVystup.Name = "TxtVystup";
            this.TxtVystup.Size = new System.Drawing.Size(261, 424);
            this.TxtVystup.TabIndex = 1;
            // 
            // NumShift
            // 
            this.NumShift.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumShift.Location = new System.Drawing.Point(307, 37);
            this.NumShift.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.NumShift.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            -2147483648});
            this.NumShift.Name = "NumShift";
            this.NumShift.Size = new System.Drawing.Size(155, 35);
            this.NumShift.TabIndex = 2;
            // 
            // BtnCaesar
            // 
            this.BtnCaesar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCaesar.Location = new System.Drawing.Point(306, 85);
            this.BtnCaesar.Name = "BtnCaesar";
            this.BtnCaesar.Size = new System.Drawing.Size(162, 86);
            this.BtnCaesar.TabIndex = 3;
            this.BtnCaesar.Text = "Ceasarova šifra";
            this.BtnCaesar.UseVisualStyleBackColor = true;
            this.BtnCaesar.Click += new System.EventHandler(this.BtnCaesar_Click);
            // 
            // BtnMorse
            // 
            this.BtnMorse.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMorse.Location = new System.Drawing.Point(307, 177);
            this.BtnMorse.Name = "BtnMorse";
            this.BtnMorse.Size = new System.Drawing.Size(162, 86);
            this.BtnMorse.TabIndex = 4;
            this.BtnMorse.Text = "Morseova šifra";
            this.BtnMorse.UseVisualStyleBackColor = true;
            this.BtnMorse.Click += new System.EventHandler(this.BtnMorse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnMorse);
            this.Controls.Add(this.BtnCaesar);
            this.Controls.Add(this.NumShift);
            this.Controls.Add(this.TxtVystup);
            this.Controls.Add(this.TxtVychozi);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtVychozi;
        private TextBox TxtVystup;
        private NumericUpDown NumShift;
        private Button BtnCaesar;
        private Button BtnMorse;
    }
}