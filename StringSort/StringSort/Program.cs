﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Microsoft .NET Framework 2.0 Application Development Foundation";
            string[] words = str.Split(' ');

            Array.Sort(words);

            string sortedString = string.Join(" ",words);
            Console.WriteLine(sortedString);
        }
    }
}
