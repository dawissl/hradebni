
namespace ExportFile
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RadTxt = new System.Windows.Forms.RadioButton();
            this.RadCsv = new System.Windows.Forms.RadioButton();
            this.RadXml = new System.Windows.Forms.RadioButton();
            this.Eport = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.TxtContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(25, 42);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(285, 23);
            this.TxtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Název souboru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Obsah";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Typ souboru";
            // 
            // RadTxt
            // 
            this.RadTxt.AutoSize = true;
            this.RadTxt.Location = new System.Drawing.Point(235, 113);
            this.RadTxt.Name = "RadTxt";
            this.RadTxt.Size = new System.Drawing.Size(44, 19);
            this.RadTxt.TabIndex = 5;
            this.RadTxt.TabStop = true;
            this.RadTxt.Text = "TXT";
            this.RadTxt.UseVisualStyleBackColor = true;
            // 
            // RadCsv
            // 
            this.RadCsv.AutoSize = true;
            this.RadCsv.Location = new System.Drawing.Point(235, 149);
            this.RadCsv.Name = "RadCsv";
            this.RadCsv.Size = new System.Drawing.Size(46, 19);
            this.RadCsv.TabIndex = 6;
            this.RadCsv.TabStop = true;
            this.RadCsv.Text = "CSV";
            this.RadCsv.UseVisualStyleBackColor = true;
            // 
            // RadXml
            // 
            this.RadXml.AutoSize = true;
            this.RadXml.Location = new System.Drawing.Point(232, 184);
            this.RadXml.Name = "RadXml";
            this.RadXml.Size = new System.Drawing.Size(49, 19);
            this.RadXml.TabIndex = 7;
            this.RadXml.TabStop = true;
            this.RadXml.Text = "XML";
            this.RadXml.UseVisualStyleBackColor = true;
            // 
            // Eport
            // 
            this.Eport.Location = new System.Drawing.Point(235, 232);
            this.Eport.Name = "Eport";
            this.Eport.Size = new System.Drawing.Size(75, 23);
            this.Eport.TabIndex = 8;
            this.Eport.Text = "Export";
            this.Eport.UseVisualStyleBackColor = true;
            this.Eport.Click += new System.EventHandler(this.Eport_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(235, 261);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 23);
            this.Load.TabIndex = 9;
            this.Load.Text = "Načíst";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // TxtContent
            // 
            this.TxtContent.Location = new System.Drawing.Point(25, 113);
            this.TxtContent.Multiline = true;
            this.TxtContent.Name = "TxtContent";
            this.TxtContent.Size = new System.Drawing.Size(173, 251);
            this.TxtContent.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 396);
            this.Controls.Add(this.TxtContent);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Eport);
            this.Controls.Add(this.RadXml);
            this.Controls.Add(this.RadCsv);
            this.Controls.Add(this.RadTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RadTxt;
        private System.Windows.Forms.RadioButton RadCsv;
        private System.Windows.Forms.RadioButton RadXml;
        private System.Windows.Forms.Button Eport;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.TextBox TxtContent;
    }
}

