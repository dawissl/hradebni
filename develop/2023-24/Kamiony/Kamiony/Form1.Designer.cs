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
            PanelRides = new Panel();
            BtnAddRide = new Button();
            TxtTruck = new TextBox();
            ListRides = new ListBox();
            BtnLoadRides = new Button();
            SuspendLayout();
            // 
            // PanelRides
            // 
            PanelRides.BackColor = Color.White;
            PanelRides.Location = new Point(24, 14);
            PanelRides.Name = "PanelRides";
            PanelRides.Size = new Size(448, 381);
            PanelRides.TabIndex = 0;
            PanelRides.Paint += PanelRides_Paint;
            PanelRides.MouseDown += PanelRides_MouseDown;
            // 
            // BtnAddRide
            // 
            BtnAddRide.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAddRide.Location = new Point(494, 55);
            BtnAddRide.Name = "BtnAddRide";
            BtnAddRide.Size = new Size(204, 50);
            BtnAddRide.TabIndex = 1;
            BtnAddRide.Text = "Přidat jízdu";
            BtnAddRide.UseVisualStyleBackColor = true;
            BtnAddRide.Click += BtnAddRide_Click;
            // 
            // TxtTruck
            // 
            TxtTruck.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTruck.Location = new Point(494, 14);
            TxtTruck.Name = "TxtTruck";
            TxtTruck.PlaceholderText = "Název kamionu";
            TxtTruck.Size = new Size(204, 35);
            TxtTruck.TabIndex = 2;
            // 
            // ListRides
            // 
            ListRides.FormattingEnabled = true;
            ListRides.ItemHeight = 15;
            ListRides.Location = new Point(495, 118);
            ListRides.Name = "ListRides";
            ListRides.Size = new Size(202, 274);
            ListRides.TabIndex = 3;
            ListRides.SelectedIndexChanged += ListRides_SelectedIndexChanged;
            // 
            // BtnLoadRides
            // 
            BtnLoadRides.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnLoadRides.Location = new Point(495, 398);
            BtnLoadRides.Name = "BtnLoadRides";
            BtnLoadRides.Size = new Size(204, 50);
            BtnLoadRides.TabIndex = 4;
            BtnLoadRides.Text = "Načíst jízdy";
            BtnLoadRides.UseVisualStyleBackColor = true;
            BtnLoadRides.Click += BtnLoadRides_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 465);
            Controls.Add(BtnLoadRides);
            Controls.Add(ListRides);
            Controls.Add(TxtTruck);
            Controls.Add(BtnAddRide);
            Controls.Add(PanelRides);
            Name = "Form1";
            Text = "Kamiony";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelRides;
        private Button BtnAddRide;
        private TextBox TxtTruck;
        private ListBox ListRides;
        private Button BtnLoadRides;
    }
}