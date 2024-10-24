namespace _06_Transakce
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            InitDefaultAccounts();
        }

        private void InitDefaultAccounts()
        {
            Random rnd = new Random();
            for (int i = 1; i <= 20; i += rnd.Next(1, 5))
            {
                Account a = new Account(i);
                a.InsertMoney(rnd.Next(5, 15) * 1000);
                ListAccs.Items.Add(a);
            }
        }

        private void BtnTransaction_Click(object sender, EventArgs e)
        {
            Account from = GetAccountById(double.Parse(TxtFromAcc.Text));
            Account to = GetAccountById(double.Parse(TxtToAcc.Text));
            // TODO check for different accounts
            from.TransferMoney(to, double.Parse(TxtMoney.Text));

            ListAccs.Refresh();
        }

        private Account GetAccountById(double id) { 
        
            foreach (Account a in ListAccs.Items)
            {
                if(a.ID == id) return a;
            }
            throw new Exception("Account not found");
        }
    }
}
