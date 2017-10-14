using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AppendList
{
    class AppendList
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('|').ToList();
            List<string> result = new List<string>();

            for (int i = (input.Count -1); i >= 0; i--)
            {
                var lists = input[i].Split();
                foreach (var item in lists)
                {
                    result.Add(item);
                }
            }
            result.RemoveAll(string.IsNullOrEmpty);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
