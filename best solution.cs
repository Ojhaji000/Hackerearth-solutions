using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input1 = int.Parse(Console.ReadLine());
            string[] arr = Console.ReadLine().Split(' ');
            long prod = 1;
            for (int i = 0; i< input1;i++)
            {
                prod =  (prod * long.Parse(arr[i]))%(1000000007);
            }
            Console.WriteLine(prod);
        }
    }
}





