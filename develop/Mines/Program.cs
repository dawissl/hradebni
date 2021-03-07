using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool work = true;
            do
            {
                Console.WriteLine("*** Find the mine game ***");
                Console.Write("Enter the size of square field: ");

                MineField mine = new MineField(int.Parse(Console.ReadLine()));
                bool winning = false;

                while (!winning)
                {
                    Console.WriteLine("Insert coordinations for search:");
                    winning = mine.Guess(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("New game (y/n)?\n>");
                string instruction = Console.ReadLine().ToLower();
                if (instruction == "n") work = false;

            } while (work);

        }

        class MineField
        {
            private char[,] field;
            private char[,] playerField;
            private Random rnd = new Random();
            // position of hidden mine
            private int x;
            private int y;
            public MineField(int size)
            {
                if (size <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid size of field. Default field (size 3) was created");
                    Console.ForegroundColor = ConsoleColor.White;
                    Size = 3;
                }
                else
                {
                    if(size > 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Field is too big. Default field (size 3) was created");
                        Console.ForegroundColor = ConsoleColor.White;
                        Size = 3;
                    }
                    else
                    {
                        Size = size;
                    }
                   
                    
                }

                field = new char[Size, Size];
                playerField = new char[Size, Size];
                x = rnd.Next(0, Size);
                y = rnd.Next(0, Size);
                fillFields();
            }

            public bool Guess(int posX, int posY)
            {
                if (posX < 0 || posX >= Size)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("invalid coordination x");
                    Console.ForegroundColor = ConsoleColor.White;
                    return false;
                }
                if (posY < 0 || posY >= Size)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("invalid coordination y");
                    Console.ForegroundColor = ConsoleColor.White;
                    return false;
                }

                if (posX == x && posY == y)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You found the mine!");
                    playerField[posX, posY] = '#';
                    Print();
                    return true;
                }
                else
                {
                    Console.WriteLine("You miss the mine!");
                    MarkPosition(posX, posY);
                    Print();
                    return false;
                }
            }

            private void MarkPosition(int x, int y)
            {
                playerField[x, y] = 'X';
            }

            private void Print()
            {
                string output = "";
                for (int i = 0; i < Size * 2; i++) { output += "-"; }
                output += "\n";
                for (int i = 0; i < Size; i++)
                {
                    for (int j = 0; j < Size; j++)
                    {
                        output += playerField[i, j].ToString() + " ";
                    }
                    output += "\n";
                }
                for (int i = 0; i < Size * 2; i++) { output += "-"; }
                output += "\n";
                Console.Write(output);
            }
            private void fillFields()
            {

                for (int i = 0; i < Size; i++)
                {
                    for (int j = 0; j < Size; j++)
                    {
                        playerField[i, j] = '0';
                        if (i == x && j == y)
                        {
                            field[i, j] = '#';
                        }
                        else
                        {
                            field[i, j] = '0';
                        }
                    }
                }
            }

            public int Size { get; }



            public override string ToString()
            {
                string output = "";
                for (int i = 0; i < Size * 2; i++) { output += "-"; }
                output += "\n";
                for (int i = 0; i < Size; i++)
                {
                    for (int j = 0; j < Size; j++)
                    {
                        output += playerField[i, j].ToString() + " ";
                    }
                    output += "\n";
                }
                for (int i = 0; i < Size * 2; i++) { output += "-"; }
                output += "\n";
                // second field

                for (int i = 0; i < Size; i++)
                {
                    for (int j = 0; j < Size; j++)
                    {
                        output += field[i, j].ToString() + " ";
                    }
                    output += "\n";
                }
                for (int i = 0; i < Size * 2; i++) { output += "-"; }
                output += "\n";
                return output;
            }
        }

    }
}
