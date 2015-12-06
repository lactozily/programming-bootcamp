﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of max multiplication table: ");
            int maxNumber = 0;
            maxNumber = Int32.Parse(Console.ReadLine());

            string line = "---------------------------------------------------------";
            string border = "|\t\t\t\t\t\t\t|";
            int result = 2;
            

            Console.WriteLine(line);
            Console.WriteLine("|\t\t  Multiplication Table\t\t\t|");
            Console.WriteLine(line);

            for (int number = 2; number <= maxNumber; number++)
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
