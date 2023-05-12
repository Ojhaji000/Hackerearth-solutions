using System;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int L = int.Parse(Console.ReadLine());

            int photosNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < photosNum; i++)
            {
                string[] inputArr = Console.ReadLine().Split(' ');
                if (int.Parse(inputArr[0]) < L || int.Parse(inputArr[1]) < L)
                {
                    //
                    Console.WriteLine("UPLOAD ANOTHER");
                }
                else
                {
                    if (int.Parse(inputArr[0]) == int.Parse(inputArr[1]))
                    {
                        Console.WriteLine("ACCEPTED");
                    }
                    else
                    {
                        Console.WriteLine("CROP IT");
                    }
                }

            }

            Console.ReadLine();
        }
    }
}





