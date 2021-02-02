using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{

    // Different types of operations.
    class ClassOperation
    {
        protected internal static void Add(double x, double y)
        {
            double rezult = x + y;

            ClassCalculator.Rezult("\nCумма чисел равна ", rezult);
            ClassCalculator.StartOrFinishProgram();
        }
        protected internal static void Subtract(double x, double y)
        {
            double rezult = x - y;

            ClassCalculator.Rezult("\nРазница чисел равна ", rezult);
            ClassCalculator.StartOrFinishProgram();
        }
        protected internal static void Multiply(double x, double y)
        {
            double rezult = x * y;

            ClassCalculator.Rezult("\nУмножение чисел равно ", rezult);
            ClassCalculator.StartOrFinishProgram();
        }
        protected internal static void Divide(double x, double y)
        {
            double rezult = x / y;

            ClassCalculator.Rezult("\nДеление чисел равно ", rezult);
            ClassCalculator.StartOrFinishProgram();
 
        }
        protected internal static void Percent(double x, double y)
        {
            double rezult = x / 100 * y;

            ClassCalculator.Rezult("\nПроцент от числа равен ", rezult);
            ClassCalculator.StartOrFinishProgram();
        }
        protected internal static void SquareRoot(double x)
        {
            double rezult = Math.Sqrt(x);

            ClassCalculator.Rezult("\nКвадратный корень числа равен ", rezult);
            ClassCalculator.StartOrFinishProgram();
        }
    }
}
