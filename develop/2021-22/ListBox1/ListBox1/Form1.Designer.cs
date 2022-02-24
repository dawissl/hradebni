
namespace ListBox1
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.ListBoxLeft = new System.Windows.Forms.ListBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.ListBoxRight = new System.Windows.Forms.ListBox();
            this.CHSub = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(63, 214);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(105, 43);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // ListBoxLeft
            // 
            this.ListBoxLeft.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListBoxLeft.FormattingEnabled = true;
            this.ListBoxLeft.ItemHeight = 25;
            this.ListBoxLeft.Location = new System.Drawing.Point(195, 57);
            this.ListBoxLeft.Name = "ListBoxLeft";
            this.ListBoxLeft.Size = new System.Drawing.Size(196, 304);
            this.ListBoxLeft.TabIndex = 1;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(50, 83);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(139, 23);
            this.TxtName.TabIndex = 2;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(50, 121);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(139, 23);
            this.TxtSurname.TabIndex = 3;
            // 
            // ListBoxRight
            // 
            this.ListBoxRight.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListBoxRight.FormattingEnabled = true;
            this.ListBoxRight.ItemHeight = 25;
            this.ListBoxRight.Location = new System.Drawing.Point(461, 57);
            this.ListBoxRight.Name = "ListBoxRight";
            this.ListBoxRight.Size = new System.Drawing.Size(196, 304);
            this.ListBoxRight.TabIndex = 4;
            // 
            // CHSub
            // 
            this.CHSub.AutoSize = true;
            this.CHSub.Location = new System.Drawing.Point(49, 166);
            this.CHSub.Name = "CHSub";
            this.CHSub.Size = new System.Drawing.Size(83, 19);
            this.CHSub.TabIndex = 5;
            this.CHSub.Text = "Předplatné";
            this.CHSub.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CHSub);
            this.Controls.Add(this.ListBoxRight);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.ListBoxLeft);
            this.Controls.Add(this.BtnAdd);
            this.Name = "Form1";
            this.Text = "Práce s Listbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ListBox ListBoxLeft;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.CheckBox CHSub;
        private System.Windows.Forms.ListBox ListBoxRight;
    }
}

