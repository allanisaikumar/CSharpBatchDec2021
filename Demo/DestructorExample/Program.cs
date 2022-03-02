using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Class1 c1 = new Class1(); // Contsrutor will be called.

            // ...lines of code
            // ...lines of code
            // ...lines of code

            // ...lines of code

            //using (Class1 c1 = new Class1()) // Contsructor is called.
            //{
            //    c1.Method1(); // Method is called.
            //}// Dispose is called

            // ...lines of code
            // ...lines of code
            // ...lines of code


            Console.ReadKey();
        }// destructor is called here.
    }

    class Class1
    {
        public Class1()
        {
            Console.WriteLine("Constructor");
        }

        public void Method1()
        {
            Console.WriteLine("Method1");
        }

        ~Class1()
        {
            Console.WriteLine("Destructor");
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose");
        }
    }





}
