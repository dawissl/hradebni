using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Transakce
{
    internal class ConnectionClientAccount
    {
        private long id_client;
        private long id_account;
        private long id_connection;

        public long ID_Client {  get { return id_client; } }
        public long ID_Account {  get { return id_account; } }
        public long ID_Connection {  get { return id_connection; } }


        public ConnectionClientAccount(long connection, long client, long account)
        {
            id_client = connection;
            id_client = client;
            id_account = account;
        }
    }
}
