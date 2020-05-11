using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class Edge<T>
    {
        public int Weight { get; set; }
        public Vertex<T> Vertex { get; set; }

        public Edge(Vertex<T> vertex, int weight)
        {
            Vertex = vertex;
            Weight = weight;
        }

    }
}
