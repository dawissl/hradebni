
namespace AgroEvidence
{
    partial class AgroForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtArea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNote = new System.Windows.Forms.TextBox();
            this.TxtShow = new System.Windows.Forms.Button();
            this.TxtAction = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtMaterial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.TxtUnits = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblHa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSaveAction
            // 
            this.BtnSaveAction.Location = new System.Drawing.Point(27, 353);
            this.BtnSaveAction.Name = "BtnSaveAction";
            this.BtnSaveAction.Size = new System.Drawing.Size(93, 48);
            this.BtnSaveAction.TabIndex = 0;
            this.BtnSaveAction.Text = "Uložit činnost";
            this.BtnSaveAction.UseVisualStyleBackColor = true;
            this.BtnSaveAction.Click += new System.EventHandler(this.BtnSaveAction_Click);
            // 
            // TxtParcel
            // 
            this.TxtParcel.Location = new System.Drawing.Point(104, 34);
            this.TxtParcel.Name = "TxtParcel";
            this.TxtParcel.PlaceholderText = "Parcela";
            this.TxtParcel.Size = new System.Drawing.Size(175, 23);
            this.TxtParcel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parcela";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Výměra";
            // 
            // TxtArea
            // 
            this.TxtArea.Location = new System.Drawing.Point(104, 74);
            this.TxtArea.Name = "TxtArea";
            this.TxtArea.PlaceholderText = "Výměra (ha)";
            this.TxtArea.Size = new System.Drawing.Size(175, 23);
            this.TxtArea.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Činnost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Poznámka";
            // 
            // TxtNote
            // 
            this.TxtNote.Location = new System.Drawing.Point(104, 154);
            this.TxtNote.Name = "TxtNote";
            this.TxtNote.PlaceholderText = "Poznámka";
            this.TxtNote.Size = new System.Drawing.Size(175, 23);
            this.TxtNote.TabIndex = 7;
            // 
            // TxtShow
            // 
            this.TxtShow.Location = new System.Drawing.Point(140, 353);
            this.TxtShow.Name = "TxtShow";
            this.TxtShow.Size = new System.Drawing.Size(106, 48);
            this.TxtShow.TabIndex = 9;
            this.TxtShow.Text = "Zobrazit činnosti";
            this.TxtShow.UseVisualStyleBackColor = true;
            this.TxtShow.Click += new System.EventHandler(this.TxtShow_Click);
            // 
            // TxtAction
            // 
            this.TxtAction.FormattingEnabled = true;
            this.TxtAction.Items.AddRange(new object[] {
            "HNOJENÍ",
            "SETÍ",
            "KYPŘENÍ",
            "ORBA"});
            this.TxtAction.Location = new System.Drawing.Point(104, 116);
            this.TxtAction.Name = "TxtAction";
            this.TxtAction.Size = new System.Drawing.Size(175, 23);
            this.TxtAction.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Přípravek";
            // 
            // TxtMaterial
            // 
            this.TxtMaterial.Location = new System.Drawing.Point(104, 198);
            this.TxtMaterial.Name = "TxtMaterial";
            this.TxtMaterial.PlaceholderText = "Přípravek";
            this.TxtMaterial.Size = new System.Drawing.Size(175, 23);
            this.TxtMaterial.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Množství";
            // 
            // TxtAmount
            // 
            this.TxtAmount.Location = new System.Drawing.Point(104, 237);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.PlaceholderText = "Poznámka";
            this.TxtAmount.Size = new System.Drawing.Size(175, 23);
            this.TxtAmount.TabIndex = 13;
            // 
            // TxtUnits
            // 
            this.TxtUnits.FormattingEnabled = true;
            this.TxtUnits.Items.AddRange(new object[] {
            "-",
            "kg",
            "l",
            "t"});
            this.TxtUnits.Location = new System.Drawing.Point(104, 310);
            this.TxtUnits.Name = "TxtUnits";
            this.TxtUnits.Size = new System.Drawing.Size(175, 23);
            this.TxtUnits.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Jednotky";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Množství/ha";
            // 
            // LblHa
            // 
            this.LblHa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LblHa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblHa.Location = new System.Drawing.Point(104, 277);
            this.LblHa.Name = "LblHa";
            this.LblHa.Size = new System.Drawing.Size(175, 24);
            this.LblHa.TabIndex = 18;
            // 
            // AgroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 450);
            this.Controls.Add(this.LblHa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtUnits);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtMaterial);
            this.Controls.Add(this.TxtAction);
            this.Controls.Add(this.TxtShow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtParcel);
            this.Controls.Add(this.BtnSaveAction);
            this.Name = "AgroForm";
            this.Text = "Agroevidence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSaveAction;
        private System.Windows.Forms.TextBox TxtParcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNote;
        private System.Windows.Forms.Button TxtShow;
        private System.Windows.Forms.ComboBox TxtAction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtMaterial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.ComboBox TxtUnits;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblHa;
    }
}

