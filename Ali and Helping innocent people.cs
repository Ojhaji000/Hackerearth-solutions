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
            // 

            
            string inputTag = Console.ReadLine();
            if ((Convert.ToInt32(inputTag[0]) + Convert.ToInt32(inputTag[1])) % 2 != 0)
            {
                Console.WriteLine("invalid");
            }
            else if (inputTag[2] == 'A' || inputTag[2] == 'E' || inputTag[2] == 'I' || inputTag[2] == 'O' || inputTag[2] == 'U' || inputTag[2] == 'Y')
            {
                Console.WriteLine("invalid");
            }
            else if ((Convert.ToInt32(inputTag[3]) + Convert.ToInt32(inputTag[4])) % 2 != 0)
            {
                //
                Console.WriteLine("invalid");
            }
            else if ((Convert.ToInt32(inputTag[4]) + Convert.ToInt32(inputTag[5])) % 2 != 0)
            {
                Console.WriteLine("invalid");
            }
            else if ((Convert.ToInt32(inputTag[4]) + Convert.ToInt32(inputTag[5])) % 2 != 0)
            {
                Console.WriteLine("invalid");
            }
            else if((Convert.ToInt32(inputTag[7]) + Convert.ToInt32(inputTag[8])) % 2 != 0)
            {
                Console.WriteLine("invalid");

            }
            else
            {
                Console.WriteLine("valid");
            }






            Console.ReadLine();
        }
    }
}





