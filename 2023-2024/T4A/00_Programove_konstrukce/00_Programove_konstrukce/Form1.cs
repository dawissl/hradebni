namespace _00_Programove_konstrukce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnWork_Click(object sender, EventArgs e)
        {
            int[] poleCisel = { 2, 8, 9, 16, 18, 1, 7 };

            double cislo1 = 15;
            double cislo2 =6;

            string vystup = "";

            //$ = alt + 36
            vystup += $"{cislo1 * cislo2}{Environment.NewLine}";

            vystup += $"{cislo1 == cislo2}{Environment.NewLine}";

            if( cislo1 == cislo2)
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



            if(cislo1 != cislo2)
            {
                do
                {
                    if( cislo1 < cislo2)
                    {
                        cislo1++;
                    }
                    else
                    {
                        cislo2++;
                    }
                    
                    vystup += $"{cislo1}{Environment.NewLine}";
                } while (cislo1 != cislo2);
            }

           




            LblVystup.Text = vystup;


        }
    }
}