using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_sk1
{
    class Program
    {
        static void Main(string[] args)
        {
            Potravina syr = new Potravina("syrova");
            Ovoce jablko = new Ovoce("jablková", "jabloň");
            Zelenina okurek = new Zelenina("kyselá", "černozem");

            Potravina chleba = new Potravina("rohliková");

            Potravina mrkev = new Zelenina("mrkvova", "jíl");

            Console.WriteLine(syr.Chut);
            Console.WriteLine(jablko.Chut);
            Console.WriteLine(okurek.Chut);
            chleba.Chut = "chlebová";
            Console.WriteLine(chleba.Chut);
            Console.WriteLine(mrkev.Chut);

            Console.WriteLine("Jablko roste na {0}", jablko.Strom);
            Console.WriteLine("Okurek rost v {0}", okurek.TypPudy);

            Potravina[] nakupniSeznam = { syr, jablko, okurek, chleba, mrkev };

            int salat = syr.Krajeni() + jablko.Krajeni() + okurek.Krajeni() + chleba.Krajeni() + mrkev.Krajeni();

            Console.WriteLine("V salátu je {0} kousků potravin", salat);

        }
    }
    /// <summary>
    /// Trida zakladni potraviny
    /// </summary>
    class Potravina
    {
        // atribut tridy potraviny - odvozene tridy atribut dědí
        private string chut;

        // v konstruktoru přiřadíme chuť potravině
        public Potravina(string ch)
        {
            chut = ch;
        }
        // zpřístupnění atributu přes Chut
        // get obsahuje implementaci, co chceme zobrazit pri volani X.Chut
        // set umožňuje změnu atributu pomoci X.Chut = nova hodnota
        public string Chut { get { return chut; } set { chut = value; } }

        // funkce, kterou umožníme přepisovat v odvozených třídách pomocí slova virtual
        // bez tohoto slova se funkce pouze zdědí se stejnou implementací
        public virtual int Krajeni()
        {
            return 10;
        }
    }

    /// <summary>
    /// Třída ovoce odvozena od základní třídy Potravina
    /// </summary>
    class Ovoce : Potravina
    {
        // vlastní atribut třídy Ovoce, ostatní atributy jsou zděděny ze třídy Potravina
        private string strom;
        // konstruktor třídy Ovoce. V části : base(x,y,z,...) vypisujeme všechny vstupní parametry,
        // které jsou řešeny v konstruktoru nadřazené třídy Potravina
        public Ovoce(string ch, string s) : base(ch)
        {
            // Přestože ve vstupním atributu získáme chuť ovoce,
            // v konstruktoru ji změníme na sladkou
            Chut = "sladká";
            strom = s;
        }

        public string Strom { get { return strom; } }

        // přepsání funkce Krajeni z nadřazené třídy. Přepsanou třídu značíme pomocí override
        // funkce tak má stejné jméno jako v nadřazené třídě Potravina, ale
        // chová se jinak -> polymorfismus
        public override int Krajeni()
        {
            return 6;
        }
    }

    class Zelenina : Potravina
    {
        private string typPudy;
        public Zelenina(string ch, string t) : base(ch)
        {
            Chut = "slaná";
            typPudy = t;
        }

        public string TypPudy { get { return typPudy; } }

        public override int Krajeni()
        {
            return 15;
        }
    }
    /////////////////////////////////////////////////////////////////////////////////
    /// UKAZKOVA HIERARCHIE s konstruktory///

    /**
      Vozidlo - maximalni rychlost
        - jednostoppe
            - kolo - materiál rámu
                 - horske
                 - silnicni
            - motocykl - zrychleni 0-100 km/h
        - dvoustoppe - pocet mist k sezeni
            - auto - spotreba l/100 km
            - traktor
            - kamion - vaha návěsu
 
       */

    class Vozidlo
    {
        private double maxRychlost;

        public Vozidlo(double mr)
        {
            maxRychlost = mr;
        }
    }

    class Jednostope : Vozidlo
    {
        public Jednostope(double mr) : base(mr) { }
    }

    class Kolo : Jednostope
    {
        private string typRamu;

        public Kolo (double mr, string tr) : base(mr)
        {
            typRamu = tr;
        }
    }

    class Silnicni : Kolo
    {
        public Silnicni(double mr, string tr) : base(mr, tr) { }
        
    }

    class Horske : Kolo
    {
        public Horske(double mr, string tr) : base(mr, tr) { }

    }

    class Dvoustope : Vozidlo
    {
        private int pocetMist;
        public Dvoustope(double mr, int pm): base(mr)
        {
            pocetMist = pm;
        }
    }

    class Auto : Dvoustope
    {
        double spotreba;

        public Auto(double mr, int pm, double s) : base(mr, pm)
        {
            spotreba = s;
        }
    }

    class Traktor: Dvoustope
    {
        public Traktor ( double mr, int pm): base(mr,pm) { }
    }

    class Kamion : Dvoustope
    {
        private double vahaNavesu;
        public Kamion ( double mr, int pm, double vn): base(mr, pm)
        {
            vahaNavesu = vn;
        }
    }
}


