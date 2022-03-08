using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroEvidence
{
    public partial class AgroForm : Form
    {
        private string[] databaze = new string[10];
        private int index = 0;
        public AgroForm()
        {
            InitializeComponent();
        }

        private void BtnSaveAction_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                string newAction = CreateAction();
                if (index < 10)
                {
                    databaze[index] = newAction;
                    index++;
                }
                else
                {
                    MessageBox.Show("Databaze je již plná");
                }
            }
        }

        private string CreateAction()
        {
            return $"Činnost {TxtAction.Text} na parcele " +
                $"{TxtParcel.Text} ({TxtArea.Text} ha)" +
                $".{CreateMaterial()} {TxtNote.Text}";
        }

        private string CreateMaterial()
        {
            if (TxtAmount.Text == "" ||
                TxtMaterial.Text == "" ||
                TxtUnits.Text == "")
            {
                return "";
            }
            else
            {
                return $"Aplikace {TxtMaterial.Text} " +
                    $"v množství {TxtAmount.Text} " +
                    $"{TxtUnits.Text}.";
            }
        }

        private bool ValidateForm()
        {
            if (TxtParcel.Text != "" &&
                TxtAction.Text != "" &&
                TxtArea.Text != "")
            {
                if (TxtAction.Text == "HNOJENÍ" || TxtAction.Text == "SETÍ")
                {
                    if (TxtAmount.Text != "" &&
                        TxtMaterial.Text != "" &&
                        TxtUnits.Text != "")
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Chybějící informace o materiálu!");
                        return false;
                    }
                }
                return true;
            }
            MessageBox.Show("Formulář není validní");
            return false;
        }

        private void TxtShow_Click(object sender, EventArgs e)
        {
            string ret = "Databaze:" + Environment.NewLine;

            foreach (string s in databaze)
            {
                if (s != "")
                {
                    ret += s + Environment.NewLine;
                }
            }
            MessageBox.Show(ret);
        }
    }
}
