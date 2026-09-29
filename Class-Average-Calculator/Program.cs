using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0304_1
{
    class ClassAverage
    {
        static void Main()
        {
            int total = 0;
            int gradeCounter = 1;
            Console.Write("Enter grade or -1 to quit: ");
            int grade = int.Parse(Console.ReadLine());
            while(grade != -1)
            {
                total = total + grade;
                gradeCounter = gradeCounter + 1;
                Console.Write("Enter grade or -1 to quit: ");
                grade = int.Parse(Console.ReadLine());
            }
            if(gradeCounter != 0)
            {
                double average = (double)total / gradeCounter;
                Console.WriteLine($"Average is : {average:f}");
                Console.Read();
            }
        }
    }
}
