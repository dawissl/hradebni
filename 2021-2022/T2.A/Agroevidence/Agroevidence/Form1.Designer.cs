
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
            this.CmbAction = new System.Windows.Forms.ComboBox();
            this.CmbUnit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtProduct = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSaveAction
            // 
            this.BtnSaveAction.Location = new System.Drawing.Point(49, 382);
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
            this.TxtNote.Location = new System.Drawing.Point(112, 196);
            this.TxtNote.Name = "TxtNote";
            this.TxtNote.PlaceholderText = "Poznámka";
            this.TxtNote.Size = new System.Drawing.Size(173, 23);
            this.TxtNote.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Poznámka";
            // 
            // BtnShowActions
            // 
            this.BtnShowActions.Location = new System.Drawing.Point(177, 382);
            this.BtnShowActions.Name = "BtnShowActions";
            this.BtnShowActions.Size = new System.Drawing.Size(103, 61);
            this.BtnShowActions.TabIndex = 12;
            this.BtnShowActions.Text = "Zobrazit činnosti";
            this.BtnShowActions.UseVisualStyleBackColor = true;
            this.BtnShowActions.Click += new System.EventHandler(this.BtnShowActions_Click);
            // 
            // LblOut
            // 
            this.LblOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblOut.Location = new System.Drawing.Point(309, 37);
            this.LblOut.Name = "LblOut";
            this.LblOut.Size = new System.Drawing.Size(590, 406);
            this.LblOut.TabIndex = 13;
            // 
            // CmbAction
            // 
            this.CmbAction.FormattingEnabled = true;
            this.CmbAction.Items.AddRange(new object[] {
            "HNOJENÍ",
            "SETÍ",
            "KYPŘENÍ",
            "ORBA"});
            this.CmbAction.Location = new System.Drawing.Point(115, 145);
            this.CmbAction.Name = "CmbAction";
            this.CmbAction.Size = new System.Drawing.Size(169, 23);
            this.CmbAction.TabIndex = 14;
            // 
            // CmbUnit
            // 
            this.CmbUnit.FormattingEnabled = true;
            this.CmbUnit.Items.AddRange(new object[] {
            "kg",
            "l",
            "t",
            "-"});
            this.CmbUnit.Location = new System.Drawing.Point(116, 332);
            this.CmbUnit.Name = "CmbUnit";
            this.CmbUnit.Size = new System.Drawing.Size(169, 23);
            this.CmbUnit.TabIndex = 15;
            this.CmbUnit.SelectedIndexChanged += new System.EventHandler(this.CmbUnit_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Jednotky";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Přípravek";
            // 
            // TxtProduct
            // 
            this.TxtProduct.Location = new System.Drawing.Point(112, 248);
            this.TxtProduct.Name = "TxtProduct";
            this.TxtProduct.PlaceholderText = "Přípravek";
            this.TxtProduct.Size = new System.Drawing.Size(173, 23);
            this.TxtProduct.TabIndex = 17;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(37, 294);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(55, 15);
            this.lab.TabIndex = 20;
            this.lab.Text = "Množství";
            // 
            // TxtAmount
            // 
            this.TxtAmount.Location = new System.Drawing.Point(112, 291);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.PlaceholderText = "Množství";
            this.TxtAmount.Size = new System.Drawing.Size(173, 23);
            this.TxtAmount.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 463);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.TxtAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbUnit);
            this.Controls.Add(this.CmbAction);
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
        private System.Windows.Forms.ComboBox CmbAction;
        private System.Windows.Forms.ComboBox CmbUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtProduct;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox TxtAmount;
    }
}

