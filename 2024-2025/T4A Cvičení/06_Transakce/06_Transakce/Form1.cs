namespace _06_Transakce
{
    public partial class Form1 : Form
    {
        private List<User> users = new List<User>();
        public Form1()
        {
            InitializeComponent();
            InitDefaultUsers();
            // InitDefaultAccounts();
        }

        private void InitDefaultUsers()
        {
            string[] jmena = { "Jan", "Petr", "Lukáš", "Martin", "Tomáš", "Ondøej", "Jakub", "Adam", "Filip", "Michal" };
            string[] prijmeni = { "Novák", "Svoboda", "Novotný", "Dvoøák", "Èerný", "Procházka", "Kuèera", "Veselý", "Horák", "Jelínek" };

            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                users.Add(new User(jmena[rnd.Next(jmena.Length)], prijmeni[rnd.Next(prijmeni.Length)]));
                ComboUserFrom.Items.Add(users[i]);
                users[i].Acc[0].InsertMoney(rnd.Next(100, 1000));
                if (i == 5) users[i].AddAccount();
                ComboUserTo.Items.Add(users[i]);
            }
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
            Account from = users[ComboUserFrom.SelectedIndex].Acc[ComboAccFrom.SelectedIndex];
            Account to = users[ComboUserTo.SelectedIndex].Acc[ComboAccTo.SelectedIndex];
            
            if (from == to)
            {
                MessageBox.Show("Vyberte odlišné úèty");
                return;
            }
            from.TransferMoney(to, double.Parse(TxtMoney.Text));
            RefreshForm();

        }

        private void RefreshForm()
        {
            List<Account> list = new List<Account>();
            foreach (Account a in ListAccs.Items)
            {
                list.Add(a);
            }
            ListAccs.Items.Clear();
            foreach (Account a in list)
            {
                ListAccs.Items.Add((Account)a);
            }

            TxtMoney.Text = "";
        }

        private Account GetAccountById(double id)
        {

            foreach (Account a in ListAccs.Items)
            {
                if (a.ID == id) return a;
            }
            throw new Exception("Account not found");
        }

        private void ComboFrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboUserFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboAccFrom.Items.Clear();
            foreach (Account a in users[ComboUserFrom.SelectedIndex].Acc)
            {
                ComboAccFrom.Items.Add(a);
            }
        }

        private void ComboUserTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboAccTo.Items.Clear();
            foreach (Account a in users[ComboUserTo.SelectedIndex].Acc)
            {
                ComboAccTo.Items.Add(a);
            }
        }
    }
}
