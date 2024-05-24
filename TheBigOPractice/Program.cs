using System.Diagnostics;

namespace TheBigOPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ProblemOne();
            //ProblemTwo();
            //ProblemThree();
        }

        //PROBLEM TWO
        private static void ProblemTwo()
        {
            Stopwatch stopwatch = new Stopwatch();
            //int[] sorted1 = { 2, 5, 5, 5 };
            //int[] sorted2 = { 2, 2, 3, 5,5, 7 };

            int[] sorted1 = GetArrayOfRandomInts(500000, true);
            int[] sorted2 = GetArrayOfRandomInts(500000, true);

            stopwatch.Start();
            int[] result = FindMyTwin(sorted1, sorted2);
            stopwatch.Stop();

            PrintExecutionTime(stopwatch);
            
        }

        private static int[] FindMyTwin(int[] a1, int[] a2)
        {

            //make a list that will store the matching numbers/result 
            List<int> result = new List<int>();
            //wanted to use this count to count how many times it goes through the loop
            int count = 0;

            //these will sotre the items of an array similar to a temp
            int No1 = 0;
            int No2 = 0;

            //loop that will comaprte the elements in the arrays (a1 with a2) 
            while(No1< a1.Length && No2 < a2.Length)
            {

                //comapre current elements(a1 and a2) and if they're equal, add the number to the result and increment the count that goes to the next element in the array (repeats)
                if (a1[No1] == a2[No2])
                {
                    result.Add(a1[No1]);
                    No1++;
                    No2++;
                    //do the same thing but this time it's if they're not equal so it doesn't add it to the list
                } else if (a1[No1] < a2[No2])
                {
                    No1++;
                }
                else
                {
                    No2++;
                }
                count++;
            }                
                       
            //return result as an array
            int[] matchingResults = result.ToArray();
            Console.WriteLine(string.Join(", ", matchingResults)+ $" -> count: {count}");          

            return matchingResults;
        }
        
        //PROBLEM ONE
        private static void ProblemOne()
        {
            Stopwatch stopwatch = new Stopwatch();
            int[] sample = GetArrayOfRandomInts(8, false);
            stopwatch.Start();
            int largest = FindLargestNum(sample);
            stopwatch.Stop();

            PrintExecutionTime(stopwatch);
        }

        //class ex.
        private static int FindLargestNum(int[] a)
        {
     
            //what does it do? get the biggest num
            if(a.Length == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(a));

            }

            int x = a.Length - 1;
            int y = a[0];
            int count = 0;
            //question 2 - 
            //question 3- 999 because tou skip 0
            for (int i = 1; i <= x; i++)
            {
                count ++;   
            
                if (a[i] > y)
                {
                    y = a[i];
                }
            }
            Console.WriteLine("Count: " + count);
            return y;

        }
        

        //PROBLEM THREE
        private static void ProblemThree()
        {
            string nonPalindromeExample = "Metaphor";
            string palindromeExample = "Refer";

            MePalindrome(palindromeExample);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //code here
            stopwatch.Stop();

            PrintExecutionTime(stopwatch);
        }

        private static bool MePalindrome(string word)
        {
            //string that will take in the reversed version the word you enter
            string reversedWord = null;
            string resultOutput = "";
            //make a character array that will store each letter of that word
            char[] letterz = word.ToCharArray();

            //iterate through the characters in the word and from right to left(researched)
            for(int i = letterz.Length -1; i > -1; i--)
            {
                //append(add an element to the lsit) to the reversedWord string
                reversedWord += letterz[i];
                
            }
            //for testing;
            //Console.WriteLine(reversedWord);
            //making sure there's no whitespace on the word
            word = word.Replace(" ", "");
            reversedWord = reversedWord.Replace(" ", "");

            //comapre the reversed string and the original word then if it's the same return true and if not return false
            if (reversedWord.ToLower() == word.ToLower())
            {
                Console.WriteLine($"Your word is a Palindrome! Original word: {word} -> Reversed Word: {reversedWord}");
                return true;
                
                
            }
            else
            {
                Console.WriteLine("Your word is not a plaindrome, please try a different one");
                return false;
                
            }
           
            //return true;
        }



        //OTHR
        private static int[] GetArrayOfRandomInts(int count, bool sorted)
        {
            Random rand = new Random();
            int[] ints = new int[count];

            for(int i = 0; i< count; i++)
            {
                ints[i] = rand.Next(1, 1000);
            }

            if (sorted)
            {
                Array.Sort(ints);
            }

            return ints;
        }


        private static void PrintExecutionTime(Stopwatch stopwatch)
        {
            Console.WriteLine("Time Elapsed (s): {0}", stopwatch.Elapsed.TotalSeconds);
            Console.WriteLine("Time Elapsed (ms): {0}", stopwatch.Elapsed.TotalMilliseconds);
            Console.WriteLine("Time Elapsed (ns): {0}", stopwatch.Elapsed.TotalMilliseconds * 1000000);
            Console.WriteLine("------------------------------------------------------------------");
        }

    }
}