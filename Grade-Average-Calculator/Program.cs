using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 期中指定考_5._25._03._31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter times: ");
            int count = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int x=1; x<=count; x++)
            {
                Console.Write("Enter grade: ");
                int n = int.Parse(Console.ReadLine());
                sum = sum + n;
            }
            double average = Math.Round(((double)sum / count), 2);
            Console.WriteLine($"\nTotal of all {count} grades is {sum}");
            Console.WriteLine($"Class average is {average:f2}");
            Console.Read();
        }
    }
}
