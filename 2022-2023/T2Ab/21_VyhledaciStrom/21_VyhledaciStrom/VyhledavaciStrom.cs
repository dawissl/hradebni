using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_VyhledaciStrom
{
    internal class VyhledavaciStrom
    {
        private Uzel koren;

        public Uzel Koren { get { return koren; } set { koren = value; } }

        public void Vlozit(int hodnota)
        {
            if(koren == null)
            {
                koren = new Uzel(hodnota);
                return;
            }

            Uzel tmp = koren;
            PomocneVlozeni(hodnota, tmp);

        }

        private void PomocneVlozeni(int hodnota, Uzel tmp)
        {
            MessageBox.Show(tmp.ToString());
            if (tmp.Hodnota >= hodnota)
            {
                // jdeme doleva
                if (tmp.Levy == null)
                {
                    Uzel novyUzel = new Uzel(hodnota);
                    tmp.Levy = novyUzel;
                    novyUzel.Rodic = tmp;
                }
                else
                {
                    PomocneVlozeni(hodnota, tmp.Levy);
                }
            }
            else
            {
                //jdeme doprava
                if(tmp.Pravy == null)
                {
                    Uzel novyUzel = new Uzel(hodnota);
                    tmp.Pravy = novyUzel;
                    novyUzel.Rodic = tmp;
                }
                else
                {
                    tmp = tmp.Pravy;
                    PomocneVlozeni(hodnota, tmp);
                }
            }
        }

        public Uzel Vyhledat(int hodnota)
        {
            if(koren.Hodnota == hodnota)
            {
                return koren;
            }
                       

            return PomocneVyhledani(hodnota,koren);
        }

        private Uzel PomocneVyhledani(int hodnota, Uzel koren)
        {
            throw new NotImplementedException();
        }
    }
}
