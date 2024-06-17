using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamiony
{
    public class Ride
    {
        private double track;
        private double speed;
        private double time;
        private string name;
        private List<Point> ride;

        public List<Point> RideList { get { return ride; } }
        public string Name { get { return name; } }
        public Ride(List<Point> tmpRide, string truckName)
        {
            name = truckName;
            ride = tmpRide;
            time = ride.Count - 1;
            track = CountRide();
            speed = track / time;
        }

        private double CountRide()
        {
            double result = 0;
            for (int i = 1; i < ride.Count; i++)
            {
                double a = (ride[i].X - ride[i - 1].X) * (ride[i].X - ride[i - 1].X);
                double b = (ride[i].Y - ride[i - 1].Y) * (ride[i].Y - ride[i - 1].Y);
                result += Math.Sqrt(a + b);
            }
            return result;
        }

        public override string ToString()
        {
            return $"{name}, (rychlost [{Math.Round(speed, 1)}])";
        }

        public string Print()
        {
            return $"{name}{Environment.NewLine}rychlost: {Math.Round(speed, 1)}{Environment.NewLine}uražená trasa: {Math.Round(track,1)}";
        }

    }
}
