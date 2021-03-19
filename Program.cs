using System;

namespace Bubble_Sort_Algorithm
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
            int origArraySize = arraySize;
            array = new int[arraySize];
            Console.WriteLine("arraySize = " + arraySize);

            for (int b = 0; b < arraySize; b++)
            {
                array[b] = rnd.Next(1, 100);
                Console.WriteLine("array pos: {0} = {1}", b, array[b]);
            }
            Console.WriteLine("----------------------------- Bubble Sort / my first try ----------------------------------");

            bool swapped = true;
            bool sorted = false;
            int loops = 0;
            for (int i = 0; i < arraySize || !sorted; i++)
            {
                loops++;
                if (i != (arraySize - 1))
                {
                    int nextNum = array[i + 1];
                    //Console.WriteLine("array[i + 1] = "+ array[i + 1]);
                    if (array[i] > array[i + 1])
                    {
                        int tmpArrayVal = array[i];
                        array[i] = nextNum;
                        array[i + 1] = tmpArrayVal;
                        swapped = true;
                        //Console.WriteLine("array[i] = " + array[i] + "[i+1] = " + array[i + 1]);
                    }
                }

               if (i == (arraySize-1) && swapped)
               {
                    //arraySize--;
                    i = -1;
                    swapped = false;
               }
               else if(i == (arraySize - 1))
               {
                    Console.WriteLine("swapped = " + swapped);
                    sorted = true;
                    break;
               }
            }

            for (int i = 0; i < origArraySize; i++)
            {
                Console.WriteLine("array pos " + i + " = " + array[i]);                
            }
            Console.WriteLine("Loops = " + loops);
        }*/

        // improved bubble sort
        static void Main(string[] args)
        {
            //selection sort
            //Console.WriteLine("");
            Random rnd = new Random();

            int[] array;       
            array = new int[rnd.Next(1, 100)];
            Console.WriteLine("arraySize = " + array.Length);
            int origArraySize = array.Length;
            for (int b = 0; b < array.Length; b++)
            {
                array[b] = rnd.Next(1, 100);
                Console.WriteLine("array pos: {0} = {1}", b, array[b]);
            }
            Console.WriteLine("----------------------------- Bubble Sort / my second attempt ----------------------------------");

            bool swapped = true;
            bool sorted = false;
            for (int p = 0; p <= array.Length - 2; ) // run below swap loop as many times as the array length
            {
                for (int i = 0; i < array.Length || !sorted; i++)
                {
                    if (i != (array.Length - 1))
                    {
                        int nextNum = array[i + 1];
                        //Console.WriteLine("array[i + 1] = "+ array[i + 1]);
                        if (array[i] > array[i + 1])
                        {
                            int tmpArrayVal = array[i];
                            array[i] = nextNum;
                            array[i + 1] = tmpArrayVal;
                            swapped = true;
                            //Console.WriteLine("array[i] = " + array[i] + "[i+1] = " + array[i + 1]);
                        }
                    }

                    if (i == (array.Length - 1) && swapped)
                    {
                        //arraySize--;
                        i = -1;
                        swapped = false;
                    }
                    else if (i == (array.Length - 1))
                    {
                        Console.WriteLine("swapped = " + swapped);
                        sorted = true;
                        break;
                    }
                }
            }

            for (int i = 0; i < origArraySize; i++)
            {
                Console.WriteLine("array pos " + i + " = " + array[i]);
            }

        }


    }
}
