using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public static class SolvemazeWithDyjkstras
    {
        public static void Solve(Graph maze, string startNode, string endNode)
        {
            Vertex start = maze.Vertices.First(node => node.Id == startNode[0]);
            Vertex end = maze.Vertices.First(node => node.Id == endNode[0]);

            if(start == null || end == null)
            {
                Console.WriteLine("Start and/or end node not found (unsolvable)");
                return;
            }

            // Implement Dijkstra's algorithm to solve the maze
            List<DNode> nodes = new List<DNode>();

            // Initialize distances and previous nodes
            foreach (Vertex vertex in maze.Vertices)
            {
                DNode node = new DNode(vertex);
                nodes.Add(node);  

                if (vertex.Equals(start))
                {
                    node.Distance = 0;
                }

            }

            DNode currentNode = null;
            //int minDistance = int.MaxValue;

            while (!nodes.All(n => n.Visited))
            {
                //find unvisited with smallest distance
                //set current node as visited
                currentNode = nodes.Where(n => !n.Visited).MinBy(n => n.Distance);
                currentNode.Visited = true;


                //check for the nodes that are connected to the current one
                foreach (Edge edgy in currentNode.Vertex.EdgeList)
                {
                    Vertex neighbor = edgy.End;
                    //find DNode for neighbor (stalk them)
                    DNode neighborsNode = nodes.First(n => n.Vertex.Equals(neighbor));

                    //get new distance????
                    int distance = currentNode.Distance + edgy.Weight;

                    //if the distance of the neighbor is smaller than the current distance, update it
                    if(distance < neighborsNode.Distance)
                    {
                        neighborsNode.Distance = distance;
                        neighborsNode.Previous = currentNode.Vertex;
                    }

                }

            }

            //printing condition stuff
           // bool solutionFound = false; 

            //is node reachable 
            DNode endDNode = nodes.First(n => n.Vertex.Equals(end));
            //if the end node is null then return "unsiovaable"
            if(endNode == null || endDNode.Distance == int.MinValue) // or if its int.MaxValue
            {
                Console.WriteLine("Shortest path from " + startNode + " to " + endNode + ":");
                Console.WriteLine("maze Cannot be solved");

            }

            //new path(so that program doesnt end there
            List<Vertex> path = new List<Vertex>();
            DNode currentDNode = endDNode;
            while (currentDNode.Previous != null)
            {
                path.Insert(0, currentDNode.Vertex);
                currentDNode = nodes.First(n => n.Vertex.Equals(currentDNode.Previous));

            }
            path.Insert(0, start);

            //print path
            Console.WriteLine("Shortest path from " + startNode + " to " + endNode+ ":");
            foreach(Vertex vertex in path)
            {
                Console.WriteLine(vertex.Id + " ");
            }
            Console.WriteLine();


            #region random notes
            //SOLVABLE??

            //iterate thorugh the nodes and selsect the one with minimum distance from the beginnign 
            //unitl all nodes haev been visited -> basically record your entire table first
            //The way to do this is 

            //and that will determine the rest of the paterns

            //once you compete tha path(table) you determine if its solvable or not 
            //if a valid on is found then you u use  the info fromyour table to find every path
            //store the solvable in a temp value and output it as it goes


            //NO SOLVABALE :(

            //not valid if: destination node ccant reach the start
            #endregion random notes



        }



    }
}
