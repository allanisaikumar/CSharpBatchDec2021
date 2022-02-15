using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string str = "fCdL0Knqqp9UawRPxQXnI nj5w2pNfZpxeGtavgqijhPzxsj94wsXpqqlU0D3cN PS76YWR06FBJQRvXsHRfJHNcqEEE9vBvoHX0qa3w56vcoE4KyqUyv0pr0o9pgfO7SLzTeDxeINK8pzrsKB4ivYUEyd3ck1qroiICByEHgkqJcAxsFWBwfFuAc5LEA4BsmBFQZV1JIY94Bq0Ct3Z8vim0LTBcOPOtzd8xQJWQf8yArz683L9YOjZvVo9FkiZ7KqYcMRbUbDl9rgsJYrLh3dT3KWrzlGpEc1b1zsjVmJHfP2GEwK0lkYHbJPnYxlYuX75dHukQk2BOlSCqbIw8bYYHyfcpV2D5pHkduIGMob1phBDH3A2l90HXjsGBfubqpz0y1OwMcSY8P4odf0FsuMS4ChS3ylgF1zJkAFkUfsri4dwajhrNpTDyroCBWd1UJcxK3N2lUadhsrxBZ3RK4gkocdwUDqtCck6CxbQhWFXkCMcMhK95smA1eGaPTV3TjKvygjLokZDhIrg1dWc66PYJBUsDBNHO8PaQw6YY3FcvQLmMifkQOZDUYk8WmUBxms7wW7CY70kcPhaOTk4WE17RmOm2aB2roZof2Ib81BiUEuz9JdfK5PUWda2fQ6FJMnKum5dq2qAR90ZYhyjvJAhFH96DJJxggMeBq3odbSXPZqOKpVwlRWv6q398dx0PngZJG3nM3ALFCN4cksFhE42kygHcMD8Fn9RvVtwUGW50vZsxZxA84lDKX5QHGTHk3QanVHF1n02VKlt1ORyw42jmfYJHgmZgAuDz6g2Ink4mZsUfVAExiedxUcVAShACExZchNIcmneiJpndYRyk5VJaSsJelu3HyiUpqUzS92WqN6rK86L3C8nPNC2bnO6ierXnkQrYrJdU73QkudU8LMkIrn2NTxl8doSzBssFt4EdDQQ6MFH5h71Vk6J4ZDbQFUqzxeptjkVFJUyhNKAQv156b0gLz08c8eCIcYiRXY";

            //Console.WriteLine(str.Length);

            //string str2 = "abc";

            //Console.WriteLine(str + str2);

            ////var str3 = str.Concat(str2);
            ////Console.WriteLine(str3.ToString());


            //bool exists = str.Contains("C# Session");
            //Console.WriteLine(exists);

            //Console.WriteLine(exists);
            ////exists = str.Contains(str, StringComparer.OrdinalIgnoreCase);

            //bool equal = str.Equals(str2);


            //int compare = str.CompareTo(str2);

            //Console.WriteLine(compare);

            //compare = str2.CompareTo(str);
            //Console.WriteLine(compare);

            //// -1 - small
            //// 0  - equal
            //// 1 - bigger

            //int position = str.IndexOf("D");

            //Console.WriteLine(position);

            //position = str.LastIndexOf("D");

            //position = str.IndexOf("D", StringComparison.OrdinalIgnoreCase);
            //Console.WriteLine(position);

            //position = str.IndexOf("D");

            //Console.WriteLine(position);

            //position = str.IndexOfAny(new char[] { 'a', 'b' });
            //Console.WriteLine(position);


            //position = str.IndexOfAny(new char[] { 'a', 'b' }, 0);
            //Console.WriteLine(position);


            //position = str.IndexOfAny(new char[] { 'a', 'b' }, 15);
            //Console.WriteLine(position);


            //position = str.IndexOf("#");

            //Console.WriteLine(position);


            //var str3 = str.Substring(500);
            //Console.WriteLine(str3);


            //str3 = str.Substring(100,100);
            //Console.WriteLine(str3);

            //int len = str.Length;

            //int last100Position = len - 100;
            //str.Substring(last100Position);

            var pqr = "     I am listening C# classes C# C# ABCDEFGH      ";
            Console.WriteLine(pqr.Length);
            Console.WriteLine(pqr);
            var pqr2 = pqr.Remove(5, 3);
            Console.WriteLine(pqr2);

            var replaceString = pqr.Replace('#', '@');
            Console.WriteLine(replaceString);


            replaceString = pqr.Replace("C#", "Python");
            Console.WriteLine(replaceString);
            Console.WriteLine("-------------------");
            Console.WriteLine(pqr.Length);
            var trimStart = pqr.TrimStart();
            Console.WriteLine(trimStart);
            Console.WriteLine(trimStart.Length);
            Console.WriteLine("-------------------");
            Console.WriteLine(pqr.Length);
            var trimend = pqr.TrimEnd();
            Console.WriteLine(trimend);
            Console.WriteLine(trimend.Length);
            Console.WriteLine("-------------------");
            Console.WriteLine(pqr.Length);
            var trimBothSides = pqr.Trim();
            Console.WriteLine(trimBothSides);
            Console.WriteLine(trimBothSides.Length);

            string xyz = null;
            var s = xyz == null ? null : xyz.Trim();
            Console.WriteLine(s);

            var pqr1 = "           ";
            s = string.IsNullOrEmpty(xyz) ? null : xyz.Trim();
            s = string.IsNullOrWhiteSpace(xyz) ? null : xyz.Trim();


            string fname = "Murali";
            string laname = "T";
            string middlename = "  abc      ";

            Console.WriteLine(fname + " " + middlename + " " + laname);

            if(string.IsNullOrWhiteSpace(middlename))
            {
                Console.WriteLine(fname + " " + laname);
            }
            else
            {
                Console.WriteLine(fname + " " + middlename.Trim() + " " + laname);
            }
            var strArray = pqr.Trim().Split(' ');
            foreach (var item in strArray)
            {
                Console.WriteLine(item);
            }

            strArray = pqr.Split(new char[] {'#','A'} ,StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in strArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(pqr.Normalize());
            Console.ReadKey();


        }


    }
}
