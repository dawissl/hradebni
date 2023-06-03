namespace _14_PokrocilyFiltr
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
            this.TxtNetwork = new System.Windows.Forms.TextBox();
            this.TxtStatus = new System.Windows.Forms.TextBox();
            this.TxtFull = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ListSensors = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TxtFarm
            // 
            this.TxtFarm.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtFarm.Location = new System.Drawing.Point(44, 19);
            this.TxtFarm.Name = "TxtFarm";
            this.TxtFarm.PlaceholderText = "Farma";
            this.TxtFarm.Size = new System.Drawing.Size(283, 39);
            this.TxtFarm.TabIndex = 0;
            // 
            // TxtType
            // 
            this.TxtType.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtType.Location = new System.Drawing.Point(44, 64);
            this.TxtType.Name = "TxtType";
            this.TxtType.PlaceholderText = "Typ senzoru";
            this.TxtType.Size = new System.Drawing.Size(283, 39);
            this.TxtType.TabIndex = 1;
            // 
            // TxtNetwork
            // 
            this.TxtNetwork.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNetwork.Location = new System.Drawing.Point(44, 109);
            this.TxtNetwork.Name = "TxtNetwork";
            this.TxtNetwork.PlaceholderText = "Sít";
            this.TxtNetwork.Size = new System.Drawing.Size(283, 39);
            this.TxtNetwork.TabIndex = 2;
            // 
            // TxtStatus
            // 
            this.TxtStatus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtStatus.Location = new System.Drawing.Point(44, 154);
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.PlaceholderText = "Status";
            this.TxtStatus.Size = new System.Drawing.Size(283, 39);
            this.TxtStatus.TabIndex = 3;
            // 
            // TxtFull
            // 
            this.TxtFull.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtFull.Location = new System.Drawing.Point(44, 199);
            this.TxtFull.Name = "TxtFull";
            this.TxtFull.PlaceholderText = "Fulltextové vyhledávání";
            this.TxtFull.Size = new System.Drawing.Size(283, 39);
            this.TxtFull.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(44, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 63);
            this.button1.TabIndex = 5;
            this.button1.Text = "Filtruj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListSensors
            // 
            this.ListSensors.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListSensors.FormattingEnabled = true;
            this.ListSensors.ItemHeight = 21;
            this.ListSensors.Location = new System.Drawing.Point(334, 18);
            this.ListSensors.Name = "ListSensors";
            this.ListSensors.ScrollAlwaysVisible = true;
            this.ListSensors.Size = new System.Drawing.Size(911, 424);
            this.ListSensors.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 452);
            this.Controls.Add(this.ListSensors);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtFull);
            this.Controls.Add(this.TxtStatus);
            this.Controls.Add(this.TxtNetwork);
            this.Controls.Add(this.TxtType);
            this.Controls.Add(this.TxtFarm);
            this.Name = "Form1";
            this.Text = "s";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtFarm;
        private TextBox TxtType;
        private TextBox TxtNetwork;
        private TextBox TxtStatus;
        private TextBox TxtFull;
        private Button button1;
        private ListBox ListSensors;
    }
}