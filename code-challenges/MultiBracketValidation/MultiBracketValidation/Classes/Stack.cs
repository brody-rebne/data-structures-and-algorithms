using System;
using System.Collections.Generic;
using System.Text;

namespace BracketValidation
{
    public class Stack
    {
        public Node Top { get; set; }

        public Stack()
        {
            Top = null;
        }

        /// <summary>
        /// Pushes a node on the top of the stack
        /// </summary>
        /// <param name="val">The value of the node to be added</param>
        public void Push(char val)
        {
            Node previousTop = Top;
            Node newNode = new Node(val);
            Top = newNode;
            newNode.Next = previousTop;
        }

        /// <summary>
        /// Pops the top node off of the stack
        /// </summary>
        public void Pop()
        {
            try
            {
                Node oldTop = Top;
                Top = oldTop.Next;
                oldTop.Next = null;
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine($"Null Reference Exception: {e}");
                throw;
            }
        }

        /// <summary>
        /// Returns the value of the node on top of the stack
        /// </summary>
        /// <returns>The value of the node at the top of the stack</returns>
        public char Peek()
        {
            try
            {
                return Top.Value;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine($"Null Reference Exception: {e}");
                return '\0';
            }
        }

        /// <summary>
        /// Checks if the stack is empty
        /// </summary>
        /// <returns>True if stack is empty</returns>
        public bool IsEmpty()
        {
            if (Peek() == '\0')
                return true;
            return false;
        }

        /// <summary>
        /// Concatenates the values from each node in a stack into a char
        /// </summary>
        /// <returns>A char of all the values from a stack</returns>
        public override string ToString()
        {
            Node current = Top;

            StringBuilder sb = new StringBuilder();

            sb.Append("Top -> ");
            while (current != null)
            {
                sb.Append($"{current.Value} -> ");
                current = current.Next;
            }
            sb.Append("null");
            return sb.ToString();
        }
    }
}
