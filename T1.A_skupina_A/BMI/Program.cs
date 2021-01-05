using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double vyska, vaha, bmi;
            Console.Write("Vaha [kg]: ");
            vaha = double.Parse(Console.ReadLine());
            Console.Write("Vyska [m]: ");
            vyska = double.Parse(Console.ReadLine());
            bmi = BmiCalcul(vaha, vyska);
            Console.WriteLine("Hodnota BMI je: {0}", bmi);
            Console.WriteLine("Status: {0}", BmiResult(bmi));

        }

        private static double BmiCalcul(double vaha, double vyska)
        {
            return vaha / (vyska * vyska);
        }
        private static string BmiResult(double bmi)
        {
            Status status = Status.PODVAHA;

            if (bmi <= 20) status = Status.PODVAHA;
            if (bmi > 20 && bmi <= 24.9) status = Status.NORMALNI;
            if (bmi > 25 && bmi <= 29.9) status = Status.LEHKA_OBEZITA;
            if (bmi > 30 && bmi <= 39.9) status = Status.STREDNI_OBEZITA;
            if (bmi > 40) status = Status.VYSOKA_OBEZITA;

            switch (status)
            {
                case Status.PODVAHA:
                    return "Pozor, podváha!";
                case Status.NORMALNI:
                    return "Normální stav";
                case Status.LEHKA_OBEZITA:
                    return "Lehký případ obezity";
                case Status.STREDNI_OBEZITA:
                    return "Střední případ obezity";
                case Status.VYSOKA_OBEZITA:
                    return "Pozor, vysoká obezita!";
                default:
                    return "Neznamý stav";
            }
        }
        public enum Status { PODVAHA, NORMALNI, LEHKA_OBEZITA, STREDNI_OBEZITA, VYSOKA_OBEZITA }
    }
}
