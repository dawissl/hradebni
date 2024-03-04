namespace _10_MouseEvent
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
            this.PanelDraw = new System.Windows.Forms.Panel();
            this.RadioSquare = new System.Windows.Forms.RadioButton();
            this.RadioRectangle = new System.Windows.Forms.RadioButton();
            this.RadioCircle = new System.Windows.Forms.RadioButton();
            this.RadioEllipse = new System.Windows.Forms.RadioButton();
            this.TrackHeight = new System.Windows.Forms.TrackBar();
            this.TrackWidth = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrackHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelDraw
            // 
            this.PanelDraw.BackColor = System.Drawing.Color.White;
            this.PanelDraw.Location = new System.Drawing.Point(0, 12);
            this.PanelDraw.Name = "PanelDraw";
            this.PanelDraw.Size = new System.Drawing.Size(574, 429);
            this.PanelDraw.TabIndex = 0;
            this.PanelDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDraw_Paint_1);
            this.PanelDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelDraw_MouseDown_1);
            // 
            // RadioSquare
            // 
            this.RadioSquare.AutoSize = true;
            this.RadioSquare.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioSquare.Location = new System.Drawing.Point(603, 21);
            this.RadioSquare.Name = "RadioSquare";
            this.RadioSquare.Size = new System.Drawing.Size(112, 36);
            this.RadioSquare.TabIndex = 1;
            this.RadioSquare.TabStop = true;
            this.RadioSquare.Text = "Čtverec";
            this.RadioSquare.UseVisualStyleBackColor = true;
            this.RadioSquare.CheckedChanged += new System.EventHandler(this.RadioSquare_CheckedChanged);
            // 
            // RadioRectangle
            // 
            this.RadioRectangle.AutoSize = true;
            this.RadioRectangle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioRectangle.Location = new System.Drawing.Point(603, 63);
            this.RadioRectangle.Name = "RadioRectangle";
            this.RadioRectangle.Size = new System.Drawing.Size(129, 36);
            this.RadioRectangle.TabIndex = 2;
            this.RadioRectangle.TabStop = true;
            this.RadioRectangle.Text = "Obdelnik";
            this.RadioRectangle.UseVisualStyleBackColor = true;
            // 
            // RadioCircle
            // 
            this.RadioCircle.AutoSize = true;
            this.RadioCircle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioCircle.Location = new System.Drawing.Point(603, 105);
            this.RadioCircle.Name = "RadioCircle";
            this.RadioCircle.Size = new System.Drawing.Size(82, 36);
            this.RadioCircle.TabIndex = 3;
            this.RadioCircle.TabStop = true;
            this.RadioCircle.Text = "Kruh";
            this.RadioCircle.UseVisualStyleBackColor = true;
            this.RadioCircle.CheckedChanged += new System.EventHandler(this.RadioCircle_CheckedChanged);
            // 
            // RadioEllipse
            // 
            this.RadioEllipse.AutoSize = true;
            this.RadioEllipse.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioEllipse.Location = new System.Drawing.Point(603, 147);
            this.RadioEllipse.Name = "RadioEllipse";
            this.RadioEllipse.Size = new System.Drawing.Size(92, 36);
            this.RadioEllipse.TabIndex = 4;
            this.RadioEllipse.TabStop = true;
            this.RadioEllipse.Text = "Elipsa";
            this.RadioEllipse.UseVisualStyleBackColor = true;
            // 
            // TrackHeight
            // 
            this.TrackHeight.Location = new System.Drawing.Point(580, 228);
            this.TrackHeight.Maximum = 100;
            this.TrackHeight.Minimum = 10;
            this.TrackHeight.Name = "TrackHeight";
            this.TrackHeight.Size = new System.Drawing.Size(216, 45);
            this.TrackHeight.TabIndex = 5;
            this.TrackHeight.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.TrackHeight.Value = 10;
            this.TrackHeight.Scroll += new System.EventHandler(this.TrackHeight_Scroll);
            // 
            // TrackWidth
            // 
            this.TrackWidth.Location = new System.Drawing.Point(580, 300);
            this.TrackWidth.Maximum = 100;
            this.TrackWidth.Minimum = 10;
            this.TrackWidth.Name = "TrackWidth";
            this.TrackWidth.Size = new System.Drawing.Size(216, 45);
            this.TrackWidth.TabIndex = 6;
            this.TrackWidth.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.TrackWidth.Value = 10;
            this.TrackWidth.Scroll += new System.EventHandler(this.TrackWidth_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(590, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Výška";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(590, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Šířka";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(616, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 51);
            this.button1.TabIndex = 9;
            this.button1.Text = "Smazat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrackWidth);
            this.Controls.Add(this.TrackHeight);
            this.Controls.Add(this.RadioEllipse);
            this.Controls.Add(this.RadioCircle);
            this.Controls.Add(this.RadioRectangle);
            this.Controls.Add(this.RadioSquare);
            this.Controls.Add(this.PanelDraw);
            this.Name = "Form1";
            this.Text = "Vkládání obrazců";
            ((System.ComponentModel.ISupportInitialize)(this.TrackHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel PanelDraw;
        private RadioButton RadioSquare;
        private RadioButton RadioRectangle;
        private RadioButton RadioCircle;
        private RadioButton RadioEllipse;
        private TrackBar TrackHeight;
        private TrackBar TrackWidth;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}