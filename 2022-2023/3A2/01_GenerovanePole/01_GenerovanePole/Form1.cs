namespace _01_GenerovanePole
{
    public partial class Form1 : Form
    {
        private int[] array;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            // vytvoøení pole o dané velikosti
            array = new int[(int)NumericArraySize.Value];
            LblGeneratedArray.Text = "";
            Random r = new Random();
            // naplnìní pole hodnotami <1,50>
            // $ = alt + 36
            // vypsání vygenerovaného pole do labelu
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(1, 51);
                LblGeneratedArray.Text += $"{array[i]}, ";
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (Check()) return;
            int suma = 0;

            for (int i = 0; i < array.Length; i++)
            {
                suma += array[i];
            }
            LblResult.Text = $"{suma}";
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            if (Check()) return;
            int suma = 1;

            for (int i = 0; i < array.Length; i++)
            {
                suma *= array[i];
            }
            LblResult.Text = $"{suma}";
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            if (Check()) return;
            LblResult.Text = $"{array.Max()}";
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
     
            if (Check()) return;
            LblResult.Text = $"{array.Min()}";

        }

        /// <summary>
        /// Util function for check generated array
        /// </summary>
        /// <returns>true if array is not generated</returns>
        private bool Check()
        {
            if (LblGeneratedArray.Text == "")
            {
                MessageBox.Show("Nejprve vygenerujete pole");
                return true;
            }
            return false;
        }
    }
}