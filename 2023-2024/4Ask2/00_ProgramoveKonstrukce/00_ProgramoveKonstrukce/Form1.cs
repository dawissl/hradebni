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
            int[] pole = { 7, 11, 3, 18, 2 };

            double cislo1 =5;
            double cislo2 = 21;

            string vystup = "";

            //$ = alt + 36
            //použiti aritmetického operatoru
            vystup += $"{cislo1 / cislo2}{Environment.NewLine}";
            //použiti relaèního operatoru
            vystup += $"{cislo1 >= cislo2}{Environment.NewLine}";

            //vypsat na vystup informaci zda je cislo1 a cislo2 stejne
            //pripadne, které z èísel je vìtší
            if (cislo1 == cislo2)
            {
                vystup += $"Èísla jsou stejná{Environment.NewLine}";
            }
            else
            {
                if (cislo1 > cislo2)
                {
                    vystup += $"Èíslo 1 je vìtší{Environment.NewLine}";

                }
                else
                {
                    vystup += $"Èíslo 2 je vìtší{Environment.NewLine}";

                }
            }

            while(cislo1 != cislo2)
            {
                if(cislo1 > cislo2)
                {
                    // zvetsujeme cislo 2
                    cislo2++;
                    vystup += $"{cislo2}, ";
                }
                else
                {
                    // zvetsujem cislo 1
                    cislo1++;
                    vystup += $"{cislo1}, ";
                }
            }

            LblOutput.Text = vystup;
        }
    }
}