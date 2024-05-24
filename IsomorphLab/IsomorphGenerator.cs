using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

namespace IsomorphLab
{
    public static class IsomorphGenerator
    {
        
        public static string Create(IEnumerable<string> words)
        {
            
            // Create dictionaries to store groups of words and their corresponding letter frequencies
            Dictionary<string, List<string>> ExactwordGroups = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> LoosewordGroups = new Dictionary<string, List<string>>();

            // Iterate over each word in the input list
            foreach (string word in words)
            {
                int count = 0;
                int Lcount = 1;
                // Calculate the Exactfrequency of each letter in the word
                Dictionary<char, int> Exactfrequency = new Dictionary<char, int>();
                Dictionary<char, int> Loosefrequency = new Dictionary<char, int>();
                List<int> Exactpattern = new List<int>();
                List<int> LoosePattern = new List<int>();
                
                foreach (char c in word)
                {
                    if (!Exactfrequency.ContainsKey(c))
                    {
                        Exactfrequency.Add(c, count);
                        count++;
                        Exactpattern.Add(Exactfrequency[c]);

                    }
                    else
                    {
                        Exactpattern.Add(Exactfrequency[c]);
                    }
                }

                //for loose isomorphs
                foreach(char letter in word)
                {
                    if (!Loosefrequency.ContainsKey(letter))
                    {
                        // If the character hasn't been seen before, add it to the dictionary with a count of 1
                        Loosefrequency.Add(letter, 1);

                        // Add the new count to the LoosePattern list
                        LoosePattern.Add(1);

                    }
                    else 
                    {
                        // If the character has been seen before, increment its count in the dictionary
                        Loosefrequency[letter]++;
                        // Get the current count of the character and add it to the LoosePattern list
                        LoosePattern.Add(Loosefrequency[letter]);


                    }
                }

                //Console.WriteLine($"This line of code is there {String.Join(" ", Exactpattern)} -> " + word);
               Console.WriteLine($"This line of code is there {String.Join(" ", Loosefrequency.Values)} -> " + word);
                string patternString = string.Join(" ", Exactpattern);
                string loosePatternString = string.Join(" ", LoosePattern);
                string groupKey = patternString;
                string LGroupKey = loosePatternString;

                if (!ExactwordGroups.ContainsKey(patternString))
                {
                    //groupKey += String.Join(" ", patternString);
                    //Console.WriteLine($"group key {String.Join(" ", groupKey)}");
                    //Console.WriteLine($"loose group key {String.Join(" ", groupKey)}");
                    ExactwordGroups[groupKey] = new List<string>();
                }
                //Console.WriteLine(word);
                ExactwordGroups[groupKey].Add(word);

                //loose isomorph
                if (!LoosewordGroups.ContainsKey(loosePatternString))
                {
                    //LoosewordGroups += String.Join(" ", loosePatternString);
                    //Console.WriteLine($"group key {String.Join(" ", groupKey)}");
                    //Console.WriteLine($"loose group key {String.Join(" ", LGroupKey)}");
                    LoosewordGroups[LGroupKey] = new List<string>();
                }
               // Console.WriteLine(word);
                LoosewordGroups[LGroupKey].Add(word);

            }

            // Create strings to store the results
            string NonIsomorphs = "Non - Isomorphs\n";
            string ExactIsomorphs = "Exact Isomorphs\n";
            string LooseIsomorphs = "Loose Isomorphs\n";

            // Iterate over each group and add its words to the corresponding result string
            foreach (string groupKey in ExactwordGroups.Keys)
            {
                List<string> groupWords = ExactwordGroups[groupKey];
                
                if (groupWords.Count >= 1)
                {
                    try
                    {
                        if (IsNonIsomorph(groupWords[0], groupWords.GetRange(1, groupWords.Count - 1), groupKey))
                        {
                            NonIsomorphs += $"{String.Join(" ", groupWords)} ";
                        }
                        if (IsExactIsomorph(groupWords[0], groupWords.GetRange(1, groupWords.Count - 1), groupKey))
                        {

                            ExactIsomorphs += $"{String.Join(" ", groupKey)}:{String.Join(" ", groupWords)}\n";
                        }
                       
                    } catch(Exception e)
                    {
                        Console.WriteLine(e);
                    }

                }
            }

            foreach (string looseGroupKeys in LoosewordGroups.Keys)
            {
                List<string> looseGroupWords = LoosewordGroups[looseGroupKeys];
                if (looseGroupWords.Count > 1 || looseGroupWords.Count <= 1)
                {
                    try
                    {
                        // Count the number of characters in the first word
                        int firstWordLength = looseGroupWords[0].Length;

                        // Count the number of characters in each subsequent word and check if it matches the length of the first word
                        bool isLengthMatch = true;
                        for (int i = 1; i < looseGroupWords.Count; i++)
                        {
                            int currentWordLength = looseGroupWords[i].Length;
                            if (currentWordLength != firstWordLength)
                            {
                                isLengthMatch = false;
                                break;
                            }
                        }

                        // If all the words have the same length, check if they're loose isomorphs
                        if (isLengthMatch && IsLooseIsomorph(looseGroupWords[0], looseGroupWords.GetRange(1, looseGroupWords.Count - 1), looseGroupKeys))
                        {
                            LooseIsomorphs += $"{String.Join(" ", looseGroupKeys)} : {String.Join(" ", looseGroupWords.OrderBy(x => x))}\n";
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }


            // Combine the results and return the final string
            return $"{NonIsomorphs}\n\n{ExactIsomorphs}\n{LooseIsomorphs}";
        }


        //for loose, count how many times aletter appears in the frequency and if the count of it is <= 1 then it's loose
        private static bool IsLooseIsomorph(string word, List<string> previousWords, string frequency)
        {
            Dictionary<int, string> patterList = new Dictionary<int, string>();
            // Check if the Exactfrequency of each letter in the word is the same as the Exactfrequency of the same letter in all the previous words
            //if (word.Length != word.Length)
            //{
            //    return false;
            //}

            foreach (char c in frequency)
            {
                int expectedFreq = c * previousWords.Count;
                int actualFreq = 0;
                foreach (string prevWord in previousWords)
                {
                    actualFreq += prevWord.Count(ch => ch == c);
                }
                if (actualFreq - expectedFreq > 1)
                {
                    return true;
                }

                if (previousWords.Count < 1)
                {
                    return false;
                    //Console.WriteLine("L + Ratio");
                }
            }

            return true;
        }

        private static bool IsNonIsomorph(string word, List<string> previousWords, string frequency)
        {
            Dictionary<int, string> patterList = new Dictionary<int, string>();
            // Check if the Exactfrequency of each letter in the word is the same as the Exactfrequency of the same letter in all the previous words
            foreach (char c in frequency)
            {
                ///LOOSE
                int count = 0;
                int expectedFreq = c * previousWords.Count;
                int actualFreq = 0;
                foreach (string prevWord in previousWords)
                {
                    actualFreq += prevWord.Count(ch => ch == c);
                }
                if (actualFreq != expectedFreq)
                {
                    return false;
                }
                else
                {
                    return true;
                }



                // else {return true;}
            }

            return true;
        }

        private static bool IsExactIsomorph(string word, List<string> previousWords, string frequency)
        {

            // Check if the Exactfrequency of each letter in the word is the same as the Exactfrequency of the same letter in all the previous words, with some leeway for minor differences
            foreach (char c in frequency)
            {
                int expectedFreq = c * previousWords.Count;
                int actualFreq = 0;
                foreach (string prevWord in previousWords)
                {
                    actualFreq += prevWord.Count(ch => ch == c);
                }
                if (actualFreq - expectedFreq > 1)
                {
                    return true;
                }

                if (previousWords.Count <= 1)
                {
                    return false;
                    //Console.WriteLine("L + Ratio");
                }
            }

            

            return true;
        }

    }
    
}
