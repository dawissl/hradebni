namespace _14_GrafKomodit
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
            this.PanelGraph = new System.Windows.Forms.Panel();
            this.CheckWheat = new System.Windows.Forms.CheckBox();
            this.CheckBeef = new System.Windows.Forms.CheckBox();
            this.CheckCooper = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // PanelGraph
            // 
            this.PanelGraph.BackColor = System.Drawing.Color.White;
            this.PanelGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelGraph.Location = new System.Drawing.Point(18, 12);
            this.PanelGraph.Name = "PanelGraph";
            this.PanelGraph.Size = new System.Drawing.Size(500, 400);
            this.PanelGraph.TabIndex = 0;
            this.PanelGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelGraph_Paint);
            // 
            // CheckWheat
            // 
            this.CheckWheat.AutoSize = true;
            this.CheckWheat.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckWheat.Location = new System.Drawing.Point(547, 21);
            this.CheckWheat.Name = "CheckWheat";
            this.CheckWheat.Size = new System.Drawing.Size(75, 34);
            this.CheckWheat.TabIndex = 1;
            this.CheckWheat.Text = "Obilí";
            this.CheckWheat.UseVisualStyleBackColor = true;
            this.CheckWheat.CheckedChanged += new System.EventHandler(this.CheckWheat_CheckedChanged);
            // 
            // CheckBeef
            // 
            this.CheckBeef.AutoSize = true;
            this.CheckBeef.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBeef.Location = new System.Drawing.Point(547, 73);
            this.CheckBeef.Name = "CheckBeef";
            this.CheckBeef.Size = new System.Drawing.Size(95, 34);
            this.CheckBeef.TabIndex = 2;
            this.CheckBeef.Text = "Hovězí";
            this.CheckBeef.UseVisualStyleBackColor = true;
            this.CheckBeef.CheckedChanged += new System.EventHandler(this.CheckBeef_CheckedChanged);
            // 
            // CheckCooper
            // 
            this.CheckCooper.AutoSize = true;
            this.CheckCooper.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckCooper.Location = new System.Drawing.Point(547, 126);
            this.CheckCooper.Name = "CheckCooper";
            this.CheckCooper.Size = new System.Drawing.Size(76, 34);
            this.CheckCooper.TabIndex = 3;
            this.CheckCooper.Text = "Meď";
            this.CheckCooper.UseVisualStyleBackColor = true;
            this.CheckCooper.CheckedChanged += new System.EventHandler(this.CheckCooper_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 425);
            this.Controls.Add(this.CheckCooper);
            this.Controls.Add(this.CheckBeef);
            this.Controls.Add(this.CheckWheat);
            this.Controls.Add(this.PanelGraph);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel PanelGraph;
        private CheckBox CheckWheat;
        private CheckBox CheckBeef;
        private CheckBox CheckCooper;
    }
}