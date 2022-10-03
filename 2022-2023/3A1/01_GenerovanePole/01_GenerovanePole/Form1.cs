namespace _01_GenerovanePole
{
    public partial class Form1 : Form
    {
        private int[] nahodnePole;
        public Form1()
        {
            InitializeComponent();
            nahodnePole = new int[1];
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
           // deklarace pole o pozadovane velikosti
            nahodnePole = new int[(int)NumericArraySize.Value];
            Random rnd = new Random();
            // pomocná promìnná pro generovaný øetìzec
            string tmp = "";
            // v cyklu vygenerujeme hodnotu z rozsahu <1,51>
            // a pøipojime hodnotu k doèasnému øetìzci
            for(int i = 0; i < nahodnePole.Length; i++)
            {
                nahodnePole[i] = rnd.Next(1,51);
                tmp += $"{nahodnePole[i]}, ";
            }

            LblGeneratedArray.Text = tmp;


           
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // pomocna promenna, do ktere postupne pøièitame
            int suma = 0;
            for (int i = 0; i < nahodnePole.Length; i++)
            {
                suma += nahodnePole[i];
            }
            // $ = alt + 36
            LblResult.Text = $"{suma}";
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            double soucin = 1;
            for (int i = 0; i < nahodnePole.Length; i++)
            {
                soucin *= nahodnePole[i];
            }

            LblResult.Text = $"{soucin}";
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            int max = nahodnePole[0];
            for(int i = 1; i < nahodnePole.Length; i++)
            {
                if(nahodnePole[i] > max) 
                    max = nahodnePole[i];
            }
            LblResult.Text = $"{max}";
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            LblResult.Text = $"{nahodnePole.Min()}";
        }
    }
}