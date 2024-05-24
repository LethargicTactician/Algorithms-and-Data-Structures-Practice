using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public  class Edge
    {
        //the edge has the value of the distance between nodes which is always one 
        //start and end connect to two different ("assigned") nodes

        public int Weight { get; set; } = 1;
        public Vertex Start { get; set; }
        public Vertex End { get; set; }

        public Edge(int weight, Vertex start, Vertex end)
        {
            Weight = weight;
            Start = start;
            End = end;
        }

        public Edge(Vertex start, Vertex end)
        {
            Start = start;
            End = end;
        }
    }
}
