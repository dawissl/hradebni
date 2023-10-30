namespace _00_ProgramoveKonstrukce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnWork_Click(object sender, EventArgs e)
        {
            int[] pole = { 2, 8, 9, 16, 1, 7, 19 };

            double cislo1 = 10;
            double cislo2 = 3;

            string vystup = "";

            //$ = alt + 36
            vystup += $"{cislo1 / cislo2}{Environment.NewLine}";
            vystup += $"{cislo1 >= cislo2}{Environment.NewLine}";

            if (cislo1 == cislo2)
            {
                vystup += $"Ob� ��sla jsou stejn�{Environment.NewLine}";
            }
            else
            {
                if (cislo1 > cislo2)
                {
                    vystup += $"��slo 1 je v�t��{Environment.NewLine}";
                }
                else
                {
                    vystup += $"��slo 2 je v�t��{Environment.NewLine}";

                }
            }

            // pokud jsou cisla ruzna, zv�t�ujeme men�� ��slo do t� doby
            // ne� jsou ob� ��sla stejn�

            if (cislo1 != cislo2)
            {
                if (cislo1 > cislo2)
                {
                    // zv�t�ujeme cislo2
                    do
                    {
                        cislo2++;
                        vystup += $"{cislo2}, ";

                    } while (cislo1 != cislo2);
                }
                else
                {
                    // zv�t�ujeme cislo1
                    do
                    {
                        cislo1++;
                        vystup += $"{cislo1}, ";

                    } while (cislo1 != cislo2);
                }
                vystup += Environment.NewLine;
            }


            LblOutput.Text = vystup;
        }
    }
}