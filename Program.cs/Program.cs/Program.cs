using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs
{
    class Program
    {
        public static int MaxResult(int[] arr, int input)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == input)
                {
                    result += input;
                }
            }
            return result;
        }

        public static string IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0 && year % 400 != 0)
                {
                    return $"{year} is not a leap year.";
                } else
                {
                    return $"{year} is a leap year.";
                }
            } else
            {
                return $"{year} is not a leap year.";
            }
        }

        public static string IsPerfectSequence(int[] arr)
        {
            int sum = 0, prod = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                prod *= arr[i];
            }
            if (sum == prod)
            {
                return "Yes";
            } else
            {
                return "No";
            }
        }

        //public static int[] SumOfRows(int[,] matrix)
        //{

        //}

        static void Main(string[] args)
        {
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app!

            Random rnum = new Random();

            // Challenge 1
            int[] ch1Array = { rnum.Next(1, 10), rnum.Next(1, 10), rnum.Next(1, 10), rnum.Next(1, 10), rnum.Next(1, 10) };
            Console.WriteLine(string.Join(", ", ch1Array));
            Console.Write("Choose a number between 1 and 10: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The score for your selection is: {MaxResult(ch1Array, input)}");

            // Challenge 2
            Console.Write("Enter a year from 1 and up: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsLeapYear(year));

            // Challenge 3
            int[] ch3Array = { 3, 6, 9 };
            Console.WriteLine($"Is the array [{string.Join(", ", ch3Array)}] a perfect sequence?");
            Console.WriteLine(IsPerfectSequence(ch3Array));
        }
    }
}
