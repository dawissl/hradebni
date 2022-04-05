
namespace DialogovaOkna
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
            this.BtnColour = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCompute
            // 
            this.BtnCompute.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCompute.Location = new System.Drawing.Point(442, 30);
            this.BtnCompute.Name = "BtnCompute";
            this.BtnCompute.Size = new System.Drawing.Size(170, 117);
            this.BtnCompute.TabIndex = 0;
            this.BtnCompute.Text = "Počítadlo";
            this.BtnCompute.UseVisualStyleBackColor = true;
            this.BtnCompute.Click += new System.EventHandler(this.BtnCompute_Click);
            // 
            // BtnColour
            // 
            this.BtnColour.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnColour.Location = new System.Drawing.Point(442, 165);
            this.BtnColour.Name = "BtnColour";
            this.BtnColour.Size = new System.Drawing.Size(170, 117);
            this.BtnColour.TabIndex = 1;
            this.BtnColour.Text = "Barva";
            this.BtnColour.UseVisualStyleBackColor = true;
            this.BtnColour.Click += new System.EventHandler(this.BtnColour_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnReset.Location = new System.Drawing.Point(442, 305);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(170, 117);
            this.BtnReset.TabIndex = 2;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // TxtInput
            // 
            this.TxtInput.Location = new System.Drawing.Point(46, 29);
            this.TxtInput.Multiline = true;
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(356, 392);
            this.TxtInput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.TxtInput);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnColour);
            this.Controls.Add(this.BtnCompute);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCompute;
        private System.Windows.Forms.Button BtnColour;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.TextBox TxtInput;
    }
}

