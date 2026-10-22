namespace _24_Faktura
{
    public partial class Form1 : Form
    {
        double cena = 0;
        double cena_s_dph = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private double ZjistiDan(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0:
                    return 1.15;
                case 1:
                    return 1.21;
                case 2:
                    return 1.27;
                default:
                    return 0;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Zboží | 3 ks | 30,25 Kè/ks
            try
            {
                double c = double.Parse(textBox2.Text);
                string n = textBox1.Text.Trim();
                if (n == string.Empty)
                {
                    MessageBox.Show("Nazev nesmi byt prazdny");
                    return;
                }
                int pocet = (int)numericUpDown1.Value;
                double dan = ZjistiDan(comboBox1.SelectedIndex);
                if (dan == 0)
                {
                    MessageBox.Show("Neplatná hodnta pro daò");
                    return;
                }

                double cena_polozka = c * dan;
                double cena_bez_dane_za_vse = c * pocet;

                cena_s_dph += cena_polozka * pocet;
                cena += cena_bez_dane_za_vse;

                listBox1.Items.Add($"{n} | {pocet} ks | {Math.Round(cena_polozka,2)} Kè/ks");

                label7.Text = $"{cena}";
                label8.Text = $"{Math.Round(cena_s_dph,2)}";
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Neplatný formát pro cenovku, zadejte èíslo");
            }
            VymazatVstupy();
        }

        private void VymazatVstupy()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            numericUpDown1.Value = numericUpDown1.Minimum;
            comboBox1.SelectedIndex = -1;

        }
    }
}
