namespace _23_RadaCisel
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
            TxtNumbers = new TextBox();
            BtnLoad = new Button();
            ComboOpt = new ComboBox();
            BtnWork = new Button();
            label1 = new Label();
            LblVystup = new Label();
            SuspendLayout();
            // 
            // TxtNumbers
            // 
            TxtNumbers.Location = new Point(17, 10);
            TxtNumbers.Name = "TxtNumbers";
            TxtNumbers.Size = new Size(315, 23);
            TxtNumbers.TabIndex = 0;
            // 
            // BtnLoad
            // 
            BtnLoad.Location = new Point(348, 9);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(75, 23);
            BtnLoad.TabIndex = 1;
            BtnLoad.Text = "Načti";
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // ComboOpt
            // 
            ComboOpt.FormattingEnabled = true;
            ComboOpt.Items.AddRange(new object[] { "suma", "výpis", "maximum" });
            ComboOpt.Location = new Point(17, 39);
            ComboOpt.Name = "ComboOpt";
            ComboOpt.Size = new Size(315, 23);
            ComboOpt.TabIndex = 2;
            // 
            // BtnWork
            // 
            BtnWork.Location = new Point(348, 39);
            BtnWork.Name = "BtnWork";
            BtnWork.Size = new Size(75, 23);
            BtnWork.TabIndex = 3;
            BtnWork.Text = "Zpracuj";
            BtnWork.UseVisualStyleBackColor = true;
            BtnWork.Click += BtnWork_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(17, 81);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 4;
            label1.Text = "Výstup";
            // 
            // LblVystup
            // 
            LblVystup.BorderStyle = BorderStyle.Fixed3D;
            LblVystup.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            LblVystup.Location = new Point(17, 111);
            LblVystup.Name = "LblVystup";
            LblVystup.Size = new Size(406, 54);
            LblVystup.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 226);
            Controls.Add(LblVystup);
            Controls.Add(label1);
            Controls.Add(BtnWork);
            Controls.Add(ComboOpt);
            Controls.Add(BtnLoad);
            Controls.Add(TxtNumbers);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtNumbers;
        private Button BtnLoad;
        private ComboBox ComboOpt;
        private Button BtnWork;
        private Label label1;
        private Label LblVystup;
    }
}