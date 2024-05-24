using System.Runtime.InteropServices;

namespace Sandbox
{
    public static class Recursion
    {
        //youre always retuening something in recursion
        public static string HelloWorld(char[] arr, int index)
        {
            //stop case: iterate thorught the loop until you reach the end of the array
            if(index == arr.Length - 1)
            {
                return arr[index].ToString();

            }
            else
            {
                //grab the item of the current index and append it so that it goes to the next letter
                return arr[index] + HelloWorld(arr, index + 1);
            }


        }

        public static int SumArrayOfNumbers(int[] numbers, int index)
        {
            if(index == numbers.Length - 1)
            {
                return numbers[index];

            }
            else
            {
                return numbers[index] + SumArrayOfNumbers(numbers, index + 1);
            }
        }

        //public static int SumArrayByIndex(int[] arr, int startIndex, int trackedIndex)
        //{
        //    if(startIndex == 0)
        //    {
        //        return arr[startIndex];

        //    } else if(startIndex == arr.Length - 1)
        //    {
        //        return arr[startIndex];

        //    }
        //    else
        //    {
        //        //int rightValue = SumArrayByIndex
        //        return arr[startIndex] + SumArrayByIndex(arr, startIndex + 1) + SumArrayByIndex(arr, startIndex -1);
        //    }
        //}



    }
}