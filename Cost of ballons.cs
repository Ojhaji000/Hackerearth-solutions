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
            // code here



            int testCaseNum = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCaseNum; i++)
            {
                string[] ballonsCost = Console.ReadLine().Split(' ');

                int[] ballonsCostInt = new int[2];
                int m = 0;
                foreach (string ballon in ballonsCost)
                {
                    ballonsCostInt[m] = int.Parse(ballon);
                    m++;
                }

                int participantsNum = int.Parse(Console.ReadLine());

                //storing the question solving pattern by the people                
                string[] quesSolvingPatternOfPeople = new string[participantsNum];
                for (int j = 0; j < participantsNum; j++)
                {
                    quesSolvingPatternOfPeople[j] = Console.ReadLine();
                }

                // number of people that solved question 1 and 2
                int[] numOfPeopleWhoSolvedQues = new int[2];
                for (int k = 0; k < participantsNum; k++)
                {
                    if (quesSolvingPatternOfPeople[k][0] == '1')
                    {
                        // first element of arrays numOfPeopleWhoSolvedQues is for question 1
                        numOfPeopleWhoSolvedQues[0]++;
                    }
                    if (quesSolvingPatternOfPeople[k][2] == '1')
                    //the reason I am taking index position 2 is that the 0space0, in this form the pattern is stored

                    {
                        // first element of arrays numOfPeopleWhoSolvedQues is for question 2
                        numOfPeopleWhoSolvedQues[1]++;
                    }
                }
                int costing = numOfPeopleWhoSolvedQues.Max() * ballonsCostInt.Min() + numOfPeopleWhoSolvedQues.Min() * ballonsCostInt.Max();
                Console.WriteLine(costing);
            }
            //Console.ReadLine();
        }
    }
}
