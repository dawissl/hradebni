using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_MortalKombat
{
    internal class Fighter
    {
        private string name;
        private int minAttack;
        private int maxAttack;
        private int defense;
        private int health;
        private bool healed = false;

        public int Health { get { return health; } set { EditHealth(value); } }
        public int MaxAttack { get { return maxAttack; } }
        public int MinAttack { get { return minAttack; } }
        public int Defense { get { return defense; } }
        public string Name { get { return name; } }


        public Fighter(string n, int minA, int maxA, int def)
        {
            name = n;
            minAttack = minA;
            maxAttack = maxA;
            defense = def;
            health = 100;
        }
        private void EditHealth(int value)
        {
            health -= value;
            if(health < 30 && !healed)
            {
                health += new Random().Next(20,51);
                healed = true;
            }
        }

        public void RestoreHealth()
        {
            health = 100;
        }

        public override string ToString()
        {
            return $"{name.ToUpper()}: [{health}]";
        }
    }
}
