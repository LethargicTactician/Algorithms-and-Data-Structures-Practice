using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public class LinearSearch
    {

        //linear search will go through an array until itfinds the value you're looking for
        public static int SearchLinear(int[] items, int target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                //find target and return it
                if (items[i] == target)
                {
                    return i;
                }
               
            }
            return -1;
        }
    }
}
