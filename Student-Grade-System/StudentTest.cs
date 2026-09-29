using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0304
{
    class StudentTest
    {
        static void Main()
        {
            Student student1 = new Student("Jane Green", 93);
            Student student2 = new Student("John Blue", 72);

            Console.WriteLine($"{student1.Name} is {student1.Average}, {student1.LetterGrade}");
            Console.WriteLine($"{student2.Name} is {student2.Average}, {student2.LetterGrade}");

            Console.Read();
        }
    }
}
