using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.InTextSearch
{
    class InTextSearch
    {
        //Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
        static void Main(string[] args)
        {
            string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string lookingFor = "in";
            int counter = 0;
            text = text.ToLower();
            for (int i = 0; i < text.Length - lookingFor.Length + 1; i++)
            {
                if (text.Substring(i, lookingFor.Length) == lookingFor)
                {
                    counter++;
                }
            }
            Console.WriteLine("\"{0}\" is contained {1} times", lookingFor, counter);
            Console.ReadLine();
        }
    }
}
