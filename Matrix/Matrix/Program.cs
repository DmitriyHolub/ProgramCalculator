using System;
using MatrixLibrary;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsolDisplay.Message += DisplayMessage;
            ConsolDisplay.MartixMessage += DisplayMessage;
            ConsolDisplay.MartixOperation += DisplayMessage;

            ConsolDisplay.StartMatrixProgram();
        }
        static void DisplayMessage(string Message)
        {
            Console.WriteLine(Message);
        }
        static void DisplayMessage(int [,] Massiv)
        {
            Console.WriteLine();

            int row = Massiv.GetUpperBound(0) + 1;
            int column = Massiv.Length / row;

            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < column; y++)
                {
                    Console.Write($" {Massiv[x, y]} \t");
                }

                Console.WriteLine("\n");
            }
        }
        static void DisplayMessage(string Message, int count)
        {
            Console.WriteLine(Message+count);
        }
    }
}
