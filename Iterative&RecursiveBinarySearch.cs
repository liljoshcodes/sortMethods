using System;

namespace BinarySearchSpace
{
    class Program
    {       
        static void Main(string[] args)
        {
            Random rnd = new Random(); // set random variable to be used by methods below.

            Console.WriteLine("Create array of size 10: ");           
            int[] array = new int[10];
            Console.WriteLine("Array Length = " + array.Length);

            // assign array with values:
            Console.WriteLine("Now run loop to set random values with max of 10 for array:");
            SetValue(array, rnd);

            //pick at random, target number to search for between 0 and 10:
            int x = rnd.Next(11); // maxValue is 1 over 10 because random.next only gets less than max value.
            Console.WriteLine("Pick random value between 0 and 10 to search for: ");
            Console.WriteLine("Search for {0} in array \n", x);

            //Sort in ascending order
            Console.WriteLine("------------------ Sort in ascending order ------------------- ");
            Console.WriteLine("Now sort array in ascending order:");
            SortArray(array);

            // ### Iterative binary search ###
            Console.WriteLine("------- Start iterative binary search: -------");
            Result(BinarySearch(array, x), x); // result display method takes final result from search method.                        
            Console.WriteLine("------- End of iterative binary search ------\n");

            // --- Overloaded Iterative binary search ---
            Console.WriteLine("------- Start Overloaded Iterative binary search: -------");
            Result(BinarySearch(array, 0, array.Length - 1, x), x); // result display method takes final result from search method.                        
            Console.WriteLine("------- End of Overloaded iterative binary search -------\n");

            // ### Recursive binary search ### 
            Console.WriteLine("------- Start recursive binary search: -------");           
            Result(RecurBinarySearch(array, x), x); // result display method takes final result from search method.  
            Console.WriteLine("------- End of recursive binary search -------\n");

            // --- Overloaded Recursive binary search --- 
            Console.WriteLine("------- Start Overloaded recursive binary search: -------");
            Result(RecurBinarySearch(array, 0, array.Length -1, x), x); // result display method takes final result from search method.  
            Console.WriteLine("------- End of Overloaded recursive binary search -------\n");

            Console.WriteLine("###### End of program #######");
        }

        //####### Iterative binary search ########
        public static int BinarySearch(int[] array, int x)
        {
           return BinarySearch(array, 0, array.Length - 1, x);
        }
        
        public static int BinarySearch(int[] array, int low, int high, int x)     
        {          
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (array[mid] == x) // found x
                {
                    return mid; // mid equals target array index value
                }
                else if (x < array[mid]) // x is left of middle of array
                {
                    high = mid - 1 ;
                }
                else // x is right of middle array
                {
                    low = mid + 1;
                }
            }
            return -1; // could not find x in array.
        }

        //######## Recursive binary search #######
        public static int RecurBinarySearch(int[] array, int x)
        {
            return RecurBinarySearch(array, 0, array.Length - 1, x);
        }

        public static int RecurBinarySearch(int[] array, int lowIndex, int highIndex, int x)
        {
            if (lowIndex > highIndex) // if target x is not in the array.
            {      
                return -1;
            }
           
            int mid = (highIndex + lowIndex) / 2;        
            if (array[mid] == x) // found x
            {                  
                return mid;
            }
            else if (x < array[mid]) // x is left of middle of array
            {
                return RecurBinarySearch(array, lowIndex, mid-1, x); // highIndex is now mid - 1
            }
            else // x is right of middle array
            {
                return RecurBinarySearch(array, mid+1, highIndex, x); // lowIndex is now mid + 1
            }          
        }

        //######### Sort Array ########
        static void SortArray(int[] array)
        {           
            bool swapped = false;
            for (int i = 0; i < array.Length - 1; i++) // Run below swap loop as many times as the array length
            {
                for (int j = 0; j <= array.Length - 2; j++) // loop up to 8 in array becuase this checks for next number below
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
            // loop to print sorted array.
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Sorted array index {0} = {1}", i, array[i]);
                if (i == array.Length - 1)
                {
                    Console.WriteLine(); // create empty new line for readability.
                }
            }
        }

        //######## Set array values #######
        static void SetValue(int[] array, Random rnd)
        {
            
            for (int i = 0; i < array.Length; i++) // assign array with values
            {
                array[i] = rnd.Next(11); // random value between 0 and 10.
                Console.WriteLine("Unsorted array index " + i + " = " + array[i]);
                if (i == array.Length - 1)
                {
                    Console.WriteLine(); // create empty new line for readability.
                }
            }
        }

        //######## Print results of searches ########
        static void Result(int result, int x)
        {
            if (result == -1) // search failed if it returns -1
            {
                Console.WriteLine("Unable to find {0} in array. {0} is not in this array.", x);
            }
            else // success found target number in array
            {
                 Console.WriteLine("Found target {0} at sorted array index position {1}", x, result);
            }
        }
    }
}
