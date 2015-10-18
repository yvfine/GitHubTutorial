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
            // TODO: Complete fhe funtion
            return n % 2 != 0;
        }

        /// <summary>
        /// Sorts a given integer array
        /// </summary>
        /// <param name="a">An integer array</param>
        public static void Sort(int[] a)
        {
            int min;
            for (int x = 0; x < a.Length; x++)
            {
                min = a[x];
                for (int i = x+1; i < a.Length; i++)
                {
                    min = Math.Min(min, a[i]);
                }
                a[x] = min;
            }
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
            return 1000;
        }
    }
}
