using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int elemSum = 0;
            string input = "";
            int[] array = new int[0];
            while (input != "exit")
            {
                foreach (int i in array)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                Console.Write("Введите число или команду: ");
                input = Console.ReadLine();
                if ( int.TryParse(input, out int result))
                {                   
                    elemSum += result;
                    int[] newArray = new int[array.Length + 1];
                    array.CopyTo(newArray, 0);
                    newArray[array.Length] = result;
                    array = newArray;
                }
                else
                {
                    if (input == "exit")
                    {
                        Console.WriteLine("Конец");
                    }
                    else if (input == "sum")
                    {
                        Console.WriteLine(elemSum);
                    }                   
                    else
                    {
                        Console.WriteLine("Данные были введены некорректно, повторите попытку");
                    }
                }
            }
        }
    }
}