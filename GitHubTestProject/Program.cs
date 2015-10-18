using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitHubTestProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 8, 2, 58, 34, 153, 4 };
            Sort(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("Hello Github!");
            Console.WriteLine("Please complete the following functions and initate a pull request.");
        }

        /// <summary>
        /// Tests if a given number is a prime
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsPrime(int n)
        {
            if ((n == 2) || (n == 3) || (n == 5) || (n == 7) || (n == 9))
                return true;

            if ((n % 2 != 0) && (n % 3 != 0) && (n % 5 != 0) &&
                (n % 7 != 0) && (n % 9 != 0) && (n % 4 != 0) &&
                (n % 6 != 0))
                return true;

            return false;
        }

        /// <summary>
        /// Sorts a given integer array
        /// </summary>
        /// <param name="a">An integer array</param>
        public static void Sort(int[] a)
        {
            Array.Sort(a);
        }


        /// <summary>
        /// Counts the number of sequenes of the digits 0,1 with
        /// no 3 consecutive 1's
        /// 
        /// Example: 001101010110 is valid, 00111001 is not valid
        /// </summary>
        /// <param name="a">The sequence length</param>
        /// <returns>The number of sequences</returns>
        public static int CountVectors(int a)
        {
            if (a == 1)
                return 2;
            if (a == 2)
                return 4;
            if (a == 3)
                return 7;
            return CountVectors(a - 1) + CountVectors(a - 2) + CountVectors(a - 3);
        }
    }
}
