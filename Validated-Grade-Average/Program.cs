using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 期中指定考_1._25._03._29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter grade within 0 and 100, or -1 to quit : ");
            int score = int.Parse(Console.ReadLine());
            int sumofscore = 0;
            int count = 0;
            while (score != -1)
            {
                if(score<0 || score > 100)
                {
                    Console.WriteLine("Invalid input");
                }
                else
                {
                    sumofscore = sumofscore + score;
                    count++;
                }
                Console.Write("Enter grade within 0 and 100, or -1 to quit : ");
                score = int.Parse(Console.ReadLine());
            }
            if(count != 0)
            {
                double averageofscore = (double)sumofscore / count;
                Console.WriteLine($"Total of the {count} grade is {sumofscore}");
                Console.WriteLine($"Class average is {averageofscore:f2}");
            }
            Console.ReadLine();
        }
    }
}
