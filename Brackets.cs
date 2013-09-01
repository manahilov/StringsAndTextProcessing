using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Brackets
{
    class Brackets
    {
        // Write a program to check if in a given expression the brackets are put correctly.
        // Example of correct expression: ((a+b)/5-d).
        // Example of incorrect expression: )(a+b)).
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int temp = 0;
            if (input[0] == ')' || input[input.Length - 1] == '(')
            {
                Console.WriteLine("Incorect!");
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == '(')
                    {
                        temp++;
                    }
                    else if (input[i] == ')')
                    {
                        temp--;
                    }

                }
                if (temp == 0)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorect!");
                }
            }
            Console.ReadLine();
        }
    }
}
