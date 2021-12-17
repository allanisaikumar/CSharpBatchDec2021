// namespaced declarations
using System;


// Start of the namespace
namespace FirstProgram
{
    // Class
    class Program
    {
        // Main method - entry point of the application.
        public static void Main(string[] args)
        {
            // Write to Console
            Console.WriteLine("Welcome to C# Sessions");
            //Console.
            //// Writting with help of namespace
            //Console.WriteLine("Welcome to C# Sessions");

            //// This does not need name space inclusion
            //Console.WriteLine("Write using the Fully qualified name");

            // Session - 2 -  Read Write - Start
            ////Prompt the user to provide his name.
            //Console.WriteLine("Please enter your name:");

            //// Read the name from console.
            //string name = Console.ReadLine();

            ////Concatenate name with hello and message.
            //Console.WriteLine("Hello " + name + ", welcome to c# classes ");

            ////Hello Mani, Welcome to classes, wish from XYZ - Mani || if name is Mani
            //Console.WriteLine("Hello {0}, Welcome to classes, wish from {1} - {0}", name, "XYZ");

            // Session - 2 -  Read Write - End

            // Session - 2 -  Data Types - Start

            //sbyte a = 10;
            //byte b = 20;
            //short c = 30;
            //ushort d = 40;
            //int e = 50;
            //uint f = 60;
            //long g = 70;
            //ulong h = 80;
            //float i = 90.23F;
            //double j = 100.23489;
            //decimal k = 110.882932M;

            ////displays the values of all variables
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.WriteLine(e);
            //Console.WriteLine(f);
            //Console.WriteLine(g);
            //Console.WriteLine(h);
            //Console.WriteLine(i);
            //Console.WriteLine(j);
            //Console.WriteLine(k);

            //// Min and Max Values of data types.

            //sbyte sByteMin = sbyte.MinValue;
            //sbyte sByteMax = sbyte.MaxValue;
            
            //Console.WriteLine("sByteMin : {0}", sByteMin);
            //Console.WriteLine("sByteMax : {0}", sByteMax);

            //long longMin = long.MinValue;
            //long longMax = long.MaxValue;

            //Console.WriteLine("longMin : {0}", longMin);
            //Console.WriteLine("longMax : {0}", longMax);

            // String

            string s = "Mani !@#$%^ 121232    Sai";
            Console.WriteLine(s);

            bool b = false;
            Console.WriteLine(b);

            char c = 'a';
            Console.WriteLine(c);

            // Session - 2 -  Data Types - End

            // Use of Variables, Displaying Min and Max of all the Datatypes.






            Console.ReadKey();
        }
    }
}
