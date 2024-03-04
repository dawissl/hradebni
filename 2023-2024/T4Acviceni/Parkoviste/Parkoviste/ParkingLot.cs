using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkoviste
{
    public class ParkingLot
    {
        private Car[,] parkingSpaces;
        private int income = 0;

        public Car[,] Parkoviste { get { return parkingSpaces; } }
        public int Income { get { return income; } }

        public ParkingLot(int patra, int mista)
        {
            parkingSpaces = new Car[patra, mista];
        }

        public void Park(Car car)
        {
            int floor = EmptiestFlor();
            bool placed = false;
            for (int m = 0; m < parkingSpaces.GetLength(1); m++)
            {
                if (parkingSpaces[floor, m] == null)
                {
                    parkingSpaces[floor, m] = car;
                    placed = true;
                    break;
                }
            }
            if (!placed) MessageBox.Show("Nelze zaparkovat");
                }

        private int EmptiestFlor()
        {
            int[] floors = new int[parkingSpaces.GetLength(0)];
            for (int i = 0; i < floors.Length; i++)
            {
                for (int j = 0; j < parkingSpaces.GetLength(1); j++)
                {
                    if (parkingSpaces[i, j] != null) floors[i]++;
                }
            }
            return Array.IndexOf(floors, floors.Min());
        }

        public void Part(Car car, int patro, int misto)
        {
            if (patro > parkingSpaces.GetLength(0) || misto > parkingSpaces.GetLength(1))
            {
                MessageBox.Show("Neplatné misto");
                return;
            }
            if (patro <= 0 || misto <= 0)
            {
                MessageBox.Show("Neplatné misto");
                return;
            }
            if (parkingSpaces[parkingSpaces.GetLength(0) - patro, misto - 1] != null)
            {
                MessageBox.Show("Misto obsazeno");
                return;
            }
            else
            {
                parkingSpaces[parkingSpaces.GetLength(0) - patro, misto - 1] = car;
            }
        }

        public void Vyparkuj(int patro, int misto)
        {
            if (patro > parkingSpaces.GetLength(0) || misto > parkingSpaces.GetLength(1))
            {
                MessageBox.Show("Neplatné misto");
                return;
            }
            if (patro <= 0 || misto <= 0)
            {
                MessageBox.Show("Neplatné misto");
                return;
            }
            if (parkingSpaces[parkingSpaces.GetLength(0) - patro, misto - 1] == null)
            {
                MessageBox.Show("Misto není obsazeno");
                return;
            }
            else
            {
                parkingSpaces[parkingSpaces.GetLength(0) - patro, misto - 1] = null;
                income += 50;
            }
        }
    }

    public class Car
    {
        private string name, spz;
        public string SPZ { get { return spz; } }
        public string Majitel { get { return name; } }

        public Car(string name, string spz)
        {
            this.name = name;
            this.spz = spz;
        }

        public override string ToString()
        {
            return $"Vozidlo {spz}[majitel: {name}]";
        }

    }

}
