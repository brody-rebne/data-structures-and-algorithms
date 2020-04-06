using System;
using Xunit;
using Trees;

namespace TreesTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Generates a test tree with 3 levels, and node values 1-7 counted up in reading order
        /// </summary>
        /// <returns>The test tree</returns>
        public BinaryTree GenerateTree()
        {
            BinaryTree globalTestTree = new BinaryTree();

            //manually defining nodes for a predictable test tree layout
            globalTestTree.Root = new Node(1);
            globalTestTree.Root.Left = new Node(2);
            globalTestTree.Root.Right = new Node(3);
            globalTestTree.Root.Left.Left = new Node(4);
            globalTestTree.Root.Left.Right = new Node(5);
            globalTestTree.Root.Right.Left = new Node(6);
            globalTestTree.Root.Right.Right = new Node(7);

            return globalTestTree;
        }
        
        //tests whether a binary tree can be instantiated
        [Fact]
        public void CanInstantiateBT()
        {
            BinaryTree testTree = new BinaryTree();
            Assert.IsType<BinaryTree>(testTree);
        }

        //tests that a tree can be traversed via PreOrder
        [Fact]
        public void CanPreOrderTraverse()
        {
            BinaryTree testTree = GenerateTree();
            int[] testArray = testTree.PreOrder();
            string testString = string.Join(",", testArray);
            Assert.Equal("1,2,4,5,3,6,7", testString);
        }

        //tests that a tree can be traversed via InOrder
        [Fact]
        public void CanInOrderTraverse()
        {
            BinaryTree testTree = GenerateTree();
            int[] testArray = testTree.InOrder();
            string testString = string.Join(",", testArray);
            Assert.Equal("4,2,5,1,6,3,7", testString);
        }

        //tests that a tree can be traversed via PostOrder
        [Fact]
        public void CanPostOrderTraverse()
        {
            BinaryTree testTree = GenerateTree();
            int[] testArray = testTree.PostOrder();
            string testString = string.Join(",", testArray);
            Assert.Equal("4,5,2,6,7,3,1", testString);
        }

        //tests whether a new binary tree is empty
        [Fact]
        public void InstantiatesEmpty()
        {
            BinaryTree emptyTree = new BinaryTree();
            int[] testArray = emptyTree.PreOrder();
            string testString = string.Join(",", testArray);
            Assert.Equal("", testString);
        }

        //tests whether a new binary search tree can be instantiated
        [Fact]
        public void CanInstantiateBST()
        {
            BinarySearchTree testTree = new BinarySearchTree();
            Assert.IsType<BinarySearchTree>(testTree);
        }

        //tests whether nodes can be added to a binary search tree
        [Fact]
        public void CanAddNodesToBST()
        {
            BinarySearchTree testTree = new BinarySearchTree();
            testTree.Insert(5);
            testTree.Insert(7);
            testTree.Insert(2);
            testTree.Insert(3);

            int[] testArray = testTree.PreOrder();
            string testString = string.Join(",", testArray);

            Assert.Equal("5,2,3,7", testString);
        }

        //tests whether nodes can be added to a binary search tree
        [Fact]
        public void CanFindExistingNode()
        {
            BinarySearchTree testTree = new BinarySearchTree();
            testTree.Insert(5);
            testTree.Insert(7);
            testTree.Insert(2);
            testTree.Insert(3);

            Assert.True(testTree.Contains(3));
        }

        //tests whether nodes can be added to a binary search tree
        [Fact]
        public void CantFindNonexistingNode()
        {
            BinarySearchTree testTree = new BinarySearchTree();
            testTree.Insert(5);
            testTree.Insert(7);
            testTree.Insert(2);
            testTree.Insert(3);

            Assert.False(testTree.Contains(4));
        }
    }
}
