namespace _16_Trezor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnWork_Click(object sender, EventArgs e)
        {
            int cislo = (int) NumCislo.Value;
            LblVystup.Text = $"{cislo}";
            if (RadBlue.Checked)
            {
                LblVystup.BackColor = Color.Blue;
            }
            if (RadGreen.Checked)
            {
                LblVystup.BackColor = Color.Green;
            }
        }
    }
}