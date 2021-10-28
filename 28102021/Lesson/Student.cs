using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    class Student : Human
    {
        public Student()
        {
            Console.WriteLine("Student obyekti yaradildi");
        }
        public string GroupNo;
        public int AbsenceCount;
    }
}
