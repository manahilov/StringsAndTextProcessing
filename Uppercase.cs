using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _05.Uppercase
{
    class Uppercase
    {
        // You are given a text. Write a program that changes the text in all regions
        // surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested.
        static void Main(string[] args)
        {
            string input = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            Console.WriteLine(Regex.Replace(input, "<upcase>(.*?)</upcase>", p => p.Groups[1].Value.ToUpper()));
            Console.ReadLine();
        }
    }
}
