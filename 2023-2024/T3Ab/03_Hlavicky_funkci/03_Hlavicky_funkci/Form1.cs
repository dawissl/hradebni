namespace _03_Hlavicky_funkci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnF1_Click(object sender, EventArgs e)
        {
            new Function_01().ShowDialog();
        }

        private void BtnF2_Click(object sender, EventArgs e)
        {
            new Function_02().ShowDialog();
        }
    }
}