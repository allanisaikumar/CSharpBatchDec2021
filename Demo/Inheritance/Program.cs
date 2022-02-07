using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parent parent = new Parent();

            //Child child = new Child();

            //SuperChild superChild = new SuperChild();

            //Console.WriteLine(parent.Method1());



            //Bird b = new Peackock();

            //b.Fly();

            Peackock p = new Peackock();

            p.Fly();

            NewBird newBird = new NewBird();
            newBird.

            // Lab - Perform Multiple Level inheriance
            // along with virtual(parent) , overide (child), child overide(super child).




            Console.ReadKey();
        }
    }





    class Bird
    {
        public virtual void Dance()
        {

        }

        public virtual void Fly()
        {
            Console.WriteLine("Birds flys");
        }
    }

    class Peackock : Bird // Derived class
    {
        public sealed override void Dance()
        {
            Console.WriteLine("Peacock Dance");
        }

        public  override void Fly() // Derived class method
        {
            base.Fly();

            Bird b = new Bird();
            //b.Fly();
            Console.WriteLine("Peacock Flys");
        }
    }

    class NewBird : Peackock
    {
        public override void Dance()
        {
            Console.WriteLine("New Bird Dance");
        }

    }















    //internal class Parent
    //{
    //    public string Name { get; set; }
    //    public string Place { get; set; }
    //    public string Property { get; set; }

    //    public virtual string Method1()
    //    {
    //        return "Method 1 from Parent";
    //    }
    //}


    //internal class Child : Parent
    //{
    //    public string Name { get; set; }
    //    public string Place { get; set; }

    //    public override string Method1()
    //    {
    //        return "Method 1 Child";
    //    }
    //}


    //internal class SuperChild : Child
    //{

    //}

}
