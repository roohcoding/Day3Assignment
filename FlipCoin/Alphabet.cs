﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Assignment
{
    internal class Alphabet
    {
        public static void vowelConsonantMethod()
        {
            Console.WriteLine();
            Console.WriteLine("Enter any alphabet ");
            string input = Console.ReadLine();


            switch (input)
            {
                case "a":
                    Console.WriteLine("Entered alphabet is a vowel : " + input);
                    break;
                case "i":
                    Console.WriteLine("Entered alphabet is a vowel : " + input);
                    break;
                case "o":
                    Console.WriteLine("Entered alphabet is a vowel : " + input);
                    break;
                case "u":
                    Console.WriteLine("Entered alphabet is a vowel : " + input);
                    break;
                case "e":
                    Console.WriteLine("Entered alphabet is a vowel : " + input);
                    break;
                default:
                    Console.WriteLine("Entered alphabet is a consonant : " + input);
                    break;
            }

        }
    }
}
