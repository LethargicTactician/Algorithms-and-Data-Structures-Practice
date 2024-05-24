using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class Graph
    {
        public List<Vertex> Vertices { get; set; }

        public Graph(List<string> lines)
        {
            Vertices = new List<Vertex>();
            //node build
            foreach(string line in lines)
            {
                string[] nodeNames = lines[0].Split(',');

                foreach (string nodeName in nodeNames)
                {
                    Vertex node = new Vertex(Convert.ToChar(nodeName), 1);
                    Vertices.Add(node);
                }

                //Vertices.ForEach(v =>
                //{
                //    Console.WriteLine(v.Id);
                //});

                //creating graph
                for (int i = 1; i < lines.Count; i++)
                {
                    //basically position lines towards the nodes by their ID and connect
                    string[] adjacentNodes = lines[i].Split(',');

                    Vertex startNode = Vertices.First(node => node.Id.Equals(Convert.ToChar(adjacentNodes[0])));

                    ////it was giving me a pain with the null exceptions so I just added a few moew if statements to fix it
                    if (startNode != null)
                    {
                        for (int w = 1; w < adjacentNodes.Length; w++)
                        {

                            Vertex endNode = Vertices.First(node => node.Id.Equals(Convert.ToChar(adjacentNodes[w])));

                            if(endNode != null)
                            {
                                //if these thow things have a value then we mark the line up
                                Edge edge = new Edge(startNode, endNode);
                                startNode.EdgeList.Add(edge);

                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Start node where??");
                    }

                }
            }
            
        }
    }
}
