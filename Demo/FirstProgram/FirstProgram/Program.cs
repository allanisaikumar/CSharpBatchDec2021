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

            //// String

            //string s = "Mani !@#$%^ 121232    Sai";
            //Console.WriteLine(s);

            //bool b = false;
            //Console.WriteLine(b);

            //char c = 'a';
            //Console.WriteLine(c);

            //// Session - 2 -  Data Types - End

            //Assignment - 1
            // Use of Variables, Displaying Min and Max of all the Datatypes.



            // Opertaiors - Start


            // Assignment Operator example
            // Single = is the assignment operator
            int i = 10;
            bool b = true;

            int p = 1, q = 10;
            int z = q; // q = 10


            // For dividing 2 numbers we can use either
            // % or / operators
            int numerator = 14;
            int denominator = 3;

            // Arithmentic operator / returns quotient
            int quotient = numerator / denominator;
            Console.WriteLine("Quotient = {0}", quotient);


            // Arithmentic operator % returns remainder
            int remainder = numerator % denominator;
            Console.WriteLine("Remainder = {0}", remainder);

            int sum = numerator + denominator;
            int substract = numerator - denominator;
            int multiplication = numerator * denominator;

            Console.WriteLine("Sum of {0} + {1} = {2}", numerator, denominator, sum);
            //Console.WriteLine("Sum of {0} + {1} = {2}", numerator, denominator, numerator + denominator);

            Console.WriteLine("Sum of {0} - {1} = {2}", numerator, denominator, substract);
            Console.WriteLine("Sum of {0} * {1} = {2}", numerator, denominator, multiplication);


            // To compare if 2 numbers are
            // equal use comparison operator ==
            int number = 10;
            if (number == 10) // if(true)
            {
                Console.WriteLine("Number is equal to 10");
            }

            // To compare if 2 numbers are not
            // equal use comparison operator !=
            if (number != 5) // if(true)
            {
                Console.WriteLine("Number is not equal to 5");
            }

            // When && operator is used all the conditions must
            // be true for the code in the "if" block to be executed
            int number1 = 10;
            int number2 = 20;

            if (number1 == 10 && number2 == 20)
            {
                Console.WriteLine("Both conditions are true");
            }

            // When || operator is used the code in the "if" block
            // is excuted if any one of the condition is true
            number1 = 10;
            number2 = 21;

            if (number1 == 10 || number2 == 20)
            {
                Console.WriteLine("Atleast one of the condition is true");
            }


            if (number1 <= 15 && number2 >= 5)
            {
                Console.WriteLine("Both conditions are true");
            }

            //Assignment - 2 Pass or Fail based on 5 subject marks.


            //Assignment  - 3
            /*
             AND (&&)

            true && true - 
            true && false  - 
            false && false - 
            false && false - 

             */

            /*
            OR (||)

           true && true - 
           true && false - 
           false && false - 
           false && false -
            
            */

            /*
            // Ternary Operator

            Console.WriteLine("Ternary Operator");

            int num = 100;

            bool boolean;

            if (num == 101)
            {
                boolean = true;
            }
            else
            {
                boolean = false;
            }

            Console.WriteLine("Num == 100 is {0}", boolean);

            boolean = num == 100 ? true : false;

            Console.WriteLine("Num == 100 is {0}", boolean);

            //Null Coalescing Operator ?? 
            string gender = null;
            string gender1 = "null";
            string gender2 = "U";


            Console.WriteLine("Gender : {0} ", gender ?? gender1 ?? gender2 ?? "XYZ");

            */




            Console.ReadKey();
        }
    }
}
