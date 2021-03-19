using System;

namespace Merge_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ Mergesort Program ------ \n");
            Console.WriteLine("Create array of size 10.");         
            int[] myArray = new int[10];

            Console.WriteLine("Populate array with random values: ");
            PopulateArray(myArray);
            
            // #### Merge Sort array ####
            int low = 0;
            int high = myArray.Length - 1;
            Console.WriteLine("Sort and Merge:");
            Sort(myArray, low, high);

            // #### Print final sorted array ####
            PrintArr(myArray);
            Console.WriteLine("\n ##### End of Program #####");
        }

        // populate array elements with values
        private static void PopulateArray(int[] myArray) 
        {          
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = new Random().Next(100);
                Console.WriteLine("Unsorted array index " + i + " is " + myArray[i]);
            }
            Console.WriteLine();
        }

        public static void Sort(int[] arr, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex) 
            {
                int m = (lowIndex + highIndex) / 2; // find the middle

                Sort(arr, lowIndex, m); // sort low index half
                Sort(arr, m+1, highIndex); // sort high index half 
                Merge(arr, lowIndex, highIndex, m);
            }
        }

        public static void Merge(int[] arr, int lowIndex, int highIndex, int middle)
        {
            // create temp subarrays
            int[] lowArr = new int[middle - lowIndex + 1];
            int[] highArr = new int[highIndex - middle]; 

            // copy original array data to sub arrays
            int i = 0;
            for (i = 0; i < lowArr.Length; i++)
            {
                lowArr[i] = arr[lowIndex + i]; // set LOW array data as original array data.
            }
            for (i = 0; i < highArr.Length; i++)
            {
                highArr[i] = arr[middle + 1 + i]; // set HIGH array data as original array data.
            }

            i = 0;
            int j = 0;
            int k = lowIndex;
            while (i < lowArr.Length && j < highArr.Length) // while there are elements in the subarrays
            {
                if(lowArr[i] <= highArr[j])
                {
                    arr[k] = lowArr[i]; // original array = lower number from sub array
                    i++; //iterate through low subarray
                }
                else
                {
                    arr[k] = highArr[j]; //original array = higher number from sub array
                    j++; //iterate through high subarray
                }
                k++; // iterate through original array
            }
            
            // copy any remaining elements of low subarray to origianl array
            while (i < lowArr.Length)
            {
                arr[k] = lowArr[i];
                i++;
                k++;
            }

            // copy any remaining elements of high subarray to origianl array
            while (j < highArr.Length)
            {
                arr[k] = highArr[j];
                j++;
                k++;
            }        
        }

        public static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Sorted array index " + i + " is " + arr[i]);
            }
        }

    }
}
