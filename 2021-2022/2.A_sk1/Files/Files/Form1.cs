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

namespace Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string path = textBox1.Text;
            if (path == "")
            {
                path = "dummyFile.csv";
            }
            using(StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(textBox2.Text);
                sw.Close();
                MessageBox.Show($"Soubor {path} vytvořen.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = openFileDialog.FileName;

                    Stream fileStream = openFileDialog.OpenFile();

                    using(StreamReader sr = new StreamReader(fileStream))
                    {
                        textBox2.Text = sr.ReadToEnd();
                        sr.Close();
                    }
                }
            }
        }
    }
}
