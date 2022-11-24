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
            return (suma == number)?"Dokonalé èíslo" +Environment.NewLine : "";
        }

        private string GetPrime(int number)
        {
            if (number <= 1) return "";
            for(int i = 2; i < number / 2; i++)
            {
                if (number % i == 0) return "";
            }
            return "prvoèíslo" + Environment.NewLine;

        }

        private string GetDividers(int number)
        {
            string dividers = "";
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0) dividers += $"{i}, ";
            }


            return $"Dìlitelé: {dividers}";

        }

        private string GetEvenOdd(int number)
        {
            return (number % 2 == 0) ? "sudé" + Environment.NewLine : "liché" + Environment.NewLine;
        }

        private string GetSign(int number)
        {
            if(number == 0) return "èíslo je 0" + Environment.NewLine;
            // využití ternárního operátoru
            return (number > 0) ? "kladné" + Environment.NewLine : "záporné"+ Environment.NewLine;
        }

        private string GetCifry(string text)
        {
            return $"Cislo má {text.Length} cifer." + Environment.NewLine;
        }
    }
}