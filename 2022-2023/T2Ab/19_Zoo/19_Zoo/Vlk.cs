﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Zoo
{
    internal class Vlk : Zvire
    {
        private string role;

        public Vlk(string jmeno, int vek, int zdravi, string role) : base(jmeno,vek,zdravi)
        {
            this.role = role;
        }

        public string Vyti()
        {
            return "Howww";
        }
    }
}