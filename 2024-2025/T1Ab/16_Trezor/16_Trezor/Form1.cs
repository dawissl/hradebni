namespace _16_Trezor
{
    public partial class Form1 : Form
    {
        // [ = alt + F
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
                // explicitni pøetypování decimal na int
                tipovaneHeslo[0] = (int)NumEnter.Value;
            }
            if (RadSecond.Checked)
            {
                // explicitni pøetypování decimal na int
                tipovaneHeslo[1] = (int)NumEnter.Value;
            }
            if (RadThird.Checked)
            {
                // explicitni pøetypování decimal na int
                tipovaneHeslo[2] = (int)NumEnter.Value;
            }
            if (RadFourth.Checked)
            {
                // explicitni pøetypování decimal na int
                tipovaneHeslo[3] = (int)NumEnter.Value;
            }
            // zobrazeni zadavaneho hesla uživateli
            string heslo = "";
            for (int i = 0; i < tipovaneHeslo.Length; i++)
            {
                if (tipovaneHeslo[i] == -1)
                {
                    // vložime X
                    heslo += "X ";
                }
                else
                {
                    // heslo = heslo + $"{tipovaneHeslo[i]} "
                    heslo += $"{tipovaneHeslo[i]} ";
                }
            }
            LblPassword.Text = heslo;
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            // & = alt + 38
            if (tipovaneHeslo[0] == skutecneHeslo[0] &&
                tipovaneHeslo[1] == skutecneHeslo[1] &&
                tipovaneHeslo[2] == skutecneHeslo[2] &&
                tipovaneHeslo[3] == skutecneHeslo[3])
            {
                LblStatus.BackColor = Color.Green;
            }
            else
            {
                // vyskakovaci dialogové okno
                MessageBox.Show("Neplatné heslo");
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            tipovaneHeslo[0] = -1;
            tipovaneHeslo[1] = -1;
            tipovaneHeslo[2] = -1;
            tipovaneHeslo[3] = -1;

            LblPassword.Text = "X X X X";
            LblStatus.BackColor = Color.Red;
        }
    }
}