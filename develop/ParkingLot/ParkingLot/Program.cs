using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Parkoviste
    {
        private Vozidlo[] parkovaciMista;
        private int kapacita;

        public Parkoviste()
        {
            parkovaciMista = new Vozidlo[3];
            kapacita = 3;
        }

        public Parkoviste(int k)
        {
            kapacita = k;
            parkovaciMista = new Vozidlo[kapacita];
        }

        public int PrijemZParkovani()
        {
            int suma = 0;
            foreach (Vozidlo v in parkovaciMista)
            {
                if (v != null)
                {
                    switch (v.CarType)
                    {
                        case TypVozidla.BASIC:
                            suma += 80;
                            break;
                        case TypVozidla.ELECTRO:
                            suma += 60;
                            break;
                        case TypVozidla.PICKUP:
                            suma += 10;
                            break;
                        default:
                            break;
                    }
                }
            }
            return suma;
        }

        public void VypisVozidel()
        {

        }

        public bool JeMistoObsazene(int position)
        {
            if (!PositionCheck(position))
            {
                Console.WriteLine("Neznámé číslo parkovacího místa");
                return false;
            }

            if (parkovaciMista[position] != null)
            {
                Console.WriteLine("Místo {1} je obsazene {0}", parkovaciMista[position].CarType, position);
                return false;
            }
            else
            {
                Console.WriteLine("Místo {0} je volne", position);
                return true;
            }
        }

        public void ZablokujMisto(int position)
        {
            if (!PositionCheck(position))
            {
                Console.WriteLine("Neznámé číslo parkovacího místa");
                return;
            }

            if (parkovaciMista[position] != null)
            {
                Console.WriteLine("Místo je již obsazené");
            }
            else
            {
                parkovaciMista[position] = new Vozidlo();
            }
        }

        public void Obsazenost() {
            double obsazeno = 0;
            foreach(Vozidlo v in parkovaciMista)
            {
                if (v != null) obsazeno++;     
            }
            double procentualniObsazeni = (obsazeno / kapacita) * 100;
            Console.WriteLine("Obsazenost parkoviště: {0} %", procentualniObsazeni);
        }

        public void ZobrazVolnaMista()
        {
            string volna = "";
            for(int i = 0; i < kapacita; i++)
            {
                if (parkovaciMista[i] == null) volna += i + "\t";
            }
            Console.WriteLine("Místa k dispozici:\n{0}",volna);
        }

        private bool PositionCheck(int num)
        {
            return num >= 0 && num < kapacita;
        }
    }

    class Vozidlo
    {
        private string licensePlate;
        private string owner;
        private TypVozidla carType;

        public TypVozidla CarType { get { return carType; } }

        // konstruktor pro blokovane vozidlo
        public Vozidlo()
        {
            licensePlate = "-------";
            owner = "blokované místo";
            carType = TypVozidla.BLOCKED;
        }

        public Vozidlo(string owner, string licensePlate)
        {
            this.licensePlate = LicensePlateCheck(licensePlate);
            this.owner = owner;
            carType = TypVozidla.BASIC;
        }

        private string LicensePlateCheck(string input)
        {
            bool letter = false;
            bool digit = false;

            if (input.Length != 7)
            {
                Console.WriteLine("Neplatná SPZ, zadejte znovu:");
                return LicensePlateCheck(Console.ReadLine());
            }
            char[] plate = input.ToCharArray();
            for (int i = 0; i < 7; i++)
            {
                if (Char.IsDigit(plate[i])) digit = true;
                if (Char.IsLetter(plate[i])) letter = true;

            }

            if (!letter || !digit)
            {
                Console.WriteLine("Neplatná SPZ, zadejte znovu:");
                return LicensePlateCheck(Console.ReadLine());
            }

            return input;
        }

        public override string ToString()
        {
            return licensePlate + " [" + carType + "]";
        }
    }

    class Elektromobil : Vozidlo
    {

    }

    class Dodavka : Vozidlo
    {

    }

    enum TypVozidla { BASIC, ELECTRO, PICKUP, BLOCKED }
}
