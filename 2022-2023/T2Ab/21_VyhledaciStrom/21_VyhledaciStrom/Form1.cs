namespace _21_VyhledaciStrom
{
    public partial class Form1 : Form
    {
        VyhledavaciStrom strom = new VyhledavaciStrom();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int hodnota = int.Parse(TxtVal.Text);
            strom.Vlozit(hodnota);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int hodnota = int.Parse(TxtVal.Text);
            if(strom.Vyhledat(hodnota) == null)
            {
                MessageBox.Show("Hodnota nenalezena");
            }
            else
            {
                MessageBox.Show("Hodnota nalezena");
            }
        }
    }
}