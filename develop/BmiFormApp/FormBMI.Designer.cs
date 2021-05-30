
namespace BmiFormApp
{
    partial class FormBMI
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
            this.BtnBMICalcul = new System.Windows.Forms.Button();
            this.LblResult = new System.Windows.Forms.Label();
            this.CheckBoxIssues = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtHeight = new System.Windows.Forms.TextBox();
            this.TxtWeight = new System.Windows.Forms.TextBox();
            this.RadioMan = new System.Windows.Forms.RadioButton();
            this.RadioWoman = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // BtnBMICalcul
            // 
            this.BtnBMICalcul.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBMICalcul.Location = new System.Drawing.Point(12, 133);
            this.BtnBMICalcul.Name = "BtnBMICalcul";
            this.BtnBMICalcul.Size = new System.Drawing.Size(187, 31);
            this.BtnBMICalcul.TabIndex = 0;
            this.BtnBMICalcul.Text = "Zjisti BMI";
            this.BtnBMICalcul.UseVisualStyleBackColor = true;
            // 
            // LblResult
            // 
            this.LblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblResult.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblResult.Location = new System.Drawing.Point(9, 178);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(308, 31);
            this.LblResult.TabIndex = 1;
            this.LblResult.Text = "Zde se zobrazí výsledek";
            this.LblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckBoxIssues
            // 
            this.CheckBoxIssues.AutoSize = true;
            this.CheckBoxIssues.Location = new System.Drawing.Point(211, 143);
            this.CheckBoxIssues.Name = "CheckBoxIssues";
            this.CheckBoxIssues.Size = new System.Drawing.Size(99, 19);
            this.CheckBoxIssues.TabIndex = 2;
            this.CheckBoxIssues.Text = "Zobrazit rizika";
            this.CheckBoxIssues.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Výška [m]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Váha [m]";
            // 
            // TxtHeight
            // 
            this.TxtHeight.Location = new System.Drawing.Point(94, 17);
            this.TxtHeight.Name = "TxtHeight";
            this.TxtHeight.Size = new System.Drawing.Size(171, 23);
            this.TxtHeight.TabIndex = 5;
            // 
            // TxtWeight
            // 
            this.TxtWeight.Location = new System.Drawing.Point(94, 52);
            this.TxtWeight.Name = "TxtWeight";
            this.TxtWeight.Size = new System.Drawing.Size(171, 23);
            this.TxtWeight.TabIndex = 6;
            // 
            // RadioMan
            // 
            this.RadioMan.AutoSize = true;
            this.RadioMan.Checked = true;
            this.RadioMan.Location = new System.Drawing.Point(94, 96);
            this.RadioMan.Name = "RadioMan";
            this.RadioMan.Size = new System.Drawing.Size(48, 19);
            this.RadioMan.TabIndex = 7;
            this.RadioMan.TabStop = true;
            this.RadioMan.Text = "Muž";
            this.RadioMan.UseVisualStyleBackColor = true;
            // 
            // RadioWoman
            // 
            this.RadioWoman.AutoSize = true;
            this.RadioWoman.Location = new System.Drawing.Point(148, 96);
            this.RadioWoman.Name = "RadioWoman";
            this.RadioWoman.Size = new System.Drawing.Size(51, 19);
            this.RadioWoman.TabIndex = 8;
            this.RadioWoman.Text = "Žena";
            this.RadioWoman.UseVisualStyleBackColor = true;
            // 
            // FormBMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 221);
            this.Controls.Add(this.RadioWoman);
            this.Controls.Add(this.RadioMan);
            this.Controls.Add(this.TxtWeight);
            this.Controls.Add(this.TxtHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckBoxIssues);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.BtnBMICalcul);
            this.Name = "FormBMI";
            this.Text = "BMI kalkulačka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBMICalcul;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.CheckBox CheckBoxIssues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtHeight;
        private System.Windows.Forms.TextBox TxtWeight;
        private System.Windows.Forms.RadioButton RadioMan;
        private System.Windows.Forms.RadioButton RadioWoman;
    }
}

