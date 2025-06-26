using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, -8, 2, -3, 7, 1 };

            if (arr.Length < 2)
            {
                Console.WriteLine("Массив должен содержать минимум два элемента.");
                return;
            }

            FindAnswer(arr);
        }

        private static void FindAnswer(int[] arr)
        {
            int min1 = int.MaxValue;
            int min2 = int.MaxValue;

            foreach (int num in arr)
            {
                if (num <= min1)
                {
                    min2 = min1;
                    min1 = num;
                }
                else if (num < min2)
                {
                    min2 = num;
                }
            }

            Console.WriteLine($"Минимальная пара: ({min1}, {min2})");
            Console.WriteLine($"Сумма: {min1 + min2}");
        }
    }
}
