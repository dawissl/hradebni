using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace _02_Transakce
{
    public partial class Form1 : Form
    {
        private Bank superBanka = new Bank();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            MessageBox.Show("Naèítání databáze banky");
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                superBanka.CreateClient();
                for (int j = 0; j < random.Next(1, 5); j++)
                {
                    superBanka.CreateAccount(i, Randomizer());
                    superBanka.Accounts[superBanka.Accounts.Count - 1].Deposit = random.Next(200, 5001);
                    // fill deposit of bank
                    if (superBanka.Accounts[superBanka.Accounts.Count - 1].IsInterest)
                    {
                        superBanka.InvestDeposit = superBanka.Accounts[superBanka.Accounts.Count - 1].Deposit;
                    }
                    else
                    {
                        superBanka.BaseDeposit = superBanka.Accounts[superBanka.Accounts.Count - 1].Deposit;
                    }
                }
            }

            ComboUserA.Items.Clear();
            ComboUserB.Items.Clear();
            foreach (Client c in superBanka.Clients)
            {
                ComboUserA.Items.Add(c);
                ComboUserB.Items.Add(c);
            }


            TxtOutput.Text = superBanka.ToString();
        }

        /// <summary>
        /// Function return 1 in 70% of cases and value 1.1 - 1.5 in 30% of cases
        /// </summary>
        /// <returns>double from 1 to 1.5</returns>
        private double Randomizer()
        {
            Random rnd = new Random();

            int threshold = rnd.Next(1, 101);
            if (threshold <= 70)
            {
                return 1.0;
            }
            else
            {
                return 1 + rnd.Next(10, 51) / 100.0;
            }

        }

        private void ComboUserA_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboAccountA.Items.Clear();
            Client cA = superBanka.Clients[ComboUserA.SelectedIndex];

            foreach (ConnectionClientAccount con in cA.Connections)
            {
                Account acc = superBanka.Accounts.Find(x => x.ID_account == con.ID_Account);
                if (acc != null) ComboAccountA.Items.Add(acc);
            }
        }

        private void ComboUserB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboAccountB.Items.Clear();
            Client cB = superBanka.Clients[ComboUserB.SelectedIndex];

            foreach (ConnectionClientAccount con in cB.Connections)
            {
                Account acc = superBanka.Accounts.Find(x => x.ID_account == con.ID_Account);
                if (acc != null) ComboAccountB.Items.Add(acc);
            }
        }

        private void RefreshBank()
        {

            TxtOutput.Text = superBanka.ToString();
        }

        private void ComboUserA_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ComboAccountA.Items.Clear();
            Client cA = superBanka.Clients[ComboUserA.SelectedIndex];

            foreach (ConnectionClientAccount con in cA.Connections)
            {
                Account acc = superBanka.Accounts.Find(x => x.ID_account == con.ID_Account);
                if (acc != null) ComboAccountA.Items.Add(acc);
            }
        }


        private void ComboUserB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ComboAccountB.Items.Clear();
            Client cB = superBanka.Clients[ComboUserB.SelectedIndex];

            foreach (ConnectionClientAccount con in cB.Connections)
            {
                Account acc = superBanka.Accounts.Find(x => x.ID_account == con.ID_Account);
                if (acc != null) ComboAccountB.Items.Add(acc);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            TxtClasicDeposit.Text = superBanka.BaseDeposit.ToString();
            TxtInvestDeposit.Text = superBanka.InvestDeposit.ToString();
            TxtDepositSum.Text = (superBanka.BaseDeposit + superBanka.InvestDeposit).ToString();
        }

        private void BtnTransfer_Click_1(object sender, EventArgs e)
        {
           long accA = long.Parse(ComboAccountA.Text.Trim().Split(" ")[0].ToString());
           long accB = long.Parse(ComboAccountB.Text.Trim().Split(" ")[0].ToString());
           superBanka.TransferMoney(accA, accB, (double)NumMoney.Value);
        


            RefreshBank();
        }
    }
}