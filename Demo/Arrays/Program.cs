using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a;
            a = 10;


            //int[] m;
            //m = new int[5]; // int[] m = new int[5];
            //m[0] = 35;m[1] = 72; m[2] = 83; m[3] = 94; m[4] = 95;


            // declaration and initilaization.
            int[] marks = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75 };

            //int[] m2 = new int[75];

            //m2 = marks;

            //Console.WriteLine(m[0]);
            //Console.WriteLine(m[1]);
            //Console.WriteLine(m[2]);
            //Console.WriteLine(m[3]);
            //Console.WriteLine(m[4]);

            //Console.WriteLine("_____________________");

            //Console.WriteLine(marks[0]);
            //Console.WriteLine(marks[1]);
            //Console.WriteLine(marks[2]);
            //Console.WriteLine(marks[3]);
            //Console.WriteLine(marks[4]);

            Console.WriteLine(marks.Length);



            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write(marks[i] + " ");
            }

            Console.WriteLine("_______________\n");

            foreach (var item in marks)
            {
                Console.Write(item + " ");
            }

            /* IndexOf()
             * BinarySearch()
             * Clear()
             * Resize();
             * Sort()
             * Reverse()
             * CopyTo()
             * 
             */

            // index finding or linear search.
            int indexOf60 = Array.IndexOf(marks, 60);

            Console.WriteLine();
            Console.WriteLine(indexOf60);

            int indexOf100 = Array.IndexOf(marks, 100);

            Console.WriteLine();
            Console.WriteLine(indexOf100);


            int indexOf48 = Array.BinarySearch(marks, 48);

            Console.WriteLine();
            Console.WriteLine(indexOf48);

            //Array.Clear(marks, 0, marks.Length);

            //Console.WriteLine(marks[75]);

            Console.WriteLine();
            foreach (var item in marks)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine(marks.Length);

            Array.Resize(ref marks, marks.Length + 5);

            Console.WriteLine();
            Console.WriteLine(marks.Length);

            Console.WriteLine();
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write(marks[i] + " ");
            }


            Array.Resize(ref marks, marks.Length - 10);

            Console.WriteLine();
            Console.WriteLine(marks.Length);

            Console.WriteLine();
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write(marks[i] + " ");
            }

            Console.WriteLine();

            int[] unSortArray = new int[] { 1, 20, 13, 4, 55, 46, 17, 8, 19 };


            for (int i = 0; i < unSortArray.Length; i++)
            {
                Console.Write(unSortArray[i] + " ");
            }
            Console.WriteLine();
            Array.Sort(unSortArray);

            for (int i = 0; i < unSortArray.Length; i++)
            {
                Console.Write(unSortArray[i] + " ");
            }

            Console.WriteLine();
            Array.Reverse(unSortArray);
            for (int i = 0; i < unSortArray.Length; i++)
            {
                Console.Write(unSortArray[i] + " ");
            }

            int[] marks2 = new int[75];

            //marks.CopyTo(marks2, 6);
            Console.WriteLine();

            for (int i = 0; i < marks2.Length; i++)
            {
                Console.Write(marks2[i] + " ");
            }
            Console.WriteLine();


            int[,] array = new int[2, 2] {
            {10,20},
            {30,40}
            };


            // 00,  01
            // 10   11

            int[,] array1 = new int[4, 3] {
            {10,20,30}, //0
            {30,40,50}, //1
            {60,70,80},//2
            {90,100,110},//3
            };


            Console.WriteLine(array[0,1]);
            Console.WriteLine(array1[2,1]);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array1[i,j] + " ");
                }
                Console.WriteLine("\n");
            }


            Console.WriteLine();



            List<int> list = new List<int>() {10,20,50,100,12,120 };

            Console.WriteLine(list[5]);
            Console.WriteLine(list.Count);
            Console.WriteLine();

            list.Add(130);
            Console.WriteLine(list.Count);
            Console.WriteLine();

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            list.Insert(3, 33);


            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();


            List<int> p = new List<int>() { 100, 200,300,400 };

            list.AddRange(p);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();


            list.InsertRange(1, p);


            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            list.Remove(100);


            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            list.RemoveAt(3);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            list.Clear();

            Console.WriteLine("post clear");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(list.Count);


            list.Contains(100);

            list.Sort();
            list.Reverse();

            List<int> pqr = new List<int>() { 1,2,3,4,5,6,7 };
            List<int> evenNbrs = new List<int>();

            foreach (var item in pqr)
            {
                if(item % 2 == 0)
                {
                    evenNbrs.Add(item);
                }
            }
            Console.WriteLine();
            foreach (var item in evenNbrs)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }

    // 1,2,3,4,5,6 - 6 Numbers. 

    // int a = 10;

    // DataType[] arrayName =  new DataType[int length];
}
