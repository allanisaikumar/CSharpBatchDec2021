using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Employee employee = new Employee("John" ," Smith");

            //Console.WriteLine(employee.GetFullName());


            //Sample sample = new Sample();

            //sample.Fname = "John";
            //sample.Lname = " Smith";
            //Console.WriteLine(sample.GetFullName());



            //Employee emp = new Employee();

            //emp.Name = "John";
            //emp.Gender = "Male";

            //Employee emp1 = new Employee();

            //emp1.Gender = emp.Gender;
            //emp1.Name = emp.Name;

            //emp.Name = "XYZ";

            //Console.WriteLine(emp1.Name);

            //Console.WriteLine(emp1.Name);
            //Console.WriteLine(emp1.Gender);


            Employee employee = new Employee();
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();


            
            Console.ReadKey();
        }
    }

    //class Employee
    //{
    //    public string Name { get; set; }

    //    public Employee()
    //    {
    //        Console.WriteLine("Inside - Constructor");
    //    }

    //    public void Display()
    //    {
    //        Console.WriteLine("Display from Method");
    //    }

    //}



    //class Employee
    //{
    //    string FullName;
    //    public Employee(string fname, string lname)
    //    {
    //        FullName = fname + lname;
    //    }

    //    public string GetFullName()
    //    {
    //        return FullName;
    //    }
    //}


    //class Sample
    //{
    //    public string Fname { get; set; }
    //    public string Lname { get; set; }

    //    public string GetFullName()
    //    {
    //        return Fname + Lname;
    //    }
    //}


    public class Employee
    {
        static string CompanyName = "PQR";
        static string discount;

        public string Name { get; set; }
        public string Gender { get; set; }

        static Employee()
        {
            discount = "10%";
            Console.WriteLine("Static Constuctor");
        }

        //public Employee()
        //{
        //    Console.WriteLine("Default Constuctor");
        //}


        private Employee()
        {

        }

        //// COpy COnstructor
        //public Employee(Employee employee)
        //{
        //    Name = employee.Name;
        //    Gender = employee.Gender;
        //}

    }


}
