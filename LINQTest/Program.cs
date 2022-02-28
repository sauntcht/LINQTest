using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 99; i++)
            { 
                numbers.Add(i);
            }
            IEnumerable<int> firstAndLastFive = numbers.Take(5).Concat(numbers.TakeLast(5)).Concat(numbers.Take(9));
            foreach (int i in firstAndLastFive)
            {
                if (i % 3 == 0)
                {
                    Console.Write($"{i} ");
                }
                else
                    Console.WriteLine(($"{i}"));
            }
            */
            int[] values = new int[] { 0, 12, 44, 36, 92, 54, 13, 8 };

            IEnumerable<int> result = 
                from v in values
                where v < 50
                orderby -v
                select v;

            foreach (int i in result)
            {
                Console.Write($"{i} ");
            }
            
        }
    }
}
