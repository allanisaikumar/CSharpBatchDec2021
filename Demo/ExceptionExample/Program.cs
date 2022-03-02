using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Code

                Console.WriteLine("Enter first Number:");
                int a = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter Second Number:");
                int b = Convert.ToInt32(Console.ReadLine());

                int c = a / b;

                //string s = null;
                //s.Trim();

                Console.WriteLine("Quotient is " + c);

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DivideByZeroException " + ex.Message);

                // 
            }
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine("NullReferenceException " + ex.Message);
            //}
            catch (Exception ex)
            {
                Console.WriteLine("Exception " + ex.Message);
            }
            finally
            {
                // Code
                Console.WriteLine("Calculation completed");
            }
            Console.ReadLine();

        }
    }
}
