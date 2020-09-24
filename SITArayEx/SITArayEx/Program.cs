using System;
using System.Diagnostics;

namespace SITArayEx
{
    class Program
    {
        static void Main(string[] args)
        {

            //Max from array
            int[] numbers = CreateArray();
            int[] other = CreateArray();

           // PrintArray(numbers);
            Console.WriteLine();
            //Console.WriteLine($"Max numbers is: {GetMaxFromArray(numbers)}");
            // Number of occurrance of an element
            // Console.WriteLine($"{numbers[0]} appearse {GetOccurrencies(numbers)}");
            // soum of even numbers

            //Console.WriteLine($"Sum of even nmbers is {GetSumOfEvenNumbers(numbers)}");

            //Revers an array
            //Console.WriteLine("ReversedArray :");
            //var arrayToPrint = ReverseArray(numbers);
            //PrintArray(arrayToPrint);

            //var sorted = SortAscending(numbers);
            //PrintArray(sorted);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Array.Sort(numbers);
            sw.Stop();
            Console.WriteLine($"ArraySort took : {sw.ElapsedMilliseconds} ms");
            sw.Start();
            SortAscending(numbers);
            sw.Stop();
            Console.WriteLine($"Bubble Sort took : {sw.ElapsedMilliseconds} ms");
            Console.ReadLine();
        }
        
        static int[] CreateArray()
        {
            int[] numbers = new int[100000];
            Random rnd = new Random();



            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0, 50);
            }
            return numbers;
        }
        static void PrintArray(int[] arrayToPrint)
        {
            foreach (var number in arrayToPrint)
            {
                Console.Write($"{number}, ");
            }

        }
        static int GetMaxFromArray(int[] numbers)
        {

            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i]>max)
              
                    max = numbers[i];
   
            }

            return max;
        }

        static int GetOccurrencies(int[] numbers)
        {
            int counter = 0;
            int reference = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == reference)
                    counter += 1;
            }
            return counter;
        }
        static int GetSumOfEvenNumbers(int[] numbers)
        {
            int sum = 0;
           

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                
                    sum += number;
              
            }
            return sum;

        }

        static int[] ReverseArray(int[] input)
        {
            int[] output = new int[input.Length];
            int outputCounter = 0;

            for (int i = input.Length - 1 ; i >=0 ; i--)
            {
                output[outputCounter] = input[i];
                outputCounter++;
            }
            return output;
        }

        static int[] SortAscending(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i+1; j < input.Length; j++)
                {

                    if (input[i]>input[j])
                    {
                        var temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }

                }
               
            }

            return input;
        }
    }

}
