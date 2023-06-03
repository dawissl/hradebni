namespace _17_Prvocisla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LblPrimes_Click(object sender, EventArgs e)
        {          


        }

        /// <summary>
        /// Funkce zjistujici, zda je vstupni cislo prvocislem
        /// </summary>
        /// <param name="num">vstupn� ��slo</param>
        /// <returns> true pokud je ��slo prvo��slem</returns>
        private bool IsPrime(int num)
        {
            bool prime = true;
            if (num == 1) return false;
            if (num == 2) return prime;
            for(int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)            
                    prime = false;                  
            
                    
            }                

            return prime;
            
        }

        private void BtnGetPrimes_Click(object sender, EventArgs e)
        {
            int left = Convert.ToInt32(NumLeft.Value);
            int right = Convert.ToInt32(NumRight.Value);

            // prohozen� hodnot
            if (left > right)
            {
                int tmp = left;
                left = right;
                right = tmp;
            }

            // vyhledani prvocisel
            string primes = "";
            for (int i = left; i <= right; i++)
            {
                if (IsPrime(i)) primes += $"{i}, ";
            }
            if (primes.Length == 0)
                primes = "V zadan�m intervalu nejsou prvo��sla";
            LblPrimes.Text = primes;
        }
    }
}