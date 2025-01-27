namespace _13_Metody
{
    class Program
    {
        static void Main(string[] args)
        {
            // Funkce 0 //
            string input_0 = "Demo funkce";
            string result_0 = Funkce0(input_0);
            Console.WriteLine($"Funkce 0 - DEMO\n----------");
            Console.WriteLine($"Očekávaný výstup: {input_0}");
            Console.WriteLine($"Získaný výstup: {result_0}");

            // Funkce 1 //
            int[] input_1 = { 1, 6, -2 };
            int[] expected_1 = { -2, 1, 6 };
            int[] result_1 = Function1(input_1[0], input_1[1], input_1[2]);
            Console.WriteLine($"Funkce 1\n----------");
            Console.WriteLine($"Očekávaný výstup: {string.Join(", ", expected_1)}");
            Console.WriteLine($"Získaný výstup: {string.Join(", ", result_1)}");

            // Funkce 2 //
            int[] input_2 = { 1, 6, -2, 5 };
            int expected_2 = 6;
            int result_2 = Function2(input_2[0], input_2[1], input_2[2], input_2[3]);
            Console.WriteLine($"Funkce 2\n----------");
            Console.WriteLine($"Očekávaný výstup: {expected_2}");
            Console.WriteLine($"Získaný výstup: {result_2}");


            // Funkce 3 //
            string input_3_name = "Karel";
            int input_3_age = 1998;
            string expected_3 = "Karel_1998";
            string result_3 = Function3(input_3_name, input_3_age);
            Console.WriteLine($"Funkce 3\n----------");
            Console.WriteLine($"Očekávaný výstup: {expected_3}");
            Console.WriteLine($"Získaný výstup: {result_3}");


            // Funkce 4 //
            string input_4_name = "Karel";
            string input_4_surname = "Vomáčka";
            int input_4_salary = 180000;
            Osoba expected_4 = new Osoba(input_4_name, input_4_surname, input_4_salary);
            Osoba result_4 = Function4(input_4_name, input_4_surname, input_4_salary);
            Console.WriteLine($"Funkce 4\n----------");
            Console.WriteLine($"Očekávaný výstup: {expected_4}");
            Console.WriteLine($"Získaný výstup: {result_4}");


            // Funkce 5 //
            double[] input_5 = { 1.8, 6.7, -8.02, 5 };
            double[] expected_5 = { 0.8, 5.7, -9.02, 4 };
            double[] result_5 = Function5(input_5);
            Console.WriteLine($"Funkce 5\n----------");
            Console.WriteLine($"Očekávaný výstup: {string.Join(", ", expected_5)}");
            Console.WriteLine($"Získaný výstup: {string.Join(", ", result_5)}");


            // Funkce 6 //
            string input_6 = "Fifinka";
            Console.WriteLine($"Funkce 6\n----------");
            Console.WriteLine($"Očekáváný výstup:\nAhoj {input_6}");
            Console.WriteLine($"Získaný výstup:");
            Funkce6(input_6);


            // Funkce 7 //
            int[] input_7 = { 1, 6, -2, 5 };
            double expected_7 = 2.5;
            double result_7 = Function7(input_7[0], input_7[1], input_7[2], input_7[3]);
            Console.WriteLine($"Funkce 7\n----------");
            Console.WriteLine($"Očekáváný výstup: {expected_7}");
            Console.WriteLine($"Získaný výstup: {result_7}");


            // Funkce 8 //
            int input_8_A = 7;
            int input_8_B = 6;
            bool result_8_A = Function8(input_8_A, 3);
            bool result_8_B = Function8(input_8_B, 3);
            Console.WriteLine($"Funkce 8\n----------");
            Console.WriteLine($"Očekáváný výstup: {false}, {true}");
            Console.WriteLine($"Získaný výstup: {result_8_A}, {result_8_B}");


            // Funkce 9 //
            int input_9_A = 7;
            int input_9_B = 6;
            int expected_9 = 13;
            int result_9 = Function9(input_9_A, input_9_B);
            Console.WriteLine($"Funkce 9\n----------");
            Console.WriteLine($"Očekáváný výstup: {expected_9}");
            Console.WriteLine($"Získaný výstup: {result_9}");


            // Funkce 10 //
            int input_10_A = 21;
            int input_10_B = 36;
            bool result_10_A = Function10(input_10_A);
            bool result_10_B = Function10(input_10_B);
            Console.WriteLine($"Funkce 10\n----------");
            Console.WriteLine($"Očekáváný výstup: {true}, {false}");
            Console.WriteLine($"Získaný výstup: {result_10_A}, {result_10_B}");


            // Funkce 11 //
            string input_11 = "Lorem ipsum dolores";
            char input_11_letter = 'O';
            int expected_11 = 3;
            int result_11 = Function11(input_11, input_11_letter);
            Console.WriteLine($"Funkce 11\n----------");
            Console.WriteLine($"Očekáváný výstup: {expected_11}");
            Console.WriteLine($"Získaný výstup: {result_11}");


            // Funkce 12 //
            int[] input_12_A = { 1, 6, 3 };
            int[] input_12_B = { 4, 6, 3 };
            bool result_12_A = Function12(input_12_A[0], input_12_A[1], input_12_A[2]);
            bool result_12_B = Function12(input_12_B[0], input_12_B[1], input_12_B[2]);
            Console.WriteLine($"Funkce 12\n----------");
            Console.WriteLine($"Očekáváný výstup: {false}, {true}");
            Console.WriteLine($"Získaný výstup: {result_12_A}, {result_12_B}");


            // Funkce 13 //
            double[] input_13 = { 1.8, 6.7, -8.02, 5 };
            double expected_13 = 1.37;
            double result_13 = Function13(input_13);
            Console.WriteLine($"Funkce 13\n----------");
            Console.WriteLine($"Očekáváný výstup: {expected_13}");
            Console.WriteLine($"Získaný výstup: {result_13}");

        }
        /// <summary>
        /// Funkce, která vrací uživatelskou přezdívku tvořeno jménem a rokem narození
        /// </summary>
        /// <param name="input_3_name">jméno například Pepa</param>
        /// <param name="input_3_age">rok narození například 2001</param>
        /// <returns> Pepa_2001</returns>
        public static string Function3(string input_3_name, int input_3_age)
        {
            return $"{input_3_name}_{input_3_age}";
        }
        /// <summary>
        /// Funkce vracející novou instanci struktury Osoba
        /// </summary>
        /// <param name="input_4_name"></param>
        /// <param name="input_4_surname"></param>
        /// <param name="input_4_salary"></param>
        /// <returns></returns>
        public static Osoba Function4(string input_4_name, string input_4_surname, int input_4_salary)
        {
            return new Osoba(input_4_name, input_4_surname, input_4_salary);
        }
        /// <summary>
        /// funkce vrátí původní pole s hodnotami o jedna nižší
        /// </summary>
        /// <param name="input_5"></param>
        /// <returns></returns>
        private static double[] Function5(double[] input_5)
        {
            double[] outArr = new double[input_5.Length];
            for (int i = 0; i < input_5.Length; i++)
            {
                outArr[i] = input_5[i] - 1;
            }
            return outArr;
        }

        /// <summary>
        /// Pozdrav uživatele na konzoli
        /// </summary>
        /// <param name="input_6"></param>
        public static void Funkce6(string input_6)
        {
            Console.WriteLine($"Ahoj {input_6}");
        }

        /// <summary>
        /// Aritmetický průměr 4 vstupních hodnot
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <param name="v3"></param>
        /// <param name="v4"></param>
        /// <returns></returns>
        public static double Function7(int v1, int v2, int v3, int v4)
        {
            double suma = v1 + v3 + v2 + v4;
            return suma / 4.0;
        }
        /// <summary>
        /// zjištění dělitelnost dvou vstupních hodnot beze zbytku
        /// </summary>
        /// <param name="input_8_A"></param>
        /// <param name="input_8_num"></param>
        /// <returns></returns>
        protected static bool Function8(int input_8_A, int input_8_num)
        {
            return input_8_A % input_8_num == 0;
        }
        /// <summary>
        /// Součet dvou hodnot
        /// </summary>
        /// <param name="input_9_A"></param>
        /// <param name="input_9_B"></param>
        /// <returns></returns>
        private static int Function9(int input_9_A, int input_9_B)
        {
            return input_9_A + input_9_B;
        }

        /// <summary>
        /// Dělitelnost 7
        /// </summary>
        /// <param name="input_10_A"></param>
        /// <returns></returns>
        public static bool Function10(int input_10_A)
        {
            return input_10_A % 7 == 0;
        }

        /// <summary>
        /// Spočtení výskytů znaků v daném řetězci
        /// </summary>
        /// <param name="input_11"></param>
        /// <param name="input_11_letter"></param>
        /// <returns></returns>
        public static int Function11(string input_11, char input_11_letter)
        {
            int count = 0;
            foreach (char c in input_11.ToUpper())
            {
                if (c == input_11_letter) count++;
            }
            return count;
        }
        /// <summary>
        /// Zjištění zda zadané strany tvoří trojuhelník
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <param name="v3"></param>
        /// <returns></returns>
        public static bool Function12(int v1, int v2, int v3)
        {
            return v1 + v2 > v3 && v1 + v3 > v2 && v2 + v3 > v1;
        }

        /// <summary>
        /// průměrná hodnota v poli čísel
        /// </summary>
        /// <param name="input_13"></param>
        /// <returns></returns>
        public static double Function13(double[] input_13)
        {
            return input_13.Average();
        }

        protected static int Function2(int v1, int v2, int v3, int v4)
        {
            int[] a = { v1, v2, v3, v4 };
            return a.Max();
        }

        private static int[] Function1(int v1, int v2, int v3)
        {
            int[] arr = { v1, v2, v3 };
            Array.Sort(arr);
            return arr;
        }

        private static string Funkce0(string input_0)
        {
            return input_0;
        }

        public struct Osoba
        {
            public Osoba(string name, string surname, int salary)
            {
                Name = name;
                Surname = surname;
                Salary = salary;
            }

            public string Name { get; set; }
            public string Surname { get; set; }
            public int Salary { get; set; }

            public override string ToString()
            {
                return $"{Surname} {Name} má plat {Salary} Kč";
            }
        }
    }
}
