using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingLibrary;
using System.Text;

namespace SortingLibraryTests
{
    //[TestClass]
    //public class SorterTests
    //{
    //    //constatly switch this number, smaller numbers will help you for testing but you'll have to use 100 eventually
    //    private int itemsInArray = 5;
    //    protected int[] hunRand;
    //    protected int[] hunDesc;
    //    protected int[] hunAsc;
    //    protected string expected;
    //    //protected string expected2;

    //    #region setupCode

    //    public SorterTests()
    //    {
    //        hunRand = new int[itemsInArray];
    //        hunDesc = new int[itemsInArray];
    //        hunAsc = new int[itemsInArray];
    //        Random rand = new Random(12271978);
    //        for (int i = 0; i < hunRand.Length; i++)
    //        {
    //            hunRand[i] = rand.Next(100001);
    //        }

    //        //ten = mil.Take(10).ToArray();
    //        hunDesc = hunRand.OrderByDescending(x => x).ToArray();
    //        hunAsc = hunRand.OrderBy(x => x).ToArray();
    //        expected = ArrayToString(hunAsc);
    //    }

    //    protected int[] CloneRand
    //    {
    //        get { return (int[])hunRand.Clone(); }
    //    }

    //    protected int[] CloneDesc
    //    {
    //        get { return (int[])hunDesc.Clone(); }
    //    }

    //    protected int[] CloneAsc
    //    {
    //        get { return (int[])hunAsc.Clone(); }
    //    }

    //    protected string ArrayToString(int[] a)
    //    {
    //        StringBuilder sb = new StringBuilder();

    //        if (a.Length > 0)
    //        {
    //            sb.Append(a[0]);
    //            for (int i = 1; i < a.Length; i++)
    //            {
    //                sb.Append(", ");
    //                sb.Append(a[i]);
    //            }
    //        }

    //        return sb.ToString();
    //    }

    //    #endregion

    //    [TestMethod]
    //    public void ExampleTestMethod()
    //    {
    //        Assert.AreEqual(true, true);
    //    }
        

    //    //BUBBLE SORT TESTS
    //    [TestMethod]
    //    public void BubbleSortOnRandomArrayOne()
    //    {
    //        int[] arr = CloneRand;

    //        Sorter<int>.BubbleSort(arr);
    //        string actual = ArrayToString(arr);
    //        Console.WriteLine(actual);
    //        Assert.AreEqual(expected, actual);

    //    }

    //    [TestMethod]
    //    public void BubbleSortTwo()
    //    {
    //        string[] arrActual = { "10", "1", "8", "5", "4", "12" };
    //        int[] arrActualInt = Array.ConvertAll(arrActual, int.Parse); // Convert string array to int array
    //        int[] arrExpected = { 1, 4, 5, 8, 10, 12 };

    //        Sorter<int>.BubbleSort(arrActualInt);
    //        string actual = string.Join(",", arrActualInt); // Convert int array to string for comparison
    //        string expected = string.Join(",", arrExpected);

    //        Assert.AreEqual(expected, actual);
    //    }


    //    [TestMethod]
    //    public void BubbleSortThree()
    //    {
    //        int[] arrActual = { 11, 9, 21, 7, 3, 15 };
    //        int[] arrExpected = { 3, 7, 9, 11, 15, 21 };
    //        Sorter<int>.BubbleSort(arrActual);
    //        string actual = ArrayToString(arrActual);
    //        string expected = ArrayToString(arrExpected);
    //        Console.WriteLine(actual);
    //        Assert.AreEqual(expected, actual);
    //    }

    //    [TestMethod]
    //    public void BubbleSortFour()
    //    {
    //        int[] arrActual = { 47, 18, 32, 11, 29, 25 };
    //        int[] arrExpected = { 11, 18, 25, 29, 32, 47 };
    //        Sorter<int>.BubbleSort(arrActual);
    //        string actual = ArrayToString(arrActual);
    //        string expected = ArrayToString(arrExpected);
    //        Console.WriteLine(actual);
    //        Assert.AreEqual(expected, actual);
    //    }

    //    [TestMethod]
    //    public void BubbleSortFive()
    //    {
    //        int[] arrActual = { 10, 1, 8, 5, 4, 12 };
    //        int[] arrExpected = { 1, 4, 5, 8, 10, 12 };
    //        Sorter<int>.BubbleSort(arrActual);
    //        string actual = ArrayToString(arrActual);
    //        string expected = ArrayToString(arrExpected);
    //        Console.WriteLine(actual);
    //        Assert.AreEqual(expected, actual);
    //    }


    //    //INSERTION SORT TESTS
    //    [TestMethod]
    //    public void InsertionSortTestOne()
    //    {
    //       int[] arrActual = { 4, 5, 8, 2, 9, 43, 200, 119, 23, 3, 6, 7 };
    //       int[] arrExpected = { 2, 3, 4, 5, 6, 7, 8, 9, 23, 43, 119, 200 };
    //       // int[] arrActual = CloneRand;
            
    //        Sorter<int>.InsertSort(arrActual);
    //        string actual = ArrayToString(arrActual);
    //        string expected2 = ArrayToString(arrExpected);
    //        Assert.AreEqual(expected2, actual);
    //    }
    
    //    [TestMethod]
    //    public void InserSortTestTwo()
    //    {
    //        int[] arrActual = { 4, 5, 8, 2, 9, 43, 200, 119, 23, 3, 6, 7, 1 };
    //        int[] arrExpected = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 23, 43, 119, 200 };
    //        // int[] arrActual = CloneRand;

    //        Sorter<int>.InsertSort(arrActual);
    //        string actual = ArrayToString(arrActual);
    //        string expected2 = ArrayToString(arrExpected);
    //        Assert.AreEqual(expected2, actual);

    //    }

    //    [TestMethod]
    //    public void InserSortThree()
    //    {
    //        int[] arrActual = { 10, 1, 8, 5, 4, 12 };
    //        int[] arrExpected = { 1, 4, 5, 8, 10, 12 };

    //        Sorter<int>.InsertSort(arrActual);
    //        string actual = ArrayToString(arrActual);
    //        string expected = ArrayToString(arrExpected);
    //        Console.WriteLine(actual);
    //        Assert.AreEqual(expected, actual);
    //    }

    //    [TestMethod]
    //    public void InserSortFour()
    //    {
    //        int[] arrActual = { 1, 4, 5, 8, 10, 12 };
    //        int[] arrExpected = { 1, 4, 5, 8, 10, 12 };

    //        Sorter<int>.InsertSort(arrActual);
    //        string actual = ArrayToString(arrActual);
    //        string expected = ArrayToString(arrExpected);
    //        Console.WriteLine(actual);
    //        Assert.AreEqual(expected, actual);
    //    }

    //    [TestMethod]
    //    public void InserSortFive()
    //    {
    //        int[] arrActual = {  };
    //        int[] arrExpected = {  };

    //        Sorter<int>.InsertSort(arrActual);
    //        string actual = ArrayToString(arrActual);
    //        string expected = ArrayToString(arrExpected);
    //        Console.WriteLine(actual);
    //        Assert.AreEqual(expected, actual);
    //    }

    //    //SELECTION SORT TESTS
    //    [TestMethod]
    //    public void SelectionSortTestOne()
    //    {
    //        int[] arrActual = { 10, 1, 8, 5, 4, 12, 10, 1, 8, 5, 4, 12 };
    //        int[] arrExpected = { 1, 1, 4, 4, 5, 5, 8, 8, 10, 10, 12, 12 };

    //        Sorter<int>.SelecetionSort(arrActual);
    //        string actual = ArrayToString(arrActual);
    //        string expected = ArrayToString(arrExpected);
    //        Console.WriteLine(actual);
    //        Assert.AreEqual(expected, actual);

    //    }
        
    //    [TestMethod]
    //    public void SelectionSortTestTwo()
    //    {
    //        int[] arrActual = { 10, 10, 10, 10, 10, 10, 10, 10, 10 };
    //        int[] arrExpected = { 10, 10, 10, 10, 10, 10, 10, 10, 10 };

    //        Sorter<int>.SelecetionSort(arrActual);
    //        string actual = ArrayToString(arrActual);
    //        string expected = ArrayToString(arrExpected);
    //        Console.WriteLine(actual);
    //        Assert.AreEqual(expected, actual);
    //    }

    //    [TestMethod]
    //    public void SelectionSortTestThree()
    //    {
    //        int[] arrActual = { 10, 1, 8, 5, 4, 12, 10, 1, 8, 5, 4, 12, 10, 1, 8, 5, 4, 12 };
    //        int[] arrExpected = { 1, 1, 1, 4, 4, 4, 5, 5, 5, 8, 8, 8, 10, 10, 10, 12, 12, 12 };

    //        Sorter<int>.SelecetionSort(arrActual);
    //        string actual = ArrayToString(arrActual);
    //        string expected = ArrayToString(arrExpected);
    //        Console.WriteLine(actual);
    //        Assert.AreEqual(expected, actual);
    //    }

    //    [TestMethod]
    //    public void SelectionSortTestFour()
    //    {
    //        int[] arrActual = { 81, 72, 26, 23, 49, 38, 61, 57, 34, 30, 95, 12, 54, 41, 89, 15 };
    //        int[] arrExpected = { 12, 15, 23, 26, 30, 34, 38, 41, 49, 54, 57, 61, 72, 81, 89, 95 };

    //        Sorter<int>.SelecetionSort(arrActual);
    //        string actual = ArrayToString(arrActual);
    //        string expected = ArrayToString(arrExpected);
    //        Console.WriteLine(actual);
    //        Assert.AreEqual(expected, actual);
    //    }

    //    [TestMethod]
    //    public void SelectionSortTestFive()
    //    {
         
    //        int[] arrActual = {  };
    //        int[] arrExpected = {  };

    //        Sorter<int>.SelecetionSort(arrActual);
    //        string actual = ArrayToString(arrActual);
    //        string expected = ArrayToString(arrExpected);
    //        Console.WriteLine(actual);
    //        Assert.AreEqual(expected, actual);

    //    }



    //    //QUICK SORT TESTS -> 5 PARTITION AND 5 QUICKSORT
    //    //[TestMethod]
    //    //public void PartitionTestPivotEndsMiddleOne()
    //    //{
    //    //    int[] arr = { 3, 1,5,2,4 };
    //    //    int[] expectedArr = { 2, 1, 3, 5, 4 };

    //    //    int correctIndex = Sorter<int>.Partition(arr, 0, arr.Length-1);
    //    //    Assert.AreEqual(2, correctIndex);


    //    //}
    //    [TestMethod]
    //    public void PartitionShouldReturnSameResultForEqualElements()
    //    {

    //        int[] arr = { 1, 1, 1, 1 };
    //        int start = 0;
    //        int end = arr.Length - 1;

    //        int actualResult2 = Sorter<int>.Partition(arr, start, end);

    //        Assert.AreEqual(start, actualResult2);
    //    }

    //    [TestMethod]
    //    public void PartitionHasNoElements()
    //    {
    //        //it used to be an empty array but that was not possible to test with this methodsince it would go out of bounds
    //        int[] arr = { 5,8 };
    //        int start = 0;
    //        int end = arr.Length - 1;

    //        int actualResult = Sorter<int>.Partition(arr, start, end);

    //        Assert.AreEqual(start, actualResult);
    //    }

    //    [TestMethod]
    //    public void PartitionHasSomeEqualElements()
    //    {
    //        int[] arr = { 3,5,6,3,1,5 };
    //        int start = 0;
    //        int end = arr.Length - 1;

    //        int actualResult = Sorter<int>.Partition(arr, start, end);

    //        Assert.AreEqual(start, actualResult);
    //    }

    //    [TestMethod]
    //    public void PartitionTestingBiggerNumbers()
    //    {
    //        //it used to be an empty array but that was not possible to test with this methodsince it would go out of bounds
    //        int[] arr = { 554, 7993 };
    //        int start = 0;
    //        int end = arr.Length - 1;

    //        int actualResult = Sorter<int>.Partition(arr, start, end);

    //        Assert.AreEqual(start, actualResult);
    //    }

    //    [TestMethod]
    //    public void IDKWhatOtherTestsToDoSoIJustMadeAnArrayWithEvenNumbers()
    //    {
    //        //it used to be an empty array but that was not possible to test with this methodsince it would go out of bounds
    //        int[] arr = { 2,6,4,8,12,10 };
    //        int start = 0;
    //        int end = arr.Length - 1;

    //        int actualResult = Sorter<int>.Partition(arr, start, end);

    //        Assert.AreEqual(start, actualResult);
    //    }





    //    [TestMethod]
    //    public void WahtIFArrayIsEmptyQuickSortOne()
    //    {
    //        int[] arr = {  };
    //        int[] expectedArr = {  };


    //        Sorter<int>.QuickSort(arr);
    //        string actual = ArrayToString(arr);
    //        string expected2 = ArrayToString(expectedArr);
    //        Assert.AreEqual(expected2, actual);
            

    //    }

    //    [TestMethod]
    //    public void IRanOutOfTestNameIdeasForThisQuickSortTestFive()
    //    {
    //        int[] arrActual = { 10, 1, 8, 5, 4, 12, 10, 1, 8, 5, 4, 12 };
    //        int[] arrExpected = { 1, 1, 4, 4, 5, 5, 8, 8, 10, 10, 12, 12 };

    //        Sorter<int>.QuickSort(arrActual);
    //        string actual = ArrayToString(arrActual);
    //        string expected = ArrayToString(arrExpected);
    //        Console.WriteLine(actual);
    //        Assert.AreEqual(expected, actual);
    //    }


    //    [TestMethod]
    //    public void RandomEzNumArrayQuickSortTestTwo()
    //    {
    //        int[] arrActual = { 10, 1, 8, 5, 4, 12, 10, 1, 8, 5, 4, 12 };
    //        int[] arrExpected = { 1, 1, 4, 4, 5, 5, 8, 8, 10, 10, 12, 12 };

    //        Sorter<int>.QuickSort(arrActual);
    //        string actualBlah = ArrayToString(arrActual);
    //        string expectedBlah = ArrayToString(arrExpected);
    //        Console.WriteLine(actualBlah); 
    //        Assert.AreEqual(expectedBlah, actualBlah);


    //    }

    //    [TestMethod]
    //    public void WhatIfAlreadySortedQuickSortTestThree()
    //    {
    //        int[] arr = { 1, 4, 5, 7, 9, 10, 30, 59  };
    //        int[] expectedArr = { 1, 4, 5, 7, 9, 10, 30, 59 };


    //        Sorter<int>.QuickSort(arr);
    //        string actual = ArrayToString(arr);
    //        string expected2 = ArrayToString(expectedArr);
    //        Assert.AreEqual(expected2, actual);
    //    }

    //    [TestMethod]
    //    public void ArrayThatsInReverseQuickSortTestFour()
    //    {
    //        int[] arr = { 90, 80, 70, 60, 50, 40, 30, 20, 10 };
    //        int[] expectedArr = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };


    //        Sorter<int>.QuickSort(arr);
    //        string actual = ArrayToString(arr);
    //        string expected2 = ArrayToString(expectedArr);
    //        Assert.AreEqual(expected2, actual);
    //    }



    //    //MERGE SORT TESTS
    //    [TestMethod]
    //    public void TestMergeSort()
    //    {
    //        int[] arr = { 3, 1, 5, 2, 4 };
    //        int[] expectedArr = { 1, 2, 3, 4, 5 };

    //        Sorter<int>.MergeSort(arr);
    //        string actual = ArrayToString(arr);
    //        string expected2 = ArrayToString(expectedArr);
    //        Assert.AreEqual(expected2, actual);
    //    }

    //    [TestMethod]
    //    public void WhatIfTheresOnlyOneNumAlreadyMergeTestTwo()
    //    {
    //        int[] arr = { 3 };
    //        int[] expectedArr = { 3 };

    //        Sorter<int>.MergeSort(arr);
    //        string actual = ArrayToString(arr);
    //        string expected2 = ArrayToString(expectedArr);
    //        Assert.AreEqual(expected2, actual);
    //    }

    //    [TestMethod]
    //    public void EmptyArrayCheckMergeSortTestThree()
    //    {
    //        int[] arr = { 3, 1, 5, 2, 4 };
    //        int[] expectedArr = { 1, 2, 3, 4, 5 };

    //        Sorter<int>.MergeSort(arr);
    //        string actual = ArrayToString(arr);
    //        string expected2 = ArrayToString(expectedArr);
    //        Assert.AreEqual(expected2, actual);
    //    }

    //    [TestMethod]
    //    public void Hi()
    //    {
    //        int[] arr = { 3, 1, 5, 2, 4 };
    //        int[] expectedArr = { 1, 2, 3, 4, 5 };

    //        Sorter<int>.MergeSort(arr);
    //        string actual = ArrayToString(arr);
    //        string expected2 = ArrayToString(expectedArr);
    //        Assert.AreEqual(expected2, actual);
    //    }

    //    [TestMethod]
    //    public void BiggerNumbersArrayTest()
    //    {
    //        int[] arr = { 433, 100, 574, 322, 454 };
    //        int[] expectedArr = { 100, 322, 433, 454, 574 };

    //        Sorter<int>.MergeSort(arr);
    //        string actual = ArrayToString(arr);
    //        string expected2 = ArrayToString(expectedArr);
    //        Assert.AreEqual(expected2, actual);
    //    }



    //}
}
