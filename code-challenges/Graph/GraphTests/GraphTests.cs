using Graph.Classes;
using System;
using System.Reflection.Metadata;
using Xunit;

namespace GraphTests
{
    public class GraphTests
    {
        [Fact]
        public void CanConstructVertex()
        {
            Vertex<int> testVertex = new Vertex<int>(1);

            Assert.IsType<Vertex<int>>(testVertex);
        }

        [Fact]
        public void ConstructedVertexHoldsValue()
        {
            Vertex<int> testVertex = new Vertex<int>(1);

            Assert.Equal(1, testVertex.Value);
        }

        [Fact]
        public void CanConstructEdge()
        {
            Vertex<int> testVertex = new Vertex<int>(1);
            Edge<int> testEdge = new Edge<int>(testVertex, 10);

            Assert.IsType<Edge<int>>(testEdge);
        }

        [Fact]
        public void ConstructedEdgeHoldsVertex()
        {
            Vertex<int> testVertex = new Vertex<int>(1);
            Edge<int> testEdge = new Edge<int>(testVertex, 10);

            Assert.Equal(testVertex, testEdge.Vertex);
        }
    }
}
