namespace Sklenik
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
            ComboPlant = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            ComboOre = new ComboBox();
            LblStatus = new Label();
            TrackTemperature = new TrackBar();
            label3 = new Label();
            label4 = new Label();
            TrackLight = new TrackBar();
            Čas = new Label();
            TrackTime = new TrackBar();
            BtnAddMoist = new Button();
            LblTemp = new Label();
            LblLight = new Label();
            LblTime = new Label();
            LblMoisture = new Label();
            BtnRemoveMoist = new Button();
            label5 = new Label();
            label8 = new Label();
            LblLeafWettness = new Label();
            BtnRecountLeafWettness = new Button();
            BtnRollet = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)TrackTemperature).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrackLight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrackTime).BeginInit();
            SuspendLayout();
            // 
            // ComboPlant
            // 
            ComboPlant.AutoCompleteCustomSource.AddRange(new string[] { "ORCHIDEJ", "KAKTUS", "FIALKA", "ŠALVĚJ" });
            ComboPlant.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ComboPlant.FormattingEnabled = true;
            ComboPlant.Items.AddRange(new object[] { "ORCHIDEJ", "KAKTUS", "FIALKA", "ŠALVĚJ" });
            ComboPlant.Location = new Point(23, 52);
            ComboPlant.Name = "ComboPlant";
            ComboPlant.Size = new Size(212, 38);
            ComboPlant.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 19);
            label1.Name = "label1";
            label1.Size = new Size(86, 30);
            label1.TabIndex = 1;
            label1.Text = "Rostlina";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 97);
            label2.Name = "label2";
            label2.Size = new Size(82, 30);
            label2.TabIndex = 3;
            label2.Text = "Zemina";
            // 
            // ComboOre
            // 
            ComboOre.AutoCompleteCustomSource.AddRange(new string[] { "RAŠELINA", "RAŠELINNÍ SMĚS", "UNVERZÁLNÍ", "JÍLOVITÁ", "PÍSČITÁ" });
            ComboOre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ComboOre.FormattingEnabled = true;
            ComboOre.Items.AddRange(new object[] { "RAŠELINA", "RAŠELINNÍ SMĚS", "UNVERZÁLNÍ", "JÍLOVITÁ", "PÍSČITÁ" });
            ComboOre.Location = new Point(23, 130);
            ComboOre.Name = "ComboOre";
            ComboOre.Size = new Size(212, 38);
            ComboOre.TabIndex = 2;
            // 
            // LblStatus
            // 
            LblStatus.BorderStyle = BorderStyle.Fixed3D;
            LblStatus.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LblStatus.Location = new Point(23, 192);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(212, 234);
            LblStatus.TabIndex = 4;
            // 
            // TrackTemperature
            // 
            TrackTemperature.Location = new Point(359, 19);
            TrackTemperature.Maximum = 40;
            TrackTemperature.Minimum = 10;
            TrackTemperature.Name = "TrackTemperature";
            TrackTemperature.Size = new Size(408, 45);
            TrackTemperature.TabIndex = 5;
            TrackTemperature.Value = 10;
            TrackTemperature.Scroll += TrackTemperature_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(275, 19);
            label3.Name = "label3";
            label3.Size = new Size(80, 30);
            label3.TabIndex = 6;
            label3.Text = "Teplota";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(275, 70);
            label4.Name = "label4";
            label4.Size = new Size(68, 30);
            label4.TabIndex = 8;
            label4.Text = "Světlo";
            // 
            // TrackLight
            // 
            TrackLight.Location = new Point(359, 70);
            TrackLight.Maximum = 16000;
            TrackLight.Name = "TrackLight";
            TrackLight.Size = new Size(408, 45);
            TrackLight.TabIndex = 7;
            TrackLight.Scroll += TrackLight_Scroll;
            // 
            // Čas
            // 
            Čas.AutoSize = true;
            Čas.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Čas.Location = new Point(275, 121);
            Čas.Name = "Čas";
            Čas.Size = new Size(80, 30);
            Čas.TabIndex = 10;
            Čas.Text = "Hodina";
            // 
            // TrackTime
            // 
            TrackTime.Location = new Point(359, 121);
            TrackTime.Maximum = 20;
            TrackTime.Minimum = 6;
            TrackTime.Name = "TrackTime";
            TrackTime.Size = new Size(408, 45);
            TrackTime.TabIndex = 9;
            TrackTime.Value = 6;
            TrackTime.Scroll += TrackTime_Scroll;
            // 
            // BtnAddMoist
            // 
            BtnAddMoist.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAddMoist.Location = new Point(395, 168);
            BtnAddMoist.Name = "BtnAddMoist";
            BtnAddMoist.Size = new Size(160, 44);
            BtnAddMoist.TabIndex = 11;
            BtnAddMoist.Text = "Zavlažovat";
            BtnAddMoist.UseVisualStyleBackColor = true;
            BtnAddMoist.Click += BtnAddMoist_Click;
            // 
            // LblTemp
            // 
            LblTemp.AutoSize = true;
            LblTemp.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LblTemp.Location = new Point(823, 19);
            LblTemp.Name = "LblTemp";
            LblTemp.Size = new Size(54, 30);
            LblTemp.TabIndex = 12;
            LblTemp.Text = "10 C";
            // 
            // LblLight
            // 
            LblLight.AutoSize = true;
            LblLight.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LblLight.Location = new Point(823, 70);
            LblLight.Name = "LblLight";
            LblLight.Size = new Size(63, 30);
            LblLight.TabIndex = 13;
            LblLight.Text = " 0 lux";
            // 
            // LblTime
            // 
            LblTime.AutoSize = true;
            LblTime.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LblTime.Location = new Point(823, 121);
            LblTime.Name = "LblTime";
            LblTime.Size = new Size(80, 30);
            LblTime.TabIndex = 14;
            LblTime.Text = "06:00 h";
            // 
            // LblMoisture
            // 
            LblMoisture.AutoSize = true;
            LblMoisture.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LblMoisture.Location = new Point(823, 175);
            LblMoisture.Name = "LblMoisture";
            LblMoisture.Size = new Size(47, 30);
            LblMoisture.TabIndex = 15;
            LblMoisture.Text = "0 %";
            // 
            // BtnRemoveMoist
            // 
            BtnRemoveMoist.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnRemoveMoist.Location = new Point(592, 168);
            BtnRemoveMoist.Name = "BtnRemoveMoist";
            BtnRemoveMoist.Size = new Size(160, 44);
            BtnRemoveMoist.TabIndex = 16;
            BtnRemoveMoist.Text = "Vysušovat";
            BtnRemoveMoist.UseVisualStyleBackColor = true;
            BtnRemoveMoist.Click += BtnRemoveMoist_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(275, 175);
            label5.Name = "label5";
            label5.Size = new Size(81, 30);
            label5.TabIndex = 17;
            label5.Text = "Vlhkost";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(277, 226);
            label8.Name = "label8";
            label8.Size = new Size(138, 30);
            label8.TabIndex = 20;
            label8.Text = "Ovlhčení listů";
            // 
            // LblLeafWettness
            // 
            LblLeafWettness.AutoSize = true;
            LblLeafWettness.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LblLeafWettness.Location = new Point(823, 225);
            LblLeafWettness.Name = "LblLeafWettness";
            LblLeafWettness.Size = new Size(47, 30);
            LblLeafWettness.TabIndex = 19;
            LblLeafWettness.Text = "0 %";
            // 
            // BtnRecountLeafWettness
            // 
            BtnRecountLeafWettness.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnRecountLeafWettness.Location = new Point(448, 218);
            BtnRecountLeafWettness.Name = "BtnRecountLeafWettness";
            BtnRecountLeafWettness.Size = new Size(241, 44);
            BtnRecountLeafWettness.TabIndex = 18;
            BtnRecountLeafWettness.Text = "Přepočítat ovlhčení";
            BtnRecountLeafWettness.UseVisualStyleBackColor = true;
            BtnRecountLeafWettness.Click += BtnRecountLeafWettness_Click;
            // 
            // BtnRollet
            // 
            BtnRollet.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnRollet.Location = new Point(448, 278);
            BtnRollet.Name = "BtnRollet";
            BtnRollet.Size = new Size(241, 44);
            BtnRollet.TabIndex = 21;
            BtnRollet.Text = "Zavřít rolety";
            BtnRollet.UseVisualStyleBackColor = true;
            BtnRollet.Click += BtnRollet_Click;
            // 
            // button1
            // 
            button1.Location = new Point(470, 361);
            button1.Name = "button1";
            button1.Size = new Size(117, 39);
            button1.TabIndex = 22;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 450);
            Controls.Add(button1);
            Controls.Add(BtnRollet);
            Controls.Add(label8);
            Controls.Add(LblLeafWettness);
            Controls.Add(BtnRecountLeafWettness);
            Controls.Add(label5);
            Controls.Add(BtnRemoveMoist);
            Controls.Add(LblMoisture);
            Controls.Add(LblTime);
            Controls.Add(LblLight);
            Controls.Add(LblTemp);
            Controls.Add(BtnAddMoist);
            Controls.Add(Čas);
            Controls.Add(TrackTime);
            Controls.Add(label4);
            Controls.Add(TrackLight);
            Controls.Add(label3);
            Controls.Add(TrackTemperature);
            Controls.Add(LblStatus);
            Controls.Add(label2);
            Controls.Add(ComboOre);
            Controls.Add(label1);
            Controls.Add(ComboPlant);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)TrackTemperature).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrackLight).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrackTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboPlant;
        private Label label1;
        private Label label2;
        private ComboBox ComboOre;
        private Label LblStatus;
        private TrackBar TrackTemperature;
        private Label label3;
        private Label label4;
        private TrackBar TrackLight;
        private Label Čas;
        private TrackBar TrackTime;
        private Button BtnAddMoist;
        private Label LblTemp;
        private Label LblLight;
        private Label LblTime;
        private Label LblMoisture;
        private Button BtnRemoveMoist;
        private Label label5;
        private Label label8;
        private Label LblLeafWettness;
        private Button BtnRecountLeafWettness;
        private Button BtnRollet;
        private Button button1;
    }
}