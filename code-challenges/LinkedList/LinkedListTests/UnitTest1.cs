using System;
using Xunit;
using LinkedList;
using LinkedList.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        //test that a new node will have a property "Value" of type int
        [Fact]
        public void NodeClassHasValueProperty()
        {
            Node node = new Node();
            Assert.IsType<int>(node.Value);
        }

        //test that a node can be given a value and that value can be read
        [Fact]
        public void CanGetValueOfValuePropertyInNode()
        {
            Node node = new Node();
            node.Value = 10;
            Assert.Equal(10, node.Value);
        }

        //test that a node's value can be changed
        [Fact]
        public void CanChangeAndSetValueOfValuePropertyInNode()
        {
            Node node = new Node();
            node.Value = 10;
            node.Value = 15;

            Assert.Equal(15, node.Value);
        }

        //test that a node will have a property "Next", and that it will default to null
        [Fact]
        public void NodeClassHasNextProperty()
        {
            Node node = new Node();
            Assert.Null(node.Next);
        }

        //ensure that the Next property can be set
        [Fact]
        public void NextProperyOnNodeCanBeSet()
        {
            Node node = new Node();
            node.Value = 18;

            Node node2 = new Node();
            node.Next = node2;

            Assert.Equal(node.Next, node2);
        }

        //test that a linklist has a Head property on instantiation
        [Fact]
        public void LinkedListClassHasHeadProperty()
        {
            LinkList LinkList = new LinkList();
            Assert.Null(LinkList.Head);
        }

        //test that a node can be inserted into a link list
        [Fact]
        public void CanInsertNewNodeToLinkedListAsHead()
        {
            LinkList ll = new LinkList();
            ll.Insert(10);
            Assert.Equal(10, ll.Head.Value);

        }

        //test that a node can be inserted into a list which already has an existing Head node
        [Fact]
        public void CanInsertNewNodeAsHeadInLLThatAlreadyHasNodes()
        {
            LinkList ll = new LinkList();
            ll.Insert(10);
            ll.Insert(20);

            Assert.Equal(20, ll.Head.Value);
        }

        //test that a node can be inserted at the end of a list
        [Fact]
        public void CanInsertNewNodeAtEndOfList()
        {
            LinkList ll = new LinkList();
            ll.Insert(20);
            ll.Insert(20);
            ll.Append(10);
            string testString = ll.ToString();
            Assert.Equal("20 -> 20 -> 10 -> NULL", testString);
        }

        //test that multiple nodes can be inserted at the end of a list
        [Fact]
        public void CanInsertMultipleNewNodesAtEndOfList()
        {
            LinkList ll = new LinkList();
            ll.Insert(20);
            ll.Insert(20);
            ll.Append(30);
            ll.Append(40);
            string testString = ll.ToString();
            Assert.Equal("20 -> 20 -> 30 -> 40 -> NULL", testString);
        }

        //test that a node can be added before a given node in the middle of a list
        [Fact]
        public void CanInsertNewNodeBeforeGivenNodeInMiddleOfList()
        {
            LinkList ll = new LinkList();
            ll.Insert(30);
            ll.Insert(20);
            ll.Insert(10);
            ll.InsertBefore(30, 25);
            string testString = ll.ToString();
            Assert.Equal("10 -> 20 -> 25 -> 30 -> NULL", testString);
        }

        //test that a node can be added before the first node in a list
        [Fact]
        public void CanInsertNewNodeBeforeGivenNodeAtBeginningOfList()
        {
            LinkList ll = new LinkList();
            ll.Append(10);
            ll.Append(20);
            ll.Append(30);
            ll.InsertBefore(10, 5);
            string testString = ll.ToString();
            Assert.Equal("5 -> 10 -> 20 -> 30 -> NULL", testString);
        }

        //test that a node can be added after a given node in the middle of a list
        [Fact]
        public void CanInsertNewNodeAfterGivenNodeInMiddleOfList()
        {
            LinkList ll = new LinkList();
            ll.Append(10);
            ll.Append(20);
            ll.Append(30);
            ll.InsertAfter(10, 15);
            string testString = ll.ToString();
            Assert.Equal("10 -> 15 -> 20 -> 30 -> NULL", testString);
        }

        //test that a node can be added after the last node in a list
        [Fact]
        public void CanInsertNewNodeAfterGivenNodeAtEndOfList()
        {
            LinkList ll = new LinkList();
            ll.Append(10);
            ll.Append(20);
            ll.Append(30);
            ll.InsertAfter(30, 35);
            string testString = ll.ToString();
            Assert.Equal("10 -> 20 -> 30 -> 35 -> NULL", testString);
        }

        //test that the search method can find a value
        [Fact]
        public void CanFindNodeWithValueInLL()
        {
            // Arrange
            LinkList ll = new LinkList();
            ll.Insert(10);
            ll.Insert(20);
            ll.Insert(30);
            ll.Insert(42);

            // Act
            bool exists = ll.Includes(30);

            // Assert
            // method call will be true
            Assert.True(exists);
        }

        //test that the search function will not find a nonexistent value
        [Fact]
        public void CannotFindNodewithValueinLL()
        {
            // Arrange
            LinkList ll = new LinkList();
            ll.Insert(10);
            ll.Insert(20);
            ll.Insert(30);
            ll.Insert(42);

            // Act
            bool exists = ll.Includes(32);

            Assert.False(exists);
        }

        //test that the head node's value will be read by the search method
        [Fact]
        public void CanFindHeadValueSuccessfullyInLL()
        {
            // Arrange
            LinkList ll = new LinkList();
            ll.Insert(10);
            ll.Insert(20);
            ll.Insert(30);
            ll.Insert(42);

            // Act
            bool exists = ll.Includes(42);
            Assert.True(exists);

        }

        //test that the last node's value will be read by the search method
        [Fact]
        public void CanFindLastNodeValueInLL()
        {
            LinkList ll = new LinkList();
            ll.Insert(10);
            ll.Insert(20);
            ll.Insert(30);
            ll.Insert(42);

            // Act
            bool exists = ll.Includes(10);
            Assert.True(exists);
        }

        //test that the the string converter works properly
        [Fact]
        public void CanConvertLinkListToString()
        {
            // Arrange
            LinkList ll = new LinkList();
            ll.Insert(10);
            ll.Insert(20);
            ll.Insert(30);
            ll.Insert(42);

            // Act 
            string allyson = ll.ToString();

            string expected = $"42 -> 30 -> 20 -> 10 -> NULL";
            // Assert
            Assert.Equal(expected, allyson);

        }
    }
}