using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    class ClassCheckEnter
    {
        // Checking entered numbers.
        protected internal static void Checknumbers(string x1, string x2, out double y1, out double y2, out bool vozvrat3)
        {
            bool rezult1 = double.TryParse(x1, out double number1);
            bool rezult2 = double.TryParse(x2, out double number2);

            if (rezult1 == true && rezult2 == true)
            {
                y1 = number1;
                y2 = number2;
                vozvrat3 = false;
            }
            else
            {
                vozvrat3 = true;
                y1 = number1;
                y2 = number2;
            }
        } 
    }
}
