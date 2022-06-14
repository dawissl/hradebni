using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NakupniKosik
{
    public partial class Form1 : Form
    {
        private Kosik mujKosik = new Kosik();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Zbozi z;
            switch (ComboType.Text)
            {
                case "zboží":
                    z = new Zbozi(TxtName.Text, double.Parse(TxtPrice.Text));
                    break;
                case "drogerie":
                    z = new Drogerie(TxtName.Text, double.Parse(TxtPrice.Text),TxtFor.Text);
                    break;
                case "potravina":
                    z = new Potravina(TxtName.Text, double.Parse(TxtPrice.Text), TxtStoring.Text);
                    break;
                default:
                    z = null;
                    break;

            }
            if (z != null)
            {
                mujKosik.AddItem(z);
            }
            else
            {
                MessageBox.Show("Chyba při vkládání zboží");
            }

            LblShoppingList.Text = mujKosik.ToString();
            LblTotalPrice.Text = $"{mujKosik.TotalPrice()} Kč";
            EmptyForm();
        }

        private void EmptyForm()
        {
            TxtName.Text = "";
            TxtPrice.Text = "";
            TxtFor.Text = "";
            TxtStoring.Text = "";
            ComboType.Text = "";
        }

        private void BtnEmpty_Click(object sender, EventArgs e)
        {
            mujKosik = new Kosik();
            LblShoppingList.Text = "";
            LblTotalPrice.Text = "";
            EmptyForm();

        }

        private void ComboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboType.Text)
            {
                case "zboží":
                    TxtStoring.Enabled = false;
                    TxtFor.Enabled = false;
                    break;
                case "drogerie":
                    TxtStoring.Enabled = false;
                    TxtFor.Enabled = true;
                    break;
                case "potravina":
                    TxtStoring.Enabled = true;
                    TxtFor.Enabled = false;
                    break;
        
            }
        }
    }
}
