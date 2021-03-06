﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatedWord.Classes
{
    public class HashTable
    {
        /// <summary>
        /// The array of linked lists that forms the hash table
        /// </summary>
        public LinkedList<string>[] Buckets = new LinkedList<string>[1024];

        /// <summary>
        /// Adds a new key value pair to the hash table
        /// </summary>
        /// <param name="value">The value string</param>
        public void Add(string value)
        {
            //find the index to place the KVP at
            int index = GetHash(value);

            //create a linked list at that index if none exists
            if(Buckets[index] == null)
            {
                Buckets[index] = new LinkedList<string>();
            }

            //add a node with the KVP at the end of that index' LL
            Buckets[index].AddLast(value);
        }

        /// <summary>
        /// Finds the value associated with a given key
        /// </summary>
        /// <param name="value">The key to search for</param>
        /// <returns>The value associated with a given key</returns>
        public string Find(string value)
        {
            //finds the index to search by hashing the key
            //this is why its necessary to hash keys consistently
            int index = GetHash(value);

            //only searches linkedlist if one is found
            if(Buckets[index] != null)
            {
                //search linkedlist for key
                foreach(string str in Buckets[index])
                {
                    //if node's key is the given key, return its value
                    if(str == value)
                        return str;
                }
            }

            //returns null if the value is not found
            return null;
        }

        /// <summary>
        /// Checks if the hash table contains a KVP with the given key
        /// </summary>
        /// <param name="value">The key to search for</param>
        /// <returns>True if the key is found</returns>
        public bool Contains(string value)
        {
            //i wrote this out and it was the same code as Find() but with bools so i just called Find() and returned bools from it instead because it looks cooler
            //i mean uh because it makes the code easier to refactor...
            if(Find(value) == null)
                return false;
            return true;
        }

        /// <summary>
        /// Hashes a key string and returns its position in the array
        /// </summary>
        /// <param name="value">String to be hashed</param>
        /// <returns>Position in array</returns>
        public int GetHash(string value)
        {
            //initialize the hashed key
            int hash = 0;

            //add character codes in input string
            //this allows for greater diversity in key values between different strings
            foreach(char charCode in value)
            {
                hash += charCode;
            }

            //multiply key by large prime to further hash it
            //not too large though or it will often go over the int32 limit and become negative
            hash *= 1973;
            
            //modulo it by the array length to find its position in the array
            hash %= Buckets.Length;

            return hash;
        }
    }
}
