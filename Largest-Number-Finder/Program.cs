using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 期中指定考_2._25._03._29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number : ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number : ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Enter number : ");
            int n3 = int.Parse(Console.ReadLine());
            Console.Write("Enter number : ");
            int n4 = int.Parse(Console.ReadLine());
            Console.Write("Enter number : ");
            int n5 = int.Parse(Console.ReadLine());
            List<int> number = new List<int>() { n1, n2, n3, n4, n5 };
            number.Sort();
            Console.WriteLine($"Largest is {number[4]}");
            Console.WriteLine($"Second largest is {number[3]}");
            Console.ReadLine();
        }
    }
}
