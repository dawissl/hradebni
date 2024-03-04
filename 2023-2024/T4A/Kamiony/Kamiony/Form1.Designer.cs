namespace Kamiony
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
            PanelRide = new Panel();
            TxtTruck = new TextBox();
            BtnAdd = new Button();
            BtnLoadRide = new Button();
            SuspendLayout();
            // 
            // PanelRide
            // 
            PanelRide.BackColor = Color.White;
            PanelRide.Location = new Point(9, 12);
            PanelRide.Name = "PanelRide";
            PanelRide.Size = new Size(550, 400);
            PanelRide.TabIndex = 0;
            PanelRide.Paint += PanelRide_Paint;
            PanelRide.MouseClick += PanelRide_MouseClick;
            // 
            // TxtTruck
            // 
            TxtTruck.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTruck.Location = new Point(565, 12);
            TxtTruck.Name = "TxtTruck";
            TxtTruck.PlaceholderText = "Název kamionu";
            TxtTruck.Size = new Size(196, 33);
            TxtTruck.TabIndex = 1;
            // 
            // BtnAdd
            // 
            BtnAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAdd.Location = new Point(566, 56);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(187, 41);
            BtnAdd.TabIndex = 2;
            BtnAdd.Text = "Přidat jizdu";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnLoadRide
            // 
            BtnLoadRide.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnLoadRide.Location = new Point(566, 114);
            BtnLoadRide.Name = "BtnLoadRide";
            BtnLoadRide.Size = new Size(187, 41);
            BtnLoadRide.TabIndex = 3;
            BtnLoadRide.Text = "Načíst jízdu";
            BtnLoadRide.UseVisualStyleBackColor = true;
            BtnLoadRide.Click += BtnLoadRide_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 429);
            Controls.Add(BtnLoadRide);
            Controls.Add(BtnAdd);
            Controls.Add(TxtTruck);
            Controls.Add(PanelRide);
            Name = "Form1";
            Text = "Kamiony";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelRide;
        private TextBox TxtTruck;
        private Button BtnAdd;
        private Button BtnLoadRide;
    }
}