namespace _21_KvadratickaRovnice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCompute_Click(object sender, EventArgs e)
        {
            int a, b, c;
            // vymazani v�stup�
            TxtD.Text = "";
            TxtX1.Text = "";
            TxtX2.Text = "";


            try
            {
                // na�ten� koeficient� rovnice
                a = int.Parse(TxtA.Text);
                b = int.Parse(TxtB.Text);
                c = int.Parse(TxtC.Text);

                if(a == 0)
                {
                    MessageBox.Show("Nejedn� se o kvadratickou rovnici");
                    return;
                }
                double d = SpocitejDiskriminant(a, b, c);
                if (d < 0) {
                    MessageBox.Show("Rovnice nem� �e�en� v oboru re�ln�ch ��sel.");
                    return;
                }
                double x1 = (Math.Sqrt(d) - b) / (2 * a);
                double x2 = (Math.Sqrt(d) + b) / (2 * a);

                TxtD.Text = $"{d}";
                // zakrouhlen� v�sledku na dv� desetinn� m�sta
                TxtX1.Text = $"{Math.Round(x1,2)}";
                TxtX2.Text = $"{Math.Round(x2,2)}";


            }catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// V�po�et diskriminantu kvadratick� rovnice
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>diskriminant</returns>
        private double SpocitejDiskriminant(int a, int b, int c)
        {
            return b * b - 4.0 * a * c;
        }
    }
}
