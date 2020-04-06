using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree()
        {
            Root = null;
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

        public int[] InOrder()
        {
            List<int> values = new List<int>();
            if (Root != null)
                InOrderTraversal(Root, values);
            return values.ToArray();
        }

        public void InOrderTraversal(Node current, List<int> list)
        {
            if (current.Left != null)
                InOrderTraversal(current.Left, list);
            list.Add(current.Value);
            if (current.Right != null)
                InOrderTraversal(current.Right, list);
        }

        public int[] PostOrder()
        {
            List<int> values = new List<int>();
            if (Root != null)
                PostOrderTraversal(Root, values);
            return values.ToArray();
        }

        public void PostOrderTraversal(Node current, List<int> list)
        {
            if (current.Left != null)
                PostOrderTraversal(current.Left, list);
            if (current.Right != null)
                PostOrderTraversal(current.Right, list);
            list.Add(current.Value);
        }
    }
}
