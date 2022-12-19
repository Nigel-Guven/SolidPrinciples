
using SolidPrinciples.Single_Responsibility_Principle;
using System;

namespace SolidPrinciples
{
    internal class Program : ArithmeticOperations
    {
        static void Main(string[] args)
        {
            /***** Demonstration of Single Responsibility Principle *******/
            
            // First Time

            ArithmeticOperations arithmeticOperations = new ArithmeticOperations();
            arithmeticOperations.x = 4;
            arithmeticOperations.y = 4;

            Console.WriteLine(arithmeticOperations.Addition());
            Console.WriteLine(arithmeticOperations.Subtraction());
            Console.WriteLine(arithmeticOperations.Multiplication());
            Console.WriteLine(arithmeticOperations.Division());

            // Second Time

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            ArithmeticOperations doItAgain = new ArithmeticOperations();
            doItAgain.x = a;
            doItAgain.y = b;

            Console.WriteLine(doItAgain.Addition());
            Console.WriteLine(doItAgain.Subtraction());
            Console.WriteLine(doItAgain.Multiplication());
            Console.WriteLine(doItAgain.Division());

            // Close Program

            string key = Console.ReadKey().ToString();
            if (key == "")
            {
                Console.WriteLine("User pressed enter!");
                return;
            }
            
        }
    }
}
