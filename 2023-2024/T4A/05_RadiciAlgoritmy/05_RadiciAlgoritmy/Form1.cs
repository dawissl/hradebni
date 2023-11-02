namespace _05_RadiciAlgoritmy
{
    public partial class Form1 : Form
    {
        private int[] pole;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnbubble_Click(object sender, EventArgs e)
        {
            GenerateArray(20);
            BubbleSort();
            PrintArray();
        }

        /// <summary>
        ///  Funkce generujici hodnoty do pole v rozashu 1 - 99
        /// </summary>
        /// <param name="n">velikost pro novì generované pole</param>
        public void GenerateArray(int n)
        {
            pole = new int[n];
            Random rnd = new();
            for (int i = 0; i < n; i++)
            {
                pole[i] = rnd.Next(1, 100);
            }
        }

        /// <summary>
        /// Vypsání hodnot z pole do pøipraveného textboxu TxtOut
        /// </summary>
        public void PrintArray()
        {
            string arr = "";
            foreach (int i in pole)
            {
                arr += $"{i}, ";
            }
            Txtout.Text = arr;
        }

        public void BubbleSort()
        {
            for (int i = 0; i < pole.Length; i++)
            {
                for (int j = 0; j < pole.Length - 1 - i; j++)
                {
                    if (pole[j] > pole[j + 1])
                    {
                        (pole[j + 1], pole[j]) = (pole[j], pole[j + 1]);
                    }
                }
            }

        }

        public void InsertionSort()
        {
            for (int i = 1; i < pole.Length; i++)
            {
                int klic = pole[i];
                int indexSerazenych = i - 1;

                while (indexSerazenych >= 0 && pole[indexSerazenych] > klic)
                {
                    pole[indexSerazenych + 1] = pole[indexSerazenych];
                    indexSerazenych--;
                }
                pole[indexSerazenych + 1] = klic;
            }
        }

        private void BtnIsert_Click(object sender, EventArgs e)
        {
            GenerateArray(20);
            InsertionSort();
            PrintArray();
        }
    }
}