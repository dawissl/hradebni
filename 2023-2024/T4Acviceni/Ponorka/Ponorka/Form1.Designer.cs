namespace Ponorka
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
            BtnCreateData = new Button();
            BtnLoadData = new Button();
            TxtData = new TextBox();
            BtnAnalyze = new Button();
            NumStart = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            NumEnd = new NumericUpDown();
            LblResult = new Label();
            OFDialog = new OpenFileDialog();
            SFDialog = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)NumStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumEnd).BeginInit();
            SuspendLayout();
            // 
            // BtnCreateData
            // 
            BtnCreateData.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCreateData.Location = new Point(12, 33);
            BtnCreateData.Name = "BtnCreateData";
            BtnCreateData.Size = new Size(193, 46);
            BtnCreateData.TabIndex = 0;
            BtnCreateData.Text = "Create data";
            BtnCreateData.UseVisualStyleBackColor = true;
            BtnCreateData.Click += BtnCreateData_Click;
            // 
            // BtnLoadData
            // 
            BtnLoadData.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnLoadData.Location = new Point(12, 85);
            BtnLoadData.Name = "BtnLoadData";
            BtnLoadData.Size = new Size(193, 46);
            BtnLoadData.TabIndex = 1;
            BtnLoadData.Text = "Load data";
            BtnLoadData.UseVisualStyleBackColor = true;
            BtnLoadData.Click += BtnLoadData_Click;
            // 
            // TxtData
            // 
            TxtData.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TxtData.Location = new Point(12, 131);
            TxtData.Multiline = true;
            TxtData.Name = "TxtData";
            TxtData.ReadOnly = true;
            TxtData.ScrollBars = ScrollBars.Vertical;
            TxtData.Size = new Size(193, 307);
            TxtData.TabIndex = 2;
            // 
            // BtnAnalyze
            // 
            BtnAnalyze.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAnalyze.Location = new Point(233, 85);
            BtnAnalyze.Name = "BtnAnalyze";
            BtnAnalyze.Size = new Size(246, 46);
            BtnAnalyze.TabIndex = 3;
            BtnAnalyze.Text = "Analyze interval";
            BtnAnalyze.UseVisualStyleBackColor = true;
            BtnAnalyze.Click += BtnAnalyze_Click;
            // 
            // NumStart
            // 
            NumStart.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            NumStart.Location = new Point(233, 44);
            NumStart.Name = "NumStart";
            NumStart.Size = new Size(120, 35);
            NumStart.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(233, 11);
            label1.Name = "label1";
            label1.Size = new Size(55, 30);
            label1.TabIndex = 5;
            label1.Text = "Start";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(359, 11);
            label2.Name = "label2";
            label2.Size = new Size(48, 30);
            label2.TabIndex = 7;
            label2.Text = "End";
            // 
            // NumEnd
            // 
            NumEnd.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            NumEnd.Location = new Point(359, 44);
            NumEnd.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            NumEnd.Name = "NumEnd";
            NumEnd.Size = new Size(120, 35);
            NumEnd.TabIndex = 6;
            NumEnd.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // LblResult
            // 
            LblResult.BorderStyle = BorderStyle.Fixed3D;
            LblResult.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LblResult.ForeColor = Color.DarkOliveGreen;
            LblResult.Location = new Point(233, 152);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(246, 64);
            LblResult.TabIndex = 8;
            LblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OFDialog
            // 
            OFDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 450);
            Controls.Add(LblResult);
            Controls.Add(label2);
            Controls.Add(NumEnd);
            Controls.Add(label1);
            Controls.Add(NumStart);
            Controls.Add(BtnAnalyze);
            Controls.Add(TxtData);
            Controls.Add(BtnLoadData);
            Controls.Add(BtnCreateData);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumEnd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCreateData;
        private Button BtnLoadData;
        private TextBox TxtData;
        private Button BtnAnalyze;
        private NumericUpDown NumStart;
        private Label label1;
        private Label label2;
        private NumericUpDown NumEnd;
        private Label LblResult;
        private OpenFileDialog OFDialog;
        private SaveFileDialog SFDialog;
    }
}