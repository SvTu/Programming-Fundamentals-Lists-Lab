﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveNegativeAndReverse
{
    class RemoveNegativeAndReverse
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = input.Count - 1; i >= 0 ; i--)
            {
                if (input[i] < 0)
                {
                    input.Remove(input[i]);
                    
                }
            }

            input.Reverse();

            if (input.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", input));
            }
        }
    }
}
