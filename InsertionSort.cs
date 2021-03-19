using System;

namespace Insertion_sort_excersise
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] a = new int [10];

            for (int i = 0; i <= a.Length - 1; i++)
            {
                a[i] = rnd.Next(21);
                Console.WriteLine("array index " + i + " = " + a[i]);
            }
            Console.WriteLine("\n");
            InsertionSort(a);

            for (int i = 0; i <= a.Length - 1; i++)
            {
                Console.WriteLine("sorted array index " + i + " = " + a[i]);
            }
        }

        private static void InsertionSort(int[] a)
        {
            for (int i = 1; i < a.Length; i++)//loop through array 
            {
                int k = i;
                for (int j = i - 1; j >= 0; j--)// compare i to array left of it
                {
                    //swap if less than last number.
                    if (a[k] < a[j])
                    {
                        //swap
                        int lastNo = a[k];
                        a[k] = a[j];
                        a[j] = lastNo;
                        k--;
                    }
                }
            }
        }
    }
}
