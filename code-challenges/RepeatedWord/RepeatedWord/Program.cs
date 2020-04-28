using System;
using System.ComponentModel;
using RepeatedWord.Classes;

namespace RepeatedWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public string RepeatedWordChecker(string input)
        {
            input = input.ToLower();

            string[] inputArray = input.Split(" ");

            HashTable table = new HashTable();

            foreach(string word in inputArray)
            {
                if (table.Contains(word))
                    return word;
                table.Add(word);
            }

            return null;
        }
    }
}
