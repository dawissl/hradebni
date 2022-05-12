namespace NakupniKosik
{
    public partial class Form1 : Form
    {
        private Kosik mujKosik = new Kosik();
        public Form1()
        {
            InitializeComponent();
        }

        private void ComboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboType.Text)
            {
                case "zboží":
                    TxtStoring.Enabled = false;
                    TxtFor.Enabled = false;
                    break;
                case "drogerie":
                    TxtStoring.Enabled = false;
                    TxtFor.Enabled = true;
                    break;
                case "potravina":
                    TxtStoring.Enabled = true;
                    TxtFor.Enabled = false;
                    break;
            }
        }

        private void BtnEmpty_Click(object sender, EventArgs e)
        {
            LblShoppingList.Text = "";
            LblTotalPrice.Text = "";
            mujKosik = new Kosik();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
           
            if(TxtName.Text == "" || TxtPrice.Text == "")
            {
                MessageBox.Show("Chybìjící hodnoty!");
                return;
            }
            Zbozi z = null;
            switch (ComboType.Text)
            {
                case "zboží":
                    z = new Zbozi(TxtName.Text,double.Parse(TxtPrice.Text),(int)NumCount.Value);
                    break;
                case "drogerie":
                    z = new Drogerie(TxtName.Text, double.Parse(TxtPrice.Text), (int)NumCount.Value,TxtFor.Text);
                    break;
                case "potravina":
                    z = new Potravina(TxtName.Text, double.Parse(TxtPrice.Text), (int)NumCount.Value, TxtStoring.Text);
                    break;
                default:
                    MessageBox.Show("nezvolen typ");
                    return;
            }
            mujKosik.PridejZbozi(z);

            LblShoppingList.Text = mujKosik.ToString();
            LblTotalPrice.Text = $"{mujKosik.TotalPrice()} Kè";
	    ResetForm();
          
        }

	private void ResetForm()
	{
	    TxtName.Text = "";
	    TxtPrice.Text = "";
	    NumCount.Value = 1;
	    TxtFor.Text="";
            TxtStoring.Text="";
	}
    }
}