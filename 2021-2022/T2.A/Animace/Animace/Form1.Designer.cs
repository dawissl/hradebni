namespace Animace
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
            this.components = new System.ComponentModel.Container();
            this.MyPanel = new System.Windows.Forms.Panel();
            this.BtnRunX = new System.Windows.Forms.Button();
            this.BtnRunY = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.TimerXVpravo = new System.Windows.Forms.Timer(this.components);
            this.TimerYDolu = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TimerXVlevo = new System.Windows.Forms.Timer(this.components);
            this.TimerYNahoru = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MyPanel
            // 
            this.MyPanel.BackColor = System.Drawing.Color.White;
            this.MyPanel.Location = new System.Drawing.Point(22, 8);
            this.MyPanel.Name = "MyPanel";
            this.MyPanel.Size = new System.Drawing.Size(562, 421);
            this.MyPanel.TabIndex = 0;
            this.MyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MyPanel_Paint);
            // 
            // BtnRunX
            // 
            this.BtnRunX.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRunX.Location = new System.Drawing.Point(625, 31);
            this.BtnRunX.Name = "BtnRunX";
            this.BtnRunX.Size = new System.Drawing.Size(150, 60);
            this.BtnRunX.TabIndex = 1;
            this.BtnRunX.Text = "Vpravo";
            this.BtnRunX.UseVisualStyleBackColor = true;
            this.BtnRunX.Click += new System.EventHandler(this.BtnRunX_Click);
            // 
            // BtnRunY
            // 
            this.BtnRunY.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRunY.Location = new System.Drawing.Point(625, 112);
            this.BtnRunY.Name = "BtnRunY";
            this.BtnRunY.Size = new System.Drawing.Size(150, 60);
            this.BtnRunY.TabIndex = 2;
            this.BtnRunY.Text = "Dolů";
            this.BtnRunY.UseVisualStyleBackColor = true;
            this.BtnRunY.Click += new System.EventHandler(this.BtnRunY_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnReset.Location = new System.Drawing.Point(693, 195);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(150, 60);
            this.BtnReset.TabIndex = 3;
            this.BtnReset.Text = "Resetovat pozici";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // TimerXVpravo
            // 
            this.TimerXVpravo.Enabled = true;
            this.TimerXVpravo.Tick += new System.EventHandler(this.TimerX_Tick);
            // 
            // TimerYDolu
            // 
            this.TimerYDolu.Enabled = true;
            this.TimerYDolu.Tick += new System.EventHandler(this.TimerY_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(793, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "Nahoru";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(793, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 60);
            this.button2.TabIndex = 4;
            this.button2.Text = "Vlevo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TimerXVlevo
            // 
            this.TimerXVlevo.Tick += new System.EventHandler(this.TimerXVlevo_Tick);
            // 
            // TimerYNahoru
            // 
            this.TimerYNahoru.Tick += new System.EventHandler(this.TimerYNahoru_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnRunY);
            this.Controls.Add(this.BtnRunX);
            this.Controls.Add(this.MyPanel);
            this.Name = "Form1";
            this.Text = "Základy animace";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MyPanel;
        private Button BtnRunX;
        private Button BtnRunY;
        private Button BtnReset;
        private System.Windows.Forms.Timer TimerXVpravo;
        private System.Windows.Forms.Timer TimerYDolu;
        private Button button1;
        private Button button2;
        private System.Windows.Forms.Timer TimerXVlevo;
        private System.Windows.Forms.Timer TimerYNahoru;
    }
}