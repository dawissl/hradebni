
using System.Collections.Immutable;
/**
* Nad vstupními hodnotami, které mohou být zadány ruènì pøípadnì náhodnì vygenerovány,
* proveïte statistickou analýzu.
* Sledované výstupy nad hodnotami jsou:
* modus, medián, kvartily, minimum, maximum a prùmìrná hodnota
* 
* Rozšíøení - vstupní hodnoty vhodnì reprezentujte pomocí grafu * 
*/
namespace _02_Statisticka_analyza
{
    public partial class Form1 : Form
    {
        private int[] data;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            data = new int[(int) NumDataSize.Value];
            Random rnd = new Random();
            for(int i =0;i< data.Length; i++)
            {
                data[i] = rnd.Next(1,51);
            }
            // seøazení pole
            Array.Sort(data);
            string vystupData = "";
            for (int i = 0; i < data.Length; i++)
            {
                vystupData += $"{data[i]}, ";
            }
            LblData.Text = vystupData;
        }

        private void BtnAnalyze_Click(object sender, EventArgs e)
        {
            LblMin.Text = $"{FindMin()}";
            LblMax.Text = $"{FindMax()}";
            LblAvg.Text = $"{FindAvg()}";

            LblModus.Text = $"{FindModus()}";
            LblMedian.Text = $"{FindMedian()}";

            Lbl1Q.Text = $"{FindQuartil(1)}";
            Lbl3Q.Text = $"{FindQuartil(3)}";
            
        }

        private int FindMin()
        {
            return data[0];
        }

        private int FindMax()
        {
            return data[data.Length-1];
        }

        private double FindAvg()
        {
            return data.Average();
        }

        private int FindModus()
        {
            return -1;
        }
        private double FindMedian()
        {

            
            if(data.Length %2 == 1)
            {
                return data[data.Length / 2];
            }
            else
            {
                return (data[data.Length / 2] + data[data.Length / 2 + 1]) / 2;
            }
        }

        private int FindQuartil(int quartil)
        {
            if(quartil == 1)
            {
                return data[(int)((data.Length - 1) * 0.25)+1];
            }

            if(quartil == 3)
            {
                return data[(int)((data.Length - 1) * 0.75)];
            }

            return -1;
        }
    }
}