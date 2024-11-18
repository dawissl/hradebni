using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Who
{
    public class Pricina
    {
        private int count;
        private string name;
        public string Name { get { return name; } }
        public int Count { get { return count; } }

       /// <summary>
       /// Přidání pacienta pro již existující příčinu
       /// </summary>
        public void AddPatient()
        {
            count++;
        }
        // pacient 0 pro konkrétní příčinu
        public Pricina(string name)
        {
            this.name = name;
            count = 1;
        }
        public override string ToString()
        {
            return $"{name} [{count}]";
        }
    }
}
