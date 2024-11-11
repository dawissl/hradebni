namespace _02_Knihovna
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
            ListLibrary = new ListBox();
            ListSelected = new ListBox();
            ChAuthor = new CheckBox();
            ChTitle = new CheckBox();
            ChPublisher = new CheckBox();
            ChSort = new CheckBox();
            NumCount = new NumericUpDown();
            BtnSearch = new Button();
            TxtAuthor = new TextBox();
            TxtTitle = new TextBox();
            TxtPublisher = new TextBox();
            ((System.ComponentModel.ISupportInitialize)NumCount).BeginInit();
            SuspendLayout();
            // 
            // ListLibrary
            // 
            ListLibrary.FormattingEnabled = true;
            ListLibrary.ItemHeight = 15;
            ListLibrary.Location = new Point(22, 27);
            ListLibrary.Name = "ListLibrary";
            ListLibrary.Size = new Size(512, 169);
            ListLibrary.TabIndex = 0;
            // 
            // ListSelected
            // 
            ListSelected.FormattingEnabled = true;
            ListSelected.ItemHeight = 15;
            ListSelected.Location = new Point(22, 220);
            ListSelected.Name = "ListSelected";
            ListSelected.Size = new Size(512, 169);
            ListSelected.TabIndex = 1;
            // 
            // ChAuthor
            // 
            ChAuthor.AutoSize = true;
            ChAuthor.Location = new Point(561, 33);
            ChAuthor.Name = "ChAuthor";
            ChAuthor.Size = new Size(56, 19);
            ChAuthor.TabIndex = 2;
            ChAuthor.Text = "Autor";
            ChAuthor.UseVisualStyleBackColor = true;
            // 
            // ChTitle
            // 
            ChTitle.AutoSize = true;
            ChTitle.Location = new Point(561, 58);
            ChTitle.Name = "ChTitle";
            ChTitle.Size = new Size(58, 19);
            ChTitle.TabIndex = 3;
            ChTitle.Text = "Nazev";
            ChTitle.UseVisualStyleBackColor = true;
            // 
            // ChPublisher
            // 
            ChPublisher.AutoSize = true;
            ChPublisher.Location = new Point(561, 83);
            ChPublisher.Name = "ChPublisher";
            ChPublisher.Size = new Size(95, 19);
            ChPublisher.TabIndex = 4;
            ChPublisher.Text = "Vydavatelstvi";
            ChPublisher.UseVisualStyleBackColor = true;
            // 
            // ChSort
            // 
            ChSort.AutoSize = true;
            ChSort.Location = new Point(561, 108);
            ChSort.Name = "ChSort";
            ChSort.Size = new Size(62, 19);
            ChSort.TabIndex = 5;
            ChSort.Text = "Seřadit";
            ChSort.UseVisualStyleBackColor = true;
            // 
            // NumCount
            // 
            NumCount.Location = new Point(561, 144);
            NumCount.Name = "NumCount";
            NumCount.Size = new Size(120, 23);
            NumCount.TabIndex = 6;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(561, 186);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(120, 23);
            BtnSearch.TabIndex = 7;
            BtnSearch.Text = "Vyhledat";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // TxtAuthor
            // 
            TxtAuthor.Location = new Point(672, 29);
            TxtAuthor.Name = "TxtAuthor";
            TxtAuthor.Size = new Size(100, 23);
            TxtAuthor.TabIndex = 8;
            // 
            // TxtTitle
            // 
            TxtTitle.Location = new Point(672, 54);
            TxtTitle.Name = "TxtTitle";
            TxtTitle.Size = new Size(100, 23);
            TxtTitle.TabIndex = 9;
            // 
            // TxtPublisher
            // 
            TxtPublisher.Location = new Point(672, 79);
            TxtPublisher.Name = "TxtPublisher";
            TxtPublisher.Size = new Size(100, 23);
            TxtPublisher.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 418);
            Controls.Add(TxtPublisher);
            Controls.Add(TxtTitle);
            Controls.Add(TxtAuthor);
            Controls.Add(BtnSearch);
            Controls.Add(NumCount);
            Controls.Add(ChSort);
            Controls.Add(ChPublisher);
            Controls.Add(ChTitle);
            Controls.Add(ChAuthor);
            Controls.Add(ListSelected);
            Controls.Add(ListLibrary);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListLibrary;
        private ListBox ListSelected;
        private CheckBox ChAuthor;
        private CheckBox ChTitle;
        private CheckBox ChPublisher;
        private CheckBox ChSort;
        private NumericUpDown NumCount;
        private Button BtnSearch;
        private TextBox TxtAuthor;
        private TextBox TxtTitle;
        private TextBox TxtPublisher;
    }
}