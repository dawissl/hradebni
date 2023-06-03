using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_VyhledavaciStrom
{
    internal class VyhledavaciStrom
    {
        private Uzel koren;

        public Uzel Koren { get { return koren; } set { koren = value; } }

        public void VlozitUzel(int hodnota, Uzel u)
        {
            // koren prazdny

            if(koren == null)
            {
                Uzel tmp = new Uzel(hodnota);
                this.koren = tmp;
                return;
            }

            
            Uzel rodic = u;

            if(hodnota <= rodic.Hodnota)
            {
               if(rodic.Levy == null)
                {
                    // TODO vlozit
                }
                else
                {
                    rodic = rodic.Levy;
                    
                }
            }
        }

        public Uzel VyhledatUzel(int hodnota)
        {

            return null;
        }
    }
}
