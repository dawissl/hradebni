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
            this.button1 = new System.Windows.Forms.Button();
            this.ComboType = new System.Windows.Forms.ComboBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtLabel = new System.Windows.Forms.TextBox();
            this.TxtList = new System.Windows.Forms.TextBox();
            this.DateCalendar = new System.Windows.Forms.DateTimePicker();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.ListTasks = new System.Windows.Forms.ListBox();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1211, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComboType
            // 
            this.ComboType.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ComboType.FormattingEnabled = true;
            this.ComboType.Items.AddRange(new object[] {
            "POZNAMKA",
            "SEZNAM",
            "UKOL"});
            this.ComboType.Location = new System.Drawing.Point(36, 27);
            this.ComboType.Name = "ComboType";
            this.ComboType.Size = new System.Drawing.Size(237, 40);
            this.ComboType.Sorted = true;
            this.ComboType.TabIndex = 1;
            this.ComboType.Text = "POZNAMKA";
            this.ComboType.SelectedIndexChanged += new System.EventHandler(this.ComboType_SelectedIndexChanged);
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtName.Location = new System.Drawing.Point(36, 73);
            this.TxtName.Name = "TxtName";
            this.TxtName.PlaceholderText = "Nadpis";
            this.TxtName.Size = new System.Drawing.Size(237, 35);
            this.TxtName.TabIndex = 2;
            // 
            // TxtLabel
            // 
            this.TxtLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtLabel.Location = new System.Drawing.Point(36, 114);
            this.TxtLabel.Name = "TxtLabel";
            this.TxtLabel.PlaceholderText = "Štítek";
            this.TxtLabel.Size = new System.Drawing.Size(237, 35);
            this.TxtLabel.TabIndex = 3;
            // 
            // TxtList
            // 
            this.TxtList.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtList.Location = new System.Drawing.Point(36, 184);
            this.TxtList.Multiline = true;
            this.TxtList.Name = "TxtList";
            this.TxtList.PlaceholderText = "Seznam položek";
            this.TxtList.Size = new System.Drawing.Size(237, 193);
            this.TxtList.TabIndex = 4;
            // 
            // DateCalendar
            // 
            this.DateCalendar.CalendarFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateCalendar.Location = new System.Drawing.Point(36, 155);
            this.DateCalendar.Name = "DateCalendar";
            this.DateCalendar.Size = new System.Drawing.Size(238, 23);
            this.DateCalendar.TabIndex = 5;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAdd.Location = new System.Drawing.Point(36, 394);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(116, 40);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Přidat";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnReset.Location = new System.Drawing.Point(158, 394);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(116, 40);
            this.BtnReset.TabIndex = 7;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // ListTasks
            // 
            this.ListTasks.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListTasks.FormattingEnabled = true;
            this.ListTasks.ItemHeight = 25;
            this.ListTasks.Location = new System.Drawing.Point(293, 27);
            this.ListTasks.Name = "ListTasks";
            this.ListTasks.Size = new System.Drawing.Size(958, 354);
            this.ListTasks.TabIndex = 8;
            // 
            // BtnCheck
            // 
            this.BtnCheck.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCheck.Location = new System.Drawing.Point(293, 394);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(116, 40);
            this.BtnCheck.TabIndex = 9;
            this.BtnCheck.Text = "Splněno";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDelete.Location = new System.Drawing.Point(415, 394);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(116, 40);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "Odebrat";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnExport
            // 
            this.BtnExport.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnExport.Location = new System.Drawing.Point(537, 394);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(116, 40);
            this.BtnExport.TabIndex = 11;
            this.BtnExport.Text = "Export";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 450);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.ListTasks);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.DateCalendar);
            this.Controls.Add(this.TxtList);
            this.Controls.Add(this.TxtLabel);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.ComboType);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private ComboBox ComboType;
        private TextBox TxtName;
        private TextBox TxtLabel;
        private TextBox TxtList;
        private DateTimePicker DateCalendar;
        private Button BtnAdd;
        private Button BtnReset;
        private ListBox ListTasks;
        private Button BtnCheck;
        private Button BtnDelete;
        private Button BtnExport;
    }
}