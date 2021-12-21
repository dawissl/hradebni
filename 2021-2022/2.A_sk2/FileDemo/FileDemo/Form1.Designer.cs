
namespace FileDemo
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
            this.BtnExport = new System.Windows.Forms.Button();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtContent = new System.Windows.Forms.TextBox();
            this.RadTxt = new System.Windows.Forms.RadioButton();
            this.RadCsv = new System.Windows.Forms.RadioButton();
            this.RadXml = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnExport
            // 
            this.BtnExport.Location = new System.Drawing.Point(369, 219);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(98, 60);
            this.BtnExport.TabIndex = 0;
            this.BtnExport.Text = "Export";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(369, 298);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(98, 60);
            this.BtnLoad.TabIndex = 1;
            this.BtnLoad.Text = "Load";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(59, 56);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(302, 23);
            this.TxtName.TabIndex = 2;
            // 
            // TxtContent
            // 
            this.TxtContent.AcceptsTab = true;
            this.TxtContent.Location = new System.Drawing.Point(59, 111);
            this.TxtContent.Multiline = true;
            this.TxtContent.Name = "TxtContent";
            this.TxtContent.Size = new System.Drawing.Size(302, 307);
            this.TxtContent.TabIndex = 3;
            // 
            // RadTxt
            // 
            this.RadTxt.AutoSize = true;
            this.RadTxt.Location = new System.Drawing.Point(373, 111);
            this.RadTxt.Name = "RadTxt";
            this.RadTxt.Size = new System.Drawing.Size(44, 19);
            this.RadTxt.TabIndex = 4;
            this.RadTxt.TabStop = true;
            this.RadTxt.Text = "TXT";
            this.RadTxt.UseVisualStyleBackColor = true;
            // 
            // RadCsv
            // 
            this.RadCsv.AutoSize = true;
            this.RadCsv.Location = new System.Drawing.Point(373, 145);
            this.RadCsv.Name = "RadCsv";
            this.RadCsv.Size = new System.Drawing.Size(46, 19);
            this.RadCsv.TabIndex = 5;
            this.RadCsv.TabStop = true;
            this.RadCsv.Text = "CSV";
            this.RadCsv.UseVisualStyleBackColor = true;
            // 
            // RadXml
            // 
            this.RadXml.AutoSize = true;
            this.RadXml.Location = new System.Drawing.Point(373, 179);
            this.RadXml.Name = "RadXml";
            this.RadXml.Size = new System.Drawing.Size(49, 19);
            this.RadXml.TabIndex = 6;
            this.RadXml.TabStop = true;
            this.RadXml.Text = "XML";
            this.RadXml.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Název souboru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Obsah souboru";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RadXml);
            this.Controls.Add(this.RadCsv);
            this.Controls.Add(this.RadTxt);
            this.Controls.Add(this.TxtContent);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.BtnExport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtContent;
        private System.Windows.Forms.RadioButton RadTxt;
        private System.Windows.Forms.RadioButton RadCsv;
        private System.Windows.Forms.RadioButton RadXml;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

