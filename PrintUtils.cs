﻿using System;
using System.Linq;
using System.Text;

namespace bordertale
{
    class PrintUtils
    {
        public static void PadHash(string text, int length)
        {
            string finalString = '#' + text + '#';
            while (length > finalString.Length)
            {
                finalString = finalString.Insert(1, " ");
                if (length > finalString.Length)
                {
                    finalString = finalString.Insert(finalString.Length - 1, " ");
                }
            }

            Console.WriteLine(finalString);
        }
        
        public static void GetHash(int length)
        {
            var finalString = new string('#', length);
            Console.WriteLine(finalString.ToString());
        }
    }
}
