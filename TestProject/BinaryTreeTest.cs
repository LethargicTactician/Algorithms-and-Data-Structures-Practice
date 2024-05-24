using DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    [TestClass]
    public class BinaryTreeTest
    {
        //[TestMethod]
        //public void BST_AddOne()
        //{
        //    BinarySearchTree<int> bst = new BinarySearchTree<int>();

        //    // BinarySearchTree<int> bst = new BinarySearchTree<int>();
        //    bst.Add(1);
        //    Assert.AreEqual(1, bst.Count);


        //}

        //[TestMethod]
        //public void BST_AddMoreMoreMoreeee()
        //{
        //    BinarySearchTree<int> bst = new BinarySearchTree<int>();
        //    bst.Add(1);
        //    bst.Add(2);
        //    bst.Add(3);
        //    bst.Add(4);
        //    bst.Add(5);
        //    bst.Add(6);
        //    bst.Add(7);
        //    bst.Add(8);
        //    bst.Add(9);
        //    bst.Add(12);
        //    bst.Add(43);
        //    bst.Add(14);
        //    bst.Add(6);
        //    bst.Add(1);
        //    bst.Add(23);
        //    bst.Add(10);
        //    bst.Add(11);
        //    bst.Add(12);

        //    Assert.AreEqual(18, bst.Count);

        //}

        //[TestMethod]
        //public void BST_RemoveMeFromMyMisery()
        //{
        //    BinarySearchTree<int> bst = new();

        //    bst.Add(1);
        //    bst.Add(2);
        //    bst.Add(3);
        //    bst.Remove(2);

        //    Assert.AreEqual(2, bst.Count);
        //}

        //[TestMethod]
        //public void BST_Remove_NowYouSeeMeNowYouDont()
        //{
        //    BinarySearchTree<int> bst = new();
        //    bst.Add(1);
        //    bst.Remove(1);
        //    Assert.AreEqual(0, bst.Count);
        //}

        //[TestMethod]
        //public void BST_DoesItActuallyGetBranchHeight()
        //{
        //    BinarySearchTree<int> bst = new();
        //    bst.Add(1); 
        //    var height = bst.Height();

        //    Assert.AreEqual(1, height);
        //}

        //[TestMethod]
        //public void BST_BranchHeightTest2()
        //{
        //    BinarySearchTree<int> bst = new();
        //    bst.Add(5);
        //    bst.Add(3);
        //    bst.Add(7);
        //    bst.Add(4);
        //    bst.Add(2);
        //    bst.Add(8);
        //    bst.Add(6);
        //    var height = bst.Height();

        //    Assert.AreEqual(3, height);
        //}

        //[TestMethod]
        //public void ClearMePles()
        //{
        //    BinarySearchTree<int> bst = new();
        //    bst.Add(5);
        //    bst.Add(3);
        //    bst.Add(7);
        //    bst.Clear();
        //    Assert.AreEqual(0, bst.Count);
        //}

        //[TestMethod]
        //public void BST_AddRemoveAddClear()
        //{
        //    BinarySearchTree<int> bst = new();
        //    bst.Add(5);
        //    bst.Add(3);
        //    bst.Add(7);
        //    bst.Add(40);
        //    bst.Remove(5);
        //    bst.Add(1);

        //    bst.Clear();
        //    Assert.AreEqual(0, bst.Count);
        //}


        //[TestMethod]
        //public void BST_SearchForMe()
        //{
        //    BinarySearchTree<int> bst = new();

        //    bst.Add(5);
        //    bst.Add(3);
        //    bst.Add(7);
        //    bst.Add(4);
        //    bst.Add(2);
        //    bst.Add(8);
        //    bst.Add(6);
        //    var found = bst.Contains(3);
        //    Assert.AreEqual(true, found);
        //}

        //[TestMethod]
        //public void BST_SearchForMeEvenThoIDontExist()
        //{
        //    BinarySearchTree<int> bst = new();

        //    bst.Add(5);
        //    bst.Add(3);
        //    bst.Add(7);
        //    bst.Add(4);
        //    bst.Add(2);
        //    bst.Add(8);
        //    bst.Add(6);
        //    var found = bst.Contains(10);
        //    Assert.AreEqual(false, found);
        //}
        //[TestMethod]
        //public void BST_AmIInOrder()
        //{
        //    BinarySearchTree<int> bst = new BinarySearchTree<int>();
        //    bst.Add(5);
        //    bst.Add(3);
        //    bst.Add(7);
        //    var result = bst.InOrder();

        //    Assert.AreEqual("3, 5, 7", result);
        //}
        //[TestMethod]
        //public void BST_AmIInOrderTwo()
        //{
        //    BinarySearchTree<int> bst = new BinarySearchTree<int>();
        //    bst.Add(34);
        //    bst.Add(12);
        //    bst.Add(100);
        //    var result = bst.InOrder();

        //    Assert.AreEqual("12, 34, 100", result);
        //}
        //[TestMethod]
        //public void BST_AmIInPreOrder()
        //{
        //    BinarySearchTree<int> bst = new BinarySearchTree<int>();
        //    bst.Add(5);
        //    bst.Add(3);
        //    bst.Add(7);
        //    var result = bst.PreOrder();

        //    Assert.AreEqual("5, 3, 7", result);
        //}
        
        //[TestMethod]
        //public void BST_AmIInPreOrderToo()
        //{
        //    BinarySearchTree<int> bst = new BinarySearchTree<int>();
        //    bst.Add(342);
        //    bst.Add(243);
        //    bst.Add(934);
        //    var result = bst.PreOrder();

        //    Assert.AreEqual("342, 243, 934", result);
        //}


        //[TestMethod]
        //public void BST_AmIInPostOrder()
        //{
        //    BinarySearchTree<int> bst = new BinarySearchTree<int>();
        //    bst.Add(5);
        //    bst.Add(3);
        //    bst.Add(7);
        //    var result = bst.PostOrder();

        //    Assert.AreEqual("3, 7, 5", result);
        //}
        ////LEFT RIGHT ROOT
        //[TestMethod]
        //public void BST_AmIInPostOrderTwo()
        //{
        //    BinarySearchTree<int> bst = new BinarySearchTree<int>();
        //    bst.Add(50);
        //    bst.Add(30);
        //    bst.Add(70);
        //    var result = bst.PostOrder();

        //    Assert.AreEqual("30, 70, 50", result);
        //}

        //[TestMethod]
        //public void BST_IWannaBeArrayedButIHaveKids()
        //{
        //    BinarySearchTree<int> bst = new BinarySearchTree<int>();
        //    bst.Add(7);
        //    bst.Add(4);
        //    bst.Add(9);
        //    bst.Add(8);
        //    bst.Add(10);
        //    bst.Add(2);
        //    bst.Add(6);

        //    int[] result = bst.ToArray();

        //    CollectionAssert.AreEqual(new[]{2, 4, 6, 7, 8, 9, 10}, result);
        //}

        //[TestMethod]
        //public void BST_CanIevenAddOneThingOrTwoToAnArray()
        //{
        //    BinarySearchTree<int> bst = new BinarySearchTree<int>();
        //    bst.Add(2);
        //    bst.Add(3);
        //    bst.Add(1);
            
            

        //    int[] result = bst.ToArray();
        //    CollectionAssert.AreEqual(new[] {1,2,3}, result);

        //}


    }
}
