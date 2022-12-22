using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_MortalKombat
{
    internal class Player
    {
        private int attackMax;
        private int attackMin;
        private int defence;
        private int health;
        private string name;
        private bool healed = true;

        public int AttackMax { get { return attackMax; } }
        public int AttackMin { get { return attackMin; } }
        public int Defence { get { return defence; } }
        public string Name { get { return name; } }

        public int Health { get { return health; } set { health = EditHealth(value); } }

        private int EditHealth(int value)
        {
            int tmpHealth = health - value;
            // & = alt + 38
            if (tmpHealth < 30 && tmpHealth > 0 && healed)
            {
                tmpHealth = new Random().Next(20, 26);
                healed = false;
            }
            return tmpHealth;
        }

        public Player(string n, int aMax, int aMin, int d)
        {
            name = n;
            attackMax = aMax;
            attackMin = aMin;
            defence = d;
            health = 100;
        }

        public void RestoreHealth(int h)
        {
            health = h;
        }

        public override string ToString()
        {
            // $ = alt + 36
            return $"{name} [{health}]";
        }
    }
}
