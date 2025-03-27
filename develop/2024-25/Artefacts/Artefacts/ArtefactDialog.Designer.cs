namespace Artefacts
{
    partial class ArtefactDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TxtValue = new TextBox();
            label3 = new Label();
            TxtAge = new TextBox();
            BtnCancel = new Button();
            BtnSave = new Button();
            SuspendLayout();
            // 
            // TxtName
            // 
            TxtName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TxtName.Location = new Point(102, 25);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(156, 39);
            TxtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 1;
            label1.Text = "Název";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 3;
            label2.Text = "Hodnota";
            // 
            // TxtValue
            // 
            TxtValue.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TxtValue.Location = new Point(102, 82);
            TxtValue.Name = "TxtValue";
            TxtValue.Size = new Size(156, 39);
            TxtValue.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(12, 149);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 5;
            label3.Text = "Stáří";
            // 
            // TxtAge
            // 
            TxtAge.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TxtAge.Location = new Point(102, 140);
            TxtAge.Name = "TxtAge";
            TxtAge.Size = new Size(156, 39);
            TxtAge.TabIndex = 4;
            // 
            // BtnCancel
            // 
            BtnCancel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BtnCancel.Location = new Point(12, 212);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(124, 49);
            BtnCancel.TabIndex = 6;
            BtnCancel.Text = "Zrušit";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnSave
            // 
            BtnSave.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BtnSave.Location = new Point(164, 212);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(124, 49);
            BtnSave.TabIndex = 7;
            BtnSave.Text = "Uložit";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // ArtefactDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 294);
            Controls.Add(BtnSave);
            Controls.Add(BtnCancel);
            Controls.Add(label3);
            Controls.Add(TxtAge);
            Controls.Add(label2);
            Controls.Add(TxtValue);
            Controls.Add(label1);
            Controls.Add(TxtName);
            Name = "ArtefactDialog";
            Text = "ArtefactDialog";
            Load += ArtefactDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtName;
        private Label label1;
        private Label label2;
        private TextBox TxtValue;
        private Label label3;
        private TextBox TxtAge;
        private Button BtnCancel;
        private Button BtnSave;
    }
}