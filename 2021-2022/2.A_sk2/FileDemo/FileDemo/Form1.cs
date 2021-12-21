using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "")
            {
                MessageBox.Show("Zadejte prosím název souboru");
                return;
            }

            string fileName = $"{TxtName.Text}.{getFileType()}";


            using (StreamWriter sw = new StreamWriter(fileName, false))
            {

                sw.Write(TxtContent.Text);
                sw.Close();
                MessageBox.Show($"Soubor {fileName} byl vytvořen.");
            }
        }

        private string getFileType()
        {
            if (RadCsv.Checked) return RadCsv.Text.ToLower();
            if (RadTxt.Checked) return RadTxt.Text.ToLower();
            if (RadXml.Checked) return RadXml.Text.ToLower();
            MessageBox.Show("Není zvolena přípona souboru.");
            return "";
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            RadCsv.Checked = false;
            RadTxt.Checked = false;
            RadXml.Checked = false;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    string fileName = openFileDialog.FileName;
                    TxtName.Text = fileName;
                    Stream fileStream = openFileDialog.OpenFile();

                    using (StreamReader sr = new StreamReader(fileStream))
                    {
                        TxtContent.Text = sr.ReadToEnd();
                        sr.Close();
                    }
                }
            }
        }
    }
}
