namespace _05_RadiciAlgoritmy
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
            Btnbubble = new Button();
            BtnIsert = new Button();
            Txtout = new TextBox();
            SuspendLayout();
            // 
            // Btnbubble
            // 
            Btnbubble.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Btnbubble.Location = new Point(21, 12);
            Btnbubble.Name = "Btnbubble";
            Btnbubble.Size = new Size(257, 51);
            Btnbubble.TabIndex = 0;
            Btnbubble.Text = "Bublinkové řazení";
            Btnbubble.UseVisualStyleBackColor = true;
            Btnbubble.Click += Btnbubble_Click;
            // 
            // BtnIsert
            // 
            BtnIsert.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            BtnIsert.Location = new Point(284, 12);
            BtnIsert.Name = "BtnIsert";
            BtnIsert.Size = new Size(257, 51);
            BtnIsert.TabIndex = 1;
            BtnIsert.Text = "Řazení vkládáním";
            BtnIsert.UseVisualStyleBackColor = true;
            BtnIsert.Click += BtnIsert_Click;
            // 
            // Txtout
            // 
            Txtout.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Txtout.Location = new Point(13, 72);
            Txtout.Name = "Txtout";
            Txtout.ReadOnly = true;
            Txtout.Size = new Size(729, 35);
            Txtout.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 114);
            Controls.Add(Txtout);
            Controls.Add(BtnIsert);
            Controls.Add(Btnbubble);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btnbubble;
        private Button BtnIsert;
        private TextBox Txtout;
    }
}