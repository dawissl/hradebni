
namespace DummyCalc
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
            this.BtnCompute = new System.Windows.Forms.Button();
            this.RbtnAdd = new System.Windows.Forms.RadioButton();
            this.RbtnSub = new System.Windows.Forms.RadioButton();
            this.RbtnDiv = new System.Windows.Forms.RadioButton();
            this.RbtnMul = new System.Windows.Forms.RadioButton();
            this.TxtVstupA = new System.Windows.Forms.TextBox();
            this.TxtVstupB = new System.Windows.Forms.TextBox();
            this.LblResult = new System.Windows.Forms.Label();
            this.ChBColor = new System.Windows.Forms.CheckBox();
            this.ChBRound = new System.Windows.Forms.CheckBox();
            this.RbtnPow = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // BtnCompute
            // 
            this.BtnCompute.Location = new System.Drawing.Point(224, 178);
            this.BtnCompute.Name = "BtnCompute";
            this.BtnCompute.Size = new System.Drawing.Size(94, 40);
            this.BtnCompute.TabIndex = 0;
            this.BtnCompute.Text = "Počítej";
            this.BtnCompute.UseVisualStyleBackColor = true;
            this.BtnCompute.Click += new System.EventHandler(this.BtnCompute_Click);
            // 
            // RbtnAdd
            // 
            this.RbtnAdd.AutoSize = true;
            this.RbtnAdd.Checked = true;
            this.RbtnAdd.Location = new System.Drawing.Point(224, 29);
            this.RbtnAdd.Name = "RbtnAdd";
            this.RbtnAdd.Size = new System.Drawing.Size(60, 19);
            this.RbtnAdd.TabIndex = 1;
            this.RbtnAdd.TabStop = true;
            this.RbtnAdd.Text = "Sčítání";
            this.RbtnAdd.UseVisualStyleBackColor = true;
            // 
            // RbtnSub
            // 
            this.RbtnSub.AutoSize = true;
            this.RbtnSub.Location = new System.Drawing.Point(224, 54);
            this.RbtnSub.Name = "RbtnSub";
            this.RbtnSub.Size = new System.Drawing.Size(70, 19);
            this.RbtnSub.TabIndex = 2;
            this.RbtnSub.TabStop = true;
            this.RbtnSub.Text = "Odčítání";
            this.RbtnSub.UseVisualStyleBackColor = true;
            // 
            // RbtnDiv
            // 
            this.RbtnDiv.AutoSize = true;
            this.RbtnDiv.Location = new System.Drawing.Point(224, 79);
            this.RbtnDiv.Name = "RbtnDiv";
            this.RbtnDiv.Size = new System.Drawing.Size(58, 19);
            this.RbtnDiv.TabIndex = 3;
            this.RbtnDiv.TabStop = true;
            this.RbtnDiv.Text = "Dělení";
            this.RbtnDiv.UseVisualStyleBackColor = true;
            // 
            // RbtnMul
            // 
            this.RbtnMul.AutoSize = true;
            this.RbtnMul.Location = new System.Drawing.Point(224, 104);
            this.RbtnMul.Name = "RbtnMul";
            this.RbtnMul.Size = new System.Drawing.Size(75, 19);
            this.RbtnMul.TabIndex = 4;
            this.RbtnMul.TabStop = true;
            this.RbtnMul.Text = "Násobení";
            this.RbtnMul.UseVisualStyleBackColor = true;
            // 
            // TxtVstupA
            // 
            this.TxtVstupA.Location = new System.Drawing.Point(12, 25);
            this.TxtVstupA.Name = "TxtVstupA";
            this.TxtVstupA.Size = new System.Drawing.Size(175, 23);
            this.TxtVstupA.TabIndex = 5;
            // 
            // TxtVstupB
            // 
            this.TxtVstupB.Location = new System.Drawing.Point(12, 75);
            this.TxtVstupB.Name = "TxtVstupB";
            this.TxtVstupB.Size = new System.Drawing.Size(175, 23);
            this.TxtVstupB.TabIndex = 6;
            // 
            // LblResult
            // 
            this.LblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblResult.Location = new System.Drawing.Point(12, 128);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(175, 25);
            this.LblResult.TabIndex = 7;
            // 
            // ChBColor
            // 
            this.ChBColor.AutoSize = true;
            this.ChBColor.Location = new System.Drawing.Point(13, 175);
            this.ChBColor.Name = "ChBColor";
            this.ChBColor.Size = new System.Drawing.Size(74, 19);
            this.ChBColor.TabIndex = 8;
            this.ChBColor.Text = "Obarvení";
            this.ChBColor.UseVisualStyleBackColor = true;
            // 
            // ChBRound
            // 
            this.ChBRound.AutoSize = true;
            this.ChBRound.Location = new System.Drawing.Point(113, 175);
            this.ChBRound.Name = "ChBRound";
            this.ChBRound.Size = new System.Drawing.Size(96, 19);
            this.ChBRound.TabIndex = 9;
            this.ChBRound.Text = "Zaokrouhlení";
            this.ChBRound.UseVisualStyleBackColor = true;
            // 
            // RbtnPow
            // 
            this.RbtnPow.AutoSize = true;
            this.RbtnPow.Location = new System.Drawing.Point(224, 129);
            this.RbtnPow.Name = "RbtnPow";
            this.RbtnPow.Size = new System.Drawing.Size(72, 19);
            this.RbtnPow.TabIndex = 10;
            this.RbtnPow.TabStop = true;
            this.RbtnPow.Text = "Mocnina";
            this.RbtnPow.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 244);
            this.Controls.Add(this.RbtnPow);
            this.Controls.Add(this.ChBRound);
            this.Controls.Add(this.ChBColor);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.TxtVstupB);
            this.Controls.Add(this.TxtVstupA);
            this.Controls.Add(this.RbtnMul);
            this.Controls.Add(this.RbtnDiv);
            this.Controls.Add(this.RbtnSub);
            this.Controls.Add(this.RbtnAdd);
            this.Controls.Add(this.BtnCompute);
            this.Name = "Form1";
            this.Text = "Hloupá kalkulačka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCompute;
        private System.Windows.Forms.RadioButton RbtnAdd;
        private System.Windows.Forms.RadioButton RbtnSub;
        private System.Windows.Forms.RadioButton RbtnDiv;
        private System.Windows.Forms.RadioButton RbtnMul;
        private System.Windows.Forms.TextBox TxtVstupA;
        private System.Windows.Forms.TextBox TxtVstupB;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.CheckBox ChBColor;
        private System.Windows.Forms.CheckBox ChBRound;
        private System.Windows.Forms.RadioButton RbtnPow;
    }
}

