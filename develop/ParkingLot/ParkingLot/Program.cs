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


    }

    class Vozidlo
    {
        private string licensePlate;
        private string owner;
        private TypVozidla carType;

        // konstruktor pro blokovane vozidlo
        public Vozidlo()
        {
            licensePlate = "0XXXXXX";
            owner = "blokované místo";
            carType = TypVozidla.BASIC;
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
         
                if(input.Length != 7)
                {
                    Console.WriteLine("Neplatná SPZ, zadejte znovu:");
                    return LicensePlateCheck(Console.ReadLine());
                }

                for(int i = 0; i < 7; i++)
                {
                    
                }
           
            return "";
        }
    }

    class Elektromobil : Vozidlo
    {

    }

    class Dodavka : Vozidlo
    {

    }

    enum TypVozidla { BASIC, ELECTRO, PICKPU, BLOCKED }
}
