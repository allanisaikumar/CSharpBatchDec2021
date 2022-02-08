using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Person p = new Person(); // This is not possible bcz of Person is a abtsract class.

    //        Student student = new Student();
    //        student.Display();

    //        Employee employee = new Employee();
    //        employee.Display();

    //        System.Console.ReadKey();

    //    }
    //}

    ////parent class (abstract class)
    //abstract class Person
    //{
    //    //normal method in abstract class
    //    public void Display()
    //    {
    //        System.Console.WriteLine("Person.Display");
    //    }
    //}

    ////child class 1
    //class Student : Person
    //{
    //}

    ////child class 2
    //class Employee : Person
    //{
    //}




    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        Student s = new Student();

    //        s.Name = " Murali";
    //        s.Gender = "Male";
    //        s.StudentID = 1;
    //        s.Marks = 70;

    //        s.Display();

    //        Console.WriteLine("Student ID : " + s.StudentID);
    //        Console.WriteLine("Marks : " + s.Marks);

    //        Employee emp = new Employee();

    //        emp.Name = "Emp 1";
    //        emp.Gender = "Male";
    //        emp.EmpID = 100;
    //        emp.Salary = 100;

    //        emp.Display();

    //        Console.WriteLine("Emp ID : " + emp.EmpID);
    //        Console.WriteLine("Sal : " + emp.Salary);


    //        Console.ReadKey();
    //    }
    //}


    //abstract class Person
    //{
    //    public string Name { get; set; }
    //    public string Gender { get; set; }

    //    public void Display()
    //    {
    //        Console.WriteLine("Person Name : " + this.Name);
    //        Console.WriteLine("Gender : " + this.Gender);
    //    }
    //}

    //class Student : Person
    //{
    //    public int StudentID;
    //    public int Marks;
    //}


    //class Employee : Person
    //{
    //    public int EmpID;
    //    public double Salary;
    //}


    internal class Program
    {
        static void Main(string[] args)
        {
            Class2 c2 = new Class2();
            c2.Display();

            Console.ReadLine();
        }
    }


    abstract class Class1
    {
        public abstract void Display();
    }


    abstract class Class2 : Class1
    {
        public override void Display()
        {
            Console.WriteLine("Class2.Display");
        }
        public virtual void VDisplay()
        {
            Console.WriteLine("VD");
        }

        public abstract void ADisplay();

    }

    class Class3 : Class2
    {
        public override void Display()
        {
            base.Display();
        }
    }



    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        Student s = new Student();

    //        s.Name = " Murali";
    //        s.Gender = "Male";
    //        s.StudentID = 1;
    //        s.Marks = 70;

    //        s.Display();


    //        Employee emp = new Employee();

    //        emp.Name = "Emp 1";
    //        emp.Gender = "Male";
    //        emp.EmpID = 100;
    //        emp.Sal = 100;

    //        emp.Display();

    //        Console.ReadLine();
    //    }
    //}


    //abstract class Person
    //{
    //    public string Name { get; set; }
    //    public string Gender { get; set; }

    //    public abstract void Display();

    //}

    //class Student : Person
    //{
    //    public int StudentID;
    //    public int Marks;
    //    public override void Display()
    //    {
    //        Console.WriteLine("Student Name : " + base.Name);
    //        Console.WriteLine("Gender : " + base.Gender);
    //        Console.WriteLine("Student ID : " + this.StudentID);
    //        Console.WriteLine("Student Marks : " + this.Marks);
    //    }
    //}


    //class Employee : Person
    //{
    //    public int EmpID;
    //    public int Sal;
    //    public override void Display()
    //    {
    //        Console.WriteLine("Employee Name : " + base.Name);
    //        Console.WriteLine("Gender : " + base.Gender);
    //        Console.WriteLine("Employee ID : " + this.EmpID);
    //        Console.WriteLine("Employee Sal : " + this.Sal);
    //    }
    //}

}
