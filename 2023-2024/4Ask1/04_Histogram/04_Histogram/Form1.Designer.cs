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
            NumWidth = new NumericUpDown();
            NumHeight = new NumericUpDown();
            PanelImage = new Panel();
            BtnGenerate = new Button();
            PanelHistogram = new Panel();
            ((System.ComponentModel.ISupportInitialize)NumWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumHeight).BeginInit();
            SuspendLayout();
            // 
            // NumWidth
            // 
            NumWidth.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NumWidth.Location = new Point(547, 30);
            NumWidth.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            NumWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumWidth.Name = "NumWidth";
            NumWidth.Size = new Size(185, 39);
            NumWidth.TabIndex = 0;
            NumWidth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NumHeight
            // 
            NumHeight.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NumHeight.Location = new Point(547, 91);
            NumHeight.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            NumHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumHeight.Name = "NumHeight";
            NumHeight.Size = new Size(185, 39);
            NumHeight.TabIndex = 1;
            NumHeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // PanelImage
            // 
            PanelImage.BorderStyle = BorderStyle.FixedSingle;
            PanelImage.Location = new Point(12, 12);
            PanelImage.Name = "PanelImage";
            PanelImage.Size = new Size(500, 500);
            PanelImage.TabIndex = 2;
            PanelImage.Paint += PanelImage_Paint;
            // 
            // BtnGenerate
            // 
            BtnGenerate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnGenerate.Location = new Point(546, 157);
            BtnGenerate.Name = "BtnGenerate";
            BtnGenerate.Size = new Size(186, 43);
            BtnGenerate.TabIndex = 3;
            BtnGenerate.Text = "Vykresli";
            BtnGenerate.UseVisualStyleBackColor = true;
            BtnGenerate.Click += BtnGenerate_Click;
            // 
            // PanelHistogram
            // 
            PanelHistogram.BorderStyle = BorderStyle.Fixed3D;
            PanelHistogram.Location = new Point(518, 412);
            PanelHistogram.Name = "PanelHistogram";
            PanelHistogram.Size = new Size(256, 100);
            PanelHistogram.TabIndex = 4;
            PanelHistogram.Paint += PanelHistogram_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 539);
            Controls.Add(PanelHistogram);
            Controls.Add(BtnGenerate);
            Controls.Add(PanelImage);
            Controls.Add(NumHeight);
            Controls.Add(NumWidth);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumHeight).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown NumWidth;
        private NumericUpDown NumHeight;
        private Panel PanelImage;
        private Button BtnGenerate;
        private Panel PanelHistogram;
    }
}