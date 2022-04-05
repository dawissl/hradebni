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
            if (ValidateForm())
            {
                string newAction = CreateAction();
                if (index < 10)
                {
                    databaze[index] = newAction;
                    index++;
                    if(ComboAction.Text != "ORBA" && ComboAction.Text != "KYPŘENÍ")
                    {
                        LblHa.Text = $"{double.Parse(TxtAmount.Text) / double.Parse(TxtArea.Text)}";
                    }
                    else
                    {
                        LblHa.Text = "-";
                    }
                    LblInfo.Visible = true;
                }
                else
                {
                    MessageBox.Show("Databáze je již plná");
                    LblInfo.Visible = false;
                }

            }
        }
        private string CreateAction()
        {
            return $"Činnost {ComboAction.SelectedItem} na parcele {TxtParcel.Text}" +
                $" o výměře {TxtArea.Text}ha vytvořena. {Chemistry()} {TxtNote.Text}";
        }

        private string Chemistry()
        {
            if (TxtChemistry.Text != "" && ComboAction.Text != "ORBA" && ComboAction.Text != "KYPŘENÍ")
            {
                return $"Aplikován přípravek {TxtChemistry.Text} - {TxtAmount.Text}{ComboUnits.SelectedItem}";
            }
            return "";
        }

        private bool ValidateForm()
        {
            if (ComboAction.SelectedIndex != -1 && TxtArea.Text != "" && TxtParcel.Text != "")
            {
                if (ComboAction.Text == "SETÍ" || ComboAction.Text == "HNOJENÍ")
                {
                    if (TxtChemistry.Text != "" && TxtAmount.Text != "" && ComboUnits.Text != "")
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Chybějící informace o aplikované látce.");
                        LblInfo.Visible = false;
                        return false;
                    }
                }
                return true;
            }
            else
            {
                MessageBox.Show("Formulář není správně vyplněn.");
                LblInfo.Visible = false;
                return false;
            }
        }

        private void BtnShowActions_Click(object sender, EventArgs e)
        {
            LblOut.Text = "";
            foreach (string action in databaze)
            {
                if (action != "")
                {
                    LblOut.Text += $"{action}{Environment.NewLine}";
                }
            }
        }


    }
}
