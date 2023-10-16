using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Transakce
{
    internal class Bank
    {
        private long last_account_id = 0;
        private long last_connection_id = 0;
        private long last_client_id = 0;

        private double baseDeposit = 0;
        private double investDeposit = 0;

        private List<Client> clients = new List<Client>();
        private List<Account> accounts = new List<Account>();
        private List<ConnectionClientAccount> connections = new List<ConnectionClientAccount>();


        public long Last_acc_id { get { return last_account_id; } set { last_account_id++; } }
        public long Last_connection_id { get { return last_connection_id; } set { last_connection_id++; } }
        public long Last_client_id { get { return last_client_id; } set { last_client_id++; } }

        public List<Client> Clients { get { return clients; } }
        public List<Account> Accounts { get { return accounts; } }
        public List<ConnectionClientAccount> Connections { get { return connections; } }

        public double BaseDeposit { get { return baseDeposit; } set { baseDeposit = EditBaseDeposit(value); } }
        public double InvestDeposit { get { return investDeposit; } set { investDeposit = EditInvestDeposit(value); } }

        private double EditInvestDeposit(double value)
        {
            return investDeposit += value;
        }

        private double EditBaseDeposit(double value)
        {
            return baseDeposit += value;
        }

        public void CreateClient()
        {
            string[] names = { "Kamil", "Mirek", "Petr", "Otakar", "Richard", "Ludvík", "Gabriel" };
            string[] surnames = { "Svoboda", "Novotný", "Němec", "Tužil", "Hácha", "Král", "Syrový"};
            Random r = new Random();
            string n = names[r.Next(0,7)];
            string s = surnames[r.Next(0, 7)];
            clients.Add(new Client(Last_client_id, n, s, $"{n}.{s}@mail.cz", $"{r.Next()}"));
            Last_client_id = 1;
        }

        public void CreateClient(double interest)
        {
            CreateClient();
            CreateAccount(Last_client_id, interest);
        }

        public void CreateAccount(long client_id, double interest)
        {
            accounts.Add(new Account(Last_acc_id, interest));
            Last_acc_id = 1;
            ConnectionClientAccount newConnection = new ConnectionClientAccount(last_connection_id, client_id, Last_acc_id);
            connections.Add(newConnection);
            Last_connection_id = 1;
            Client tmpC = clients.Find(x => x.ID_Client == client_id);
            if (tmpC != null)
            {
                tmpC.Connections.Add(newConnection);
            }
            else
            {
                MessageBox.Show("Invalid clinet id");
            }
            accounts[accounts.Count - 1].ID_Connection = last_connection_id;
        }

        /// TODO
        /// 1 . editace konta zákazníka a jeho účtu
        /// 2. transakce mezi dvěma účty
        ///     a. účty jsou u jednoho zákazníka
        ///     b. účty patří různýnm zákazníkům
        ///     



        public void InsertMoneyToAccount(long account_id, double money)
        {
            long account_index = -1;
            foreach (Account a in accounts)
            {
                if (a.ID_account == account_id)
                {
                    account_index = (int)a.ID_account;
                    break;
                }
            }

            if (account_index == -1)
            {
                MessageBox.Show("Transaction error - invalid account");
                return;
            }
            // now we have index of account

            accounts[(int)account_index].Deposit = money;

            if (accounts[(int)account_index].IsInterest)
            {
                InvestDeposit = money;
            }
            else
            {
                BaseDeposit = money;
            }
        }

        public void TransferMoney(long id_acc_from, long id_acc_to, double amount)
        {

            Account acc_from = null;
            Account acc_to = null;

            foreach (Account a in accounts)
            {
                if (a.ID_account == id_acc_from)
                {
                    acc_from = a;
                }
                else if (a.ID_account == id_acc_to)
                {
                    acc_to = a;
                }
            }

            // | = alt + 124
            if (acc_from == null || acc_to == null)
            {
                MessageBox.Show("Neexistující některý z účtů");
            }
            else
            {
                acc_from.Deposit = -amount;
                acc_to.Deposit = amount;

                // transfer mezi účty různého typu
                if (acc_from.IsInterest != acc_to.IsInterest)
                {
                    if (acc_from.IsInterest)
                    {
                        BaseDeposit = amount;
                        InvestDeposit = -amount;
                    }
                    else
                    {
                        BaseDeposit = -amount;
                        InvestDeposit = amount;
                    }
                }
            }



        }

        public override string ToString()
        {
            string vypis = "";
            foreach (Client c in clients)
            {
                vypis += c.ToString() + Environment.NewLine;
                foreach (ConnectionClientAccount connection in c.Connections)
                {
                    Account account = accounts.Find(x => x.ID_account == connection.ID_Account);
                    if (account != null)
                    {
                        vypis += account.ToString() + Environment.NewLine;
                    }
                }
            }
            return vypis;
        }



    }





}

