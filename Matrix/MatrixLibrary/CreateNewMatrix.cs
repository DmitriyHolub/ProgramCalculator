using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixLibrary
{
    class CreateNewMatrixClass
    {
       // Creating a new matrix.
        protected internal static void NewMatrix(int row, int column)
        {
            bool z = true;
            int number = 0;
            int[,] massiv = new int[row, column];

            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < column; y++)
                {
                    z = true;

                    while (z == true)
                    {
                        ConsolDisplay.Display("\n Введите элемент матрицы");

                        Check.CheckEnterNumberMatrix(Console.ReadLine(), out number, out z);

                        massiv[x, y] = number;
                    }
                }  
            }
            ConsolDisplay.Display(massiv);
            ConsolDisplay.StartMatrixProgramOperation(massiv);
        }
    }
}
