using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LinkList
    {
        public Node Head { get; set; }
        private Node Current { get; set; }

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
            if(Head == null)
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
        /// Inserts a node immediately before the first node in the list with a given value
        /// </summary>
        /// <param name="value">The value of the existing node to search for</param>
        /// <param name="newValue">The value of the node to be inserted</param>
        public void InsertBefore(int value, int newValue)
        {
            //if searched value is the Head, Insert() can be called instead
            if(Head.Value == value)
            {
                Insert(newValue);
                return;
            }

            //otherwise we must create a node and find the searched value
            Node newNode = CreateNode(newValue);

            //traverses the list until it reaches the first node before a node with the searched value
            Current = Head;
            while (Current != null)
            {
                //if the next node's value is the searched value, place the new node between current node and next
                if (Current.Next.Value == value)
                {
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }
        }

        /// <summary>
        /// Inserts a node immediately after the first node in the list with a given value
        /// </summary>
        /// <param name="value">The value of the existing node to search for</param>
        /// <param name="newValue">The value of the node to be inserted</param>
        public void InsertAfter(int value, int newValue)
        {
            Node newNode = CreateNode(newValue);

            //traverses the list until it reaches the first node with the searched value
            Current = Head;
            while (Current != null)
            {
                //if the current node's value is the searched value, place the new node between current node and next
                if (Current.Value == value)
                {
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }
        }

        /// <summary>
        /// Checks if a value is contained in any of the nodes in a list
        /// </summary>
        /// <param name="value">Value to find</param>
        /// <returns>Bool indicating if value was found</returns>
        public bool Includes(int value)
        {
            //begin at the beginning
            Current = Head;

            //and go on till you come to the end
            while(Current != null)
            {
                //if the value of the current node equals the input, return true
                if (Current.Value == value)
                {
                    return true;
                }
                //otherwise, keep traversing the list
                Current = Current.Next;
            }

            //then stop
            return false;
        }

        /// <summary>
        /// Finds the value of the node a certain distance from the end of the list
        /// </summary>
        /// <param name="k">The distance of the node from the end of the list</param>
        /// <returns></returns>
        public int KthFromEnd(int k)
        {
            //counter for list length
            int listLength = 0;

            //traversal loop to find length
            Current = Head;
            while(Current != null)
            {
                listLength++;
                Current = Current.Next;
            }

            //find distance from left
            int distFromBeginning = listLength - k - 1;

            //if the "index" is within the bounds of the list, find its value
            //if k sends you to the first value in the list, the for loop will not run and Current will remain as Head
            if(distFromBeginning >= 0)
            {
                Current = Head;
                for(int i = 0; i < distFromBeginning; i++)
                {
                    Current = Current.Next;
                }
            }
            else
            {
                throw(Exception e);
            }

            //return value of current node
            return Current.Value;
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
