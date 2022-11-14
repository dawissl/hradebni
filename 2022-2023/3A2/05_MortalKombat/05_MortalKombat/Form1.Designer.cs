namespace _05_MortalKombat
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
            this.ComboPlayerOne = new System.Windows.Forms.ComboBox();
            this.ComboPlayerTwo = new System.Windows.Forms.ComboBox();
            this.ButtonFight = new System.Windows.Forms.Button();
            this.LblOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboPlayerOne
            // 
            this.ComboPlayerOne.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboPlayerOne.FormattingEnabled = true;
            this.ComboPlayerOne.Location = new System.Drawing.Point(34, 23);
            this.ComboPlayerOne.Name = "ComboPlayerOne";
            this.ComboPlayerOne.Size = new System.Drawing.Size(238, 33);
            this.ComboPlayerOne.TabIndex = 0;
            // 
            // ComboPlayerTwo
            // 
            this.ComboPlayerTwo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboPlayerTwo.FormattingEnabled = true;
            this.ComboPlayerTwo.Location = new System.Drawing.Point(299, 23);
            this.ComboPlayerTwo.Name = "ComboPlayerTwo";
            this.ComboPlayerTwo.Size = new System.Drawing.Size(238, 33);
            this.ComboPlayerTwo.TabIndex = 1;
            // 
            // ButtonFight
            // 
            this.ButtonFight.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonFight.Location = new System.Drawing.Point(370, 69);
            this.ButtonFight.Name = "ButtonFight";
            this.ButtonFight.Size = new System.Drawing.Size(99, 33);
            this.ButtonFight.TabIndex = 2;
            this.ButtonFight.Text = "Souboj";
            this.ButtonFight.UseVisualStyleBackColor = true;
            this.ButtonFight.Click += new System.EventHandler(this.ButtonFight_Click);
            // 
            // LblOut
            // 
            this.LblOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblOut.Location = new System.Drawing.Point(34, 69);
            this.LblOut.Name = "LblOut";
            this.LblOut.Size = new System.Drawing.Size(314, 642);
            this.LblOut.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 735);
            this.Controls.Add(this.LblOut);
            this.Controls.Add(this.ButtonFight);
            this.Controls.Add(this.ComboPlayerTwo);
            this.Controls.Add(this.ComboPlayerOne);
            this.Name = "Form1";
            this.Text = "Mortal Kombat";
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox ComboPlayerOne;
        private ComboBox ComboPlayerTwo;
        private Button ButtonFight;
        private Label LblOut;
    }
}