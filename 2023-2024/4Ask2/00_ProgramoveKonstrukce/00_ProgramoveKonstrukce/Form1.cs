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
            //pou�iti aritmetick�ho operatoru
            vystup += $"{cislo1 / cislo2}{Environment.NewLine}";
            //pou�iti rela�n�ho operatoru
            vystup += $"{cislo1 >= cislo2}{Environment.NewLine}";

            //vypsat na vystup informaci zda je cislo1 a cislo2 stejne
            //pripadne, kter� z ��sel je v�t��
            if (cislo1 == cislo2)
            {
                vystup += $"��sla jsou stejn�{Environment.NewLine}";
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