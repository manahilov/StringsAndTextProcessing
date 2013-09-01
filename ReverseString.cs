using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace _02.ReverseString
{
    class ReverseString
    {
        // Write a program that reads a string, reverses it and prints the result at the console.
        // Example: "sample"  "elpmas".
        static void Main(string[] args)
        {
            string s;
            s = Console.ReadLine();
            Console.WriteLine(Reverse(s));
            Console.ReadLine();
        }

        static public string Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }  
    }
}
