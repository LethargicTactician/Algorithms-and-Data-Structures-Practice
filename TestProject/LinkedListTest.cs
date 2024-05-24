using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedListTest
{
    [TestClass]
    public class LinkedListTest
    {
        #region SingleLinkedList Tests
        /*
        add test - 2/2
        count test - 2/2
        insert - 2/2
        toString 1/2
        remove - 1.5/2
        removeAt - 2/2
        removeLast - 2/2
        search - 2/2
         */

        //[TestMethod]
        //public void SLL_AddTwoItemsTest()
        //{
        //    SingleLinkedList<int> sll = new SingleLinkedList<int>();
        //    sll.Add(1);
        //    sll.Add(2);
        //    string actual = sll.ToString();
        //    Assert.AreEqual("1, 2", actual);

        //}
        
        //[TestMethod]
        //public void SLL_AddMoreItemsTest()
        //{
        //    SingleLinkedList<int> sll = new SingleLinkedList<int>();
        //    sll.Add(1);
        //    sll.Add(2);
        //    sll.Add(3);
        //    sll.Add(4);
        //    sll.Add(5);
        //    sll.Add(6);
        //    sll.Add(7);
        //    sll.Add(8);
        //    sll.Add(9);
        //    sll.Add(10);
            
        //    string actual = sll.ToString();
        //    Assert.AreEqual("1, 2, 3, 4, 5, 6, 7, 8, 9, 10", actual);

        //}

        //[TestMethod]
        //public void SLL_InsertAtBeginning()
        //{
        //    SingleLinkedList<int> sll = new SingleLinkedList<int>();
        //    sll.Insert(10, 0);
        //    int expected = 10;
        //    //Assert.AreEqual(1, sll.Count);
        //    Assert.AreEqual(10, expected);
        //}

        //[TestMethod]
        //public void Insert_InMiddle()
        //{
        //    SingleLinkedList<string> sll = new SingleLinkedList<string>();
        //    sll.Add("a");
        //    sll.Add("b");
        //    sll.Add("c");
        //    sll.Insert("d", 2);
        //    string actual = "a, b, d, c";
        //    Assert.AreEqual("a, b, d, c", actual);
        //}




        //[TestMethod]
        //public void SLL_EmptyCountTest()
        //{
        //    SingleLinkedList<int> sll = new SingleLinkedList<int>();
        //    int expectedCount = 0;
        //    int actuaCount = sll.Count;
        //    Assert.AreEqual(expectedCount, actuaCount);
        //}
        
        //[TestMethod]
        //public void SLL_Counting()
        //{
        //    SingleLinkedList<int> sll = new SingleLinkedList<int>();
        //    sll.Add(1);
        //    int expected = 1;
        //    int actualCount = sll.Count;
        //    Assert.AreEqual(expected, actualCount);


           
        //}

        //[TestMethod]
        //public void SLL_EmptytoStringTest()
        //{
        //    SingleLinkedList<int> sll = new SingleLinkedList<int>();
        //     Assert.ThrowsException<InvalidOperationException>(() => sll.ToString());
        //}


        //[TestMethod]
        //public void SLL_ToStringTest() {
        //   SingleLinkedList<int> sll = new SingleLinkedList<int>();
        //    sll.Add(1);
        //    sll.Add(2);
        //    sll.Add(3);

        //    string result = sll.ToString();

        //    Assert.AreEqual("1, 2, 3", result);


        //}

        //[TestMethod]
        //public void SLL_StringToStirngTest()
        //{
        //    SingleLinkedList<string> sll = new SingleLinkedList<string>();
        //    sll.Add("Hi");
        //    sll.Add("Hello");
        //    sll.Add("Goodbye");

        //    string result = sll.ToString();
        //    Assert.AreEqual("Hi, Hello, Goodbye", result);
        //}


        //[TestMethod]
        //public void SLL_ItemRemoveTest() {

        //    SingleLinkedList<int> sll = new SingleLinkedList<int>();
        //    sll.Add(1);
        //    sll.Add(2);
        //    sll.Add(3);

        //    int removedValue = sll.Remove();

        //    Assert.AreEqual(1, removedValue);
        //    Assert.AreEqual(2, sll.Count);
        //    Assert.AreEqual("2, 3", sll.ToString());


        //}

        //[TestMethod]
        //public void SLL_EmptyListRemoveExceptionTest()
        //{
        //    SingleLinkedList<int> sll = new SingleLinkedList<int>();

        //    Assert.ThrowsException<InvalidOperationException>(() => sll.Remove());

       

        //}

        //[TestMethod]
        //public void TestSearch_Found()
        //{
        //    SingleLinkedList<int> sll = new SingleLinkedList<int>();
        //    sll.Add(10);
        //    sll.Add(20);
        //    sll.Add(30);
        //    sll.Add(40);

           
        //    int val = sll.Search(20);
        //    Assert.AreEqual(1, val);
        //}

        //[TestMethod]
        //public void TestSearch_NotFound()
        //{

        //    SingleLinkedList<int> sll = new SingleLinkedList<int>();
        //    sll.Add(10);
        //    sll.Add(20);
        //    sll.Add(30);
        //    sll.Add(40);
            
        //    int val = sll.Search(50);
        //    Assert.AreEqual(-1, val);
        //}

        //[TestMethod]
        //public void SLL_RemoveAtBeginning()
        //{
        //    SingleLinkedList<int> sll = new SingleLinkedList<int>();
        //    sll.Add(1);
        //    sll.Add(2);
        //    sll.Add(3);

        //    int removed = sll.RemoveAt(0);
        //    Assert.AreEqual(1, removed);
        //    Assert.AreEqual("2, 3", sll.ToString());
        //}


        //[TestMethod]
        //public void SLL_RemoveLastTest1()
        //{
        //    SingleLinkedList<int> sll = new SingleLinkedList<int>();
        //    sll.Add(1);
        //    sll.Add(2);
        //    sll.Add(3);

        
        //    int removed = sll.RemoveLast();

        //    Assert.AreEqual(3, removed);
        //    Assert.AreEqual("1, 2", sll.ToString());
        //}

        //[TestMethod]
        //public void SLL_RemoveLastTest2()
        //{
        //    SingleLinkedList<string> sll = new SingleLinkedList<string>();
        //    sll.Add("apple");
        //    sll.Add("banana");
        //    sll.Add("cherry");

            
        //    string removed = sll.RemoveLast();

            
        //    Assert.AreEqual("cherry", removed);
        //    Assert.AreEqual("apple, banana", sll.ToString());
        //}

        //[TestMethod]
        //public void SLL_GetTest1()
        //{
        //    SingleLinkedList<int> sll = new SingleLinkedList<int>();
        //    sll.Add(1);//0
        //    sll.Add(2);//1
        //    sll.Add(3);//2
        //    sll.Add(4);//3

        //    int actual = sll.Get(1);

        //    Assert.AreEqual(2, actual);
        //}

        //[TestMethod]
        //public void SLL_GetTest2()
        //{
        //    SingleLinkedList<string> sll = new SingleLinkedList<string>();
        //    sll.Add("pen");
        //    sll.Add("pineapple");
        //    sll.Add("apple");
        //    sll.Add("pen");

        //    string actual = sll.Get(1);

        //    Assert.AreEqual("pineapple", actual);
        //}







        //#endregion

        //#region DoubleLinkedList Tests
        ///*
        //add test - 
        //count test - 
        //insert - 
        //get - 
        //toString 
        //remove - 
        //removeAt - 
        //removeLast - 
        //search - 
        // */

        //[TestMethod]
        //public void DLL_AddTwoItemsTest()
        //{
        //    DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        //    dll.Add(1);
        //    dll.Add(2);
        //    string actual = dll.ToString();
        //    Assert.AreEqual("1, 2", actual);

        //}

        //[TestMethod]
        //public void DLL_AddMoreItemsTest()
        //{
        //    DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        //    dll.Add(1);
        //    dll.Add(2);
        //    dll.Add(3);
        //    dll.Add(4);
        //    dll.Add(5);
        //    dll.Add(6);
        //    dll.Add(7);
        //    dll.Add(8);
        //    dll.Add(9);
        //    dll.Add(10);

        //    string actual = dll.ToString();
        //    Assert.AreEqual("1, 2, 3, 4, 5, 6, 7, 8, 9, 10", actual);

        //}

        //[TestMethod]
        //public void DLL_InsertAtBeginning()
        //{
        //    DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        //    dll.Insert(10, 0);
        //    int expected = 10;
        //    //Assert.AreEqual(1, sll.Count);
        //    Assert.AreEqual(10, expected);
        //}

        //[TestMethod]
        //public void DLL_InsertInMiddle()
        //{
        //    DoubleLinkedList<string> sll = new DoubleLinkedList<string>();
        //    sll.Add("a");
        //    sll.Add("b");
        //    sll.Add("c");
        //    sll.Insert("d", 2);
        //    string actual = "a, b, d, c";
        //    Assert.AreEqual("a, b, d, c", actual);
        //}




        //[TestMethod]
        //public void DLL_EmptyCountTest()
        //{
        //    DoubleLinkedList<int> sll = new DoubleLinkedList<int>();
        //    int expectedCount = 0;
        //    int actuaCount = sll.Count;
        //    Assert.AreEqual(expectedCount, actuaCount);
        //}

        //[TestMethod]
        //public void DLL_Counting()
        //{
        //    DoubleLinkedList<int> sll = new DoubleLinkedList<int>();
        //    sll.Add(1);
        //    int expected = 1;
        //    int actualCount = sll.Count;
        //    Assert.AreEqual(expected, actualCount);



        //}

        //[TestMethod]
        //public void DLL_StringToStirngTest()
        //{
        //    SingleLinkedList<string> dll = new SingleLinkedList<string>();
        //    dll.Add("Hi");
        //    dll.Add("Hello");
        //    dll.Add("Goodbye");

        //    string result = dll.ToString();
        //    Assert.AreEqual("Hi, Hello, Goodbye", result);
        //}


        //[TestMethod]
        //public void DLL_ToStringTest()
        //{
        //    DoubleLinkedList<int> sll = new DoubleLinkedList<int>();
        //    sll.Add(1);
        //    sll.Add(2);
        //    sll.Add(3);

        //    string result = sll.ToString();

        //    Assert.AreEqual("1, 2, 3", result);


        //}


        //[TestMethod]
        //public void DLL_ItemRemoveTest()
        //{

        //    DoubleLinkedList<int> sll = new DoubleLinkedList<int>();
        //    sll.Add(1);
        //    sll.Add(2);
        //    sll.Add(3);

        //    int removedValue = sll.Remove();

        //    Assert.AreEqual(1, removedValue);
        //    Assert.AreEqual(2, sll.Count);
        //    Assert.AreEqual("2, 3", sll.ToString());


        //}

        //[TestMethod]
        //public void DLL_EmptyListRemoveExceptionTest()
        //{
        //    DoubleLinkedList<int> sll = new DoubleLinkedList<int>();

        //    Assert.ThrowsException<InvalidOperationException>(() => sll.Remove());



        //}

        //[TestMethod]
        //public void DLL_TestSearchFound()
        //{
        //    DoubleLinkedList<int> sll = new DoubleLinkedList<int>();
        //    sll.Add(10);
        //    sll.Add(20);
        //    sll.Add(30);
        //    sll.Add(40);


        //    int val = sll.Search(20);
        //    Assert.AreEqual(1, val);
        //}

        //[TestMethod]
        //public void DLL_TestSearchNotFound()
        //{

        //    DoubleLinkedList<int> sll = new DoubleLinkedList<int>();
        //    sll.Add(10);
        //    sll.Add(20);
        //    sll.Add(30);
        //    sll.Add(40);

        //    int val = sll.Search(50);
        //    Assert.AreEqual(-1, val);
        //}

        //[TestMethod]
        //public void DLL_RemoveAtBeginning()
        //{
        //    DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        //    dll.Add(1);
        //    dll.Add(2);
        //    dll.Add(3);

        //    int removed = dll.RemoveAt(0);
        //    Assert.AreEqual(1, removed);
        //    Assert.AreEqual("2, 3", dll.ToString());
        //}


        //[TestMethod]
        //public void DLL_RemoveLastTest1()
        //{
        //    DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        //    dll.Add(1);
        //    dll.Add(2);
        //    dll.Add(3);

        //    int removed = dll.RemoveAt(2);
        //    Assert.AreEqual(3, removed);
        //    Assert.AreEqual("1, 2", dll.ToString());
        //}

        //[TestMethod]
        //public void DLL_RemoveLastTest2()
        //{
        //    DoubleLinkedList<string> sll = new DoubleLinkedList<string>();
        //    sll.Add("apple");
        //    sll.Add("banana");
        //    sll.Add("cherry");


        //    string removed = sll.RemoveLast();


        //    Assert.AreEqual("cherry", removed);
        //    Assert.AreEqual("apple, banana", sll.ToString());
        //}

        //[TestMethod]
        //public void DLL_GetTest1()
        //{
        //    DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        //    dll.Add(1);//0
        //    dll.Add(2);//1
        //    dll.Add(3);//2
        //    dll.Add(4);//3

        //    int actual = dll.Get(1);

        //    Assert.AreEqual(2, actual);
        //}

        //[TestMethod]
        //public void DLL_GetTest2()
        //{
        //    DoubleLinkedList<string> sll = new DoubleLinkedList<string>();
        //    sll.Add("pen");
        //    sll.Add("pineapple");
        //    sll.Add("apple");
        //    sll.Add("pen");

        //    string actual = sll.Get(1);

        //    Assert.AreEqual("pineapple", actual);
        //}


        #endregion DoubleLinkedList Tests




    }
}
