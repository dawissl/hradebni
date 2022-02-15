using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    /// <summary>
    /// Třída reprezentující jednoduchý výtah
    /// </summary>
    class Vytah
    {
        
        private int maxPocet;
        private int nostnost;
        // seznam aktuálně nastoupených lidí ukládáme do seznamu
        private List<int> poleVah;

        public Vytah(int count, int weight)
        {
            maxPocet = count;
            nostnost = weight;
            poleVah = new List<int>();
        }

        public void AddPerson(int weight)
        {
            if (poleVah.Count > maxPocet) return;
            if (poleVah.Sum() > nostnost) return;
            poleVah.Add(weight);
            
        }

        /// <summary>
        /// Kontrola přetížení
        /// </summary>
        /// <returns> true pokud je výtah přetížen</returns>
        public bool Overweight()
        {
            return poleVah.Sum() > nostnost;
        }

        /// <summary>
        /// Kontrola obsazenosti
        /// </summary>
        /// <returns>true pokud je ve výtahu víc lidí neže je dovoleno</returns>
        public bool Overcounte()
        {
            return poleVah.Count > maxPocet;
        }

        // vypsání vah pasažérů ve výtahu
        public override string ToString()
        {
            string ret = "";
            for (int i = 0; i < poleVah.Count; i++)
            {
                ret += $"{poleVah[i]}{Environment.NewLine}";
            }
            return ret;
        }

    }
}
