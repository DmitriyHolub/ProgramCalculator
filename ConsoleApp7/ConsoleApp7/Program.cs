using System;




namespace ConsoleApp7
{

    class Program
    {
        static void Main(string[] args)
        {
            string x1;
            string x2;
            string x3;
            double y1;
            double y2;
            bool vozvrat = true;
            double rezult;
            while (vozvrat == true)
            {
                // Choosing the operation
                Console.WriteLine("Choose the operation:\n" +
                   " ADD -                        +\n" +
                   " Subtract -                   -\n" +
                   " Multiply -                   *\n" +
                   " Divide -                     /\n" +
                   " percentage of the number -   1\n" +
                   " Square root -                2\n ");
                string operation = Console.ReadLine();
                vozvrat = true;
                bool vozvrat1 = true;
                bool vozvrat3 = true;
                switch (operation)
                {
                  case "+":
                    while (vozvrat3 == true)
                    {
                     Console.WriteLine("Enter two numbers to Add");
                      x1 = Console.ReadLine();
                      x2 = Console.ReadLine();
                      Vvod(x1, x2, out y1, out y2, out vozvrat3);
                      rezult = y1 + y2;
                            if (vozvrat3 == false && rezult > -5 * Math.Pow(10, 324) && rezult < 1.7 * Math.Pow(10, 302))
                            { 
                                Console.WriteLine($"{y1} + {y2} = {rezult}");
                            }
                            else
                            {
                                Console.WriteLine("Error");
                                vozvrat3 = true;
                            }
                    }
                  break;
                  case "-":
                    while (vozvrat3 == true)
                    {
                      Console.WriteLine("Enter two numbers to Subtract");
                      x1 = Console.ReadLine();
                      x2 = Console.ReadLine();
                      Vvod(x1, x2, out y1, out y2, out vozvrat3);
                      rezult = y1 - y2;
                            if (vozvrat3 == false && rezult > -5 * Math.Pow(10, 324) && rezult < 1.7 * Math.Pow(10, 302))
                            {
                                 Console.WriteLine($"{y1} - {y2} = {rezult}"); 
                            }
                            else
                            {
                                 Console.WriteLine("Error");
                                 vozvrat3 = true;
                            }
                    }
                  break;
                  case "*":
                    while (vozvrat3 == true)
                    {
                      Console.WriteLine("Enter two numbers to Multiply");
                      x1 = Console.ReadLine();
                      x2 = Console.ReadLine();
                      Vvod(x1, x2, out y1, out y2, out vozvrat3);
                            rezult = y1 * y2;
                            if (vozvrat3 == false && rezult > -5 * Math.Pow(10, 324) && rezult < 1.7 * Math.Pow(10, 302))
                            {
                                Console.WriteLine($"{y1} * {y2} = {rezult}");
                            }
                            else
                            {
                                Console.WriteLine("Error");
                                vozvrat3 = true;
                            }
                    }
                  break;
                  case "/":
                    while (vozvrat3 == true)
                    {
                        Console.WriteLine("Enter two numbers to Divide");
                        x1 = Console.ReadLine();
                        x2 = Console.ReadLine();
                        Vvod(x1, x2, out y1, out y2, out vozvrat3);
                            rezult = y1 / y2;
                            if (vozvrat3 == false && rezult > -5 * Math.Pow(10, 324) && rezult < 1.7 * Math.Pow(10, 302) && y2 != 0)
                            { 
                                Console.WriteLine($"{y1} / {y2} = {rezult}"); 
                            }
                            else
                            {
                                Console.WriteLine("Error");
                                vozvrat3 = true;
                            }
                    }
                  break;
                  case "1":
                    while (vozvrat3 == true)
                    {
                        Console.WriteLine("Enter the number");
                        x1 = Console.ReadLine();
                        Console.WriteLine("Enter the percent");
                        x2 = Console.ReadLine();
                        bool rezult1 = double.TryParse(x1, out double number1);
                        bool rezult2 = double.TryParse(x2, out double number2);
                           if (rezult1 == true && rezult2 == true && number2 <= 100 && number2 >= 0 && number1 < 1.7 * Math.Pow(10, 302) &&
                              number1 > -5 * Math.Pow(10, 324))
                           {
                               Console.WriteLine($"  {number2}% from number {number1} = {number1 / 100 * number2}");
                               vozvrat3 = false;
                           }
                           else
                           {
                               Console.WriteLine("Error");
                           }
                    }
                  break;
                  case "2":
                      while (vozvrat3 == true)
                      {
                          Console.WriteLine("Enter the number");
                          x1 = Console.ReadLine();
                          bool rezult1 = double.TryParse(x1, out double number1);
                           if (rezult1==true && number1>=0 && number1 < 1.7 * Math.Pow(10, 302))
                           {
                           Console.WriteLine($"  Square root number {number1}   -    {Math.Sqrt(number1)}");
                           vozvrat3 = false;
                           }
                           else
                           {
                           Console.WriteLine("Error");
                                vozvrat3 = true;
                           }
                      }
                  break;
                  default:
                       Console.WriteLine("Error");
                       vozvrat1 = false;
                     break;
                }
                while (vozvrat1 == true)
                {
                    Console.WriteLine("Would you like another operation?\n" +
                                     "   Enter number 1 if YES\n" +
                                     "   Enter number 2 if NO");
                    x3 = Console.ReadLine();
                    switch (x3)
                    {
                        case "1":
                            vozvrat = true;
                            vozvrat1 = false;
                            break;
                        case "2":
                            vozvrat = false;
                            vozvrat1 = false;
                            break;
                        default:
                            Console.WriteLine("Error");
                            vozvrat1 = true;
                            break;
                    }
                }
            }
        }
        // Сhecks if the input is correct
        public static void Vvod(string x1, string x2, out double y1, out double y2, out bool vozvrat3)   
        {  
            bool rezult1 = double.TryParse(x1, out double number1);
            bool rezult2 = double.TryParse(x2, out double number2);
            if (rezult1 == true && rezult2 == true && number1<1.7*Math.Pow(10,302) && number2 < 1.7 * Math.Pow(10, 302)
                && number1 > -5 * Math.Pow(10, 324) && number2 > -5 * Math.Pow(10, 324))
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
 

 


















