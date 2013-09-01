using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class FillTheString
    {
        static void Main(string[] args)
        {
            // Write a program that reads from the console a string of maximum 20 characters.
            // If the length of the string is less than 20, the rest of the characters should be filled with '*'.
            // Print the result string into the console.
            string input;
            do
            {
                Console.Write("Input the string /max 20 chars/ : ");
                input = Console.ReadLine();
            } while (input.Length > 20);
            Console.WriteLine(input.Length);
            if (input.Length <= 20)
            {
                Console.WriteLine(input.PadRight(20, '*'));

            }
            Console.ReadLine();

        }
    }
}
