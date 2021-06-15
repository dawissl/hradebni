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
            string parkoviste = "";

            foreach (Vozidlo v in parkovaciMista)
            {
                if (v != null || v.CarType != TypVozidla.BLOCKED)
                {
                    parkoviste += v;
                }
            }

            Console.WriteLine(parkoviste);
        }

        public void Zaparkuj(Vozidlo v)
        {
            int position = SelectPosition();
            if (position == -1) return;

            parkovaciMista[position] = v;
        }

        public void Zaparkuj()
        {
            int position = SelectPosition();
            if (position == -1) return;

            Vozidlo v = CreateCar();
            parkovaciMista[position] = v;

        }

        private Vozidlo CreateCar()
        {
            Console.WriteLine("Vyváření vozidla");
            Console.WriteLine("MAJITEL SPZ TYP [DOBA NABIJENI/NOSNOST]");
            string line = Console.ReadLine();
            string[] input = line.Split(' ');
            if (input.Length > 4)
            {
                Console.WriteLine("Neplatný formát vstupu");
                CreateCar();
            }

            try {
               
                switch (input[2])
                {
                    case "BASIC":
                        return new Vozidlo(input[0],input[1]);
                    case "ELEKTRO":
                        return new Elektromobil(input[0], input[1], input[3]);  
                    case "PICKUP":
                        return new Dodavka(input[0], input[1], double.Parse(input[3]));
                    default:
                        Console.Write("Neznamý typ vozidla");
                        return CreateCar();
                  
                }
            }
            catch (FormatException e)
            { 
                Console.Write(e.Message);
               return CreateCar(); 
            }

        }

        private int SelectPosition()
        {
            for (int i = 0; i < kapacita; i++)
            {
                if (parkovaciMista[i] == null)
                {
                    return i;
                }
            }
            Console.WriteLine("Parkoviště je plné");
            return -1;
        }

        public void Vyparkuj(int pozice)
        {
          
                parkovaciMista[pozice] = null;
          
        }

        public void Vyparkuj()
        {
            Console.Write("Vyparkovat misto: ");
            try
            {
                int position = int.Parse(Console.ReadLine());
                if (!PositionCheck(position))
                {
                   Vyparkuj();
                }
                else
                {
                    Vyparkuj(position);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Vyparkuj();
            }
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

        public void Obsazenost()
        {
            double obsazeno = 0;
            foreach (Vozidlo v in parkovaciMista)
            {
                if (v != null) obsazeno++;
            }
            double procentualniObsazeni = (obsazeno / kapacita) * 100;
            Console.WriteLine("Obsazenost parkoviště: {0} %", procentualniObsazeni);
        }

        public void ZobrazVolnaMista()
        {
            string volna = "";
            for (int i = 0; i < kapacita; i++)
            {
                if (parkovaciMista[i] == null) volna += i + "\t";
            }
            Console.WriteLine("Místa k dispozici:\n{0}", volna);
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
        private string dobaNabijeni;

        public Elektromobil(string owner, string licensePlate, string doba) : base(owner, licensePlate) {
            dobaNabijeni = doba;
        } 
    }

    class Dodavka : Vozidlo
    {
        private double maxNosnost;
        public Dodavka(string owner, string licensePlate, double zatizeni) : base(owner, licensePlate) {
            maxNosnost = zatizeni;
        }
    }

    enum TypVozidla { BASIC, ELECTRO, PICKUP, BLOCKED }
}
