using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 3, 8, 6, 7, 2, 9, 4, 10, 1,
                        12, 8, 15, 13, 11, 16, 14, 18, 17, 19,
                        20, 22, 21, 23, 25, 24, 26, 27, 29, 28 };

            if (array[0] > array[1])
            {
                Console.WriteLine(array[0]);
            }

            for (int i = 1; i < array.Length-1; i++)
            {
                if (array[i] > array[i+1] && array[i] > array[i - 1])
                {
                    Console.WriteLine(array[i]);
                }
            }

            if (array[array.Length-1] > array[array.Length - 2])
            {
                Console.WriteLine(array[array.Length - 1]);
            }
        }
    }
}