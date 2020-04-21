using System;
using System.Collections.Generic;
using FizzBuzzTree;

namespace FizzBuzzTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public string FizzBuzz(int input)
        {
            if (input % 15 == 0)
                return "FizzBuzz";
            else if (input % 5 == 0)
                return "Buzz";
            else if (input % 3 == 0)
                return "Fizz";
            else
                return Convert.ToString(input);
        }

        public BinaryStringTree CreateFizzBuzzTree(BinaryIntTree baseTree) {
            BinaryStringTree stringTree = new BinaryStringTree();
            stringTree.Root = new StringNode(FizzBuzz(baseTree.Root.Value));
            FizzBuzzRecursive(baseTree.Root, stringTree.Root);
            return stringTree;
        }

        public void FizzBuzzRecursive(IntNode intNode, StringNode stringNode)
        {
            if (intNode.Left != null)
            {
                stringNode.Left = new StringNode(FizzBuzz(intNode.Left.Value));
                FizzBuzzRecursive(intNode.Left, stringNode.Left);
            }
            else if(intNode.Right != null)
            {
                stringNode.Right = new StringNode(FizzBuzz(intNode.Right.Value));
                FizzBuzzRecursive(intNode.Right, stringNode.Right);
            }
        }
    }
}
