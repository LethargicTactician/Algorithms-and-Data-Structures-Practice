namespace Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //list of ints in ascending order
            int[] items = { 1, 12, 23, 33, 45, 56, 69,75,80,92 };

            //number to search for 
            int target = 69;
            //search for it 
            //int indexFound = LinearSearch.SearchLinear(items, target);
            int indexFound = BinarySearch.SearchBinry(items, 0,items.Length-1, target);
            if(indexFound != -1)
            {
                Console.WriteLine(target+ " was found at  " + indexFound);
                Console.WriteLine($"Item at thar index is {items[indexFound]} ");

            }
            else
            {
                Console.WriteLine($"{target} was not found in the array :(");
            }
        }
    }
}