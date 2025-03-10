namespace _16_Trezor
{
    public partial class Form1 : Form
    {
        // [ = altGr + F
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
                // explicitni pøetpování decimal na int
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
                    // heslo = heslo + "X ";
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
                skutecneHeslo[3] == tipovaneHeslo[3]
                )
            {
                LblStatus.BackColor = Color.Green;
            }
            else
            {
                // vyskakovaci dialogove okno
                MessageBox.Show("Heslo není platné");
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            LblPassword.Text = "X X X X";
            LblStatus.BackColor = Color.Red;
            tipovaneHeslo[0] = -1;
            tipovaneHeslo[1] = -1;
            tipovaneHeslo[2] = -1;
            tipovaneHeslo[3] = -1;
        }
    }
}