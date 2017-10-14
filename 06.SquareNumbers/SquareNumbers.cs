using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split().Select(double.Parse).ToList();

            List<double> squareList = new List<double>();

            foreach (var item in input)
            {
                if (Math.Sqrt(item) == (int)Math.Sqrt(item))
                {
                    squareList.Add(item);
                }
            }
            squareList.Sort();
            squareList.Reverse();
            Console.WriteLine(string.Join(" ", squareList));
        }
    }
}
