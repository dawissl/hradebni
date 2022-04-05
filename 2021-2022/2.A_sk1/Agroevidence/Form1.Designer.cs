
namespace Agroevidence
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
            this.BtnSaveAction = new System.Windows.Forms.Button();
            this.TxtParcel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtArea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnShowActions = new System.Windows.Forms.Button();
            this.LblOut = new System.Windows.Forms.Label();
            this.LblInfo = new System.Windows.Forms.Label();
            this.TxtChemistry = new System.Windows.Forms.TextBox();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.ComboUnits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboAction = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LblHa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSaveAction
            // 
            this.BtnSaveAction.Location = new System.Drawing.Point(37, 455);
            this.BtnSaveAction.Name = "BtnSaveAction";
            this.BtnSaveAction.Size = new System.Drawing.Size(103, 61);
            this.BtnSaveAction.TabIndex = 0;
            this.BtnSaveAction.Text = "Uložit činnost";
            this.BtnSaveAction.UseVisualStyleBackColor = true;
            this.BtnSaveAction.Click += new System.EventHandler(this.BtnSaveAction_Click);
            // 
            // TxtParcel
            // 
            this.TxtParcel.Location = new System.Drawing.Point(112, 36);
            this.TxtParcel.Name = "TxtParcel";
            this.TxtParcel.PlaceholderText = "Název parcely";
            this.TxtParcel.Size = new System.Drawing.Size(173, 23);
            this.TxtParcel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parcela";
            // 
            // TxtArea
            // 
            this.TxtArea.Location = new System.Drawing.Point(112, 90);
            this.TxtArea.Name = "TxtArea";
            this.TxtArea.PlaceholderText = "Výměra (ha)";
            this.TxtArea.Size = new System.Drawing.Size(173, 23);
            this.TxtArea.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Výměra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Činnost";
            // 
            // TxtNote
            // 
            this.TxtNote.Location = new System.Drawing.Point(112, 395);
            this.TxtNote.Name = "TxtNote";
            this.TxtNote.PlaceholderText = "Poznámka";
            this.TxtNote.Size = new System.Drawing.Size(173, 23);
            this.TxtNote.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Poznámka";
            // 
            // BtnShowActions
            // 
            this.BtnShowActions.Location = new System.Drawing.Point(179, 455);
            this.BtnShowActions.Name = "BtnShowActions";
            this.BtnShowActions.Size = new System.Drawing.Size(106, 61);
            this.BtnShowActions.TabIndex = 9;
            this.BtnShowActions.Text = "Zobrazit činnosti";
            this.BtnShowActions.UseVisualStyleBackColor = true;
            this.BtnShowActions.Click += new System.EventHandler(this.BtnShowActions_Click);
            // 
            // LblOut
            // 
            this.LblOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblOut.Location = new System.Drawing.Point(309, 34);
            this.LblOut.Name = "LblOut";
            this.LblOut.Size = new System.Drawing.Size(821, 482);
            this.LblOut.TabIndex = 10;
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.ForeColor = System.Drawing.Color.ForestGreen;
            this.LblInfo.Location = new System.Drawing.Point(37, 437);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(92, 15);
            this.LblInfo.TabIndex = 11;
            this.LblInfo.Text = "Činnost uložena";
            this.LblInfo.Visible = false;
            // 
            // TxtChemistry
            // 
            this.TxtChemistry.Location = new System.Drawing.Point(112, 195);
            this.TxtChemistry.Name = "TxtChemistry";
            this.TxtChemistry.PlaceholderText = "Přípravek";
            this.TxtChemistry.Size = new System.Drawing.Size(173, 23);
            this.TxtChemistry.TabIndex = 12;
            // 
            // TxtAmount
            // 
            this.TxtAmount.Location = new System.Drawing.Point(112, 244);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.PlaceholderText = "Množství";
            this.TxtAmount.Size = new System.Drawing.Size(173, 23);
            this.TxtAmount.TabIndex = 13;
            // 
            // ComboUnits
            // 
            this.ComboUnits.FormattingEnabled = true;
            this.ComboUnits.Items.AddRange(new object[] {
            "-",
            "l",
            "kg",
            "t",
            ""});
            this.ComboUnits.Location = new System.Drawing.Point(112, 345);
            this.ComboUnits.Name = "ComboUnits";
            this.ComboUnits.Size = new System.Drawing.Size(173, 23);
            this.ComboUnits.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Přípravek";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Množství";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Jednotky";
            // 
            // ComboAction
            // 
            this.ComboAction.FormattingEnabled = true;
            this.ComboAction.Items.AddRange(new object[] {
            "HNOJENÍ",
            "SETÍ",
            "KYPŘENÍ",
            "ORBA"});
            this.ComboAction.Location = new System.Drawing.Point(112, 145);
            this.ComboAction.Name = "ComboAction";
            this.ComboAction.Size = new System.Drawing.Size(173, 23);
            this.ComboAction.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Množství/ha";
            // 
            // LblHa
            // 
            this.LblHa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblHa.Location = new System.Drawing.Point(112, 298);
            this.LblHa.Name = "LblHa";
            this.LblHa.Size = new System.Drawing.Size(169, 31);
            this.LblHa.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 575);
            this.Controls.Add(this.LblHa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ComboAction);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboUnits);
            this.Controls.Add(this.TxtAmount);
            this.Controls.Add(this.TxtChemistry);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.LblOut);
            this.Controls.Add(this.BtnShowActions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtParcel);
            this.Controls.Add(this.BtnSaveAction);
            this.Name = "Form1";
            this.Text = "Agroevidence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSaveAction;
        private System.Windows.Forms.TextBox TxtParcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnShowActions;
        private System.Windows.Forms.Label LblOut;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.TextBox TxtChemistry;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.ComboBox ComboUnits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComboAction;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblHa;
    }
}

