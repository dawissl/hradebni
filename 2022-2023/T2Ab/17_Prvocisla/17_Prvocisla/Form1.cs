namespace _17_Prvocisla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGetPrimes_Click(object sender, EventArgs e)
        {
            int left = (int)NumLeft.Value;
            int right = (int)NumRight.Value;

            if (left > right)
            {
                int t = left;
                left = right;
                right = t;
            }

            string tmp = "";
            for (int i = left; i <= right; i++)
            {
                if (IsPrime(i)) tmp += $"{i}, ";
            }
            if (tmp.Length == 0) tmp = "V zadanem rozsahu se nenachazi prvocisla";
            LblPrimes.Text = tmp;
        }

        /// <summary>
        /// Funkce ovìøující zda je èíslo prvoèíslem
        /// </summary>
        /// <param name="num"> vstupní èíslo ke kontrole</param>
        /// <returns>true pokud se jedná o prvoèíslo</returns>
        private bool IsPrime(int num)
        {
            if (num < 2) return false;
            if (num == 2) return true;
            for (int i = 2; i <= num / 2; i++)

            {
                if (num % i == 0) return false;
            }

            return true;

        }
    }
}