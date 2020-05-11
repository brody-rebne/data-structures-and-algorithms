using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    class Graph<T>
    {
        public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }

        private int _size;

        public Graph()
        {
            AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
        }

        /// <summary>
        /// Adds a node to the graph with type T
        /// </summary>
        /// <param name="value">The value to be passed to the node</param>
        /// <returns>The created node</returns>
        public Vertex<T> AddNode(T value)
        {
            Vertex<T> node = new Vertex<T>(value);
            AdjacencyList.Add(node, new List<Edge<T>>());
            _size++;
            return node;
        }

        /// <summary>
        /// Adds a new directed edge between two nodes in a graph
        /// </summary>
        /// <param name="a">The "parent" node</param>
        /// <param name="b">The "child" node</param>
        /// <param name="weight">The weight of the edge</param>
        public void AddDirectedEdge(Vertex<T> a, Vertex<T> b, int weight)
        {
            AdjacencyList[a].Add(new Edge<T>(b, weight));
        }

        /// <summary>
        /// Adds edges between two nodes to create an undirected edge
        /// </summary>
        /// <param name="a">The first node</param>
        /// <param name="b">The second node</param>
        /// <param name="weight">The weight of the edge</param>
        public void AddUndirectedEdge(Vertex<T> a, Vertex<T> b, int weight)
        {
            //an undirected edge is, in effect, a bidirectional edge
            //this we can create one by creating two (mono)directional edges
            AddDirectedEdge(a, b, weight);
            AddDirectedEdge(b, a, weight);
        }

        /// <summary>
        /// Return the list of all neighbors for a given node
        /// </summary>
        /// <param name="vertex"></param>
        /// <returns></returns>
        public List<Edge<T>> GetNeighbors(Vertex<T> vertex)
        {
            return AdjacencyList[vertex];
        }

        /// <summary>
        /// Get the size of a graph
        /// </summary>
        /// <returns>The size of the graph as an int</returns>
        public int GetSize()
        {
            return _size;
        }
    }
}
