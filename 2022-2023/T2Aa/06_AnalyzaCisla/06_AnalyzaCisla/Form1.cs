namespace _06_AnalyzaCisla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAnalyze_Click(object sender, EventArgs e)
        {
            LblResult.Text = "";
            int number = int.Parse(TxtNumber.Text);

            LblResult.Text += GetCifry(TxtNumber.Text);

            LblResult.Text += GetSign(number);

            LblResult.Text += GetEvenOdd(number);

            LblResult.Text += GetDividers(number);

            LblResult.Text += GetPrime(number);

            LblResult.Text += GetPerfect(number);
        }

        private string GetPerfect(int number)
        {
            int suma = 0;
            for(int i = 1; i < number; i++)
            {
                if (number % i == 0) suma += i;
            }
            return (suma == number)?"Dokonal� ��slo" +Environment.NewLine : "";
        }

        private string GetPrime(int number)
        {
            if (number <= 1) return "";
            for(int i = 2; i < number / 2; i++)
            {
                if (number % i == 0) return "";
            }
            return "prvo��slo" + Environment.NewLine;

        }

        private string GetDividers(int number)
        {
            string dividers = "";
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0) dividers += $"{i}, ";
            }


            return $"D�litel�: {dividers}";

        }

        private string GetEvenOdd(int number)
        {
            return (number % 2 == 0) ? "sud�" + Environment.NewLine : "lich�" + Environment.NewLine;
        }

        private string GetSign(int number)
        {
            if(number == 0) return "��slo je 0" + Environment.NewLine;
            // vyu�it� tern�rn�ho oper�toru
            return (number > 0) ? "kladn�" + Environment.NewLine : "z�porn�"+ Environment.NewLine;
        }

        private string GetCifry(string text)
        {
            return $"Cislo m� {text.Length} cifer." + Environment.NewLine;
        }
    }
}