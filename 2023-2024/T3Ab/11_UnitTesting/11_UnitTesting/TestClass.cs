using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_UnitTesting
{
    public class TestClass
    {
        private int amount;
        private Color clr;

        public int Amount { get { return amount; } }
        public Color Clr { get { return clr; } }

        public TestClass()
        {
            amount = 100;
            clr = Color.Black;
        }

        public TestClass(int a)
        {
            amount = a;
            clr = Color.Black;
        }

        /// Výběr z účtu
        public string DecreaseAmount(int value)
        {
            if (value > amount)
            {
                return "Nedostatečný zůstatek";
            }

            amount -= value;

            if (amount == 0)
            {
                return "Konto vyčerpáno";
            }
            else
            {
                return $"Z účtu byla vybrána částka {value}";
            }
        }

        /// Optimální teplota je mezi 3 a 8 stupni. Pokud je optimální teplota, barva je zelená
        public void SetTemperature(int value)
        {
            if (value >= 3 && value <= 8)
            {
                clr = Color.Green;
            }
            else
            {
                clr = Color.Red;
            }
        }

        /// Student může získat maximálně 40 bodů, pokud dostane alespoň 26 bodů, uspěl
        public bool PassExam(int points)
        {
            bool result = false;
            if (points > 26)
            {
                return true;
            }

            return result;
        }

        /// Nepravděpodobný logický obvod
        public bool LogicalInput(bool a, bool b, bool c)
        {
            if (a == c) return true;
            if (a == true) return false;
            if (a == b && a != c) return true;
            return false;
        }
    }

}
