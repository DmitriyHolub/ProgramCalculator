using System;

namespace CalculatorLibrary
{
    enum Operation
    {
      Add=1,                      
      Subtract,               
      Multiply,               
      Divide,                    
      PercentageNumber,  
      SquareRoot
    }
    enum YesNO
    {
        Yes=1,
        No
    }

    public delegate void Rezult(string mes, double x);
    public delegate void ErrorMessage(string mes); // 4fvfvfvfs

    public class ClassCalculator
    {
        public static event Rezult RezultMessage;
        public static event ErrorMessage ErrorMessage;
        public static event ErrorMessage DisplayMessage;

        // starting programm. Main menu.
        public static void StartProgram()
        {
            // Choosing the operation 

            ConsoleMessageDisplay("\nChoose the operation:\n" +
               " ADD -                        1\n" +
               " Subtract -                   2\n" +
               " Multiply -                   3\n" +
               " Divide -                     4\n" +
               " Percentage of the number -   5\n" +
               " Square root -                6\n ");

            string operation = Console.ReadLine();

            ClassSwitchOperation.ChoosingOperation(operation);
          
        }

        // Asking for continue or finishing the program.
        protected internal static void StartOrFinishProgram()
        {
           bool  vozvrat1 = true;

            while (vozvrat1 == true)
            {
                ConsoleMessageDisplay("\nWould you like another operation?\n" +
                                 "   Enter number 1 if YES\n" +
                                 "   Enter number 2 if NO");
                YesNO yesNO=0;

                string x = Console.ReadLine();
                bool rezalt = Byte.TryParse(x, out byte x1);

                if (rezalt)
                {
                   yesNO = (YesNO)x1;
                }
            
                switch (yesNO)
                {
                    case YesNO.Yes:

                        StartProgram();

                        vozvrat1 = false;

                        break;

                    case YesNO.No:
                        
                        vozvrat1 = false;

                        ConsoleMessageDisplay("Goodbay))))");

                        break;

                    default:

                        ErrorMessageDisplay("Error. Start of Finish?");

                        vozvrat1 = true;

                        break;
                }
            }
        }

        // Delegate invoke
        protected internal static void Rezult(string x, double y)
        {
            RezultMessage?.Invoke(x, y);
        }
        protected internal static void ErrorMessageDisplay(string x)
        {
            ErrorMessage?.Invoke(x);
        }
        protected internal static void ConsoleMessageDisplay(string x)
        {
            DisplayMessage?.Invoke(x);
        }

    }
    



}
