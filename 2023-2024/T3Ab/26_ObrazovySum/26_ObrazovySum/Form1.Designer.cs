namespace _26_ObrazovySum
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
            this.PictureDefault = new System.Windows.Forms.PictureBox();
            this.PictureEdit = new System.Windows.Forms.PictureBox();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.BtnSaltPepperNoise = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ComboGrey = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureDefault
            // 
            this.PictureDefault.BackColor = System.Drawing.Color.White;
            this.PictureDefault.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureDefault.Location = new System.Drawing.Point(16, 16);
            this.PictureDefault.Name = "PictureDefault";
            this.PictureDefault.Size = new System.Drawing.Size(300, 300);
            this.PictureDefault.TabIndex = 0;
            this.PictureDefault.TabStop = false;
            // 
            // PictureEdit
            // 
            this.PictureEdit.BackColor = System.Drawing.Color.White;
            this.PictureEdit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureEdit.Location = new System.Drawing.Point(322, 16);
            this.PictureEdit.Name = "PictureEdit";
            this.PictureEdit.Size = new System.Drawing.Size(300, 300);
            this.PictureEdit.TabIndex = 1;
            this.PictureEdit.TabStop = false;
            // 
            // BtnLoad
            // 
            this.BtnLoad.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnLoad.Location = new System.Drawing.Point(16, 322);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(152, 66);
            this.BtnLoad.TabIndex = 2;
            this.BtnLoad.Text = "Načti obrázek";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnSaltPepperNoise
            // 
            this.BtnSaltPepperNoise.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSaltPepperNoise.Location = new System.Drawing.Point(174, 322);
            this.BtnSaltPepperNoise.Name = "BtnSaltPepperNoise";
            this.BtnSaltPepperNoise.Size = new System.Drawing.Size(152, 66);
            this.BtnSaltPepperNoise.TabIndex = 3;
            this.BtnSaltPepperNoise.Text = "Sůl a pepř";
            this.BtnSaltPepperNoise.UseVisualStyleBackColor = true;
            this.BtnSaltPepperNoise.Click += new System.EventHandler(this.BtnSaltPepperNoise_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(332, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 66);
            this.button1.TabIndex = 4;
            this.button1.Text = "Mediánový filtr";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComboGrey
            // 
            this.ComboGrey.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboGrey.FormattingEnabled = true;
            this.ComboGrey.Items.AddRange(new object[] {
            "ČERVENÝ KANÁL",
            "MODRÝ KANÁL",
            "ZELENÝ KANÁL",
            "PRŮMĚROVÁNÍ"});
            this.ComboGrey.Location = new System.Drawing.Point(16, 394);
            this.ComboGrey.Name = "ComboGrey";
            this.ComboGrey.Size = new System.Drawing.Size(242, 40);
            this.ComboGrey.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.ComboGrey);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnSaltPepperNoise);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.PictureEdit);
            this.Controls.Add(this.PictureDefault);
            this.Name = "Form1";
            this.Text = "Obrazový šum";
            ((System.ComponentModel.ISupportInitialize)(this.PictureDefault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox PictureDefault;
        private PictureBox PictureEdit;
        private Button BtnLoad;
        private Button BtnSaltPepperNoise;
        private Button button1;
        private ComboBox ComboGrey;
    }
}