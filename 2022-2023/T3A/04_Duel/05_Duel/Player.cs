using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Duel
{
    class Player
    {
        private int hp;
        private int attackMax;
        private int attackMin;
        private int defense;
        private string name;

        public int Hp { get { return hp; } set { hp -= value; } }
        public int AttackMax { get { return attackMax; } }
        public int AttackMin { get { return attackMin; } }
        public int Defense { get { return defense; } }

        public Player(int _attackMax, int _attackMin, int _defense, string _name)
        {
            hp = 100; attackMax = _attackMax; attackMin = _attackMin;
            defense = _defense; name = _name;
        }

        public override string ToString()
        {
            return $"{name}: HP[{hp}]";
        }


    }
}
