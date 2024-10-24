namespace _04_Faktorial
{
    public partial class Form1 : Form
    {
        private int number;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFact_Click(object sender, EventArgs e)
        {
            try
            {
                number = int.Parse(TxtInput.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Neplatný vstup");
                return;
            }
            if (number < 0)
            {
                MessageBox.Show("Vložte nezáporné èíslo");
                return;
            }

             LblResult.Text = $"{FactorialRecursion(number)}";
            //LblResult.Text = $"{Factorial(number)}";
        }

        private int Factorial(int n)
        {
            int f = 1;
            if (n == 0 || n == 1) return f;
            for (int i = n; i > 1; i--)
            {
                f *= i;
            }
            return f;
        }

        private int FactorialRecursion(int n)
        {
            if (n == 0 || n == 1) return 1;
            return n * FactorialRecursion(n - 1);
        }


    }
}
