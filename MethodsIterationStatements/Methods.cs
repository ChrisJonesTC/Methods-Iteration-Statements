using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodsIterationStatements
{
    internal class Methods
    {
        #region
        public static void PrintThousands()
        {
            for (int t = 1000; t >= -1000; t--)
            {
                Console.WriteLine(t);
            }
        }
        public static void ThreeByThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        public static void IsEqualOrNot(int num1, int num2) 
        {
            if (num1 == num2)
            {
                Console.WriteLine("These numbers are equal");
            }
            else
            {
                Console.WriteLine("These numbers are not equal");
            }

        }
        public static void IsEvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("This is an even number");
            }
            else
            {
                Console.WriteLine("This number is odd");
            }

        }

        public static void IsPositiveOrNegative(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else 
            {
                Console.WriteLine("Number is negative");
            }
        }

        public static void CanVote()
        {
            Console.WriteLine("Please enter your age: ");
            bool couldParseAge = int.TryParse(Console.ReadLine(), out int age);
            if (age >= 18) 
            {
                Console.WriteLine("You can vote");
            }
            else 
            {
                Console.WriteLine("You can't vote");
            }
        }

        #endregion

        #region
        public static void IsInRange()
        {
            Console.WriteLine("Please enter a number to check if it's between a range: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            if (number > -10 && number < 10) 
            {
                Console.WriteLine("Is in range");
            }
            else 
            {
                Console.WriteLine("Not in range");
            }
        }

        public static void MultTable(int number)
        {
            for (int i = 1; i <= 12; i++)
            { 
                Console.WriteLine($"{number} * {i} = {number * i}");
            }

        }
        #endregion
    }
}
