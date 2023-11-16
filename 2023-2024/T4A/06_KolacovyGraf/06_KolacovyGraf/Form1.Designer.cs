namespace _06_KolacovyGraf
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
            BtnData = new Button();
            BtnPie = new Button();
            PanelPie = new Panel();
            SuspendLayout();
            // 
            // BtnData
            // 
            BtnData.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnData.Location = new Point(35, 17);
            BtnData.Name = "BtnData";
            BtnData.Size = new Size(214, 64);
            BtnData.TabIndex = 0;
            BtnData.Text = "Generovani dat";
            BtnData.UseVisualStyleBackColor = true;
            BtnData.Click += BtnData_Click;
            // 
            // BtnPie
            // 
            BtnPie.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPie.Location = new Point(275, 17);
            BtnPie.Name = "BtnPie";
            BtnPie.Size = new Size(214, 64);
            BtnPie.TabIndex = 1;
            BtnPie.Text = "Koláčový graf";
            BtnPie.UseVisualStyleBackColor = true;
            BtnPie.Click += BtnPie_Click;
            // 
            // PanelPie
            // 
            PanelPie.BackColor = SystemColors.ButtonHighlight;
            PanelPie.BorderStyle = BorderStyle.FixedSingle;
            PanelPie.Location = new Point(38, 94);
            PanelPie.Name = "PanelPie";
            PanelPie.Size = new Size(452, 335);
            PanelPie.TabIndex = 2;
            PanelPie.Paint += PanelPie_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 450);
            Controls.Add(PanelPie);
            Controls.Add(BtnPie);
            Controls.Add(BtnData);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnData;
        private Button BtnPie;
        private Panel PanelPie;
    }
}