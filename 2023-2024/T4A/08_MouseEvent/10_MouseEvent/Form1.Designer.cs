namespace _08_MouseEvent
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
            PanelDraw = new Panel();
            RadioSquare = new RadioButton();
            RadioRectangle = new RadioButton();
            RadioCircle = new RadioButton();
            RadioEllipse = new RadioButton();
            TrackHeight = new TrackBar();
            TrackWidth = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            MenuApp = new MenuStrip();
            MenuPickColour = new ToolStripMenuItem();
            MenuDelete = new ToolStripMenuItem();
            ClrDialog = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)TrackHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrackWidth).BeginInit();
            MenuApp.SuspendLayout();
            SuspendLayout();
            // 
            // PanelDraw
            // 
            PanelDraw.BackColor = Color.White;
            PanelDraw.Location = new Point(0, 52);
            PanelDraw.Name = "PanelDraw";
            PanelDraw.Size = new Size(574, 429);
            PanelDraw.TabIndex = 0;
            PanelDraw.Paint += PanelDraw_Paint;
            PanelDraw.MouseDown += PanelDraw_MouseDown;
            // 
            // RadioSquare
            // 
            RadioSquare.AutoSize = true;
            RadioSquare.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            RadioSquare.Location = new Point(603, 61);
            RadioSquare.Name = "RadioSquare";
            RadioSquare.Size = new Size(112, 36);
            RadioSquare.TabIndex = 1;
            RadioSquare.TabStop = true;
            RadioSquare.Text = "Čtverec";
            RadioSquare.UseVisualStyleBackColor = true;
            RadioSquare.CheckedChanged += RadioSquare_CheckedChanged;
            // 
            // RadioRectangle
            // 
            RadioRectangle.AutoSize = true;
            RadioRectangle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            RadioRectangle.Location = new Point(603, 103);
            RadioRectangle.Name = "RadioRectangle";
            RadioRectangle.Size = new Size(129, 36);
            RadioRectangle.TabIndex = 2;
            RadioRectangle.TabStop = true;
            RadioRectangle.Text = "Obdelnik";
            RadioRectangle.UseVisualStyleBackColor = true;
            // 
            // RadioCircle
            // 
            RadioCircle.AutoSize = true;
            RadioCircle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            RadioCircle.Location = new Point(603, 145);
            RadioCircle.Name = "RadioCircle";
            RadioCircle.Size = new Size(82, 36);
            RadioCircle.TabIndex = 3;
            RadioCircle.TabStop = true;
            RadioCircle.Text = "Kruh";
            RadioCircle.UseVisualStyleBackColor = true;
            RadioCircle.CheckedChanged += RadioCircle_CheckedChanged;
            // 
            // RadioEllipse
            // 
            RadioEllipse.AutoSize = true;
            RadioEllipse.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            RadioEllipse.Location = new Point(603, 187);
            RadioEllipse.Name = "RadioEllipse";
            RadioEllipse.Size = new Size(92, 36);
            RadioEllipse.TabIndex = 4;
            RadioEllipse.TabStop = true;
            RadioEllipse.Text = "Elipsa";
            RadioEllipse.UseVisualStyleBackColor = true;
            // 
            // TrackHeight
            // 
            TrackHeight.Location = new Point(580, 268);
            TrackHeight.Maximum = 100;
            TrackHeight.Minimum = 10;
            TrackHeight.Name = "TrackHeight";
            TrackHeight.Size = new Size(216, 45);
            TrackHeight.TabIndex = 5;
            TrackHeight.TickStyle = TickStyle.TopLeft;
            TrackHeight.Value = 10;
            TrackHeight.Scroll += TrackHeight_Scroll;
            // 
            // TrackWidth
            // 
            TrackWidth.Location = new Point(580, 340);
            TrackWidth.Maximum = 100;
            TrackWidth.Minimum = 10;
            TrackWidth.Name = "TrackWidth";
            TrackWidth.Size = new Size(216, 45);
            TrackWidth.TabIndex = 6;
            TrackWidth.TickStyle = TickStyle.TopLeft;
            TrackWidth.Value = 10;
            TrackWidth.Scroll += TrackWidth_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(590, 237);
            label1.Name = "label1";
            label1.Size = new Size(75, 32);
            label1.TabIndex = 7;
            label1.Text = "Výška";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(590, 305);
            label2.Name = "label2";
            label2.Size = new Size(65, 32);
            label2.TabIndex = 8;
            label2.Text = "Šířka";
            // 
            // MenuApp
            // 
            MenuApp.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            MenuApp.Items.AddRange(new ToolStripItem[] { MenuPickColour, MenuDelete });
            MenuApp.Location = new Point(0, 0);
            MenuApp.Name = "MenuApp";
            MenuApp.Size = new Size(800, 40);
            MenuApp.TabIndex = 9;
            MenuApp.Text = "menuStrip1";
            // 
            // MenuPickColour
            // 
            MenuPickColour.BackColor = Color.Red;
            MenuPickColour.Name = "MenuPickColour";
            MenuPickColour.Size = new Size(162, 36);
            MenuPickColour.Text = "Vybrat barvu";
            MenuPickColour.Click += MenuPickColour_Click;
            // 
            // MenuDelete
            // 
            MenuDelete.Name = "MenuDelete";
            MenuDelete.Size = new Size(103, 36);
            MenuDelete.Text = "Smazat";
            MenuDelete.Click += MenuDelete_Click;
            // 
            // ClrDialog
            // 
            ClrDialog.Color = Color.Red;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 497);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TrackWidth);
            Controls.Add(TrackHeight);
            Controls.Add(RadioEllipse);
            Controls.Add(RadioCircle);
            Controls.Add(RadioRectangle);
            Controls.Add(RadioSquare);
            Controls.Add(PanelDraw);
            Controls.Add(MenuApp);
            MainMenuStrip = MenuApp;
            Name = "Form1";
            Text = "Vkládání obrazců";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)TrackHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrackWidth).EndInit();
            MenuApp.ResumeLayout(false);
            MenuApp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private MenuStrip MenuApp;
        private ToolStripMenuItem MenuPickColour;
        private ToolStripMenuItem MenuDelete;
        private ColorDialog ClrDialog;
    }
}