﻿using System;
using System.Linq;

namespace Functions
{
    class P {
        private int cislo;
        private string text;
        private char pismeno;


        public P(int c, string t, char p)
        {
            cislo = c;
            text = t;
            pismeno = p;
        }

        public override bool Equals(object obj)
        {
            return (obj is P) && ((P)obj).cislo == this.cislo && ((P)obj).text == this.text && ((P)obj).pismeno == this.pismeno;
        }

        public override int GetHashCode()
        {
            return cislo * 13 + text.GetHashCode() * 7 ;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            P a = new P(1, "a", 'a');
            P b = new P(1, "a", 'a');
            P c = new P(2, "b", 'a');

            Console.WriteLine($"{a.Equals(b)}");
            Console.WriteLine($"{a.Equals(a)}");
            Console.WriteLine($"{a.Equals(c)}");
            /* // Funkce 0 //
             string input_0 = "Demo funkce";
             //string result_0 = Funkce0(input_0);
             Console.WriteLine("Funkce 0 - DEMO\n----------");
             //Console.WriteLine("Očekávaný výstup: {0}", input_0);
             //Console.WriteLine("Získaný výstup: {0}", result_0);

             // Funkce 1 //
             int[] input_1 = { 1, 6, -2 };
             int[] expected_1 = { -2, 1, 6 };
             int[] result_1 = Function1(input_1[0], input_1[1], input_1[2]);
             Console.WriteLine("Funkce 1\n----------");
             Console.WriteLine("Očekávaný výstup: {0}, {1}, {2}", expected_1[0], expected_1[1], expected_1[2]);
             Console.WriteLine("Získaný výstup: {0}, {1}, {2}", result_1[0], result_1[1], result_1[2]);


             // Funkce 2 //
             int[] input_2 = { 1, 6, -2, 5 };
             int expected_2 = 6;
             int result_2 = Function2(input_2[0], input_2[1], input_2[2], input_2[3]);
             Console.WriteLine("Funkce 2\n----------");
             Console.WriteLine("Vstupní pole: [{0},{1},{2},{3}]", input_2[0], input_2[1], input_2[2], input_2[3]);
             Console.WriteLine("Očekávaný výstup: {0}", expected_2);
             Console.WriteLine("Získaný výstup: {0}", result_2);


             // Funkce 3 //
             string input_3_name = "Karel";
             int input_3_age = 1998;
             string expected_3 = "Karel_1998";
             string result_3 = Function3(input_3_name, input_3_age);
             Console.WriteLine("Funkce 3\n----------");
             Console.WriteLine("Očekávaný výstup: {0}", expected_3);
             Console.WriteLine("Získaný výstup: {0}", result_3);


             // Funkce 4 //
             string input_4_name = "Karel";
             string input_4_surname = "Vomáčka";
             int input_4_salary = 180000;
             Osoba expected_4 = new Osoba(input_4_name, input_4_surname, input_4_salary);
             Osoba result_4 = Function4(input_4_name, input_4_surname, input_4_salary);
             Console.WriteLine("Funkce 4\n----------");
             Console.WriteLine("Očekávaný výstup: {0}", expected_4);
             Console.WriteLine("Získaný výstup: {0}", result_4);


             // Funkce 5 //
             double[] input_5 = { 1.8, 6.7, -8.02, 5 };
             double[] expected_5 = { 0.8, 5.7, -9.02, 4 };
             double[] result_5 = Function5(input_5);
             Console.WriteLine("Funkce 5\n----------");
             Console.WriteLine("Očekávaný výstup: {0}, {1}, {2}, {3}", expected_5[0], expected_5[1], expected_5[2], expected_5[3]);
             Console.WriteLine("Získaný výstup: {0}, {1}, {2},{3}", result_5[0], result_5[1], result_5[2], result_5[3]);


             // Funkce 6 //
             string input_6 = "Fifinka";
             Console.WriteLine("Funkce 6\n----------");
             Console.WriteLine("Očekáváný výstup:\nAhoj Fifinka");
             Console.WriteLine("Získaný výstup:");
             Funkce6(input_6);


             // Funkce 7 //
             int[] input_7 = { 1, 6, -2, 5 };
             double expected_7 = 2.5;
             double result_7 = Function7(input_7[0], input_7[1], input_7[2], input_7[3]);
             Console.WriteLine("Funkce 7\n----------");
             Console.WriteLine("Očekáváný výstup: {0}", expected_7);
             Console.WriteLine("Získaný výstup: {0}", result_7);


             // Funkce 8 //
             int input_8_A = 18;
             int input_8_B = 3;
             bool result_8_A = Function8(input_8_B, input_8_A);
             bool result_8_B = Function8(input_8_A, input_8_B);
             Console.WriteLine("Funkce 8\n----------");
             Console.WriteLine("Očekáváný výstup: {0}, {1}", false, true);
             Console.WriteLine("Získaný výstup: {0}, {1}", result_8_A, result_8_B);


             // Funkce 9 //
             double input_9_A = 7;
             double input_9_B = 6;
             double expected_9 = 13;
             double result_9 = Function9(input_9_A, input_9_B);
             Console.WriteLine("Funkce 9\n----------");
             Console.WriteLine("Očekáváný výstup: {0}", expected_9);
             Console.WriteLine("Získaný výstup: {0}", result_9);


             // Funkce 10 //
             int input_10_A = 21;
             int input_10_B = 36;
             bool result_10_A = Function10(input_10_A);
             bool result_10_B = Function10(input_10_B);
             Console.WriteLine("Funkce 10\n----------");
             Console.WriteLine("Očekáváný výstup: {0}, {1}", true, false);
             Console.WriteLine("Získaný výstup: {0}, {1}", result_10_A, result_10_B);


             // Funkce 11 //
             string input_11 = "Lorem ipsum dolores";
             char input_11_letter = 'O';
             int expected_11 = 3;
             int result_11 = Function11(input_11, input_11_letter);
             Console.WriteLine("Funkce 11\n----------");
             Console.WriteLine("Očekáváný výstup: {0}", expected_11);
             Console.WriteLine("Získaný výstup: {0}", result_11);


             // Funkce 12 //
             int[] input_12_A = { 1, 6, 3 };
             int[] input_12_B = { 4, 6, 3 };
             bool result_12_A = Function12(input_12_A[0], input_12_A[1], input_12_A[2]);
             bool result_12_B = Function12(input_12_B[0], input_12_B[1], input_12_B[2]);
             Console.WriteLine("Funkce 12\n----------");
             Console.WriteLine("Očekáváný výstup: {0}, {1}", false, true);
             Console.WriteLine("Získaný výstup: {0}, {1}", result_12_A, result_12_B);


             // Funkce 13//
              /*double[] input_13 = { 1.8, 6.7, -8.02, 5 };
             double expected_13 = 1.37;
             double result_13 = Function13(input_13);
             Console.WriteLine("Funkce 13\n----------");
             Console.WriteLine("Očekáváný výstup: {0}", expected_13);
             Console.WriteLine("Získaný výstup: {0}", result_13);
           */
           

        }

        private static double[] Function5(double[] pole)
        {
            for (int i = 0; i < pole.Length; i++)
            {
                pole[i]--;
            }
            return pole;
        }

        public static double Function7(int a, int b, int c, int d)
        {
            double suma = a + b + c + d;
            double prumer = suma / 4;
            return prumer;
        }

        private static int[] Function1(int v1, int v2, int v3)
        {
            int[] tmp = { v3, v1, v2 };
            Array.Sort(tmp);
            return tmp;
        }

        protected static int Function2(int v1, int v2, int v3, int v4)
        {
            /*int[] tmp = { v1, v2, v3, v4 };
            return tmp.Max(); */
            int max = v1;
            if (max < v2)
            {
                max = v2;
            }

            if (max < v3)
            {
                max = v3;
            }

            if (max < v4)
            {
                max = v4;
            }
            return max;

        }

        public static string Function3(string name, int year)
        {
            // name = pepa, year = 2021 -> pepa_2021
            return name + "_" + year;
        }

        public static Osoba Function4(string name, string surname, int salary)
        {
            return new Osoba(name, surname, salary);
        }

        public static void Funkce6(string name)
        {
            Console.WriteLine("Ahoj {0}", name);
        }

        protected static bool Function8(int a, int b)
        {
            return (a % b) == 0;
        }

        private static double Function9(double a, double b)
        {
            return a + b;
        }

        public static bool Function10(int a)
        {
            return (a % 7) == 0;
        }

        public static int Function11(string veta, char znak)
        {
            int counter = 0;
            string letter = znak.ToString().ToUpper();
            foreach (char x in veta.ToUpper())
            {
                if (x == char.Parse(letter)) counter++;
            }
            return counter;
        }

        public static bool Function12(int a, int b, int c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }



        /// <summary>
        /// Demo funkce pro cvičení z předmětu programování
        /// </summary>
        /// <param name="input_0"> vstupní řetězec</param>
        /// <returns> stejný řetězec, který byl na vstupu</returns>
        private static string Funkce0(string input_0)
        {
            throw new NotImplementedException();
        }

        // Struktura pro funkci 4
        public struct Osoba
        {
            public Osoba(string name, string surname, int salary)
            {
                this.Name = name;
                this.Surname = surname;
                this.Salary = salary;
            }

            public string Name { get; set; }
            public string Surname { get; set; }
            public int Salary { get; set; }

            public override string ToString()
            {
                return Surname + " " + Name + " má plat " + Salary + " Kč";
            }
        }

    }

}
