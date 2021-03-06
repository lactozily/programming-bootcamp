﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "---------------------------------------------------------";
            string border = "|\t\t\t\t\t\t\t|";
            int result = 2;

            Console.WriteLine(line);
            Console.WriteLine("|\t\t  Multiplication Table\t\t\t|");
            Console.WriteLine(line);

            for (int number = 2; number < 13; number++)
            {
                Console.WriteLine(border);
                for (int multiplier = 1; multiplier < 13; multiplier++)
                {
                    result = number * multiplier;
                    Console.WriteLine("|\t{0}\tx\t{1}\t=\t{2}\t\t|", number, multiplier, result);
                    Console.WriteLine(border);
                }
                Console.WriteLine(line);
            }

            Console.Read();
        }
    }
}
