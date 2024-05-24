using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeaphsTwo
{
    public static class SolvemazeWithDyjkstras
    {
        public static void Solve(Graph maze, string startNode, string endNode)
        {
            Vertex start = maze.Vertices.FirstOrDefault(node => node.Id == startNode);
            Vertex end = maze.Vertices.FirstOrDefault(node => node.Id == endNode);

            if (start == null || end == null)
            {
                Console.WriteLine("Start or end node not found.");
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

            while (!nodes.All(n => n.Visited))
            {
                //find unvisited node with the smallest distance
                currentNode = nodes.Where(n => !n.Visited).MinBy(n => n.Distance);
                currentNode.Visited = true;

                //check for the nodes that are connected to the current one
                foreach (Edge edge in currentNode.Vertex.EdgeList)
                {
                    Vertex neighbor = edge.End;
                    //find DNode for neighbor
                    DNode neighborsNode = nodes.First(n => n.Vertex.Equals(neighbor));

                    //get new distance
                    int distance = currentNode.Distance + 1;

                    //if the distance of the neighbor is smaller than the current distance, update it
                    if (distance < neighborsNode.Distance)
                    {
                        neighborsNode.Distance = distance;
                        neighborsNode.Previous = currentNode.Vertex;
                    }
                }
            }

            // Check if the end node is reachable
            DNode endDNode = nodes.FirstOrDefault(n => n.Vertex.Equals(end));
            if (endDNode == null || endDNode.Distance == int.MaxValue)
            {
                Console.WriteLine("Maze cannot be solved.");
                return;
            }

            // Reconstruct the path from end to start
            List<Vertex> path = new List<Vertex>();
            DNode currentDNode = endDNode;
            while (currentDNode.Previous != null)
            {
                path.Insert(0, currentDNode.Vertex);
                currentDNode = nodes.First(n => n.Vertex.Equals(currentDNode.Previous));
            }
            path.Insert(0, start);

            // Display the path
            Console.WriteLine("Shortest path:");
            foreach (Vertex vertex in path)
            {
                Console.Write(vertex.Id + " ");
            }
            Console.WriteLine();
        }
    }
}
