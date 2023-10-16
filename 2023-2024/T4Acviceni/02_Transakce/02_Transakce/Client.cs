using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Transakce
{
    internal class Client
    {

        private long id_client;
        private string name;
        private string surname;
        private string email;
        private string phone;
        private List<ConnectionClientAccount> connections = new List<ConnectionClientAccount>();

        public long ID_Client { get { return id_client; } }
        public string Name { get { return name; } }
        public string Surname { get { return surname; } }
        public string Email { get { return email; } }
        public List<ConnectionClientAccount> Connections { get { return connections; } }

        public Client(long id, string n, string s, string e, string p)
        {
            id_client = id;
            name = n;
            surname = s;
            email = e;
            phone = p;
        }

        public override string ToString()
        {
            return $"{ID_Client} {Name} {Surname} {Email}";
        }


    }
}
