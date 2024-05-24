namespace nQueens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this is where the user is prompted for a table size
            Console.Write("Enter the value of n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("n = {0}", n);

            int count = NQueensSolver.CalculateNQueens(n);
            Console.WriteLine("Total Solutions: {0}", count);

        }
    }
}