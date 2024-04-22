namespace _22_ParkovaciDum
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
            BtnPark = new Button();
            LblCapacity = new Label();
            SuspendLayout();
            // 
            // BtnPark
            // 
            BtnPark.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BtnPark.Location = new Point(629, 12);
            BtnPark.Name = "BtnPark";
            BtnPark.Size = new Size(137, 72);
            BtnPark.TabIndex = 0;
            BtnPark.Text = "Zaparkuj Nahodne";
            BtnPark.UseVisualStyleBackColor = true;
            BtnPark.Click += BtnPark_Click;
            // 
            // LblCapacity
            // 
            LblCapacity.BorderStyle = BorderStyle.Fixed3D;
            LblCapacity.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            LblCapacity.Location = new Point(629, 87);
            LblCapacity.Name = "LblCapacity";
            LblCapacity.Size = new Size(136, 46);
            LblCapacity.TabIndex = 1;
            LblCapacity.Text = "0 %";
            LblCapacity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblCapacity);
            Controls.Add(BtnPark);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnPark;
        private Label LblCapacity;
    }
}
