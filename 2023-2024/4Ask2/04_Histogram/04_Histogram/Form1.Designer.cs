namespace _04_Histogram
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
            PanelImage = new Panel();
            PanelHist = new Panel();
            NumWidth = new NumericUpDown();
            NumHeight = new NumericUpDown();
            BtnGenerate = new Button();
            ((System.ComponentModel.ISupportInitialize)NumWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumHeight).BeginInit();
            SuspendLayout();
            // 
            // PanelImage
            // 
            PanelImage.Location = new Point(5, 12);
            PanelImage.Name = "PanelImage";
            PanelImage.Size = new Size(500, 500);
            PanelImage.TabIndex = 0;
            PanelImage.Paint += PanelImage_Paint;
            // 
            // PanelHist
            // 
            PanelHist.BackColor = SystemColors.ActiveCaption;
            PanelHist.BorderStyle = BorderStyle.FixedSingle;
            PanelHist.Location = new Point(511, 412);
            PanelHist.Name = "PanelHist";
            PanelHist.Size = new Size(256, 100);
            PanelHist.TabIndex = 1;
            PanelHist.Paint += PanelHist_Paint;
            // 
            // NumWidth
            // 
            NumWidth.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NumWidth.Location = new Point(537, 12);
            NumWidth.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            NumWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumWidth.Name = "NumWidth";
            NumWidth.Size = new Size(230, 39);
            NumWidth.TabIndex = 2;
            NumWidth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NumHeight
            // 
            NumHeight.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NumHeight.Location = new Point(537, 66);
            NumHeight.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            NumHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumHeight.Name = "NumHeight";
            NumHeight.Size = new Size(230, 39);
            NumHeight.TabIndex = 3;
            NumHeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // BtnGenerate
            // 
            BtnGenerate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnGenerate.Location = new Point(538, 119);
            BtnGenerate.Name = "BtnGenerate";
            BtnGenerate.Size = new Size(229, 90);
            BtnGenerate.TabIndex = 4;
            BtnGenerate.Text = "Vykresli";
            BtnGenerate.UseVisualStyleBackColor = true;
            BtnGenerate.Click += BtnGenerate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 543);
            Controls.Add(BtnGenerate);
            Controls.Add(NumHeight);
            Controls.Add(NumWidth);
            Controls.Add(PanelHist);
            Controls.Add(PanelImage);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumHeight).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelImage;
        private Panel PanelHist;
        private NumericUpDown NumWidth;
        private NumericUpDown NumHeight;
        private Button BtnGenerate;
    }
}