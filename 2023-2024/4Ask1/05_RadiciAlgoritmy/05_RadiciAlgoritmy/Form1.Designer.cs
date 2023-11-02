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
            BtnBubble = new Button();
            button1 = new Button();
            TxtSorted = new TextBox();
            SuspendLayout();
            // 
            // BtnBubble
            // 
            BtnBubble.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnBubble.Location = new Point(250, 12);
            BtnBubble.Name = "BtnBubble";
            BtnBubble.Size = new Size(223, 46);
            BtnBubble.TabIndex = 0;
            BtnBubble.Text = "Bublinkove řazení";
            BtnBubble.UseVisualStyleBackColor = true;
            BtnBubble.Click += BtnBubble_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(21, 12);
            button1.Name = "button1";
            button1.Size = new Size(223, 46);
            button1.TabIndex = 1;
            button1.Text = "Řazení vkládáním";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnInsertion_Click;
            // 
            // TxtSorted
            // 
            TxtSorted.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSorted.Location = new Point(21, 78);
            TxtSorted.Name = "TxtSorted";
            TxtSorted.ReadOnly = true;
            TxtSorted.Size = new Size(1245, 39);
            TxtSorted.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 138);
            Controls.Add(TxtSorted);
            Controls.Add(button1);
            Controls.Add(BtnBubble);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBubble;
        private Button button1;
        private TextBox TxtSorted;
    }
}