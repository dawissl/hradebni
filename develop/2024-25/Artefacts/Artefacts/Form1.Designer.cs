namespace Artefacts
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
            BtnAdd = new Button();
            BtnEdit = new Button();
            BtnSortName = new Button();
            BtnSortAge = new Button();
            LblOut = new Label();
            ListArtefacts = new ListBox();
            SuspendLayout();
            // 
            // BtnAdd
            // 
            BtnAdd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BtnAdd.Location = new Point(292, 27);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(128, 59);
            BtnAdd.TabIndex = 1;
            BtnAdd.Text = "Přidat";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BtnEdit.Location = new Point(292, 92);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(128, 59);
            BtnEdit.TabIndex = 2;
            BtnEdit.Text = "Editovat";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnSortName
            // 
            BtnSortName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BtnSortName.Location = new Point(426, 27);
            BtnSortName.Name = "BtnSortName";
            BtnSortName.Size = new Size(248, 59);
            BtnSortName.TabIndex = 3;
            BtnSortName.Text = "Seřadit podle jména";
            BtnSortName.UseVisualStyleBackColor = true;
            BtnSortName.Click += BtnSortName_Click;
            // 
            // BtnSortAge
            // 
            BtnSortAge.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BtnSortAge.Location = new Point(426, 92);
            BtnSortAge.Name = "BtnSortAge";
            BtnSortAge.Size = new Size(248, 59);
            BtnSortAge.TabIndex = 4;
            BtnSortAge.Text = "Seřadit podle stáří";
            BtnSortAge.UseVisualStyleBackColor = true;
            BtnSortAge.Click += BtnSortAge_Click;
            // 
            // LblOut
            // 
            LblOut.BorderStyle = BorderStyle.FixedSingle;
            LblOut.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            LblOut.Location = new Point(302, 165);
            LblOut.Name = "LblOut";
            LblOut.Size = new Size(372, 237);
            LblOut.TabIndex = 5;
            // 
            // ListArtefacts
            // 
            ListArtefacts.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ListArtefacts.FormattingEnabled = true;
            ListArtefacts.ItemHeight = 25;
            ListArtefacts.Location = new Point(12, 27);
            ListArtefacts.Name = "ListArtefacts";
            ListArtefacts.Size = new Size(274, 379);
            ListArtefacts.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 422);
            Controls.Add(ListArtefacts);
            Controls.Add(LblOut);
            Controls.Add(BtnSortAge);
            Controls.Add(BtnSortName);
            Controls.Add(BtnEdit);
            Controls.Add(BtnAdd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button BtnAdd;
        private Button BtnEdit;
        private Button BtnSortName;
        private Button BtnSortAge;
        private Label LblOut;
        private ListBox ListArtefacts;
    }
}
