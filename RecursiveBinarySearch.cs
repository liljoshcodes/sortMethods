using System;

namespace Recursive_Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------- Recursive Binary Search ---------");
            Random rnd = new Random();
            int[] array = new int[10];
            Console.WriteLine("Array Length = " + array.Length);

            SetValue(rnd, array); // assign array with values

            int x = array[rnd.Next(0, 9)]; //pick at random array index number to search for.
            Console.WriteLine("Pick random array value to search for: ");
            Console.WriteLine("Search for {0} in array", x);

            //Sort in ascending order
            SortArray(array);

            // binary search
            BinarySearch(array, x);
        }

        static void SetValue(Random rnd, int[] array)
        {
            for (int i = 0; i < array.Length; i++) // assign array with values
            {
                array[i] = rnd.Next(100);
                Console.WriteLine("Unsorted array index " + i + " = " + array[i]);
            }
        }

        static void SortArray(int[] array)
        {
            Console.WriteLine("----------------------------- Sort in ascending order ----------------------------------");
            bool swapped = false;
            //int loops = 0;
            for (int i = 0; i < array.Length - 1; i++) // Run below swap loop as many times as the array length
            {
                //loops++;
                for (int j = 0; j <= array.Length - 2; j++)
                {
                    if (j <= (array.Length - 2))
                    {
                        int nextNum = array[j + 1];

                        if (array[j] > array[j + 1]) // swap if a[j] is more than a[j+1]
                        {
                            int tmpArrayVal = array[j];
                            array[j] = nextNum;
                            array[j + 1] = tmpArrayVal;
                            swapped = true;
                        }
                    }
                }

                if (!swapped)
                {
                    //Console.WriteLine("Loops = "+ loops);
                    //sorted                    
                    break;
                }
                swapped = false;
            }
            // loop and print sorted array.
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Sorted array index {0} = {1}", i, array[i]);
            }
        }

        static void BinarySearch(int[] array, int x)
        {
            int left = 0;
            int right = array.Length - 1;
            int mid = 0;
            if (left <= right)
            {
                mid = (left + right) / 2;
                if (array[mid] == x) // found x
                {
                    //returnable overload here
                    Console.WriteLine("Found target {0} at array index position = {1}", x, mid);
                   
                }
                else if (x < array[mid]) // x is left of middle of array
                {
                    right = mid--;
                    BinarySearch(array, x);
                }
                else // x is right of middle array
                {
                    left = mid++;
                    BinarySearch(array, x);
                }
            }
            Console.WriteLine("-------- End of program ------");
        }

    }
}
