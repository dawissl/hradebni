namespace _07_VanocniPruvod
{
    public partial class Form1 : Form
    {
        private int max = 0;
        private int index = -1;

        private int suma = 0;
        private int tmpIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSearch1_Click(object sender, EventArgs e)
        {

            Reset();
            foreach (char c in (TxtInput.Text + " "))
            {
                if (c == ',') continue;

                if (c == ' ')
                {
                    // TODO porovnání aktuálního elfa s nejlepším
                    if (suma > max)
                    {
                        // aktualiazce hodnot
                        max = suma;
                        index = tmpIndex;
                    }
                    tmpIndex++;
                    suma = 0;
                }
                else
                {
                    // TODO práce na aktuální elfovi
                    suma += (int)Char.GetNumericValue(c);

                }
            }
            // $ = alt + 36
            LblOut.Text = $"Nejelpší elf je na pozici {index} s mnozstvim {max}";
        }



        private void Reset()
        {
            max = 0;
            index = 0;
            suma = 0;
            tmpIndex = 0;
        }

        private void BtnSearch2_Click(object sender, EventArgs e)
        {
            Reset();
            string[] vstup = (TxtInput.Text + " ").Split(",");
            for (int i = 0; i < vstup.Length; i++)
            {
                if (vstup[i] == " ")
                {
                    // porovnani
                    if (suma > max)
                    {
                        max = suma;
                        index = tmpIndex;
                    }
                    suma = 0;
                    tmpIndex++;
                }
                else
                {
                    // prace na aktualnim
                    suma += int.Parse(vstup[i]);
                }
            }
            LblOut.Text = $"Nejelpší elf je na pozici {index} s mnozstvim {max}";

        }

       
    }
}