using System;
using System.Collections.Generic;

namespace TreeIntersection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public List<int> TreeIntersection(int[] arr1, int[] arr2)
        {
            //find the largest number in arr1, to size our map array with
            //arr1 is used arbitrarily, since if a larger value is found in arr2 than exists in arr1, it cannot possibly intersect with a value in arr1
            int largest = arr1[0];
            foreach(int val in arr1)
            {
                if (val > largest)
                {
                    largest = val;
                }
            }

            //
            //there is an option here to get the largest of both arrays
            //this would prevent an unnecessarily large mapArr
            //but it would require another loop
            //


            //create a new map array based on the largest number
            //each number will map into a unique bucket so it can be found in O(1) complexity
            //this is like a hash map but without the hashing or key value pairs
            int[] mapArr = new int[largest + 1];

            //now map arr1's values to the map array
            foreach(int val in arr1)
            {
                mapArr[val] = val;
            }

            //lets make a list to hold matches (i hope we're allowed to)
            List<int> matches = new List<int>();

            //and lets make a counter to see how many matches we've got ourselves
            int matchesCt = 0;

            //now lets check for matches
            //we're gonna use largest for the limiter because its the actual limiting factor
            for(int i=0; i<largest; i++)
            {
                //this could be tons of checks but this one is the first one i thought of and it's late
                if(mapArr[arr2[i]] == arr2[i])
                {
                    //i'm not sure if this is allowed
                    //i could implement a less efficient method or create my own List class but i'm not going to
                    matches.Add(arr2[i]);

                    //this counter is only useful if i were to implement this without using List.Add()
                    matchesCt++;
                }
            }

            return matches;
        }
    }
}
