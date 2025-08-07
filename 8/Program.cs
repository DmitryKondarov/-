using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            Console.WriteLine("На сколько позиций сдвинуть?");
            string input = Console.ReadLine();

            for (int iter = 0; iter < Convert.ToInt32(input); iter++)
            {
                int buffer = array[0];
                for (int i = 0; i < array.Length - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                array[array.Length - 1] = buffer;
            }
            

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
    }
}