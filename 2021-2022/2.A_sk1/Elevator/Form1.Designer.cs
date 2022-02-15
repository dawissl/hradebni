
namespace Elevator
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
            this.TxtElevator = new System.Windows.Forms.TextBox();
            this.LblWeight = new System.Windows.Forms.Label();
            this.LblCount = new System.Windows.Forms.Label();
            this.TxtWeight = new System.Windows.Forms.TextBox();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtElevator
            // 
            this.TxtElevator.Location = new System.Drawing.Point(51, 49);
            this.TxtElevator.Multiline = true;
            this.TxtElevator.Name = "TxtElevator";
            this.TxtElevator.Size = new System.Drawing.Size(131, 340);
            this.TxtElevator.TabIndex = 0;
            // 
            // LblWeight
            // 
            this.LblWeight.BackColor = System.Drawing.Color.Lime;
            this.LblWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblWeight.Location = new System.Drawing.Point(237, 49);
            this.LblWeight.Name = "LblWeight";
            this.LblWeight.Size = new System.Drawing.Size(41, 23);
            this.LblWeight.TabIndex = 1;
            this.LblWeight.Text = "váha";
            // 
            // LblCount
            // 
            this.LblCount.BackColor = System.Drawing.Color.Lime;
            this.LblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCount.Location = new System.Drawing.Point(284, 49);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(41, 23);
            this.LblCount.TabIndex = 2;
            this.LblCount.Text = "počet";
            // 
            // TxtWeight
            // 
            this.TxtWeight.Location = new System.Drawing.Point(237, 89);
            this.TxtWeight.Name = "TxtWeight";
            this.TxtWeight.Size = new System.Drawing.Size(88, 23);
            this.TxtWeight.TabIndex = 3;
            // 
            // BtnEnter
            // 
            this.BtnEnter.Location = new System.Drawing.Point(237, 135);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(87, 39);
            this.BtnEnter.TabIndex = 4;
            this.BtnEnter.Text = "Nastoupit";
            this.BtnEnter.UseVisualStyleBackColor = true;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(237, 180);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(87, 39);
            this.BtnReset.TabIndex = 5;
            this.BtnReset.Text = "Zavřít výtah";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 450);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.TxtWeight);
            this.Controls.Add(this.LblCount);
            this.Controls.Add(this.LblWeight);
            this.Controls.Add(this.TxtElevator);
            this.Name = "Form1";
            this.Text = "Výtah";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtElevator;
        private System.Windows.Forms.Label LblWeight;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.TextBox TxtWeight;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Button BtnReset;
    }
}

