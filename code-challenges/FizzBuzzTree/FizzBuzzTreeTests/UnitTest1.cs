using System;
using Xunit;
using FizzBuzzTree;

namespace FizzBuzzTreeTests
{
    public class UnitTest1
    {
        public BinaryStringTree GenerateTree()
        {
            BinaryStringTree globalTestTree = new BinaryStringTree();

            //manually defining nodes for a predictable test tree layout
            globalTestTree.Root = new StringNode("1");
            globalTestTree.Root.Left = new StringNode("Fizz");
            globalTestTree.Root.Right = new StringNode("Buzz");
            globalTestTree.Root.Left.Left = new StringNode("7");
            globalTestTree.Root.Left.Right = new StringNode("Fizz");
            globalTestTree.Root.Right.Left = new StringNode("Fizz");
            globalTestTree.Root.Right.Right = new StringNode("FizzBuzz");

            return globalTestTree;
        }

        [Fact]
        public void CanFizzBuzz()
        {
            BinaryIntTree inputTree = new BinaryIntTree();
            inputTree.Root = new IntNode(1);
            inputTree.Root.Left = new IntNode(3);
            inputTree.Root.Right = new IntNode(5);
            inputTree.Root.Left.Left = new IntNode(7);
            inputTree.Root.Left.Right = new IntNode(9);
            inputTree.Root.Right.Left = new IntNode(12);
            inputTree.Root.Right.Right = new IntNode(15);

            Assert.Equal(GenerateTree(), Program.CreateFizzBuzzTree(inputTree));
        }
    }
}
