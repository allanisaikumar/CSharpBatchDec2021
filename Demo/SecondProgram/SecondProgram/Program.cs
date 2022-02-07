using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProgram
{
    internal class Program
    {
        int p = 10;
        static void Main(string[] args)
        {

            Program program = new Program(); // Object creation.
            //Console.WriteLine(program.Sum(10,20)); // method call.

            //Console.WriteLine("Sum : " + (10 + 20) + " Diff : " + (10 - 20) + " Mul :" + (10 * 20));

            //Console.WriteLine("---- Calling method ---");

            //Console.WriteLine(program.CalCulateMathsOps(10, 20)); // method call.
            //Console.WriteLine(program.CalCulateMathsOps(30, 20)); // method call.
            //Console.WriteLine(program.CalCulateMathsOps(40, 20)); // method call.
            //Console.WriteLine(program.CalCulateMathsOps(50, 20)); // method call.
            //Console.WriteLine(program.CalCulateMathsOps(60, 20)); // method call.
            //Console.WriteLine(program.CalCulateMathsOps("C#", 20)); // method call.

            // Value vs ref variable types

            //int x = 15, y = 2;

            //Console.WriteLine("x:" + x + "y : " + y);

            //program.Method1(x, y);

            //Console.WriteLine("x:" + x + "y : " + y);

            //program.Method2(ref x, ref y);

            //Console.WriteLine("Post ref - -- x:" + x + "y : " + y);

            // Out Variables

            //int s, d,m;
            //program.Cal(100, 200, out s, out d, out m);

            //Console.WriteLine(s + " " + d + " " + m);


            // Params keyword
            //Console.WriteLine(program.SumUsingParamAray(10, 20));
            //Console.WriteLine(program.SumUsingParamAray(10, 20,30));
            //Console.WriteLine(program.SumUsingParamAray(10, 20, 30, 40, 50));


            //Console.WriteLine(program.Sum(b:1,a:200));



            // Over loading Start

            //int a = 100, b = 200, c = 300;

            //program.Sum(a, b);
            //program.Sum(a, b,c);

            // Over loading End









            Console.ReadKey();
        }

        // Method Overlaoding.
        private void MethodOverloading(int a)
        {
            Console.WriteLine(a);
        }

        private void MethodOverloading(string str)
        {
            Console.WriteLine(str);
        }


        // DO lab to show up Method Overloading.







        // Method
        private int CalCulateMathsOps(int a, int b)
        {
            int q = 100;
            var j = Sum(p, 10);
            if(true)
            {
                int z = 10;
                var i = Sum(p, q);
            }

            if (true)
            {
                int z = 10;
                var i = Sum(p, q);
            }


            Console.WriteLine("Sum : " + Sum(a, b) + " Diff : " + Diff(a, b) + "Mul :" + Mul(a, b));
            //return Sum(a,z);
            return Sum(a, b);
        }

        //private int CalCulateMathsOps(string c, int d)
        //{
        //    Console.WriteLine("Sum : " + Sum(a, b) + " Diff : " + Diff(a, b) + "Mul :" + Mul(a, b));
        //    return Sum(a, q);
        //}

        private int Sum(int a,int b)
        {
            return a + b;
        }

        private int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        private int Diff(int a, int b)
        {
            return a - b;
        }

        private int Mul(int a, int b)
        {
            return a * b;
        }



        // Value Paramters
        private void Method1(int a, int b)
        {
            Console.WriteLine("a : " + a + " b : " + b);
            a = 25; b = 35;
            Console.WriteLine("a : " + a + " b : " + b);
        }

        private void Method2(ref int p, ref int q)
        {
            Console.WriteLine("p : " + p + " q : " + q);
            p = 25;q = 35;
            Console.WriteLine("p : " + p + " q : " + q);

        }


        private void Cal(int a, int b, out int sum, out int diff, out int mul)
        {
            sum = a + b;
            diff = a - b;
            mul = a * b;
        }



        private int SumUsingParamAray(params int[] values)
        {
            return values.Sum();
        }

    }
}
