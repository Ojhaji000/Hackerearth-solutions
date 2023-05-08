using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //      new int[] {digit,numOfSticks}
            int[][] arr = {
                    new int[] { 0, 6 },
                    new int[] { 1, 2 },
                    new int[] { 2, 5 },
                    new int[] { 3, 5 },
                    new int[] { 4, 4 },
                    new int[] { 5, 5 },
                    new int[] { 6, 6 },
                    new int[] { 7, 3 },
                    new int[] { 8, 7 },
                    new int[] { 9, 6 }
            };



            int sumOfSticks = 0;

            int testCaseNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCaseNum; i++)
            {
                //
                string num = Console.ReadLine();
                for (int j = 0; j < num.Length; j++)
                {
                    int numDigit = Convert.ToInt32(num[j]) - 48;
                    //num[j] is a char data type
                    //the value of zero in ASCII table is 48
                    //need to subtract 48 after converting the char into ASCII value to show the number we want
                    for (int k = 0; k < arr.Length; k++)
                    {
                        //
                        if (numDigit == arr[k][0])
                        {
                            sumOfSticks = sumOfSticks + arr[k][1];
                        }
                    }

                }
                if (sumOfSticks % 2 == 0)
                {
                    string prin = string.Empty;

                    // noOfSticks -> max no.
                    //         2 -> 1
                    //         4 -> 11
                    //         6 -> 111 and so on

                    for (int l = 0; l < (sumOfSticks / 2); l++)
                    {
                        prin += "1";
                    }

                    Console.WriteLine(prin);
                    sumOfSticks = 0;
                }
                else
                {
                    string prin = "7";

                    // noOfSticks -> max no.
                    //         3 -> 7
                    //         5 -> 71
                    //         7 -> 711 and so on
                    for(int m = 0; m < ((sumOfSticks-3)/2); m++)
                    {
                        prin += "1";
                    }
                    Console.WriteLine(prin);
                    sumOfSticks = 0;
                }
            }
            Console.ReadLine();
        }
    }
}





