using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0218上課
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("case1.格式化輸出");
            string person = "Bonnie";
            Console.WriteLine($"Hi, {person}!");

            Console.WriteLine("case2.");
            int n1, n2, sum;
            Console.Write("Input 1 integer:");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Input 1 integer:");
            n2 = int.Parse(Console.ReadLine());
            sum = n1 + n2;
            Console.WriteLine($"Total:{sum}");

            Console.WriteLine("case3.");
            int n3, n4;
            Console.Write("Input 1 integer:");
            n3 = int.Parse(Console.ReadLine());
            Console.Write("Input 1 integer:");
            n4 = int.Parse(Console.ReadLine());
            if (n3 < n4)
            {
                Console.WriteLine($"{n3} < {n4}");
            }else if(n3 > n4)
            {
                Console.WriteLine($"{n3} > {n4}");
            }
            else
            {
                Console.WriteLine($"{n3} = {n4}");
            }
            Console.Read();
        }
    }
}
