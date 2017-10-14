using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(new char[] {',', ';', ':', '.', '!','(', ')', '"', '\'', '\\', '/', '[', ']', ' '}).ToList();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCace = new List<string>();
            input.RemoveAll(string.IsNullOrEmpty);

            foreach (var item in input)
            {
                if (item.All(char.IsUpper))
                {
                    upperCase.Add(item);
                }
                else if (item.All(char.IsLower))
                {
                    lowerCase.Add(item);
                }
                else
                {
                    mixedCace.Add(item);
                }
            }
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCace));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
        }
    }
}
