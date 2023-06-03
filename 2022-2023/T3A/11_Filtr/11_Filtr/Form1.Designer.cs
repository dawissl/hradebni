namespace _11_Filtr
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
            this.TxtFarm = new System.Windows.Forms.TextBox();
            this.TxtType = new System.Windows.Forms.TextBox();
            this.TxtStatus = new System.Windows.Forms.TextBox();
            this.TxtNetwork = new System.Windows.Forms.TextBox();
            this.TxtFull = new System.Windows.Forms.TextBox();
            this.BtnFiltr = new System.Windows.Forms.Button();
            this.ListSensors = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TxtFarm
            // 
            this.TxtFarm.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtFarm.Location = new System.Drawing.Point(38, 12);
            this.TxtFarm.Name = "TxtFarm";
            this.TxtFarm.PlaceholderText = "Farma";
            this.TxtFarm.Size = new System.Drawing.Size(306, 43);
            this.TxtFarm.TabIndex = 0;
            // 
            // TxtType
            // 
            this.TxtType.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtType.Location = new System.Drawing.Point(38, 61);
            this.TxtType.Name = "TxtType";
            this.TxtType.PlaceholderText = "Typ senzoru";
            this.TxtType.Size = new System.Drawing.Size(306, 43);
            this.TxtType.TabIndex = 1;
            // 
            // TxtStatus
            // 
            this.TxtStatus.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtStatus.Location = new System.Drawing.Point(38, 110);
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.PlaceholderText = "Status";
            this.TxtStatus.Size = new System.Drawing.Size(306, 43);
            this.TxtStatus.TabIndex = 2;
            // 
            // TxtNetwork
            // 
            this.TxtNetwork.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNetwork.Location = new System.Drawing.Point(38, 159);
            this.TxtNetwork.Name = "TxtNetwork";
            this.TxtNetwork.PlaceholderText = "Síť";
            this.TxtNetwork.Size = new System.Drawing.Size(306, 43);
            this.TxtNetwork.TabIndex = 3;
            // 
            // TxtFull
            // 
            this.TxtFull.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtFull.Location = new System.Drawing.Point(38, 208);
            this.TxtFull.Name = "TxtFull";
            this.TxtFull.PlaceholderText = "Fulltextové vyhledávání";
            this.TxtFull.Size = new System.Drawing.Size(306, 43);
            this.TxtFull.TabIndex = 4;
            // 
            // BtnFiltr
            // 
            this.BtnFiltr.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnFiltr.Location = new System.Drawing.Point(46, 271);
            this.BtnFiltr.Name = "BtnFiltr";
            this.BtnFiltr.Size = new System.Drawing.Size(298, 53);
            this.BtnFiltr.TabIndex = 5;
            this.BtnFiltr.Text = "Filtruj";
            this.BtnFiltr.UseVisualStyleBackColor = true;
            this.BtnFiltr.Click += new System.EventHandler(this.BtnFiltr_Click);
            // 
            // ListSensors
            // 
            this.ListSensors.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListSensors.FormattingEnabled = true;
            this.ListSensors.ItemHeight = 25;
            this.ListSensors.Location = new System.Drawing.Point(395, 9);
            this.ListSensors.Name = "ListSensors";
            this.ListSensors.ScrollAlwaysVisible = true;
            this.ListSensors.Size = new System.Drawing.Size(1145, 429);
            this.ListSensors.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1566, 450);
            this.Controls.Add(this.ListSensors);
            this.Controls.Add(this.BtnFiltr);
            this.Controls.Add(this.TxtFull);
            this.Controls.Add(this.TxtNetwork);
            this.Controls.Add(this.TxtStatus);
            this.Controls.Add(this.TxtType);
            this.Controls.Add(this.TxtFarm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtFarm;
        private TextBox TxtType;
        private TextBox TxtStatus;
        private TextBox TxtNetwork;
        private TextBox TxtFull;
        private Button BtnFiltr;
        private ListBox ListSensors;
    }
}