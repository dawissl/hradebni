using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    public class Class1
    {
        // Metoda pro sčítání dvou čísel
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Metoda pro odečítání dvou čísel
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        // Metoda pro násobení dvou čísel
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        // Metoda pro dělení dvou čísel
        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Dělení nulou není povoleno.");
            }
            return a / b;
        }
    }
}
