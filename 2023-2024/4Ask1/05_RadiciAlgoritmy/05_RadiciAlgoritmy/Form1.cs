namespace _05_RadiciAlgoritmy
{
    public partial class Form1 : Form
    {
        private int[] pole = new int[20];
        private Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            GenerateArray();
        }

        private int[] GenerateArray()
        {
            for (int i = 0; i < 20; i++)
            {
                pole[i] = rnd.Next(1, 51);
            }
            return pole;
        }

        private void BtnInsertion_Click(object sender, EventArgs e)
        {
            GenerateArray();
            // TODO - Insertion sort
            PrintArray();
        }

        private void BtnBubble_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < pole.Length; i++)
            {
                for (int j = 0; j < pole.Length - 1 - i; j++)
                {
                    if (pole[j] > pole[j + 1])
                    {
                        int tmp = pole[j];
                        pole[j] = pole[j + 1];
                        pole[j + 1] = tmp;
                    }
                }
            }
            PrintArray();
        }

        private void PrintArray()
        {
            string tmp = "";
            foreach (int value in pole)
            {
                tmp += $"{value}, ";
            }
            TxtSorted.Text = tmp;
        }
    }
}