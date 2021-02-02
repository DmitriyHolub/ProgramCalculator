using System;
using CalculatorLibrary;

namespace Calculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ClassCalculator.RezultMessage += Display;
            ClassCalculator.ErrorMessage += Display;
            ClassCalculator.DisplayMessage += ConsoleDisplay;

            ClassCalculator.StartProgram();
            
        }
        static  void Display(string mes, double x)
        {

            ConsoleColor color = Console.ForegroundColor;
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{mes}  {x}");
            Console.ForegroundColor = color;

        }
        static void Display(string mes)
        {

            ConsoleColor color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mes);
            Console.ForegroundColor = color;

        }
        static void ConsoleDisplay(string mes)
        {

            ConsoleColor color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(mes);
            Console.ForegroundColor = color;

        }


    }         
}

