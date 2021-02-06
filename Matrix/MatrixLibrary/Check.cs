using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixLibrary
{
    class Check
    { 
        //Checking the entered data of matrix and numbers
        protected internal static void CheckEnterNumberMatrix(string x, out int Number, out bool z )
        {
            bool A = Int32.TryParse(x, out int number);
            
            if (A)
            {
                Number = number;
                z = false;
            }
            else
            {
                ConsolDisplay.Display("\n Неверный ввод числа ");

                Number = 0;
                z = true;
            }

        }
        protected internal static void CheckEnterNumber(string x, out byte Number, out bool z)
        {
            bool A = Byte.TryParse(x, out byte number);

            if (A)
            {
                Number = number;
                z = false;
            }
            else
            {
                ConsolDisplay.Display("\n Неверный ввод числа ");

                Number = 0;
                z = true;
            }

        }
    }
}
