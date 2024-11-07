using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Transakce
{
   public class User
    {
        private string name;
        private string surname;
        private List<Account> acc = new List<Account>();

        public string Name { get { return name; } }
        public string Surname { get { return surname; } }
        public List<Account> Acc { get { return acc; } }
        public User(string n, string s)
        {
            name = n;
            surname = s;
            double acc_id = Math.Round(Account.GenerateId());
            acc.Add( new Account(acc_id));
        }

        public void AddAccount()
        {
            acc.Add(new Account(Math.Round(Account.GenerateId())));
        }

        public override string ToString()
        {
            return $"{name} {surname} [{acc.Count}]";
        }

    }
}
