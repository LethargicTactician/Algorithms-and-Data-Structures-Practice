using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_Architect
{
    public class Graph
    {
        public List<Vertex> Vertices { get; set; }
        

        public Graph(List<string> lines)
        {
            Vertices = new List<Vertex>();
            //node build
            foreach (string line in lines)
            {
                string[] nodeNames = lines[0].Split(',');

                foreach (string nodeName in nodeNames)
                {
                    Vertex node = new Vertex(nodeName, 1);
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

                    Vertex startNode = Vertices.First(node => node.Id.Equals(adjacentNodes[0]));

                    if (startNode != null)
                    {
                        for (int w = 1; w < adjacentNodes.Length; w++)
                        {
                            string[] weightValues = adjacentNodes[w].Split(":");

                            //Console.WriteLine(String.Join(", ",weightValues));
                            Vertex endNode = Vertices.First(node => node.Id.Equals(weightValues[0]));

                            if (endNode != null)
                            {
                                //if these thow things have a value then we mark the line up
                                Edge edge = new Edge(Convert.ToInt16(weightValues[1]), startNode, endNode);
                                startNode.EdgeList.Add(edge);

                                //setting wegight??
                                //int weight = edge.Weight;
                                //weight = ;
                            }



                        }
                    }

                }
            }

        }
    }


}

            
