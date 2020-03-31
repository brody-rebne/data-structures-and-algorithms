using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class PseudoQueue
    {
        public Stack Frontwards { get; set; }
        public Stack Backwards { get; set; }

        public PseudoQueue()
        {
            Frontwards = new Stack();
            Backwards = new Stack();
        }

        /// <summary>
        /// Adds a new node to the end of the pseudoqueue
        /// </summary>
        /// <param name="value">The value of the node to be added</param>
        public void Enqueue(int value)
        {
            //clear temp stack
            while(Backwards.Top != null)
            {
                Backwards.Pop();
            }

            //push existing nodes to backwards stack, reversing their order
            Node frontCurrent = Frontwards.Top;
            while(frontCurrent != null)
            {
                Backwards.Push(frontCurrent.Value);
                frontCurrent = frontCurrent.Next;
            }

            //push new node to backwards stack
            Backwards.Push(value);

            //clear frontwards stack
            while (Frontwards.Top != null)
            {
                Frontwards.Pop();
            }

            //push backwards nodes to frontwards stack, un-reversing their order
            Node backCurrent = Backwards.Top;
            while (backCurrent != null)
            {
                Frontwards.Push(backCurrent.Value);
                backCurrent = backCurrent.Next;
            }
        }

        /// <summary>
        /// Removes the node at the front of the pseudoqueue
        /// </summary>
        public void Dequeue()
        {
            //dequeueing is effectively the same as popping
            Frontwards.Pop();
        }

        //ToString shortcut for easier testing
        public override string ToString()
        {
            return Frontwards.ToString();
        }
    }
}