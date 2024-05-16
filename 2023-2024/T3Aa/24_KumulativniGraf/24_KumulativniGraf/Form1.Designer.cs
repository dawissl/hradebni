namespace _24_KumulativniGraf
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
            PanelGraph = new Panel();
            BtnRun = new Button();
            SuspendLayout();
            // 
            // PanelGraph
            // 
            PanelGraph.Location = new Point(17, 22);
            PanelGraph.Name = "PanelGraph";
            PanelGraph.Size = new Size(546, 272);
            PanelGraph.TabIndex = 0;
            PanelGraph.Paint += PanelGraph_Paint;
            // 
            // BtnRun
            // 
            BtnRun.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BtnRun.Location = new Point(588, 31);
            BtnRun.Name = "BtnRun";
            BtnRun.Size = new Size(173, 80);
            BtnRun.TabIndex = 1;
            BtnRun.Text = "Start";
            BtnRun.UseVisualStyleBackColor = true;
            BtnRun.Click += BtnRun_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 321);
            Controls.Add(BtnRun);
            Controls.Add(PanelGraph);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelGraph;
        private Button BtnRun;
    }
}
