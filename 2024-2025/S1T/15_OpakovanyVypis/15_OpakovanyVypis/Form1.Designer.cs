namespace _15_OpakovanyVypis
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
            TxtText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TxtCislo = new TextBox();
            BtnWhileCycle = new Button();
            BtnForCycle = new Button();
            LblVypis = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // TxtText
            // 
            TxtText.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TxtText.Location = new Point(154, 26);
            TxtText.Name = "TxtText";
            TxtText.Size = new Size(248, 35);
            TxtText.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 29);
            label1.Name = "label1";
            label1.Size = new Size(133, 30);
            label1.TabIndex = 1;
            label1.Text = "Vstupní text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 80);
            label2.Name = "label2";
            label2.Size = new Size(138, 30);
            label2.TabIndex = 2;
            label2.Text = "Vstupní číslo";
            // 
            // TxtCislo
            // 
            TxtCislo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCislo.Location = new Point(154, 75);
            TxtCislo.Name = "TxtCislo";
            TxtCislo.Size = new Size(248, 35);
            TxtCislo.TabIndex = 3;
            // 
            // BtnWhileCycle
            // 
            BtnWhileCycle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnWhileCycle.Location = new Point(15, 145);
            BtnWhileCycle.Name = "BtnWhileCycle";
            BtnWhileCycle.Size = new Size(189, 77);
            BtnWhileCycle.TabIndex = 4;
            BtnWhileCycle.Text = "While cyklus";
            BtnWhileCycle.UseVisualStyleBackColor = true;
            BtnWhileCycle.Click += BtnWhileCycle_Click;
            // 
            // BtnForCycle
            // 
            BtnForCycle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnForCycle.Location = new Point(213, 145);
            BtnForCycle.Name = "BtnForCycle";
            BtnForCycle.Size = new Size(189, 77);
            BtnForCycle.TabIndex = 5;
            BtnForCycle.Text = "For cyklus";
            BtnForCycle.UseVisualStyleBackColor = true;
            BtnForCycle.Click += BtnForCycle_Click;
            // 
            // LblVypis
            // 
            LblVypis.BackColor = SystemColors.ActiveBorder;
            LblVypis.BorderStyle = BorderStyle.Fixed3D;
            LblVypis.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblVypis.Location = new Point(438, 95);
            LblVypis.Name = "LblVypis";
            LblVypis.Size = new Size(318, 335);
            LblVypis.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(438, 29);
            label4.Name = "label4";
            label4.Size = new Size(81, 30);
            label4.TabIndex = 7;
            label4.Text = "Výstup";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(LblVypis);
            Controls.Add(BtnForCycle);
            Controls.Add(BtnWhileCycle);
            Controls.Add(TxtCislo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtText;
        private Label label1;
        private Label label2;
        private TextBox TxtCislo;
        private Button BtnWhileCycle;
        private Button BtnForCycle;
        private Label LblVypis;
        private Label label4;
    }
}