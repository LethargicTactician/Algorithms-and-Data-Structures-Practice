namespace Graphs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the path to the file: ");
            var path = Console.ReadLine(); //path to the file 
            string[] lines = File.ReadAllLines(path);
            List<string> result = new List<string>();
            string start ="", end = "";
            bool AddVerticies = true, addStartEnd = true;

            for(int i = 0; i < lines.Length; i++)
            {
                if (AddVerticies)
                {
                    //vertecies
                    //add result to this node
                    result.Add(lines[i]);
                    AddVerticies= false;
                }
                else if (addStartEnd)
                {
                    //assign start and end 
                    start = lines[i][0].ToString();
                    end = lines[i][2].ToString();
                    addStartEnd= false;

                }
                else if (lines[i].StartsWith('/'))
                {
                    //STAWP
                    continue;
                } else if (String.IsNullOrWhiteSpace(lines[i]))
                {
                    Graph maze = new Graph(result);
                    SolvemazeWithDyjkstras.Solve(maze, start,end);

                    //reset process
                    result = new List<string>();
                    AddVerticies = addStartEnd = true;

                }
                else
                {
                    //add each of these to the reult(will be parsed as edges)
                    result.Add(lines[i]);
                }
            }
           // Console.ReadLine();

        }
    }
}