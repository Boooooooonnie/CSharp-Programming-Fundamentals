using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0304
{
    class Student
    {
        public string Name { get; set; }
        private int average;
        public Student(string studentName, int studentAverage)
        {
            Name = studentName;
            average = studentAverage;
        }
        public int Average
        {
            get
            {
                return average;
            }
            set
            {
                if(value > 0 && value <= 100)
                {
                    average = value;
                }
            }
        }
        public string LetterGrade
        {
            get
            {
                string letterGrade = string.Empty;
                if(average >= 90)
                {
                    letterGrade = "A";
                }else if(average >= 80)
                {
                    letterGrade = "B";
                }else if (average >= 70)
                {
                    letterGrade = "C";
                }else if(average >= 60)
                {
                    letterGrade = "D";
                }else
                {
                    letterGrade = "F";
                }
                return letterGrade;
            }
        }
    }
}
