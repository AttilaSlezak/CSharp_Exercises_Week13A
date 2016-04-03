﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Microsoft .NET Framework 2.0 Application Development Foundation";
            string[] words = text.Split(' ');
            Array.Sort(words);

            text = String.Join(" ", words);
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
