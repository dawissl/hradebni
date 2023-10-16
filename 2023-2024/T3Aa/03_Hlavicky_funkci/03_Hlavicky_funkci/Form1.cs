namespace _03_Hlavicky_funkci
{
    public partial class Form1 : Form
    {
        int time = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFce1_Click(object sender, EventArgs e)
        {
            

        }

        private void BtnFce1_Click_1(object sender, EventArgs e)
        {
          //  new Function_01().ShowDialog();

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time >=0)
            {
                BtnFce1.Text = $"{time}";
                time -= 1;
            }
            else
            {
                
                timer1.Stop();
                MessageBox.Show("konec");
            }
            


        }
    }
}