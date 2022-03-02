using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbrs = new List<int>() { 50,27,58,45,96,12,11,10,5 };

            //List<int> res = new List<int>();

            ////foreach (var item in collection)
            ////{

            ////}

            //res = (from item in numbrs where (item%2 == 1) select item).ToList();

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item + " ");
            //}

            Student s1, s2, s3, s4;

            s1 = new Student() { Name = "XYZ", Marks = 75, StudentID = 101 };
            s2 = new Student() { Name = "PQR", Marks = 60, StudentID = 102 };
            s3 = new Student() { Name = "Murali", Marks = 81, StudentID = 103 };
            s4 = new Student() { Name = "Hemanth", Marks = 34, StudentID = 104 };

            List<Student> students = new List<Student>();

            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);

            Console.WriteLine("Total Students \n");
            for (int i = 0; i < students.Count; i++)
            {

                Console.Write(students[i].StudentID);
                Console.Write(", ");

                Console.Write(students[i].Name);
                Console.Write(", ");

                Console.Write(students[i].Marks);
                Console.WriteLine();
            }


            List<Student> passedStudents = new List<Student>();

            for (int i = 0; i < students.Count; i++)
            {
                Student s;
                s = students[i];

                if(s.Marks >= 35)
                {
                    passedStudents.Add(s);
                }

            }

            Console.WriteLine("Passed Students \n");
            for (int i = 0; i < passedStudents.Count; i++)
            {

                Console.Write(passedStudents[i].StudentID);
                Console.Write(", ");

                Console.Write(passedStudents[i].Name);
                Console.Write(", ");

                Console.Write(passedStudents[i].Marks);
                Console.WriteLine();
            }


            List<Student> passedSTnds = new List<Student>();

            passedSTnds = (from std in students where std.Marks >= 35 select std).ToList();


            Console.WriteLine("Passed Students Using LINQ \n");
            for (int i = 0; i < passedSTnds.Count; i++)
            {

                Console.Write(passedSTnds[i].StudentID);
                Console.Write(", ");

                Console.Write(passedSTnds[i].Name);
                Console.Write(", ");

                Console.Write(passedSTnds[i].Marks);
                Console.WriteLine();
            }



            Console.ReadLine();
        }
    }

    // LINQ - Language Integrated Query.

    // Syntax - from varibale in collection where condition select variable1;


    class Student
    {

        public string Name { get; set; }
        public int StudentID { get; set; }
        public int Marks { get; set; }

    }


}
