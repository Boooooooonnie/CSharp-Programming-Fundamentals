using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 期中指定考_4._25._03._30
{
    class Student
    {
        public Student(string studentid, string studentname, decimal grade1, decimal grade2)
        {
            ID = studentid;
            Name = studentname;
            Subject1 = grade1;
            Subject2 = grade2;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        decimal g1, g2;
        public decimal Subject1
        {
            get
            {
                return g1;
            }
            private set
            {
                if(value > 0)
                {
                    g1 = value;
                }
                else
                {
                    g1 = 0;
                }
            }
        }
        public decimal Subject2
        {
            get
            {
                return g2;
            }
            private set
            {
                if (value > 0)
                {
                    g2 = value;
                }
                else
                {
                    g2 = 0;
                }
            }
        }
        public decimal GetAggregate() //sum of two grades
        {
            return Subject1 + Subject2;
        }
        public decimal GetPercentage()
        {
            return Math.Round((GetAggregate() / 240) * 100, 2);
        }
        public void Update(string newid, string newname, decimal newgrade1, decimal newgrade2)
        {
            ID = newid;
            Name = newname;
            Subject1 = newgrade1;
            Subject2 = newgrade2;
        }
        public void Display()
        {
            Console.WriteLine($"Student ID: {ID}");
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Subject1: {Subject1}");
            Console.WriteLine($"Subject2: {Subject2}");
            Console.WriteLine($"Aggregate: {GetAggregate()}");
            Console.WriteLine($"Precentage: {GetPercentage()}");
        }
    }
class StudentRecordTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student information");
            Student stud1 = new Student("A01", "Mary", 60, 90);
            stud1.Display();
            Console.WriteLine("\nStudent with changed information");
            stud1.Update("A110", "Mary", 120, 90);
            stud1.Display();
            Console.WriteLine("\nOriginal student information");
            Student stud2 = new Student("A02", "John", 80, 70);
            stud2.Display();
            Console.WriteLine("\nUpdate student information");
            stud2.Update("A220", "John", 80, 105);
            stud2.Display();
            Console.Read();
        }
    }
}
