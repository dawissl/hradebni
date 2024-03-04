namespace Parkoviste
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
            PanelParkingLot = new Panel();
            NumPatra = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            NumMista = new NumericUpDown();
            BtnGenerateParkingLot = new Button();
            TxtPatro = new TextBox();
            TxtMisto = new TextBox();
            BtnPlace = new Button();
            BtnRemove = new Button();
            LblIncome = new Label();
            ((System.ComponentModel.ISupportInitialize)NumPatra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumMista).BeginInit();
            SuspendLayout();
            // 
            // PanelParkingLot
            // 
            PanelParkingLot.Location = new Point(9, 11);
            PanelParkingLot.Name = "PanelParkingLot";
            PanelParkingLot.Size = new Size(466, 423);
            PanelParkingLot.TabIndex = 0;
            PanelParkingLot.Paint += PanelParkingLot_Paint;
            // 
            // NumPatra
            // 
            NumPatra.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            NumPatra.Location = new Point(631, 25);
            NumPatra.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            NumPatra.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumPatra.Name = "NumPatra";
            NumPatra.Size = new Size(120, 35);
            NumPatra.TabIndex = 1;
            NumPatra.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(518, 31);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 2;
            label1.Text = "Počet pater";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(518, 72);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 4;
            label2.Text = "Počet míst";
            // 
            // NumMista
            // 
            NumMista.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            NumMista.Location = new Point(631, 66);
            NumMista.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            NumMista.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumMista.Name = "NumMista";
            NumMista.Size = new Size(120, 35);
            NumMista.TabIndex = 3;
            NumMista.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // BtnGenerateParkingLot
            // 
            BtnGenerateParkingLot.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnGenerateParkingLot.Location = new Point(518, 107);
            BtnGenerateParkingLot.Name = "BtnGenerateParkingLot";
            BtnGenerateParkingLot.Size = new Size(233, 53);
            BtnGenerateParkingLot.TabIndex = 5;
            BtnGenerateParkingLot.Text = "Vykresli parkoviště";
            BtnGenerateParkingLot.UseVisualStyleBackColor = true;
            BtnGenerateParkingLot.Click += BtnGenerateParkingLot_Click;
            // 
            // TxtPatro
            // 
            TxtPatro.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPatro.Location = new Point(518, 188);
            TxtPatro.Name = "TxtPatro";
            TxtPatro.PlaceholderText = "Patro";
            TxtPatro.Size = new Size(233, 35);
            TxtPatro.TabIndex = 6;
            // 
            // TxtMisto
            // 
            TxtMisto.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TxtMisto.Location = new Point(518, 229);
            TxtMisto.Name = "TxtMisto";
            TxtMisto.PlaceholderText = "Misto";
            TxtMisto.Size = new Size(233, 35);
            TxtMisto.TabIndex = 7;
            // 
            // BtnPlace
            // 
            BtnPlace.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPlace.Location = new Point(518, 270);
            BtnPlace.Name = "BtnPlace";
            BtnPlace.Size = new Size(233, 53);
            BtnPlace.TabIndex = 8;
            BtnPlace.Text = "Zaparkuj";
            BtnPlace.UseVisualStyleBackColor = true;
            BtnPlace.Click += BtnPlace_Click;
            // 
            // BtnRemove
            // 
            BtnRemove.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnRemove.Location = new Point(518, 329);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new Size(233, 53);
            BtnRemove.TabIndex = 9;
            BtnRemove.Text = "Vyparkuj";
            BtnRemove.UseVisualStyleBackColor = true;
            BtnRemove.Click += BtnRemove_Click;
            // 
            // LblIncome
            // 
            LblIncome.BorderStyle = BorderStyle.Fixed3D;
            LblIncome.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblIncome.Location = new Point(518, 399);
            LblIncome.Name = "LblIncome";
            LblIncome.Size = new Size(230, 39);
            LblIncome.TabIndex = 10;
            LblIncome.Text = "Příjem: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblIncome);
            Controls.Add(BtnRemove);
            Controls.Add(BtnPlace);
            Controls.Add(TxtMisto);
            Controls.Add(TxtPatro);
            Controls.Add(BtnGenerateParkingLot);
            Controls.Add(label2);
            Controls.Add(NumMista);
            Controls.Add(label1);
            Controls.Add(NumPatra);
            Controls.Add(PanelParkingLot);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumPatra).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumMista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelParkingLot;
        private NumericUpDown NumPatra;
        private Label label1;
        private Label label2;
        private NumericUpDown NumMista;
        private Button BtnGenerateParkingLot;
        private TextBox TxtPatro;
        private TextBox TxtMisto;
        private Button BtnPlace;
        private Button BtnRemove;
        private Label LblIncome;
    }
}