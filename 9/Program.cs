using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "()(()(()))";

            int depth = 0;
            int maxDepth = 0;

            foreach (char c in str)
            {
                if (c == '(')
                {
                    depth++;
                }
                else
                {
                    depth--;
                }
                if (depth < 0)
                {
                    Console.WriteLine("Некорректная строка");
                    Environment.Exit(0);
                }
                if (depth > maxDepth)
                {
                    maxDepth = depth;
                }
            }

            if (depth == 0)
            {
                Console.WriteLine("Корректная строка");
                Console.WriteLine(maxDepth);
            }
            else
            {
                Console.WriteLine("Некорректная строка");
            }
        }
    }
}