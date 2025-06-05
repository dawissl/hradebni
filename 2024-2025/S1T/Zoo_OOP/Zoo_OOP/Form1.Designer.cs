namespace Zoo_OOP
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
            TxtName = new TextBox();
            TxtVek = new TextBox();
            TxtVaha = new TextBox();
            BtnCreate = new Button();
            button1 = new Button();
            LblVystup = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // TxtName
            // 
            TxtName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TxtName.Location = new Point(33, 28);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(188, 39);
            TxtName.TabIndex = 0;
            // 
            // TxtVek
            // 
            TxtVek.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TxtVek.Location = new Point(33, 73);
            TxtVek.Name = "TxtVek";
            TxtVek.Size = new Size(188, 39);
            TxtVek.TabIndex = 1;
            // 
            // TxtVaha
            // 
            TxtVaha.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TxtVaha.Location = new Point(33, 118);
            TxtVaha.Name = "TxtVaha";
            TxtVaha.Size = new Size(188, 39);
            TxtVaha.TabIndex = 2;
            // 
            // BtnCreate
            // 
            BtnCreate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BtnCreate.Location = new Point(33, 178);
            BtnCreate.Name = "BtnCreate";
            BtnCreate.Size = new Size(150, 77);
            BtnCreate.TabIndex = 3;
            BtnCreate.Text = "Vytvoř zvíře";
            BtnCreate.UseVisualStyleBackColor = true;
            BtnCreate.Click += BtnCreate_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(206, 178);
            button1.Name = "button1";
            button1.Size = new Size(150, 77);
            button1.TabIndex = 4;
            button1.Text = "Pozdrav";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LblVystup
            // 
            LblVystup.BorderStyle = BorderStyle.FixedSingle;
            LblVystup.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            LblVystup.Location = new Point(33, 283);
            LblVystup.Name = "LblVystup";
            LblVystup.Size = new Size(323, 108);
            LblVystup.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(238, 134);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 450);
            Controls.Add(checkBox1);
            Controls.Add(LblVystup);
            Controls.Add(button1);
            Controls.Add(BtnCreate);
            Controls.Add(TxtVaha);
            Controls.Add(TxtVek);
            Controls.Add(TxtName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtName;
        private TextBox TxtVek;
        private TextBox TxtVaha;
        private Button BtnCreate;
        private Button button1;
        private Label LblVystup;
        private CheckBox checkBox1;
    }
}
