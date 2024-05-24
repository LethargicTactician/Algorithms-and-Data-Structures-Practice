using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsomorphLab
{
    //not even using this class
    //was an attempt on doing oop
    internal class Exact
    {
        //class that determines if a word is an xact isomorph 

        //will determine is its exact buy comparing ot to another word
        //method that takes two strings (word and referenced word) and two dictionaries( frequesncues) (Had to use chatgpt for most of this part but I made sure I understood what was going on)
        //
        private static bool IsExactIsomorph(string word, string referenceWord, Dictionary<char, int> firstFreq, Dictionary<char, int> secondFreq)
        {
            //method checks if the words have the smae length, if they dont IsExact=false
            if (word.Length != referenceWord.Length)
            {
                return false;
            }

            //iterate over the keys of the first frequency (the frequencies for word) and compare them to eachother (has to match frequencies)
            foreach (char c in firstFreq.Keys)
            {
                if (!secondFreq.ContainsKey(c) || firstFreq[c] != secondFreq[c])
                {
                    return false;
                }
            }

            return true;
        }



    }
}
