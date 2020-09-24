using System;
using System.Diagnostics;

namespace SitMultiDArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //var arrayToPrint = CreateTwoArray();
            //PrintArray(arrayToPrint);

            // PrintArray(CreateTwoArray());
            var twoDArray = CreateTwoArray();
            int[] otherNumbers = CreateTwoArray();
            PrintArray(twoDArray);

            Console.WriteLine();


            // Print the sum of all element
            // Console.WriteLine($"Sum of all element ={GetSum(twoDArray)}");


            // Print sum from main diagonale
            //Console.WriteLine($"Sum from main diagonal={GetSumFromMainDiagonal(twoDArray)}");

            

            Console.ReadLine();
        }
        static int[,] CreateTwoArray()
        {
            var myArray = new int[3,3];
            Random rnd = new Random();
            for (int row = 0; row < myArray.GetLength(0); row++)
            {
                for (int col = 0; col < myArray.GetLength(1); col++)
                {
                    myArray[row, col] = rnd.Next(0, 10);
                }
            }
            return myArray;
        }

        static void PrintArray(int[,] input)
        {
            for (int row = 0; row < input.GetLength(0); row++)
            {
                for (int col = 0; col < input.GetLength(1); col++)
                {
                    Console.Write($"{input[row, col]} ");
                }
                Console.WriteLine();
            }
            
        }


        static int GetSum(int[,]  input)
        {
            var sum = 0;
            for (int row = 0; row < input.GetLength(0); row++)
            {
                for (int col = 0; col < input.GetLength(1); col++)
                {
                    sum += input[row, col];
                }
            }
            return sum;
        }

        static int GetSumFromMainDiagonal(int[,] input)
        {
            int sum = 0;
            for (int row = 0; row < input.GetLength(0); row++)
            {
                for (int col = 0; col < input.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        sum += input[row, col];
                    }
                }
            }
            return sum;
        }
    }


}
