using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int key = 99;
            Console.WriteLine(BinarySearch(intArr, key));
        }

        // takes in array to search, and a key to search for
        public static int BinarySearch(int[] array, int key)
        {
            int mid = 0;
            
            // define initial start and end
            int start = 0;
            int end = array.Length - 1;
            
            // if start and end are the same, or if start is greater than end, there are no more indeces to search
            while (start <= end)
            {
                // reset mid every loop for new start and end
                mid = (start + end) / 2;
                {
                    if (array[mid] < key)
                    {
                        // if mid value is less than key, key must be at an index at least 1 greater than mid index, so move start position there
                        // the +1 here can cause the start to be larger than the mid, hence the <= instead of != in the while conditional
                        start = mid + 1;
                        Console.WriteLine($"{start}, {mid}, {end}");
                    }
                    else if (array[mid] > key)
                    {
                        // reverse of logic above if mid value is greater than key
                        end = mid - 1;
                        Console.WriteLine($"{start}, {mid}, {end}");
                    }
                    // this else only occurs if mid value matches key, and breaks the loop on search success
                    else
                    {
                        return mid;
                    }
                }
            }

            // checker in case value was found on last loop
            if (array[mid] == key)
            {
                return mid;
            }

            // failstate once no possible success return has returned
            return -1;
        }
    }
}
