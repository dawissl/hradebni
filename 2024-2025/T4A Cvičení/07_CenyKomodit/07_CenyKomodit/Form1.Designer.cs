namespace _07_CenyKomodit
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
            PanelGraf = new Panel();
            BtnLoad = new Button();
            SuspendLayout();
            // 
            // PanelGraf
            // 
            PanelGraf.Location = new Point(13, 15);
            PanelGraf.Name = "PanelGraf";
            PanelGraf.Size = new Size(636, 422);
            PanelGraf.TabIndex = 0;
            PanelGraf.Paint += PanelGraf_Paint;
            // 
            // BtnLoad
            // 
            BtnLoad.Location = new Point(682, 15);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(106, 23);
            BtnLoad.TabIndex = 1;
            BtnLoad.Text = "Načti soubor";
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnLoad);
            Controls.Add(PanelGraf);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelGraf;
        private Button BtnLoad;
    }
}
