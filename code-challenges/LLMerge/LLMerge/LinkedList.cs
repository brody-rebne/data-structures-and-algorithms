using System;
using System.Collections.Generic;
using System.Text;

namespace LLMerge.Classes
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        /// <summary>
        /// Creates a new node
        /// </summary>
        /// <param name="value">The value of the new node</param>
        /// <returns>The created node</returns>
        public Node CreateNode(int value)
        {
            //create a new node instance
            Node node = new Node();
            //set the new node's value to inputted value
            node.Value = value;
            return node;
        }

        /// <summary>
        /// Inserts a new node at the beginning the list
        /// </summary>
        /// <param name="value">The value of the node to be inserted</param>
        public void Insert(int value)
        {
            Node newNode = CreateNode(value);
            //set this node as the one before the head
            newNode.Next = Head;
            //set this node as the new head
            Head = newNode;
        }

        /// <summary>
        /// Appends a new node at the end of the list
        /// </summary>
        /// <param name="value">The value of the node to be appended</param>
        public void Append(int value)
        {
            //if the list is empty, Insert can be called instead
            if (Head == null)
            {
                Insert(value);
                return;
            }

            //otherwise create new node and search for end
            Node newNode = CreateNode(value);
            //traverses the list until it reaches the last node in the list
            Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }

            //inserts new node after the last node in the list
            Current.Next = newNode;
        }

        /// <summary>
        /// Concatenates the values from each node in the list into a string
        /// </summary>
        /// <returns>A string of all the values from the list</returns>
        public override string ToString()
        {
            //starts at the beginning of the list
            Current = Head;
            //instantiates a new instance of a well named built in class
            StringBuilder sb = new StringBuilder();
            //traverse the list and concatenate values within the string builder
            while (Current != null)
            {
                sb.Append($"{Current.Value} -> ");
                Current = Current.Next;
            }
            //appending this to mark the end of the list
            sb.Append("NULL");
            //returns the final concatenation converted to an actual string using the regular ToString() method
            return sb.ToString();
        }
    }
}
