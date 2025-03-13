namespace _16_Trezor_reseni
{
    public partial class Form1 : Form
    {
        int[] skutecneHeslo = { 1, 1, 1, 1 };
        int[] tipovaneHeslo = { -1, -1, -1, -1 };
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (RadFirst.Checked)
            {
                // explicitni pøetypování Decimal -> int
                tipovaneHeslo[0] = (int)NumEnter.Value;
            }
            if (RadSecond.Checked)
            {
                tipovaneHeslo[1] = (int)NumEnter.Value;
            }
            if (RadThird.Checked)
            {
                tipovaneHeslo[2] = (int)NumEnter.Value;
            }
            if (RadFourth.Checked)
            {
                tipovaneHeslo[3] = (int)NumEnter.Value;
            }
            string heslo = "";
            for (int i = 0; i < tipovaneHeslo.Length; i++)
            {
                if (tipovaneHeslo[i] == -1)
                {
                    // heslo = heslo + "x "
                    heslo += "X ";
                }
                else
                {
                    heslo += $"{tipovaneHeslo[i]} ";
                }
            }
            LblPassword.Text = heslo;
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            // & = alt + 38
            if (skutecneHeslo[0] == tipovaneHeslo[0] &&
                skutecneHeslo[1] == tipovaneHeslo[1] &&
                skutecneHeslo[2] == tipovaneHeslo[2] &&
                skutecneHeslo[3] == tipovaneHeslo[3])
            {
                LblStatus.BackColor = Color.Green;
            }
            else
            {
                // Vyskakovací dialogové okno s textem
                MessageBox.Show("Špatnì zadané heslo!");
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            // nová inicilalziace
            // tipovaneHeslo = new int[]{ -1,-1,-1,-1};
            tipovaneHeslo[0] = -1;
            tipovaneHeslo[1] = -1;
            tipovaneHeslo[2] = -1;
            tipovaneHeslo[3] = -1;
            LblStatus.BackColor = Color.Red;
            LblPassword.Text = "X X X X";
        }

        private void BtnSetNew_Click(object sender, EventArgs e)
        {
            if(LblStatus.BackColor == Color.Green)
            {
                for(int i=0;i<tipovaneHeslo.Length;i++)
                {
                    skutecneHeslo[i] = tipovaneHeslo[i];
                    tipovaneHeslo[i] = -1;
                }
                LblStatus.BackColor = Color.Red;
                LblPassword.Text = "X X X X";
            }
            else
            {
                MessageBox.Show("Nelze nastavit heslo u zamèenéh trezoru");
            }
        }
    }
}