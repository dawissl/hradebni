namespace _24_Faktura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double celkova_cena = 0;
        double celkova_cena_s_dph = 0;

        /// <summary>
        /// Získáme koeficient násobení na základì vybrané danì
        /// </summary>
        /// <param name="selectedIndex"></param>
        /// <returns>daòový koeficient, hodnotu 0 pokud nebyla vybrána položka</returns>
        private double ZjistiDan(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0: return 1.15;
                case 1: return 1.21;
                case 2: return 1.27;
                default: return 0;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n = textBox1.Text.Trim();
            if (n == string.Empty)
            {
                MessageBox.Show("Název nesmí být prázdný");
                return;
            }
            try { 
            double c = double.Parse(textBox2.Text);
                if(c <= 0)
                {
                    MessageBox.Show("Zadávejte pouze kladnou cenu");
                    return;
                }
            int ks = (int)numericUpDown1.Value;
            double d = ZjistiDan(comboBox1.SelectedIndex);
                if(comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Nebyla zvolena hodnota dabì");
                    return;
                }
            // Zboží | 3 ks | 30,25 Kè/ks
            double cena_za_kus_s_dani = c * d;
            listBox1.Items.Add($"{n} | {ks} ks | {Math.Round(cena_za_kus_s_dani, 2)} Kè/ks");

            celkova_cena += c * ks;
            celkova_cena_s_dph += cena_za_kus_s_dani * ks;

            label7.Text = $"{Math.Round(celkova_cena, 2)}";
            label8.Text = $"{Math.Round(celkova_cena_s_dph, 2)}";
            }catch(FormatException ex)
            {
                MessageBox.Show("Zadejte èíslo pro cenu");
                return;
            }
            SmazVstupy();
        }

        private void SmazVstupy()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            numericUpDown1.Value = numericUpDown1.Minimum;
            comboBox1.SelectedIndex = -1;
        }
    }
}
