using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_Architect
{
    public class Vertex
    {
        //node class takes care of the data and Id of the vertex (node and vertex are the same thing)

        public Vertex(string id, int data)
        {
            Id = id;
            Data = data;
            EdgeList = new List<Edge>();
        }

        public string Id { get; set; }
        //it would have the data to recognize this is where the data goes
        public int Data { get; set; }
        public List<Edge> EdgeList { get; set; }


    }
}
