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
            PanelGraph = new Panel();
            SuspendLayout();
            // 
            // BtnData
            // 
            BtnData.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnData.Location = new Point(27, 15);
            BtnData.Name = "BtnData";
            BtnData.Size = new Size(190, 48);
            BtnData.TabIndex = 0;
            BtnData.Text = "Vytvoř data";
            BtnData.UseVisualStyleBackColor = true;
            BtnData.Click += BtnData_Click;
            // 
            // BtnPie
            // 
            BtnPie.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPie.Location = new Point(223, 15);
            BtnPie.Name = "BtnPie";
            BtnPie.Size = new Size(190, 48);
            BtnPie.TabIndex = 1;
            BtnPie.Text = "Koláčový graf";
            BtnPie.UseVisualStyleBackColor = true;
            BtnPie.Click += BtnPie_Click;
            // 
            // PanelGraph
            // 
            PanelGraph.BackColor = SystemColors.ControlLightLight;
            PanelGraph.Location = new Point(29, 74);
            PanelGraph.Name = "PanelGraph";
            PanelGraph.Size = new Size(384, 351);
            PanelGraph.TabIndex = 2;
            PanelGraph.Paint += PanelGraph_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 450);
            Controls.Add(PanelGraph);
            Controls.Add(BtnPie);
            Controls.Add(BtnData);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnData;
        private Button BtnPie;
        private Panel PanelGraph;
    }
}