using System;

namespace ArrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0;

            int[] inputArr1 = new int[] { 1, 2, 3, 4 };
            insertShiftArray(inputArr1, value);

            int[] inputArr2 = new int[] { 1, 2, 3, 4, 5 };
            insertShiftArray(inputArr2, value);
        }

        public static int[] insertShiftArray(int[] inputArr, int inputValue)
        {
            int inputLength = inputArr.Length;
            int mid = inputLength / 2;
            int[] outputArr = new int[inputLength + 1];
            outputArr[mid] = inputValue;
            for(int i=0; i<outputArr.Length; i++)
            {
                if (i < mid)
                {
                    outputArr[i] = inputArr[i];
                }
                else if (i > mid)
                {
                    outputArr[i] = inputArr[i - 1];
                }
            }
            Console.WriteLine(String.Join(", ", outputArr));
            return outputArr;
        }
    }
}
