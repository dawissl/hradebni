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
            LblOut.Text = "";
            int number = int.Parse(TxtNumber.Text);

            LblOut.Text += GetEvenOdd(number);

            LblOut.Text += GetDividers(number);

            LblOut.Text += GetCiphers(TxtNumber.Text);

            LblOut.Text += GetSign(number);

            LblOut.Text += GetPrime(number);

            LblOut.Text += GetPerfect(number);
        }

        private string GetPerfect(int number)
        {
            int suma = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0) suma += i;
            }
            return (suma == number) ? "dokonalé èíslo" + Environment.NewLine : "";
        }

        private string GetPrime(int number)
        {
            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0) return "";
            }
            return "prvoèíslo" + Environment.NewLine;
        }

        private string GetSign(int number)
        {
            if (number == 0) return "";
            return (number > 0)
                ? $"kladné { Environment.NewLine}" :
                "záporné" + Environment.NewLine;

        }

        private string GetCiphers(string text)
        {
            if (int.Parse(text) < 0) return $"Èíslo má {text.Length - 1} cifer";
            return $"Èíslo má {text.Length} cifer {Environment.NewLine}";
        }

        private string GetDividers(int number)
        {
            string dividers = "";
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0) dividers += $"{i}, ";
            }

            return $"Dìlitelé: {dividers} {Environment.NewLine}";

        }

        private string GetEvenOdd(int number)
        {
            return (number % 2 == 0) ? "sudé" + Environment.NewLine : "liché" + Environment.NewLine;
        }
    }
}