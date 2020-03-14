using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ProperFractions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Fraction:");
            string userInput = Console.ReadLine();

            int pos = userInput.LastIndexOf("/") + 1;
            int denominator = Convert.ToInt32(userInput.Substring(pos, userInput.Length-pos)); // writes denominator
            int pos2 = userInput.IndexOf("/") - 1;
            int numerator = Convert.ToInt32( userInput.Substring(0, pos2+1));

            if (numerator > 0 && denominator > 0)
            {
                if (numerator > denominator)
                {
                    Console.WriteLine("Fraction is Improper!");
                }
                if (denominator > numerator)
                {
                    Console.WriteLine("Fraction is Proper!");
                }
                Console.ReadKey();

            }
            else
            {
                if (numerator > denominator)
                {
                    Console.WriteLine("Fraction is Improper!");
                }
                if (denominator > numerator)
                {
                    Console.WriteLine("Fraction is Proper!");
                }
                Console.ReadKey();
            }

        }
    }
}
