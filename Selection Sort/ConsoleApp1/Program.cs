using System;

namespace ConsoleApp1
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            //selection sort
            //Console.WriteLine("");
            Random rnd = new Random();

            int[] array; 
            int arraySize = rnd.Next(1, 100);
            array = new int[arraySize];
            Console.WriteLine("arraySize = " + arraySize);
            
            for (int i = 0; i < arraySize; i++ )
            {
                array[i] = rnd.Next(1, 100);
                Console.WriteLine("array pos: {0} = {1}", i, array[i]);
            }
            Console.WriteLine("----------------------------- Selection Sort ----------------------------------");
            // sort algorithm
            for (int i = 0; i < arraySize; i++)
            {

                for (int x = 0; x < arraySize; x++) // loop through array
                {
                    if (array[i] < array[x]) // if array i is less than  array x
                    {
                        // swap value positions
                        int tmpArrayVal = array[x];
                        array[x] = array[i];
                        array[i] = tmpArrayVal;
                        
                        //Console.WriteLine("loop " + x + " thisArray = " + thisArray);
                    }   
                }                                             
            }

            for(int i = 0; i < arraySize; i++)
            {
                Console.WriteLine("array pos "+ i + " = " + array[i]);
            }

        }
        */

        static void Main(string[] args)
        {
            //selection sort
            //Console.WriteLine("");
            Random rnd = new Random();

            int[] array;
            int arraySize = rnd.Next(1, 100);
            array = new int[arraySize];
            Console.WriteLine("arraySize = " + arraySize);

            for (int i = 0; i < arraySize; i++)
            {
                array[i] = rnd.Next(1, 100);
                Console.WriteLine("array pos: {0} = {1}", i, array[i]);
            }
            Console.WriteLine("----------------------------- Selection Sort ----------------------------------");
            // sort algorithm
            int smallest;
            for (int i = 0; i < arraySize; i++)
            {
                smallest = i; // assume first array pos is min
                for (int x = i+1; x < arraySize; x++) // loop through array pos after i
                {
                    if (array[x] < array[i]) // if array pos x is less than  array pos i
                    {                                               
                        smallest = x; //new smallest value
                    }
                }

                if(smallest != i) // if i have new smallest value
                {
                    // swap value positions
                    int tmpArrayVal = array[smallest];
                    array[smallest] = array[i];
                    array[i] = tmpArrayVal;
                }

            }

            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine("array pos " + i + " = " + array[i]);
            }

        }














    }
}
