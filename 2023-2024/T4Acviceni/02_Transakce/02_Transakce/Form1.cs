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
            /* int countA = 0;
             int countB = 0;

             for (int i = 0; i < 1000; i++)
             {
                 double val = Randomizer();
                 if (val == 1) countA++;
                 else countB++;
             }
             MessageBox.Show($"% of 1 {countA}\n% of non 1 {countB}");
            */



            MessageBox.Show("Naèítání databáze banky");
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                superBanka.CreateClient();
                for (int j = 0; j < random.Next(1, 5); j++)
                {
                    superBanka.CreateAccount(i, Randomizer());
                    superBanka.Accounts[superBanka.Accounts.Count - 1].Deposit = random.Next(200, 5001);
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

        private void ComboAccountA_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void BtnTransfer_Click(object sender, EventArgs e)
        {
            long accA = long.Parse(ComboAccountA.Text.Trim()[0].ToString());
            long accB = long.Parse(ComboAccountB.Text.Trim()[0].ToString());
            superBanka.TransferMoney(accA, accB, (double)NumMoney.Value);
            RefreshBank();
        }

        private void RefreshBank()
        {

            TxtOutput.Text = superBanka.ToString();
        }
    }
}