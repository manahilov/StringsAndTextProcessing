using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Encryption
{
    class Encryption
    {
        // Write a program that encodes and decodes a string using given encryption key (cipher).
        // The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or)
        // operation over the first letter of the string with the first of the key, the second – with the second, etc.
        // When the last key character is reached, the next is the first.
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string code = "abcdef";
            int[] coded = new int[input.Length];
            int[] decoded = new int[input.Length];
            int codeCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (codeCount == code.Length)
                {
                    codeCount = 0;
                }
                coded[i] = (int)input[i] ^ (int)code[codeCount];

                codeCount++;

            }

            codeCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (codeCount == code.Length)
                {
                    codeCount = 0;
                }
                decoded[i] = (int)coded[i] ^ (int)code[codeCount];

                codeCount++;

            }
            Console.Write("CODED: ");

            foreach (var item in coded)
            {
                Console.Write((char)item);
            }
            Console.WriteLine();
            Console.Write("DECODED: ");
            foreach (var item in decoded)
            {
                Console.Write((char)item);
            }

            Console.ReadLine();
        }
    }
}
