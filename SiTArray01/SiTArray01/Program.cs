using System;

namespace SiTArray01
{
    class Program
    {
        static void Main(string[] args)
        {

            // int[] myFirstArray = new int[3];
            // myFirstArray[0] = 3;
            //myFirstArray[1] = 10;
            //myFirstArray[2] = 15;

            // Console.WriteLine(myFirstArray[2]);

            // int[] mySecondArray = { 10, 23, 45 };
            ////Console.WriteLine($"array Length Is:{mySecondArray[2]}");
            ///


            //int[] userNumber = new int[3];
            //Console.WriteLine("first number:");
            //userNumber[0] = int.Parse(Console.ReadLine());

            //Console.WriteLine("Second number:");
            //userNumber[1] = int.Parse(Console.ReadLine());

            //Console.WriteLine("Third number:");
            //userNumber[2] = int.Parse(Console.ReadLine());

            //Console.WriteLine("array length:"+ userNumber.Length);
            //Console.WriteLine("Last array index:" + (userNumber.Length - 1));


            int[] userNumber = new int[3];
            for (int i = 0; i < userNumber.Length; i++)
            {
                Console.WriteLine($"Number on index[{i}]:");
                userNumber[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.Write("You provided the following number:");
            //for (int i = 0; i < userNumber.Length; i++)
            //{
            //    Console.WriteLine($"{userNumber[i]}, ");
            //}
            foreach (var number in userNumber)
            {
                Console.Write($"{number},");
            }


            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
