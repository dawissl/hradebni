
namespace _05_Duel
{
    partial class FormPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtPlayerName = new System.Windows.Forms.TextBox();
            this.TxtPlayerMaxAttack = new System.Windows.Forms.TextBox();
            this.TxtPlayerMinAttack = new System.Windows.Forms.TextBox();
            this.TxtPlayerDefense = new System.Windows.Forms.TextBox();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtPlayerName
            // 
            this.TxtPlayerName.Location = new System.Drawing.Point(131, 26);
            this.TxtPlayerName.Name = "TxtPlayerName";
            this.TxtPlayerName.Size = new System.Drawing.Size(100, 23);
            this.TxtPlayerName.TabIndex = 0;
//            this.TxtPlayerName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtPlayerMaxAttack
            // 
            this.TxtPlayerMaxAttack.Location = new System.Drawing.Point(131, 71);
            this.TxtPlayerMaxAttack.Name = "TxtPlayerMaxAttack";
            this.TxtPlayerMaxAttack.Size = new System.Drawing.Size(100, 23);
            this.TxtPlayerMaxAttack.TabIndex = 1;
            // 
            // TxtPlayerMinAttack
            // 
            this.TxtPlayerMinAttack.Location = new System.Drawing.Point(131, 112);
            this.TxtPlayerMinAttack.Name = "TxtPlayerMinAttack";
            this.TxtPlayerMinAttack.Size = new System.Drawing.Size(100, 23);
            this.TxtPlayerMinAttack.TabIndex = 2;
            // 
            // TxtPlayerDefense
            // 
            this.TxtPlayerDefense.Location = new System.Drawing.Point(131, 152);
            this.TxtPlayerDefense.Name = "TxtPlayerDefense";
            this.TxtPlayerDefense.Size = new System.Drawing.Size(100, 23);
            this.TxtPlayerDefense.TabIndex = 3;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConfirm.Location = new System.Drawing.Point(56, 207);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(175, 53);
            this.BtnConfirm.TabIndex = 4;
            this.BtnConfirm.Text = "Vytvořit hráče";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(56, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Jméno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Útok (max)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Útok (min)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(56, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Obrana";
            // 
            // FormPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 327);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.TxtPlayerDefense);
            this.Controls.Add(this.TxtPlayerMinAttack);
            this.Controls.Add(this.TxtPlayerMaxAttack);
            this.Controls.Add(this.TxtPlayerName);
            this.Name = "FormPlayer";
            this.Text = "FormPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPlayerName;
        private System.Windows.Forms.TextBox TxtPlayerMaxAttack;
        private System.Windows.Forms.TextBox TxtPlayerMinAttack;
        private System.Windows.Forms.TextBox TxtPlayerDefense;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}