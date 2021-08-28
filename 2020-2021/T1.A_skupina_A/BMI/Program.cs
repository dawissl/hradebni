using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double vyska, vaha, bmi;
            string pohlavi;
            Console.WriteLine("Kalkulačka pro BMI");
            Console.WriteLine("===================");
            Console.Write("Pohlavi (M/Z):");
            pohlavi = Console.ReadLine();
            Console.Write("Vaha [kg]: ");
            vaha = double.Parse(Console.ReadLine());
            Console.Write("Vyska [m]: ");
            vyska = double.Parse(Console.ReadLine());
            bmi = BmiCalcul(vaha, vyska);
            Console.WriteLine("Hodnota BMI je: {0}", bmi);
            Console.WriteLine("Status: {0}", BmiResult(bmi, pohlavi));


        }

        private static double BmiCalcul(double vaha, double vyska)
        {
            if (vaha < 0) throw new Exception("Váha nesmí být záporná");
            if (vyska <= 0) throw new Exception("Výška musí být větší než 0");
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

        private static string BmiResult(double bmi, string gender)
        {
            Status status = Status.NEZNAMY;
            if (gender == "M") status = GetStatus(bmi, Gender.MUZ);
            if (gender == "Z") status = GetStatus(bmi, Gender.ZENA);


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
        private static Status GetStatus(double bmi, Gender gender)
        {

            if (gender == Gender.MUZ)
            {
                if (bmi < 20) return Status.PODVAHA;
                if (bmi >= 20 && bmi <= 24.9) return Status.NORMALNI;
                if (bmi > 25 && bmi <= 29.9) return Status.LEHKA_OBEZITA;
                if (bmi > 30 && bmi <= 39.9) return Status.STREDNI_OBEZITA;
                if (bmi > 40) return Status.VYSOKA_OBEZITA;
            }
            else
            {
                return GetStatus(bmi + 1, Gender.MUZ);
            }
            return Status.NEZNAMY;
        }
        public enum Status { PODVAHA, NORMALNI, LEHKA_OBEZITA, STREDNI_OBEZITA, VYSOKA_OBEZITA, NEZNAMY }
        public enum Gender { MUZ, ZENA }
    }
}
