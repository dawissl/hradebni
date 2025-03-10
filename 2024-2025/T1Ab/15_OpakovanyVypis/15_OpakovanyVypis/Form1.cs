namespace _15_OpakovanyVypis
{
    public partial class Form1 : Form
    {
        // deklarace promennych pro vstup
        string vystup = "";
        int cislo;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnWhileCycle_Click(object sender, EventArgs e)
        {
            vystup = "";
            // ziskan� ��sla od u�ivatele
            cislo = int.Parse(TxtCislo.Text);
            // generator n�hodn�ch ��sel
            Random generator = new Random();

            while (generator.Next(1, 21) != cislo)
            {
                vystup += $"{TxtText.Text}{Environment.NewLine}";
            }
            LblVypis.Text = vystup;
        }

        private void BtnForCycle_Click(object sender, EventArgs e)
        {
            // smaz�n� dosavadn�ho textu vypsan�ho na v�stup
            vystup = "";
            // ziskan� ��sla od u�ivatele
            cislo = int.Parse(TxtCislo.Text);
            for (int i = 0; i < cislo; i++)
            {
                // += je zkr�cen�m vystup = vystup + text
                // operator + u �etezc� umo�nuje jejich spojeni
                // promenna Environment.NewLine vkl�d� odsazen�
                // na novy �adek v z�vislosti na typu OS
                vystup += $"{TxtText.Text}{Environment.NewLine}";
            }
            LblVypis.Text = vystup;
        }
    }
}