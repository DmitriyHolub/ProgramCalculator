using System;

namespace MatrixLibrary
{
    class Operations
    {
        // Different types of operations with matrix.
        protected internal static int AmountPositiveNumbers(int [,] mas)
        {
            int count = 0;
            int row = mas.GetUpperBound(0)+1;
            int column = mas.Length/row;

            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < column; y++)
                {
                    if (mas[x, y] >= 0)
                    {
                        count++;
                    }

                }
            }
            return count;
        }
        protected internal static int AmountNegativeNumbers(int[,] mas)
        {
            int count = 0;
            int row = mas.GetUpperBound(0) + 1;
            int column = mas.Length / row;

            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < column; y++)
                {
                    if (mas[x, y] < 0)
                    {
                        count++;
                    }

                }
            }
            return count;
        }
        protected internal static int [,] AscendingSorter(int[,] mas)
        {
            int temp;
            int row = mas.GetUpperBound(0) + 1;
            int column = mas.Length / row;

            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < column-1; y++)
                {
                    for (int z = y + 1; z < column; z++)
                    {
                        if (mas[x, y] > mas[x, z])
                        {
                            temp = mas[x, z];
                            mas[x, z] = mas[x, y];
                            mas[x, y] = temp;
                        }
                    }
                }
            }
            return mas;
            
        }
        protected internal static int[,] DescendingSorter(int[,] mas)
        {
            int temp;
            int row = mas.GetUpperBound(0) + 1;
            int column = mas.Length / row;

            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < column - 1; y++)
                {
                    for (int z = y + 1; z < column; z++)
                    {
                        if (mas[x, y] < mas[x, z])
                        {
                            temp = mas[x, z];
                            mas[x, z] = mas[x, y];
                            mas[x, y] = temp;
                        }
                    }
                }
            }
            return mas;
        }
        protected internal static int[,] Inversion(int[,] mas)
        {
            int temp;
            int row = mas.GetUpperBound(0) + 1;
            int column = mas.Length / row;

            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < column/2; y++)
                {
                        temp = mas[x, y];
                        mas[x, y] = mas[x, column-y-1];
                        mas[x, column - y - 1] = temp;
                }
            }
            return mas;
        }
    }
}
