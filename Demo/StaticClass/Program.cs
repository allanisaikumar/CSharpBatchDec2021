using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SampleClass sampleClass = new SampleClass();
            sampleClass.Display();

//            SampleStaticClass sampleStaticClass = new SampleStaticClass();

            SampleStaticClass.Display();
            SampleStaticClass.Display();
            SampleStaticClass.Display();
            SampleStaticClass.Display();


        }
    }

    static class SampleStaticClass
    {
        public static int One { get; set; }
        public static void Display()
        {
            Console.WriteLine("Dipplay in Static Class");
        }

    }


    class SampleClass
    {
        public int One { get; set; }
        public void Display()
        {
            Console.WriteLine("Dipplay in Normal Class");
        }

        static SampleClass()
        {

        }
    }

}
