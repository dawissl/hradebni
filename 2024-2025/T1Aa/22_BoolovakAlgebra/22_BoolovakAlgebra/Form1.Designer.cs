namespace _22_BoolovakAlgebra
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
            chkA = new CheckBox();
            chkB = new CheckBox();
            cmbOperation = new ComboBox();
            btnCalculate = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // chkA
            // 
            chkA.AutoSize = true;
            chkA.Location = new Point(30, 30);
            chkA.Name = "chkA";
            chkA.Size = new Size(84, 19);
            chkA.TabIndex = 0;
            chkA.Text = "Hodnota A";
            chkA.UseVisualStyleBackColor = true;
            // 
            // chkB
            // 
            chkB.AutoSize = true;
            chkB.Location = new Point(30, 60);
            chkB.Name = "chkB";
            chkB.Size = new Size(83, 19);
            chkB.TabIndex = 1;
            chkB.Text = "Hodnota B";
            chkB.UseVisualStyleBackColor = true;
            // 
            // cmbOperation
            // 
            cmbOperation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperation.FormattingEnabled = true;
            cmbOperation.Items.AddRange(new object[] { "A AND B", "A OR B", "A XOR B", "NOT A", "NOT B", "A IMPLICATE B", "B IMPLICATE A", "A EQUALL B" });
            cmbOperation.Location = new Point(30, 100);
            cmbOperation.Name = "cmbOperation";
            cmbOperation.Size = new Size(150, 23);
            cmbOperation.TabIndex = 2;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(30, 140);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(150, 30);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Spočítej";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(30, 190);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(64, 15);
            lblResult.TabIndex = 4;
            lblResult.Text = "Výsledek: -";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(225, 240);
            Controls.Add(chkA);
            Controls.Add(chkB);
            Controls.Add(cmbOperation);
            Controls.Add(btnCalculate);
            Controls.Add(lblResult);
            Name = "Form1";
            Text = "Booleovska Algebra";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox chkA;
        private System.Windows.Forms.CheckBox chkB;
        private System.Windows.Forms.ComboBox cmbOperation;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
    }
}
