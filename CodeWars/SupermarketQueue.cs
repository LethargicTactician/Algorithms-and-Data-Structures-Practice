using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class SupermarketQueue
    {
        public static long QueueTime(int[] customers, int n)
        {
            int[] till = new int[n];
           // int customerTime = 0;
            foreach (int customer in customers)
            {
                //customers[customerTime] = customer;
                till[0] += customer;
                Array.Sort(till);
            }

            //for(int i = 0; i < customers.Length; i++){ }


            return till[till.Length - 1];
        }
    }
}

//if the till is greater than the customers -> the values all add to eachother because they will be checking out at the same time


//esle if the till is less than the customers, you'll multiply the value of the till times the current customer it's on (till * customer???) and then you'd do the same for all of them
//and then the result of that adds to the expected outcome -> ex. you have customer 5 and the till of one then you have customer 4 with the same till 5 and 4
//will add to eachother after their value alreasy went through one

