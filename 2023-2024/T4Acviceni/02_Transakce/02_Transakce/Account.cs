using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Transakce
{
    internal class Account
    {
        private long id_account;
        private double deposit;
        private long id_connection;
        private double interest;


        public long ID_account { get { return id_account; } }
        public long ID_Connection { get { return id_connection; } set { id_connection = value; } }
        public double Deposit { get { return deposit; } set { deposit = EditDeposit(value); } }

        public bool IsInterest { get { return interest > 1; } }
        private double EditDeposit(double value)
        {
            if (value < 0)
            {
                if ((-1) * value > deposit)
                {
                    MessageBox.Show($"Nedostatečný zůstatek na účtu");
                    return deposit;
                }
                else
                {
                    return deposit += value;
                }
            }

            return deposit += value;
        }

        public Account(long id, double i)
        {
            id_account = id;
            deposit = 0;
            interest = i;
        }

        public override string ToString()
        {
            string typ = IsInterest ? "investiční" : "klasický";
            return $"\t{id_account} {typ} zůstatek: {Deposit}"; 
        }
    }
}
