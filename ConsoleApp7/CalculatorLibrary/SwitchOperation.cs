using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    
    class ClassSwitchOperation
    {

        // Selection of operation and input of numbers.
        protected internal static void SwitchOperation(Operation num)
        {
            string x1, x2;
            double y1, y2;
            bool vozvrat3 = true;

            switch (num)
            {
                case Operation.Add:

                    while (vozvrat3 == true)
                    {
                        ClassCalculator.ConsoleMessageDisplay("\nEnter two numbers to Add");

                        x1 = Console.ReadLine();
                        x2 = Console.ReadLine();

                        ClassCheckEnter.Checknumbers(x1, x2, out y1, out y2, out vozvrat3);// проверка ввода чисел

                        if (vozvrat3 == false)
                        {
                            ClassOperation.Add(y1, y2);
                        }
                        else
                        {   
                            ClassCalculator.ErrorMessageDisplay("\nError.You do not enter the numbers");
                        }
                    }
                    break;

                case Operation.Subtract:

                    while (vozvrat3 == true)
                    {
                        ClassCalculator.ConsoleMessageDisplay("\nEnter two numbers to Subtract");

                        x1 = Console.ReadLine();
                        x2 = Console.ReadLine();

                        ClassCheckEnter.Checknumbers(x1, x2, out y1, out y2, out vozvrat3);// проверка ввода чисел

                        if (vozvrat3 == false)
                        {
                            ClassOperation.Subtract(y1, y2);
                        }
                        else
                        {
                            ClassCalculator.ErrorMessageDisplay("\nError. You do not entet the numbers");
                        }
                    }
                    break;

                case Operation.Multiply:

                    while (vozvrat3 == true)
                    {
                        ClassCalculator.ConsoleMessageDisplay("\nEnter two numbers to Multiply");

                        x1 = Console.ReadLine();
                        x2 = Console.ReadLine();

                        ClassCheckEnter.Checknumbers(x1, x2, out y1, out y2, out vozvrat3);// проверка ввода чисел

                        if (vozvrat3 == false)
                        {
                            ClassOperation.Multiply(y1, y2);
                        }
                        else
                        {
                            ClassCalculator.ErrorMessageDisplay("\nError. You do not entet the numbers");
                        }
                    }
                    break;

                case Operation.Divide:

                    while (vozvrat3 == true)
                    {
                        ClassCalculator.ConsoleMessageDisplay("\nEnter two numbers to Divide");

                        x1 = Console.ReadLine();
                        x2 = Console.ReadLine();

                        ClassCheckEnter.Checknumbers(x1, x2, out y1, out y2, out vozvrat3);

                        if (vozvrat3 == false && y2 != 0)
                        {
                            ClassOperation.Divide(y1, y2);
                        }
                        else if (vozvrat3 == false && y2 == 0)
                        {
                            ClassCalculator.ErrorMessageDisplay("\nError. Divide by zero forbidden");
                            vozvrat3 = true;
                        }
                        else
                        {
                            ClassCalculator.ErrorMessageDisplay("Error. You do not enter the numbers");
                        }
                    }
                    break;

                case Operation.PercentageNumber:

                    while (vozvrat3 == true)
                    {
                        ClassCalculator.ConsoleMessageDisplay("\nEnter the number");

                        x1 = Console.ReadLine();

                        ClassCalculator.ConsoleMessageDisplay("\nEnter the percent %");

                        x2 = Console.ReadLine();

                        bool rezult1 = double.TryParse(x1, out double number1);
                        bool rezult2 = double.TryParse(x2, out double number2);
                        bool x = (number2 <= 100 && number2 >= 0);

                        if (rezult1 == true && rezult2 == true && x)
                        {
                            ClassOperation.Percent(number1, number2);
                            vozvrat3 = false;
                        }
                        else
                        {
                            ClassCalculator.ErrorMessageDisplay("\nError. You do not enter the numbers");
                        }
                    }
                    break;

                case Operation.SquareRoot:

                    while (vozvrat3 == true)
                    {
                        ClassCalculator.ConsoleMessageDisplay("\nEnter the number");

                        x1 = Console.ReadLine();
                        bool rezult1 = double.TryParse(x1, out double number1);

                        if (rezult1 == true && number1 > 0)
                        {
                            vozvrat3 = false;

                            ClassOperation.SquareRoot(number1);
                        }
                        else
                        {
                            ClassCalculator.ErrorMessageDisplay("\nError. You do not enter the number");
                        }
                    }
                    break;

                default:

                    ClassCalculator.ErrorMessageDisplay("\nError. You do not choose the operation");

                    ClassCalculator.StartProgram();

                    break;
            }
        }
        // Selection of operation.
        protected internal static void ChoosingOperation(string op)
        {

            bool rezalt = Byte.TryParse(op, out byte oper);

            if (rezalt)
            {

                Operation num = (Operation)oper;

                ClassSwitchOperation.SwitchOperation(num);
            }
            else
            {
                ClassCalculator.ErrorMessageDisplay("\nYou do not choose the operation");

                ClassCalculator.StartProgram();
            }
        }
    }
}
