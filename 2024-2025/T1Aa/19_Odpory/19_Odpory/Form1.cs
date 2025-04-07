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
                // ziskani prom�nn�hch od u�ivatele
                int pocet = int.Parse(TxtPocet.Text);
                int minR = int.Parse(TxtMinR.Text);
                int maxR = int.Parse(TxtMaxR.Text);
                // o�et�en� vstupn�ch hodnot dle rozsahu
                if (pocet > 10 || pocet < 2) 
                    throw new Exception("Rozsah odpor� mus� b�t mezi 2 a 10");
                if (minR > maxR)
                    throw new Exception("Minim�ln� hodnota mus� b�t ni��� ne� maxim�ln�");

                //instance pro generov�n� n�hodn�ch ��sel
                Random rnd = new Random();
                // kolekce list pro uchov�n� vytvo�en�ch odpor�
                List<int> odpory = new List<int>();
                string odporyText = "";
                for (int i = 0; i < pocet; i++)
                {
                    // vytvo�en�, p��d�n� a v�pis odporu
                    odpory.Add(rnd.Next(minR, maxR + 1));
                    odporyText += $"{odpory[i]} ";
                }
                LblRs.Text = odporyText;
                // ur�en� v�sledn�ho odporu na z�klad� volby
                // vyu�it� tern�rn�ho oper�toru () ? :
                double vyslednyOdpor = (ComboConnection.Text == "s�riov�") ? SerialResistence(odpory) : ParalelResistence(odpory);
                LblResult.Text = $"V�sledn� odpor {vyslednyOdpor} Ohm.";

            }
            // odchyt�van� v�jimky za b�hu programu
            catch (FormatException ex)
            {
                MessageBox.Show("Zad�vejte pouze ��sla.");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        // pomocn� funkce pro v�po�et s�riov�ho zapojen�
        private double SerialResistence(List<int> odpory)
        {
            return odpory.Sum();
        }

        // pomocn� funkce pro v�po�et paraleln�ho zapojen�
        private double ParalelResistence(List<int> odpory)
        {
            double partialSum = 0;
            foreach (int o in odpory)
            {
                partialSum += 1.0 / o;
            }
            // zaokrouhleni na dv� desetinn� m�sta
            return Math.Round(1.0 / partialSum,2);
        }
    }
}
