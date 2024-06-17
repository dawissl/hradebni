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
            pictureOriginal = new PictureBox();
            pictureEdit = new PictureBox();
            BtnLoad = new Button();
            BtnSaltPepper = new Button();
            BtnUniform = new Button();
            BtnMedianFilter = new Button();
            OpenImageDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureOriginal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit).BeginInit();
            SuspendLayout();
            // 
            // pictureOriginal
            // 
            pictureOriginal.BackColor = Color.White;
            pictureOriginal.BorderStyle = BorderStyle.Fixed3D;
            pictureOriginal.Location = new Point(21, 18);
            pictureOriginal.Name = "pictureOriginal";
            pictureOriginal.Size = new Size(399, 360);
            pictureOriginal.TabIndex = 0;
            pictureOriginal.TabStop = false;
            // 
            // pictureEdit
            // 
            pictureEdit.BackColor = Color.White;
            pictureEdit.BorderStyle = BorderStyle.Fixed3D;
            pictureEdit.Location = new Point(426, 18);
            pictureEdit.Name = "pictureEdit";
            pictureEdit.Size = new Size(399, 360);
            pictureEdit.TabIndex = 1;
            pictureEdit.TabStop = false;
            // 
            // BtnLoad
            // 
            BtnLoad.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BtnLoad.Location = new Point(21, 384);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(161, 36);
            BtnLoad.TabIndex = 2;
            BtnLoad.Text = "Načti obrázek";
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // BtnSaltPepper
            // 
            BtnSaltPepper.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BtnSaltPepper.Location = new Point(188, 384);
            BtnSaltPepper.Name = "BtnSaltPepper";
            BtnSaltPepper.Size = new Size(165, 36);
            BtnSaltPepper.TabIndex = 3;
            BtnSaltPepper.Text = "Sůl a pepř";
            BtnSaltPepper.UseVisualStyleBackColor = true;
            BtnSaltPepper.Click += BtnSaltPepper_Click;
            // 
            // BtnUniform
            // 
            BtnUniform.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BtnUniform.Location = new Point(359, 384);
            BtnUniform.Name = "BtnUniform";
            BtnUniform.Size = new Size(163, 36);
            BtnUniform.TabIndex = 4;
            BtnUniform.Text = "Uniformní šum";
            BtnUniform.UseVisualStyleBackColor = true;
            // 
            // BtnMedianFilter
            // 
            BtnMedianFilter.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BtnMedianFilter.Location = new Point(528, 384);
            BtnMedianFilter.Name = "BtnMedianFilter";
            BtnMedianFilter.Size = new Size(163, 36);
            BtnMedianFilter.TabIndex = 5;
            BtnMedianFilter.Text = "Medián filtr";
            BtnMedianFilter.UseVisualStyleBackColor = true;
            BtnMedianFilter.Click += BtnMedianFilter_Click;
            // 
            // OpenImageDialog
            // 
            OpenImageDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 438);
            Controls.Add(BtnMedianFilter);
            Controls.Add(BtnUniform);
            Controls.Add(BtnSaltPepper);
            Controls.Add(BtnLoad);
            Controls.Add(pictureEdit);
            Controls.Add(pictureOriginal);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureOriginal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureOriginal;
        private PictureBox pictureEdit;
        private Button BtnLoad;
        private Button BtnSaltPepper;
        private Button BtnUniform;
        private Button BtnMedianFilter;
        private OpenFileDialog OpenImageDialog;
    }
}
