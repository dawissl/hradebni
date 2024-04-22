using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SestavaTymu
{
    public class CreateTeam
    {
        private int size;
        public CreateTeam(int size)
        {
            if (size < 12) this.size = 12;
            else this.size = size;
            GenerateFile();
        }
        public CreateTeam()
        {
            size = 12;
            GenerateFile();
        }

        private void GenerateFile()
        {
            string[] names = { "Jan", "Petr", "Tomáš", "Lukáš", "Jakub", "Martin", "Jiří", "Josef", "František", "Pavel", "David", "Marek", "Michal", "Adam", "Jaroslav", "Václav", "Karel", "Daniel", "Ondřej", "Filip", "Kamil", "Richard" };
            string[] surnames = { "Novák", "Svoboda", "Novotný", "Dvořák", "Černý", "Procházka", "Kučera", "Veselý", "Horák", "Němec", "Pokorný", "Malý", "Urban", "Pospíšil", "Král", "Bartoš", "Hájek", "Bureš", "Prokop", "Vlček", "Rychlý", "Hlavatý" };
            Random rnd = new Random();
            

            using (StreamWriter sw = new StreamWriter("team.csv",false,Encoding.UTF8))
            {
                FieldPosition fp = FieldPosition.GOALKEEPER;
                sw.WriteLine("JMENO;CISLO_DRESU;POZICE;UTOK;OBRANA;VYDRZ");
                for (int i = 0; i < size; i++)
                {
                    switch (rnd.Next(0, 3))
                    {
                        case 0: fp = FieldPosition.GOALKEEPER; break;
                        case 1: fp = FieldPosition.STRIKER; break;
                        case 2: fp = FieldPosition.DEFENDER; break;
                    }
                    sw.WriteLine($"{names[rnd.Next(names.Length)]} {surnames[rnd.Next(surnames.Length)]};{i + 1};{fp};{rnd.Next(50, 100)};{rnd.Next(50, 100)};{rnd.Next(50, 100)}");
                }
                sw.Close();
            }
        }

        public List<Hrac> LoadFile()
        {
            List<Hrac> team = new List<Hrac>();
            if (!File.Exists("team.csv"))
            {
                MessageBox.Show("Chybějici soubor!");
                return team;
            }
            else
            {
                using(StreamReader sr= new StreamReader("team.csv"))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] splitted = line.Split(";");
                        FieldPosition fp = FieldPosition.GOALKEEPER;
                        if (splitted[2] == "STRIKER") fp = FieldPosition.STRIKER;
                        if (splitted[2] == "DEFENDER") fp = FieldPosition.DEFENDER;
                        team.Add(new Hrac(splitted[0],fp, int.Parse(splitted[1]), int.Parse(splitted[3]), int.Parse(splitted[4]), int.Parse(splitted[4])));
                    }
                    sr.Close();
                }
                return team;
            }

        }
    }
}
