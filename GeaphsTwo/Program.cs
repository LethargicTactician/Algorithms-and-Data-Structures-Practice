namespace GeaphsTwo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the path to the file: ");
            var path = Console.ReadLine(); //path to the file 
            string[] lines = File.ReadAllLines(path);
            List<string> result = new List<string>();

            foreach (string line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line) && !line.StartsWith('/'))
                {
                    result.Add(line);
                }
                else if (result.Count > 0)
                {
                    Graph maze = new Graph(result);
                    char start = result.First()[0];
                    char end = result.Last()[0];
                    SolvemazeWithDyjkstras.Solve(maze, start, end);

                    //reset process
                    result.Clear();
                }
            }
            Console.ReadLine();
        }
    }
}