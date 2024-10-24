using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Transakce
{
    public class Account
    {
        private double account_id;
        private double money;

        public double ID { get { return account_id; } }

        public Account(double id)
        {
            this.account_id = id;
        }

        public void InsertMoney(double money)
        {
            if (money <= 0)
            {
                throw new ArgumentException("Invalid amount of money.");
            }
            this.money += money;
        }
        public double WithdrawMoney(double money)
        {
            if (money <= 0)
            {
                throw new ArgumentException("Invalid amount of money.");
            }
            if (money > this.money)
            {
                throw new Exception("Nedostatečný zůstatek");
            }
            this.money -= money;
            return this.money;
        }

        public void TransferMoney(Account destinationAccount, double money)
        {           
            destinationAccount.InsertMoney(money);
            WithdrawMoney(money);
        }

        public override string ToString()
        {
            return $"[{account_id}] - Zůstatek {money} Kč";
        }
    }
}
