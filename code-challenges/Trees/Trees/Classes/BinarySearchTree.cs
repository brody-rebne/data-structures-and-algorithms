using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree()
        {
            Root = null;
        }

        public void Insert(int val)
        {
            if (Root == null)
                Root = new Node(val);
            else
                InsertNode(Root, val);
        }

        public Node InsertNode(Node current, int val)
        {
            if (current == null)
                current = new Node(val);
            else if (current.Value > val)
                current.Left = InsertNode(current.Left, val);
            else
                current.Right = InsertNode(current.Right, val);

            return current;
        }

        public bool Contains(int val)
        {
            return ContainsNode(Root, val);
        }

        public bool ContainsNode(Node current, int val)
        {
            if (current.Value == val)
                return true;
            else if (current.Value > val && current.Left != null)
                return ContainsNode(current.Left, val);
            else if (current.Right != null)
                return ContainsNode(current.Right, val);
            return false;
        }

        public int[] PreOrder()
        {
            List<int> values = new List<int>();
            if (Root != null)
                PreOrderTraversal(Root, values);
            return values.ToArray();
        }

        public void PreOrderTraversal(Node current, List<int> list)
        {
            list.Add(current.Value);
            if (current.Left != null)
                PreOrderTraversal(current.Left, list);
            if (current.Right != null)
                PreOrderTraversal(current.Right, list);
        }
    }
}
