

using System.Collections.Immutable;
/**
* 02_Statisticka_analyza
* 
* Nad vstupn�mi hodnotami, kter� mohou b�t zad�ny ru�n� p��padn� n�hodn� vygenerov�ny,
* prove�te statistickou anal�zu.
* Sledovan� v�stupy nad hodnotami jsou:
* modus, medi�n, kvartily, minimum, maximum a pr�m�rn� hodnota
* 
* Roz���en� - vstupn� hodnoty vhodn� reprezentujte pomoc� grafu
* 
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

        private void button1_Click(object sender, EventArgs e)
        {
            data = new int[(int)NumDataSize.Value];

            Random rnd = new Random();
            string vystupDat = "";

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = rnd.Next(1,51);
                
            }

            Array.Sort(data);
            for (int i = 0; i < data.Length; i++)
            {
                vystupDat += $"{data[i]}, ";
            }
            LblData.Text = vystupDat;

        }

        private void BtnAnalyze_Click(object sender, EventArgs e)
        {
            LblMin.Text = $"{FindMin()}";
            LblMax.Text = $"{FindMax()}";
            LblAvg.Text = $"{CountAvg()}";
            LblModus.Text = $"{FindModus()}";
            LblMedian.Text = $"{FindMedian()}";
            Lbl1Q.Text = $"{FindQuartil(1)}";
            Lbl3Q.Text = $"{FindQuartil(3)}";
        }

        private int FindMax()
        {
            return data[data.Length - 1];
        }

        private int FindMin()
        {
            return data[0];

        }
        private int FindModus()
        {
            return -1;
        }

        private double FindMedian()
        {
            if(data.Length%2 == 1)
            {
                return data[data.Length / 2 ];
            }
            else
            {
                return (data[data.Length / 2-1] + data[data.Length / 2 ]) / 2.0;
            }
        }

        private int FindQuartil(int q)
        {
            return -1;
        }

        private double CountAvg()
        {
            return data.Sum()/ (double)data.Length;
        }
    }
}