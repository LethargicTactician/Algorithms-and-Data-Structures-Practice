using System.Security.Cryptography;

namespace Network_Architect
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the path to the file: ");
            var path = Console.ReadLine(); //path to the file 
            string[] lines = File.ReadAllLines(path);
            //string start = ""; //, end = "";
            List<string> result = new List<string>();

            foreach (string line in lines)
            {
                if (String.IsNullOrWhiteSpace(line))
                {
                    // Process the graph with the collected edges
                    Graph maze = new Graph(result);
                    //SolvemazeWithDyjkstras.Solve(maze, start, end);
                    SolveWithPrims.Solve(maze);

                    // Reset the result list for the next graph
                    result = new List<string>();
                }
                else
                {
                    // Add each line to the result list
                    result.Add(line);
                }
            }

            // If there are remaining lines after the last empty line, process the final graph
            if (result.Count > 0)
            {
                Graph maze = new Graph(result);
                //SolvemazeWithDyjkstras.Solve(maze, start, end);
                SolveWithPrims.Solve(maze);
            }

            Console.ReadLine();
        }
    }
}