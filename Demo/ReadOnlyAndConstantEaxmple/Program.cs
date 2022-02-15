using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyAndConstantEaxmple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(ConstExample.number);  //Console.WriteLine(5); 

            //ConstExample constExample = new ConstExample();
            //ConstExample constExample1 = new ConstExample();


            //constExample.Abc = 20;
            //constExample1.Abc = 20;

            ReadOnlyClass readOnlyClass = new ReadOnlyClass();

            Console.WriteLine(readOnlyClass.SampleReadOnly);


            ReadOnlyClass readOnlyClass1 = new ReadOnlyClass();

            Console.WriteLine(readOnlyClass1.SampleReadOnly);

            //ReadOnlyClass readOnlyClass2 = new ReadOnlyClass(true);
            //Console.WriteLine(readOnlyClass2.SampleReadOnly);


            //const int no = 10;
            //Console.WriteLine(no);



            Console.ReadKey();
        }
    }

    class ConstExample
    {
        int a = 10, b = 20;
        public const int number = 25;
        public int Abc;

        public ConstExample()
        {
            Abc = a * b;
        }
    }


    class Example
    {
        public const int number = 10;        
    }


    class ReadOnlyClass
    {
        public readonly int SampleReadOnly;
        public readonly float SampleReadOnlyFloat;

        //public ReadOnlyClass()
        //{
        //    SampleReadOnly = 25;
        //}

        //public ReadOnlyClass(bool anotherObject)
        //{
        //    SampleReadOnly = 100;
        //}


    }


}
