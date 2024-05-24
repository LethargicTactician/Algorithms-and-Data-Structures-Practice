using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class Fold_an_Array
    {
        public static string[] FoldArray(int[] array, int runs)
        {
            // Make a copy of the array that is given by making a new variable (this helps when you're adding them up later on)
            int[] result = (int[])array.Clone();


            for (int i = 0; i < runs; i++)
            {
                // I need to store the new variables somewhenre soo BAM new iteration
                int[] temp = new int[(result.Length + 1) / 2];

                // Now that you have the temporary array, keep the other half
                for (int j = 0; j < temp.Length; j++)
                {
                    // Mirroring & adding the folded array (got help from chat gpt) also where the problem is at
                    if (j == temp.Length - 1 && result.Length % 2 != 0)
                    {
                        temp[j] = result[2 * j];
                    }
                    else
                    {
                        temp[j] = result[2 * j] + result[2 * j + 1];
                    }
                }

                // Update the result to the new temp variable that we just got
                result = temp;
            }

            // make the result a string because this kata wants to be extra
            string[] resultStr = new string[result.Length];
            for (int i = 0; i < result.Length; i++)
            {
                resultStr[i] = result[i].ToString();
            }

            // Return the string array
            return resultStr;
        }
    }
}

//note: temp[j] = j == temp.Length - 1 && result.Length % 2 != 0 ? result[2 * j] : result[2 * j] + result[2 * j + 1];
