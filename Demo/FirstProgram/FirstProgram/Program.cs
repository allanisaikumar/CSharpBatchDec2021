// namespaced declarations
using System;


// Start of the namespace
namespace FirstProgram
{
    // Class
    class Program
    {
        // Main method - entry point of the application.
        static void Main(string[] args)
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
            //int i = 10;
            //bool b = true;

            //int p = 1, q = 10;
            //int z = q; // q = 10


            //// For dividing 2 numbers we can use either
            //// % or / operators
            //int numerator = 14;
            //int denominator = 3;

            //// Arithmentic operator / returns quotient
            //int quotient = numerator / denominator;
            //Console.WriteLine("Quotient = {0}", quotient);


            //// Arithmentic operator % returns remainder
            //int remainder = numerator % denominator;
            //Console.WriteLine("Remainder = {0}", remainder);

            //int sum = numerator + denominator;
            //int substract = numerator - denominator;
            //int multiplication = numerator * denominator;

            //Console.WriteLine("Sum of {0} + {1} = {2}", numerator, denominator, sum);
            ////Console.WriteLine("Sum of {0} + {1} = {2}", numerator, denominator, numerator + denominator);

            //Console.WriteLine("Sum of {0} - {1} = {2}", numerator, denominator, substract);
            //Console.WriteLine("Sum of {0} * {1} = {2}", numerator, denominator, multiplication);


            //// To compare if 2 numbers are
            //// equal use comparison operator ==
            //int number = 10;
            //if (number == 10) // if(true)
            //{
            //    Console.WriteLine("Number is equal to 10");
            //}

            //// To compare if 2 numbers are not
            //// equal use comparison operator !=
            //if (number != 5) // if(true)
            //{
            //    Console.WriteLine("Number is not equal to 5");
            //}

            //// When && operator is used all the conditions must
            //// be true for the code in the "if" block to be executed
            //int number1 = 10;
            //int number2 = 20;

            //if (number1 == 10 && number2 == 20)
            //{
            //    Console.WriteLine("Both conditions are true");
            //}

            //// When || operator is used the code in the "if" block
            //// is excuted if any one of the condition is true
            //number1 = 10;
            //number2 = 21;

            //if (number1 == 10 || number2 == 20)
            //{
            //    Console.WriteLine("Atleast one of the condition is true");
            //}


            //if (number1 <= 15 && number2 >= 5)
            //{
            //    Console.WriteLine("Both conditions are true");
            //}

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

            // C# types

            //int p1 = 1, p2 = 2;

            //int res = Method1(ref p1, ref p2);

            //Console.WriteLine("p1 - {0}, p2 - {1}, res = {2}", p1, p2, res);



            //int notNullvariable;
            //int? nullableVariable = 6;

            //Console.WriteLine("Print - {0}", (int)nullableVariable);

            //if (nullableVariable == null)
            //{
            //    notNullvariable = 0;
            //}
            //else
            //{
            //    notNullvariable = (int)nullableVariable;
            //}

            //Console.WriteLine("Value = {0}", notNullvariable);

            //notNullvariable = nullableVariable ?? 0;


            //Implicit Conversion

            // float, double,long
            // int can be assigned to all above ones.

            //int x = 100;
            //float y = x;

            //Console.WriteLine(y);


            //float f = 500.25F;

            //int ff = (int)f;

            //Console.WriteLine(ff);
            //Console.WriteLine("Using Convert - {0}", Convert.ToInt32(f));

            //byte bb = (byte)f;

            //Console.WriteLine(bb);

            ////Assignemnet 4 - try converstions int, long, float, double.

            ////Comments, short cuts ctrl + k + c - comment,
            ////ctrl + k + u - uncomments.

            //var a = Method1(1, 2);


            // Control Statements

            //Conditional  if, switch-case.
            //Looping  while, for,do-while.
            //Jumping  break, continue,goto.


            // if

            //int zzz = 100;
            //if (zzz == 100)
            //{
            //    //executes if condition is true
            //    Console.WriteLine("inside if at 305");
            //}

            //if (zzz != 101)
            //{
            //    //executes if condition is true
            //    Console.WriteLine("inside if at 311");
            //}

            ////if-else

            //int balance = 1000;
            //int draw = 500;

            //if (draw <= balance)
            //{
            //    Console.WriteLine("Available for draw");
            //}

            //balance = 3000; draw = 2000;

            //if (draw <= balance)
            //{
            //    Console.WriteLine("Available for draw");
            //}
            //else
            //{
            //    Console.WriteLine("Not available for draw");
            //}

            //if (draw == balance)
            //{
            //    Console.WriteLine("Available for draw, but no more money");
            //}
            //else if (draw < balance)
            //{
            //    Console.WriteLine("Available for draw, still u have some money");
            //}
            //else
            //{
            //    Console.WriteLine("Not available for draw");
            //}

            //// nested if

            //int g = 180, h = 250;
            //string message = "";

            //if (g >= h)
            //{
            //    if(g > h)
            //    {
            //        message = "g is greater than h";
            //    }
            //    else if(true)
            //    {

            //    }
            //    else
            //    {
            //        message = "g is equal to h";
            //    }

            //    if (g > h)
            //    {
            //        message = "g is greater than h";
            //    }
            //    else
            //    {
            //        message = "g is equal to h";
            //    }

            //    if (g > h)
            //    {
            //        message = "g is greater than h";
            //    }


            //    else
            //    {

            //    }
            //}
            //else
            //{
            //    message = " g is less than h";
            //}


            //switch

            //int ii = 101;
            //switch (ii) //switch(101)
            //{
            //    case 0: Console.WriteLine(0); break;
            //    case 10: Console.WriteLine(10); break;
            //    case 100: Console.WriteLine(100); break;
            //    case 1000: Console.WriteLine(1000); break;
            //    default: Console.WriteLine("Default"); break;
            //}


            // while

            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);


            int iterator = 1, cnt = 5;
            //Console.WriteLine("While example 1");
            //while (iterator <= cnt)
            //{
            //    Console.WriteLine(iterator);
            //    iterator++; // iterator = iterator + 1;
            //}

            //Console.WriteLine("While example 2");
            //int ii = 1;
            //while (ii <= 5)
            //{
            //    Console.WriteLine("C# while Loop: Iteration {0}", ii);
            //    ii++;
            //}

            //Console.WriteLine("While example 3");
            //int r = 1, s = 0; //1,2,3,4,5
            //string userValueString = Console.ReadLine();
            //int userValue = Convert.ToInt32(userValueString);
            //Console.WriteLine("Sum = {0}", s);
            //while (r <= userValue)
            //{
            //    s += r; // same as s = s+r;
            //    Console.WriteLine("{0} + {1} = {0}", s, r);
            //    r++;
            //}
            //Console.WriteLine("Sum = {0}", s);

            //iterator = 6;

            //while (iterator <= 5)
            //{
            //    Console.WriteLine(iterator);
            //    iterator++;
            //}

            //Console.WriteLine("do-while example");
            //iterator = 6;
            //do
            //{
            //    Console.WriteLine(iterator);
            //    iterator++;
            //}
            //while (iterator <= 5);

            //for, foreach

            //for (int i = 1, j = 10; i <= j; i++, j--)
            //{
            //    Console.WriteLine("i={0}, j={1}", i, j);
            //}
            // Assignment - 6  - try doing same example uisng while.

            //foreach

            //int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i <= array.Length - 1; i++)
            ////for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}












            Console.ReadKey();
        }

        private static string Method2(string abc)
        {
            abc = "Text 2";
            return abc;
        }

        /// <summary>
        /// Method Name, method use
        /// </summary>
        /// <param name="q1"></param>
        /// <param name="q2"></param>
        /// <returns></returns>
        private static int Method1(int q1, int q2)
        {
            Console.WriteLine("Before changing  | p1 - {0}, p2 - {1}", q1, q2);
            q1 = 10; q2 = 20;
            Console.WriteLine("After changing  | p1 - {0}, p2 - {1}", q1, q2);
            return q1 + q2;
        }
    }
}
