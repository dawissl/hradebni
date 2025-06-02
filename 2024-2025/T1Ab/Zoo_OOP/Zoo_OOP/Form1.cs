namespace Zoo_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string jmeno = TxtName.Text;
            double porodniVaha = double.Parse(TxtWeight.Text);

            Zvire z;
            if (CheckSavec.Checked)
            {
                z = new Savec(jmeno, porodniVaha, "aaaa");
            }
            else
            {
                z = new Zvire(jmeno, porodniVaha);
            }

             ListZvirata.Items.Add(z);
        }

        private void BtnAging_Click(object sender, EventArgs e)
        {
            if (ListZvirata.SelectedIndex == -1) {
                MessageBox.Show("Je nutné vybrat položku.");
            }
            else
            {
                (ListZvirata.Items[ListZvirata.SelectedIndex] as Zvire).Starnuti();
                ListZvirata.Items[ListZvirata.SelectedIndex] = ListZvirata.Items[ListZvirata.SelectedIndex];
            }
            ListZvirata.Refresh();
        }
    }
}
