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
                try
                {
                    MineField mine = new MineField(int.Parse(Console.ReadLine()));

                
                bool winning = false;

                while (!winning)
                {
                    Console.WriteLine("Insert coordinations for search:");
                    try
                    {
                        winning = mine.Guess(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                    } catch(FormatException e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(e.Message);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("New game (y/n)?\n>");
                string instruction = Console.ReadLine().ToLower();
                if (instruction == "n") work = false;

                }
                catch (FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }

            } while (work);

        }

        /// <summary>
        /// Class defining main part of game
        /// </summary>
        class MineField
        {
            // field where the mine is hidden
            private char[,] field;
            // file used for marking players turns
            private char[,] playerField;
            private Random rnd = new Random();
            // position of hidden mines
            private int x1, x2;
            private int y1, y2;

            // constructor of class MineField
            public MineField(int size)
            {
                // check for negative size and size over 10 x 10
                if (size <= 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid size of field. Default field (size 3) was created");
                    Console.ForegroundColor = ConsoleColor.White;
                    Size = 3;
                }
                else
                {
                    if (size > 10)
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
                // generate random position of mine 
                x1 = rnd.Next(0, Size);
                y1 = rnd.Next(0, Size);
                do
                {
                    x2 = rnd.Next(0, Size);
                    y2 = rnd.Next(0, Size);
                } while (x1 == x2 || y1 == y2);
                fillFields();
            }

            /// <summary>
            /// Function for check if player hit the mine or nor
            /// </summary>
            /// <param name="posX">x coordination of guess</param>
            /// <param name="posY">y coordination of guess</param>
            /// <returns>resolution if mine was founded or not</returns>
            public bool Guess(int posX, int posY)
            {
                // check for negative and out of range coordinations x
                if (posX < 0 || posX >= Size)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("invalid coordination x");
                    Console.ForegroundColor = ConsoleColor.White;
                    return false;
                }
                // check for negative and out of range coordinations y
                if (posY < 0 || posY >= Size)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("invalid coordination y");
                    Console.ForegroundColor = ConsoleColor.White;
                    return false;
                }
                // check the postion of the mine - comparing guess with actual position of mine
                if (posX == x1 && posY == y1 || posX == x2 && posY == y2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You found the mine!");
                    Console.ForegroundColor = ConsoleColor.White;
                    playerField[posX, posY] = '#';
                    Print();
                    return playerField[x1, y1] == '#' && playerField[x2, y2] == '#';
                }
                else
                {
                    Console.WriteLine("You miss the mine!");
                    MarkPosition(posX, posY);
                    Print();
                    return false;
                }
            }

            /// <summary>
            /// Mark the position of guess
            /// </summary>
            /// <param name="x">x coordingation of guess</param>
            /// <param name="y">y coordination of guess</param>
            private void MarkPosition(int x, int y)
            {
                playerField[x, y] = 'X';
            }

            /// <summary>
            /// Create string of players field displayed on the console
            /// </summary>
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
            /// <summary>
            /// Function used as a part of constructor to set starting position
            /// of game and placing the mine into the field
            /// </summary>
            private void fillFields()
            {

                for (int i = 0; i < Size; i++)
                {
                    for (int j = 0; j < Size; j++)
                    {
                        playerField[i, j] = 'o';
                        if (i == x1 && j == y1 || i == x2 && j == y2)
                        {
                            field[i, j] = '#';
                        }
                        else
                        {
                            field[i, j] = 'o';
                        }
                    }
                }
            }

            public int Size { get; }


            /// <summary>
            /// Check function used for debugging
            /// </summary>
            /// <returns>string consisting of player and game field</returns>
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
