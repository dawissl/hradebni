namespace _21_VyhledavaciStrom
{
    public partial class Form1 : Form
    {
        private VyhledavaciStrom strom = new VyhledavaciStrom();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int value;
            if(TxtValue.Text == "")
            {
                value = new Random().Next(1, 101);
            }
            else
            {
                value = int.Parse(TxtValue.Text);
            }

            strom.VlozitUzel(value);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int value;
            if (TxtValue.Text == "")
            {
                value = new Random().Next(1, 101);
            }
            else
            {
                value = int.Parse(TxtValue.Text);
            }

            Uzel u = strom.VyhledatUzel(value);
            if(u != null)
            {
                MessageBox.Show("Uzel nalezen");
            }
            else
            {
                MessageBox.Show("Uzel NEnalezen");
            }
        }
    }
}