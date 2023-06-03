namespace _20_Poznamky
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.listTasks = new System.Windows.Forms.ListBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.BtnArchive = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtText = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CheckBoxDate = new System.Windows.Forms.CheckBox();
            this.TxtLabel = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAdd.Location = new System.Drawing.Point(42, 355);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(113, 62);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Přidat";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // listTasks
            // 
            this.listTasks.FormattingEnabled = true;
            this.listTasks.ItemHeight = 15;
            this.listTasks.Location = new System.Drawing.Point(359, 23);
            this.listTasks.Name = "listTasks";
            this.listTasks.Size = new System.Drawing.Size(676, 394);
            this.listTasks.TabIndex = 1;
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnReset.Location = new System.Drawing.Point(161, 355);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(113, 62);
            this.BtnReset.TabIndex = 2;
            this.BtnReset.Text = "Resetovat";
            this.BtnReset.UseVisualStyleBackColor = true;
            // 
            // BtnCheck
            // 
            this.BtnCheck.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCheck.Location = new System.Drawing.Point(359, 428);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(113, 62);
            this.BtnCheck.TabIndex = 3;
            this.BtnCheck.Text = "Splněno";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // BtnArchive
            // 
            this.BtnArchive.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnArchive.Location = new System.Drawing.Point(478, 428);
            this.BtnArchive.Name = "BtnArchive";
            this.BtnArchive.Size = new System.Drawing.Size(163, 62);
            this.BtnArchive.TabIndex = 4;
            this.BtnArchive.Text = "Archivovat";
            this.BtnArchive.UseVisualStyleBackColor = true;
            this.BtnArchive.Click += new System.EventHandler(this.BtnArchive_Click);
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtName.Location = new System.Drawing.Point(42, 23);
            this.TxtName.Name = "TxtName";
            this.TxtName.PlaceholderText = "Nadpis";
            this.TxtName.Size = new System.Drawing.Size(258, 35);
            this.TxtName.TabIndex = 5;
            // 
            // TxtText
            // 
            this.TxtText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtText.Location = new System.Drawing.Point(42, 74);
            this.TxtText.Multiline = true;
            this.TxtText.Name = "TxtText";
            this.TxtText.PlaceholderText = "Text";
            this.TxtText.Size = new System.Drawing.Size(258, 162);
            this.TxtText.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(42, 254);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(190, 23);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // CheckBoxDate
            // 
            this.CheckBoxDate.AutoSize = true;
            this.CheckBoxDate.Location = new System.Drawing.Point(238, 259);
            this.CheckBoxDate.Name = "CheckBoxDate";
            this.CheckBoxDate.Size = new System.Drawing.Size(62, 19);
            this.CheckBoxDate.TabIndex = 8;
            this.CheckBoxDate.Text = "Datum";
            this.CheckBoxDate.UseVisualStyleBackColor = true;
            // 
            // TxtLabel
            // 
            this.TxtLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtLabel.Location = new System.Drawing.Point(42, 297);
            this.TxtLabel.Name = "TxtLabel";
            this.TxtLabel.PlaceholderText = "Štítek";
            this.TxtLabel.Size = new System.Drawing.Size(258, 35);
            this.TxtLabel.TabIndex = 9;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDelete.Location = new System.Drawing.Point(647, 428);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(163, 62);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "Smazat";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnExport
            // 
            this.BtnExport.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnExport.Location = new System.Drawing.Point(816, 428);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(163, 62);
            this.BtnExport.TabIndex = 11;
            this.BtnExport.Text = "Exportovat";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 542);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.TxtLabel);
            this.Controls.Add(this.CheckBoxDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TxtText);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.BtnArchive);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.listTasks);
            this.Controls.Add(this.BtnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnAdd;
        private ListBox listTasks;
        private Button BtnReset;
        private Button BtnCheck;
        private Button BtnArchive;
        private TextBox TxtName;
        private TextBox TxtText;
        private DateTimePicker dateTimePicker1;
        private CheckBox CheckBoxDate;
        private TextBox TxtLabel;
        private Button BtnDelete;
        private Button BtnExport;
    }
}