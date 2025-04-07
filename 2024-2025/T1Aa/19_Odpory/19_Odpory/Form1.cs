namespace _19_Odpory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVypocet_Click(object sender, EventArgs e)
        {
            try
            {
                // ziskani promìnnýhch od uživatele
                int pocet = int.Parse(TxtPocet.Text);
                int minR = int.Parse(TxtMinR.Text);
                int maxR = int.Parse(TxtMaxR.Text);
                // ošetøení vstupních hodnot dle rozsahu
                if (pocet > 10 || pocet < 2) 
                    throw new Exception("Rozsah odporù musí být mezi 2 a 10");
                if (minR > maxR)
                    throw new Exception("Minimální hodnota musí být nižší než maximální");

                //instance pro generování náhodných èísel
                Random rnd = new Random();
                // kolekce list pro uchování vytvoøených odporù
                List<int> odpory = new List<int>();
                string odporyText = "";
                for (int i = 0; i < pocet; i++)
                {
                    // vytvoøení, pøídání a výpis odporu
                    odpory.Add(rnd.Next(minR, maxR + 1));
                    odporyText += $"{odpory[i]} ";
                }
                LblRs.Text = odporyText;
                // urèení výsledného odporu na základì volby
                // využití ternárního operátoru () ? :
                double vyslednyOdpor = (ComboConnection.Text == "sériové") ? SerialResistence(odpory) : ParalelResistence(odpory);
                LblResult.Text = $"Výsledný odpor {vyslednyOdpor} Ohm.";

            }
            // odchytávané výjimky za bìhu programu
            catch (FormatException ex)
            {
                MessageBox.Show("Zadávejte pouze èísla.");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        // pomocná funkce pro výpoèet sériového zapojení
        private double SerialResistence(List<int> odpory)
        {
            return odpory.Sum();
        }

        // pomocná funkce pro výpoèet paralelního zapojení
        private double ParalelResistence(List<int> odpory)
        {
            double partialSum = 0;
            foreach (int o in odpory)
            {
                partialSum += 1.0 / o;
            }
            // zaokrouhleni na dvì desetinná místa
            return Math.Round(1.0 / partialSum,2);
        }
    }
}
