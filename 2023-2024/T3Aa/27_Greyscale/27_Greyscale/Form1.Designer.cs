namespace _27_Greyscale
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
            PictureDefault = new PictureBox();
            PictureGrey = new PictureBox();
            ComoGreyFilter = new ComboBox();
            BtnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureDefault).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureGrey).BeginInit();
            SuspendLayout();
            // 
            // PictureDefault
            // 
            PictureDefault.Location = new Point(20, 11);
            PictureDefault.Name = "PictureDefault";
            PictureDefault.Size = new Size(400, 400);
            PictureDefault.TabIndex = 0;
            PictureDefault.TabStop = false;
            // 
            // PictureGrey
            // 
            PictureGrey.Location = new Point(435, 11);
            PictureGrey.Name = "PictureGrey";
            PictureGrey.Size = new Size(400, 400);
            PictureGrey.TabIndex = 1;
            PictureGrey.TabStop = false;
            // 
            // ComoGreyFilter
            // 
            ComoGreyFilter.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ComoGreyFilter.FormattingEnabled = true;
            ComoGreyFilter.Items.AddRange(new object[] { "ČERVENÝ KANÁL", "ZELENÝ KANÁL", "MODRÝ KANÁL", "PRŮMĚROVÁNÍ" });
            ComoGreyFilter.Location = new Point(435, 421);
            ComoGreyFilter.Name = "ComoGreyFilter";
            ComoGreyFilter.Size = new Size(400, 40);
            ComoGreyFilter.TabIndex = 2;
            ComoGreyFilter.SelectedIndexChanged += ComoGreyFilter_SelectedIndexChanged;
            // 
            // BtnLoad
            // 
            BtnLoad.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BtnLoad.Location = new Point(20, 417);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(400, 47);
            BtnLoad.TabIndex = 3;
            BtnLoad.Text = "Načti barevný obraz";
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 485);
            Controls.Add(BtnLoad);
            Controls.Add(ComoGreyFilter);
            Controls.Add(PictureGrey);
            Controls.Add(PictureDefault);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PictureDefault).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureGrey).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PictureDefault;
        private PictureBox PictureGrey;
        private ComboBox ComoGreyFilter;
        private Button BtnLoad;
    }
}
