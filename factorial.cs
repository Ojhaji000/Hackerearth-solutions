using System;
using System.Collections.Generic;
using System.Linq;

using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int prod = 1;
            for (int i = num; i > 0; i--)
            {
                prod = prod * i;
            }
            Console.WriteLine(prod);
            Console.ReadLine();
        }
    }
}





