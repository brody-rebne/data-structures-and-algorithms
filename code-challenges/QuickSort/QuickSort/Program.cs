using System;
using System.Collections.Concurrent;

namespace QuickSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Sorts an array of integers via the Quick Sort algorithm
        /// </summary>
        /// <param name="array">The array to be sorted</param>
        /// <returns>The sorted array</returns>
        public static void QuickSort(int[] array)
        {
            int max = array.Length - 1;
            QuickSortRecursive(array, 0, max);
        }

        /// <summary>
        /// Helper method for QuickSort() which calls itself recursively to sort the array. Avoid using this method directly to sort arrays
        /// </summary>
        /// <param name="array">The array to be sorted</param>
        /// <param name="left">The leftmost index of the desired section of the array</param>
        /// <param name="right">The rightmost index of the desired section of the array</param>
        static void QuickSortRecursive(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pvt = Partition(array, left, right);
                QuickSortRecursive(array, left, (pvt - 1));
                QuickSortRecursive(array, (pvt + 1), right);
            }
        }

        /// <summary>
        /// Virtually splits an array into two semi-sorted sections, and returns the pivot point between them
        /// </summary>
        /// <param name="array">The array to be split</param>
        /// <param name="left">The leftmost index of the current section of the array</param>
        /// <param name="right">The rightmost index of the current section of the array</param>
        /// <returns>The index of the new pivot value</returns>
        static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int lefter = left - 1;

            //loop through section
            for(int i=left; i<right; i++)
            {
                //if any value is less than the pivot, swap it with the left
                if(array[i] < pivot)
                {
                    lefter++;
                    SwapValues(array, lefter, i);
                }
            }
            SwapValues(array, (lefter + 1), right);
            return lefter + 1;
        }

        /// <summary>
        /// Swaps the values at two given indeces of an array
        /// </summary>
        /// <param name="array">The array containing the values</param>
        /// <param name="left">The index of the left value</param>
        /// <param name="right">The index of the right value</param>
        static void SwapValues(int[] array, int left, int right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
    }
}
