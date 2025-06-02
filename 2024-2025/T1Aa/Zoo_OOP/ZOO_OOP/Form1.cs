namespace ZOO_OOP
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
            if (CheckPlaz.Checked)
            {
                z = new Plaz(jmeno, porodniVaha, true);
            }
            else
            {
                z = new Zvire(jmeno, porodniVaha);
            }
            ListZvirata.Items.Add(z);

        }

        private void BtnAging_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListZvirata.Items.Count; i++)
            {
                (ListZvirata.Items[i] as Zvire).Starnuti();
                ListZvirata.Items[i] = ListZvirata.Items[i];
            }
            ListZvirata.Refresh();
        }

        private void BtnFeed_Click(object sender, EventArgs e)
        {
            if (ListZvirata.SelectedIndex == -1)
            {
                MessageBox.Show("je potøeba zvolit zvíøe");
            }
            else
            {
                int jidlo = int.Parse(TxtFood.Text);
                (ListZvirata.Items[ListZvirata.SelectedIndex] as Zvire).Krmeni(jidlo);
            }
        }
    }
}
