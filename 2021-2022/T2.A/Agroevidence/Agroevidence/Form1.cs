using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agroevidence
{
    public partial class Form1 : Form
    {
        private string[] databaze = new string[10];
        private int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSaveAction_Click(object sender, EventArgs e)
        {
            if (ValidaceFormulare())
            {
                if (index < 10)
                {
                    databaze[index] = TiskCinnosti();
                    index++;
                }
                else
                {
                    MessageBox.Show("Databáze je již plná");
                }
                
            }
        }
        private void BtnShowActions_Click(object sender, EventArgs e)
        {
            string ret = "";
            foreach(string s in databaze)
            {
                if (s != "") ret += s + Environment.NewLine;
            }
            LblOut.Text = ret;
            MessageBox.Show(ret);
        }

        private string TiskCinnosti()
        {
           
            return $"Činnost {CmbAction.Text} na parcele" +
                $" {TxtParcel.Text} ({TxtArea.Text}ha). {TiskAplikace()} {TxtNote.Text}";
        }

        private string TiskAplikace()
        {
            if (CmbUnit.SelectedIndex != -1 &&
                   TxtAmount.Text != "" &&
                   TxtProduct.Text != "")
            {
                return $"Aplikace {TxtProduct.Text} v množství" +
                    $" {TxtAmount.Text}{CmbUnit.Text}";
            }

                return "";
        }

        private bool ValidaceFormulare()
        {
            if (CmbAction.SelectedIndex !=-1 &&
                   TxtParcel.Text != "" &&
                   TxtArea.Text != "")
            {
                return true;
            }
            MessageBox.Show("Chybějící informace");
            return false;
        }

        private void CmbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
