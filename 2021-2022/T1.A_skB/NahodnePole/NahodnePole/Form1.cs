namespace NahodnePole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            int velikostPole = int.Parse(TxtSize.Text);
            int maximum = int.Parse(TxtMax.Text);
            int minimum = int.Parse(TxtMin.Text);

            if (maximum < minimum)
            {
                int tmp = minimum;
                minimum = maximum;
                maximum = tmp;
                TxtMax.Text = maximum.ToString();
                TxtMin.Text = minimum.ToString();
            }
            double[] novePole = new double[velikostPole];

            Random rnd = new Random();
            string retezec = "";

            for (int i = 0; i < velikostPole; i++)
            {
                novePole[i] = rnd.Next(minimum, maximum + 1);


                retezec += novePole[i].ToString() + " ";
            }

            LblOut.Text = retezec;
        }


    }
}