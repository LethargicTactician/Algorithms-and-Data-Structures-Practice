using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public class BinarySearch
    {
        public static int SearchBinry(int[] items,  int start, int end, int target)
        {

            if(start < end)
            {
                //did not find the target
                return -1;
            }
            else
            {
                int middleIndex = (start + end) / 2;
                if (items[middleIndex] == target)
                {
                    return middleIndex;
                } else if (items[middleIndex] < target)
                {
                    //going right, search the right half
                    return SearchBinry(items, middleIndex + 1, end, target);


                } else if (items[middleIndex] > target)
                {
                    //go to the left
                    return SearchBinry(items, start, middleIndex -1, target);
                }                
            } 
            return-1;
        }
    }
}
