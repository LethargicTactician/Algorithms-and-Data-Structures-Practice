using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_Architect
{
    public class SolveWithPrims
    {
        public static void Solve(Graph maze)
        {
            //prims stuff that we definitely need
            List<Vertex> visited = new List<Vertex>();
            List<Vertex> unvisited = new List<Vertex>(maze.Vertices);
            List<Edge> minSpanTree = new List<Edge>();

            //make it easy and selecet a node to start with (in this case ima taking the every first one)
            // Select the starting vertex


            // this part doesnt work well( doesnt wanna match with the list)
            Vertex start = unvisited.First();

            if (start == null)
            {
                Console.WriteLine("unsolvable -> start and/or end node(s) not found");
                return;
            }
            //basically all the nodes are stored in the unvisited until we find them in the maze, so it kind of helps to keep tack of them
            visited.Add(start);
            unvisited.Remove(start);

            while (unvisited.Count > 0)
            {
                int minWeight = int.MaxValue;
                Edge smallEdge = null;

                foreach (Vertex visitedNode in visited)
                {
                    foreach (Edge edgy in visitedNode.EdgeList)
                    {
                        Vertex nextNode = edgy.End;
                        //had to ask the ai how to do this part 
                        //from my understanding it's checking if there's a node and if there is a node it looks for the smallest edge weight on it
                        if (unvisited.Contains(nextNode) && edgy.Weight < minWeight)
                        {
                            //and if it finds that then we set the small edge to that weight and essentially "go through" that edge
                            minWeight = edgy.Weight;
                            smallEdge = edgy;
                        }
                    }
                }

                if (smallEdge != null)
                {
                    minSpanTree.Add(smallEdge);
                    visited.Add(smallEdge.End);
                    unvisited.Remove(smallEdge.End);
                }
                else
                {
                    int cableNeeded = minSpanTree.Sum(edge => edge.Weight);

                    // Print the result -> loop unitl small edge is null/ there's no more edges to go through
                    Console.WriteLine("Socket Set: " + string.Join(", ", visited.Select(v => v.Id)));
                    Console.WriteLine("Cable Needed: " + cableNeeded + "ft");
                    return;
                    //Console.WriteLine("small edge is null");
                    ////prevent infinite loop (when there is one)
                    //return;
                }

            }






        }



        
    }
}
