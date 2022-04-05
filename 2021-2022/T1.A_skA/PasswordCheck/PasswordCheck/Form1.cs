namespace PasswordCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            int skoreHesla = 0;
            bool maleP = false,
                 velkeP = false,
                 cislice = false;

            char[] heslo = TxtHeslo.Text.ToCharArray();

            // isUpper(), isDigit(), isLower()

            for (int i = 0; i < heslo.Length; i++)
            {
                if (Char.IsUpper(heslo[i]))
                {
                    velkeP = true;
                }

                if (Char.IsLower(heslo[i]))
                {
                    maleP = true;
                }

                if (Char.IsDigit(heslo[i]))
                {
                    cislice = true;
                }
            }

            if (maleP) skoreHesla++;
            if (velkeP) skoreHesla++;
            if (cislice) skoreHesla++;

            if (maleP && velkeP) skoreHesla++;

            if (heslo.Length < 8) skoreHesla -= 3;
            if (heslo.Length > 13) skoreHesla += 3;

            if (heslo.Length >= 8 && heslo.Length <= 13)
                skoreHesla += 2;

            if (skoreHesla >= 5)
                LblResult.BackColor = Color.Green;

            if (skoreHesla >= 2 && skoreHesla < 5)
                LblResult.BackColor = Color.Orange;

            if (skoreHesla < 2)
                LblResult.BackColor = Color.Red;

        }
    }
}