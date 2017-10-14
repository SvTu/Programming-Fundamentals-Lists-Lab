using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            input.Sort();
            int count = 1;

            for (int i = 0; i < (input.Count - 1); i++)
            {
                if (input[i] == input[i + 1])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", input[i], count);
                    count = 1;
                }
            }
            Console.WriteLine("{0} -> {1}",input[input.Count -1], count);
        }
    }
}
