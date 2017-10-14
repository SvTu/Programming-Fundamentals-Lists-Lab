using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < input.Count - 1;)
            {
                if (input[i] == input[i + 1])
                {
                    double sum = input[i] + input[i + 1];
                    input.Remove(input[i]);
                    input[i] = sum;
                    i = 0;
                }
                else
                {
                    i++;
                }
               
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
