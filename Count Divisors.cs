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
            string[] inputArr = Console.ReadLine().Split(' ');
            int startingNum = int.Parse(inputArr[0]);
            int endNum = int.Parse(inputArr[1]);
            int divisor = int.Parse(inputArr[2]);
            int count = 0;
            for(int i = startingNum; i <= endNum; i++) {

                if (i % divisor == 0) {
                    //Console.WriteLine($"dividend = {i} and divisor = {divisor}");

                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}





