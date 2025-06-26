using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 5, 9 };

            int sum = 0;
            foreach (int num in arr)
                sum += num;

            int powerOfTwo = 1;
            while (powerOfTwo < sum)
            {
                powerOfTwo *= 2;
            }

            Console.WriteLine($"Сумма элементов: {sum}");
            Console.WriteLine($"Наименьшая степень двойки большей или равной сумме {sum}: {powerOfTwo}");
        }
    }
}
