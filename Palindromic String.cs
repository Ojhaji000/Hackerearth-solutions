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
            string input1 = Console.ReadLine();
            int r = input1.Length-1;
            bool situation = true;
            int i = 0, j = input1.Length-1;
            while( situation == true)
            {
                if (input1[i] != input1[j])
                {
                    Console.WriteLine("NO");
                    return;
                }
                i++;
                j--;
                if (i >= j)
                {
                    Console.WriteLine("YES");
                    return;
                }
            }
            Console.ReadLine();
        }
    }
}





