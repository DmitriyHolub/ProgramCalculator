using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixLibrary
{
    enum Operation: byte
    {
        AmountPozitiveNumbers=1,
        AmountNegativeNumbers,
        AscendingSorter,
        DescendingSorter,
        Inversion
    }
    enum StartFinish: byte
    {
        NewMatrix=1,
        OperationStart,
        ProgrammFinish
    }
    public class ConsolDisplay
    {
        
        public delegate void MessageDisplay (string message);
        public delegate void MessageOper(string message, int count);
        public delegate void MatrixDisplay(int [,] massiv);

        public static event MessageDisplay Message;
        public static event MatrixDisplay MartixMessage;
        public static event MessageOper MartixOperation;

        static byte row = 0;
        static byte column = 0;
        static int number;
        static bool z = true;
        static bool z1 = true;
        static int[,] Massiv;

        // The first step of starting programm. Enter number of rows and colums.
        public static void StartMatrixProgram()
        {
            z = true;
            z1 = true;
 
            while (z == true)
            {
                Message?.Invoke("\n Введите количество строк");

                Check.CheckEnterNumber(Console.ReadLine(), out row, out z);

            }
            while (z1 == true)
            {
                Message?.Invoke("\n Введите количество столбцов");

                Check.CheckEnterNumber(Console.ReadLine(), out column, out z1);
            }

            CreateNewMatrixClass.NewMatrix(row, column);
        }

        // Choose the operations with matrix.
        public static void StartMatrixProgramOperation(int [,] massiv)
        {
            Message?.Invoke("\n Введите номер операции" +
                "\n1      Количество положительных чисел" +
                "\n2      Количество отрицательных чисел" +
                "\n3      Сортировка по возрастанию" +
                "\n4      Сортировка по убыванию" +
                "\n5      Инверсия");

            Massiv = massiv;
            z1 = true;

            while (z1 == true)
            {
                Message?.Invoke("\n Введите номер операции");

                Check.CheckEnterNumberMatrix(Console.ReadLine(), out number , out z1);

                Operation operation = (Operation)number;

                switch (number)
                {
                    case 1:
                        int count=Operations.AmountPositiveNumbers(massiv);

                        MartixOperation?.Invoke("Количество положительных чисел равно ", count);

                        StartFinishProgram();

                        break;
                      
                    case 2:
                        count = Operations.AmountNegativeNumbers(massiv);

                        MartixOperation?.Invoke("Количество отрицательных чисел равно ", count);

                        StartFinishProgram();
                        break;

                    case 3:
                        int [,] mas =Operations.AscendingSorter(massiv);

                        ConsolDisplay.Display(mas);

                        StartFinishProgram();
                        break;

                    case 4:
                        mas = Operations.DescendingSorter(massiv);

                        ConsolDisplay.Display(mas);

                        StartFinishProgram();
                        break;
                    case 5:
                        mas = Operations.Inversion(massiv);

                        ConsolDisplay.Display(mas);

                        StartFinishProgram();
                        break;

                    default:
                        Message?.Invoke("\n Неправильно выбрана операция");

                        z1 = true;
                        break;
                } 
            }
        }

        // Asking for finishing the program.
        protected internal static void StartFinishProgram()
        {
            Message?.Invoke("\n Введите номер операции" +
              "\n1      Ввести новую матрицу "+
              "\n2      Продолжить операции с матрицой " +
              "\n3      Закончить выполнение программы");

            Message?.Invoke("\n Продолжить программу?");

            Check.CheckEnterNumberMatrix(Console.ReadLine(), out number, out z1);

            StartFinish startFinish = (StartFinish)number;

            switch (number)
            {
                case 1:   
                    
                    StartMatrixProgram();
                    break;

                case 2:

                    StartMatrixProgramOperation(Massiv);
                    break;

                case 3  :

                    Message?.Invoke("\n Спасибо что выбрали нас.");
                    break;

                default:

                    Message?.Invoke("\n Неправильно выбрана операция.");

                    StartFinishProgram();
                    break;
            } 
        }

        // Methods which help to display the messages and results.
        protected internal static void Display(string m)
        {
            Message?.Invoke(m);
        }
        protected internal static void Display(int[,] m)
        {
            MartixMessage?.Invoke(m);
        }
        protected internal static void Display(string m, int x)
        {
            MartixOperation?.Invoke(m, x);
        }
    }
}
