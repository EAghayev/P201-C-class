using System;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {

            #region anonym object
            //string[] names = { "Hesen", "Huseyn", "Elmar", "Eli", "Fatime" };
            //string[] surnames = { "Abbbasov", "Abdullayev", "Elmarov", "Eliyev", "Abbasova" };
            //byte[] ages = { 15, 16, 14, 16, 15};

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine($"{names[i]} {surnames[i]} {ages[i]}");
            //}

            //var student1 = new
            //{
            //    name="Hesen",
            //    surname="Abbasov",
            //    age = 15
            //};

            //var student2 = new
            //{
            //    name = "Huseyn",
            //    surname = "Abdullayev",
            //    age = 14
            //};

            //var student3 = new
            //{
            //    fullName = "Fatime Hikmetova",
            //    age = 15
            //};

            //Console.WriteLine($"{student1.name} {student1.surname} {student1.age}");
            //Console.WriteLine($"{student2.name} {student2.surname} {student2.age}");
            //Console.WriteLine($"{student3}");
            #endregion

            Human human1 = new Human
            {
                Name = "Tofiq",
                Surname = "Abdullayev",
                Age = 16,
            };

            human1.Age = 42;

            Human human2 = new Human();

            human2.Name = "Gulnar";
            human2.Surname = "Abbaszade";
            human2.Age = 14;
            human2.FatherName = "Father";

            Console.WriteLine($"{human1.Name} {human1.Surname} {human1.Age}");
            Console.WriteLine($"{human2.Name} {human2.Surname} {human2.Age}");

            Human[] humans = new Human[] { human1, human2 };

            for (int i = 0; i < humans.Length; i++)
            {
                Console.WriteLine(humans[i].Name +" "+humans[i].Surname);
            }

            Student std1 = new Student();

            std1.Name = "Togrul";
            std1.Surname = "Togrulov";
            std1.Age = 90;
            std1.AbsenceCount = 10;
            std1.GroupNo = "P201";
            std1.Age = 70;
            std1.FatherName = "Ata adi";

            Student std2 = new Student
            {
                Name = "Elsen",
                Surname = "Elsenov",
                Age = 16,
                AbsenceCount = 2,
                GroupNo = "P201"
            };

            Teacher tch1 = new Teacher
            {
                Name = "Hikmet",
                Surname = "Abbasov",
                Age = 45,
                FatherName = "Tofiq",
                Salary = 4500
            };

            Console.WriteLine(tch1.Name);
        }
    }

}
