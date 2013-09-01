using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _08.ExtractSentances
{
    class ExtractSentances
    {
        //Write a program that extracts from a given text all sentences containing given word.
        static void Main(string[] args)
        {
            string input = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string lookingFor = "in";

            foreach (Match sentence in Regex.Matches(input, @"\s*([^\.]*\b" + lookingFor + @"\b.*?\.)"))
                Console.WriteLine(sentence.Groups[1]);

            Console.ReadLine();
        }
    }
}
