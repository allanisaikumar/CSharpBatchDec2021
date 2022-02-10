using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        Class1 p = new Class1();
    //        p.Display();


    //        Console.ReadKey();

    //    }
    //}

    ////class ClassA
    ////{
    ////    void Display()
    ////    {
    ////        Console.WriteLine();
    ////    }
    ////}

    ////public abstract class ClassB
    ////{
    ////    public abstract void Display();
    ////}

    //// This can only have abstarct methods.
    //interface IInterface1
    //{
    //    // abstract methods.
    //    void Display();
    //}


    //class Class1 : IInterface1
    //{
    //    public void Display()
    //    {
    //        Console.WriteLine("Class1.Display");
    //    }
    //}


    //interface IPerson
    //{
    //    string Name { get; set; }
    //    string Gender { get; set; }

    //    void Display();
    //}

    //class Student : IPerson
    //{
    //    public string Name { get;set; }
    //    public string Gender { get; set; }

    //    public int StdID { get; set; }

    //    public int Marks { get; set; }

    //    public void Display()
    //    {
    //        Console.WriteLine("Student Name:" + Name);
    //        Console.WriteLine("Student Gender:" + Gender);
    //        Console.WriteLine("Student ID:" + StdID);
    //        Console.WriteLine("Student Marks:" + Marks);
    //    }
    //}

    //class Employee : IPerson
    //{
    //    public string Name { get; set; }
    //    public string Gender { get; set; }

    //    public int EmpID { get; set; }
    //    public int Sal { get; set; }

    //    public void Display()
    //    {
    //        Console.WriteLine("EMployee Name:" + Name);
    //        Console.WriteLine("EMployee Gender:" + Gender);
    //        Console.WriteLine("EMployee ID:" + EmpID);
    //        Console.WriteLine("EMployee Sal:" + Sal);
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Student s = new Student();
    //        s.Name = "XYZ";
    //        s.Gender = "Male";
    //        s.StdID = 123;
    //        s.Marks = 75;
    //        s.Display();


    //        Employee e = new Employee();
    //        e.Name = "Emp XYZ";
    //        e.Gender = "Male";
    //        e.EmpID = 123;
    //        e.Sal = 1000;

    //        e.Display();

    //        Console.ReadKey();
    //    }
    //}



    //interface I1
    //{
    //    void Method1();
    //    void Method2();
    //}


    //interface I2
    //{
    //    void Method3();
    //    void Method4();
    //}

    //class C1 : I1, I2
    //{
    //    public void Method1()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Method2()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Method3()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Method4()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}


    //abstract class AC1
    //{
    //    public abstract void Method1();
    //    public abstract void Method2();
    //}
    //abstract class AC2
    //{
    //    public abstract void Method3();
    //    public abstract void Method4();
    //}


    //class C2 : AC1, I1, I2
    //{
    //    public override void Method1()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public override void Method2()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Method3()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Method4()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}



    //// Multilevel Interfaces


    //interface IParentInterface
    //{
    //    void Display1();
    //}

    //interface IChildInterface
    //{
    //    void Display2();
    //}


    //class Test : IChildInterface, IParentInterface
    //{
    //    public void Display1()
    //    {
    //        Console.WriteLine("Test.Display1");
    //    }

    //    public void Display2()
    //    {
    //        Console.WriteLine("Test.Display2");
    //    }
    //}


    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Test p = new Test();

    //        // create a reference vaiable for IParentInterface.
    //        IParentInterface i1;
    //        IChildInterface i2;

    //        i1 = p;
    //        i2 = p;




    //        Console.ReadKey();

    //    }
    //}



    interface Interface1
    {
        void Display();
    }


    class Class1 : Interface1
    {
        public void Display()
        {
            Console.WriteLine("Class1.Display");
        }
    }

    class Class2 : Interface1
    {
        public void Display()
        {
            Console.WriteLine("Class2.Display");
        }
    }



    class Program
    {
        static void Main()
        {
            //create a reference variable of interface type.
            Interface1 i;

            //creating objet of class1
            i = new Class1();
            i.Display();

            i = new Class2();
            i.Display();



            Console.ReadKey();
        }
    }
}
