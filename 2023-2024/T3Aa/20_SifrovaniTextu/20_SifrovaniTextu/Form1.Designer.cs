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
            TxtVychozi = new TextBox();
            TxtSiforvany = new TextBox();
            NumShift = new NumericUpDown();
            BtnMake = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)NumShift).BeginInit();
            SuspendLayout();
            // 
            // TxtVychozi
            // 
            TxtVychozi.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TxtVychozi.Location = new Point(22, 16);
            TxtVychozi.Multiline = true;
            TxtVychozi.Name = "TxtVychozi";
            TxtVychozi.Size = new Size(278, 415);
            TxtVychozi.TabIndex = 0;
            // 
            // TxtSiforvany
            // 
            TxtSiforvany.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TxtSiforvany.Location = new Point(510, 16);
            TxtSiforvany.Multiline = true;
            TxtSiforvany.Name = "TxtSiforvany";
            TxtSiforvany.Size = new Size(278, 415);
            TxtSiforvany.TabIndex = 1;
            // 
            // NumShift
            // 
            NumShift.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            NumShift.Location = new Point(327, 35);
            NumShift.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            NumShift.Minimum = new decimal(new int[] { 25, 0, 0, int.MinValue });
            NumShift.Name = "NumShift";
            NumShift.Size = new Size(150, 39);
            NumShift.TabIndex = 2;
            // 
            // BtnMake
            // 
            BtnMake.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BtnMake.Location = new Point(326, 95);
            BtnMake.Name = "BtnMake";
            BtnMake.Size = new Size(154, 73);
            BtnMake.TabIndex = 3;
            BtnMake.Text = "Caesarova šifra";
            BtnMake.UseVisualStyleBackColor = true;
            BtnMake.Click += BtnMake_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(323, 189);
            button1.Name = "button1";
            button1.Size = new Size(154, 73);
            button1.TabIndex = 4;
            button1.Text = "Morseova šifra";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(BtnMake);
            Controls.Add(NumShift);
            Controls.Add(TxtSiforvany);
            Controls.Add(TxtVychozi);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumShift).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtVychozi;
        private TextBox TxtSiforvany;
        private NumericUpDown NumShift;
        private Button BtnMake;
        private Button button1;
    }
}
