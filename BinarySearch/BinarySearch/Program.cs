using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int key = 3;
            Console.WriteLine(BinarySearch(intArr, key));
        }

        public static int BinarySearch(int[] array, int key)
        {
            int tracker = -1;
            int i = array.Length / 2;
            while (tracker != key)
            {
                tracker = array[i];
                if (tracker < key)
                {
                    i = i + (i / 2);
                }
                else if (tracker > key)
                {
                    i /= 2;
                }
                else
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
