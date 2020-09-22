using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    class Program
    {
        static void Main(string[] args)
        {

            string myString = "Hello Bat  man";
            string mickey = "Hello Mickey Mouse";
            if (myString==mickey)
            {

                Console.WriteLine("Mickey equals mystring");
            }
            string longString = "a, b, c, d        ";
            Console.WriteLine(longString);
            string replaceString = longString.Replace(",",";");
            Console.WriteLine(replaceString);
            Console.WriteLine(myString);

            Console.WriteLine(myString.Remove(6, 6));
            longString.Trim();
            string result = myString + mickey;
            // Console.WriteLine(longString);
            // for (int i = 0; i < 100000; i++)
            // {
            //     result += i;
            //   Console.WriteLine(result);
            // }
            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();
            StringBuilder builder = new StringBuilder();
            builder.Append(result);
            for (int i = 0; i < 100000; i++)
            {
                builder.Append(i);
                


            }
            stopWatch2.Stop();
            Console.WriteLine(builder);
            Console.WriteLine($"whith stringBuilder;{stopWatch2.Elapsed}");
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();
           
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
