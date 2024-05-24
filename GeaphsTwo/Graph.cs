using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeaphsTwo
{
    public class Graph
    {
        public List<Vertex> Vertices { get; set; }

        public Graph(List<string> lines)
        {
            Vertices = new List<Vertex>();

            foreach (string line in lines)
            {
                string[] nodes = line.Split(',');

                foreach (string nodeName in nodes)
                {
                    char nodeId = Convert.ToChar(nodeName);
                    Vertex node = Vertices.FirstOrDefault(n => n.Id == nodeId);
                    if (node == null)
                    {
                        node = new Vertex(nodeId);
                        Vertices.Add(node);
                    }
                }

                for (int i = 0; i < nodes.Length - 1; i++)
                {
                    char startNodeId = Convert.ToChar(nodes[i]);
                    char endNodeId = Convert.ToChar(nodes[i + 1]);

                    Vertex startNode = Vertices.First(n => n.Id == startNodeId);
                    Vertex endNode = Vertices.First(n => n.Id == endNodeId);

                    Edge edge = new Edge(startNode, endNode);
                    startNode.EdgeList.Add(edge);
                }
            }
        }
    }

}
