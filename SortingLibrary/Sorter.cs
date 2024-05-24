using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingLibrary
{
    public class Sorter<T> where T : IComparable<T>
    {
        public static void BubbleSort(T[] arr)
        {
            bool swapped;
            //checking for swap
            do
            {
                swapped = false;

                for (int c = 0; c < arr.Length - 1; c++)
                {
                    if (arr[c].CompareTo(arr[c + 1]) > 0)
                    {
                        T temp = arr[c + 1];
                        //T temp2 = arr[c + 1];
                        arr[c + 1] = arr[c];
                        arr[c] = temp;
                        swapped = true;
                    }

                }               
                
            } while (swapped);

        }


        ///INSERTION SORT
        public static void InsertSort(T[] arr)
        {
           for(int i =0; i < arr.Length; i++) {

                //iterate through the array and grab the first index 
                T numPos = arr[i];
                //grab the index before it
                int o = i - 1; 

                //check if the index before it is greater, less or equal to the first index 
                //if we meet any of those conditions, switch them out
                while(o >= 0 && arr[o].CompareTo(numPos) > 0)
                {
                    //the index after o goes after 
                    arr[o + 1] = arr[o];
                    //the original num goes before it
                    o--;
                }
                //then you update the position that you're checking
                arr[o + 1] = numPos;
           }
        }


        public static void SelecetionSort(int[] arr)
        {
            //iterate through the given array 
            for (int i = 0; i < arr.Length; i++)
            {
                //create and instance that will take the first index of the array
                int minIndex = i;

                //minIndex = i.Min();
                
                
                //iterate through the array AGAIN and find a number that is smaller than the value of the first num of the array
                //had tomake a correction so that this array gets the index after i because before it got the same one instead of the one next to it
                for (int o = i + 1; o < arr.Length; o++)
                {
                    //if the first value is less than the second value, switch their positions and then go to the next.
                    if (arr[o] < arr[minIndex])
                    {
                        //this makes the 
                        minIndex = o;
                    }
                    
                }
                // swap the values at the current index and the index with the lowest value
                if(minIndex != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                    //Swap(temp, arr[i], arr[o]);
                }
            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //quick sort -> figure out how to write it in place
        public static void QuickSort(T[] gimmeArray)
        {
            QuickSort(gimmeArray, 0, gimmeArray.Length-1);
        }

        public static void QuickSort(T[] array, int start, int end)
        {
            // If the partition has at least 2 elements, recursively sort it.
            if (start < end)
            {
                // Divide the array into two partitions around a pivot element.
                int pivotIndex = Partition(array, start, end);

                // Recursively sort the left and right partitions.
                QuickSort(array, start, pivotIndex-1);
                QuickSort(array, pivotIndex + 1, end);
            }
        }

        // Helper method to partition the array around a pivot element.
        public static int Partition(T[] arr, int start, int end)
        {
            // Choose the first element as the pivot.
            T pivot = arr[start];


            // Initialize i to be the index of the first element and j to be the index of the last element.
            int i = start;
            int j = end ;

            // Continue partitioning until the indices cross.
            while (i < j)
            {

                // Find the first element from the left that is greater than or equal to the pivot.
                while (arr[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                // Find the first element from the right that is less than or equal to the pivot.
                while (arr[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                // If i and j have not crosse ->  the elements at i and j.
                if (i < j && arr[i].CompareTo(arr[j]) == 0)
                {
                    i++;
                }
                else if (i < j)
                {
                    
                    Swap(arr, i, j);
                }
                else
                {
                    return j;
                }
            }

            return j;
        }

        //SWAP METHOD CUS I SWAP ALOT
        public static void Swap(T[] arr, int i, int j)
        {
            T temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }



        //Merge sort
        public static void MergeSort(T[] arr)
        {
            if(arr.Length <= 1)
            {
                // If the array length is 1 or less, it's already sorted
                return;
            }
            // Divide the array into two halves
            T[] left = new T[arr.Length / 2];
            T[] right = new T[arr.Length - left.Length];

            //comparing the arrays & swappin then
            for (int i = 0; i < left.Length; i++)
            {
                left[i] = arr[i];
            }

            for (int i = 0; i < right.Length; i++)
            {
                right[i] = arr[left.Length + i];
            }

            // Recursively call MergeSort on the left and right halves
            MergeSort(left);
            MergeSort(right);

            // Merge the sorted left and right halves
            MergeMeBBG(arr, left, right);



        }

        //Maybe make another method that will take in the arraysthet youre separating
        //and eventually sort them there?
        private static void MergeMeBBG(T[] arr, T[] left, T[] right)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            int arrIndex = 0;

            // Compare the elements in the left and right arrays, and add the smaller one to the main array
            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex].CompareTo(right[rightIndex]) < 0)
                {
                    //when the left one is the smaller number
                    arr[arrIndex++] = left[leftIndex++];
                }
                else
                {
                    //when the right one is thw smaller num
                    arr[arrIndex++] = right[rightIndex++];
                }
            }
            // Add any remaining elements from the left or right array -> stick em together
            while(leftIndex < left.Length)
            {
                arr[arrIndex++] = left[leftIndex++];
            }

             while (rightIndex < right.Length)
             {
                arr[arrIndex++] = right[rightIndex++];
             }

        }



    }
}
