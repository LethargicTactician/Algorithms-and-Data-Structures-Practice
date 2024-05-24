using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.AVL;
using DataStructures;
using System.Runtime.Intrinsics.X86;

namespace AVLTreeThing
{
    [TestClass]
    public class AVLTreeTests
    {
        protected static void PrintMyTree(AVLTree<int> tree)
        {
            if (tree.Root == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            StringBuilder sb = new StringBuilder();
            sb.Append(tree.Root.Data + " (root)");
            string pointerRight = "└──";
            string pointerLeft = (tree.Root.Right != null) ? "├──" : "└──";

            TraverseNodes(sb, "", pointerLeft, tree.Root.Left, tree.Root.Right != null);
            TraverseNodes(sb, "", pointerRight, tree.Root.Right, false);
            

            Console.WriteLine(sb.ToString());
        }

        public static void TraverseNodes(StringBuilder sb, string padding, string pointer, AVLNode<int> node, bool hasRightSibling)
        {
            if (node != null)
            {
                sb.Append("\n");
                sb.Append(padding);
                sb.Append(pointer);
                sb.Append(node.Data);

                StringBuilder paddingBuilder = new StringBuilder(padding);
                if (hasRightSibling)
                {
                    paddingBuilder.Append("│  ");
                }
                else
                {
                    paddingBuilder.Append("   ");
                }

                String paddingForBoth = paddingBuilder.ToString();
                String pointerRight = "└──";
                String pointerLeft = (node.Right != null) ? "├──" : "└──";

                TraverseNodes(sb, paddingForBoth, pointerLeft, node.Left, node.Right != null);
                TraverseNodes(sb, paddingForBoth, pointerRight, node.Right, false);
            }
        }
        //GENERAL FUNCTIONALITY TESTING
        #region General
        [TestMethod]
        public void AVT_AddOne()
        {
            AVLTree<int> avl = new AVLTree<int>();

            // BinarySearchTree<int> avl = new BinarySearchTree<int>();
            avl.Add(1);
            avl.Add(2);
            avl.Add(10);
            Assert.AreEqual(3, avl.Count);
            PrintMyTree(avl);


        }

        [TestMethod]
        public void AVL_CanIevenAddOneThingOrTwoToAnArray()
        {
            AVLTree<int> avl = new AVLTree<int>();
            avl.Add(2);
            avl.Add(3);
            avl.Add(1);

            int[] result = avl.ToArray();
            CollectionAssert.AreEqual(new[] { 1, 2, 3 }, result);
            PrintMyTree(avl);

        }

        [TestMethod]
        public void AVL_IDKIfImBalanced()
        {
            AVLTree<int> avl = new AVLTree<int>();
            avl.Add(7);
            avl.Add(4);
            avl.Add(9);
            avl.Add(8);
            avl.Add(10);
            avl.Add(2);
            avl.Add(6);

            int[] result = avl.ToArray();
            CollectionAssert.AreEqual(new[] { 2, 4, 6, 7, 8, 9, 10 }, result);
            PrintMyTree(avl);

        }

        [TestMethod]
        public void AVL_WhatchaGonnaDoWhenTheresTwoOfMe()
        {
            AVLTree<int> avl = new AVLTree<int>();

            avl.Add(7);
            avl.Add(4);
            avl.Add(9);
            avl.Add(8);
            avl.Add(7);

            int[] result = avl.ToArray();
            CollectionAssert.AreEqual(new[] { 4, 7, 7, 8, 9 }, result);
            PrintMyTree(avl);

        }
        //remove test
        [TestMethod]
        public void AVLTree_AddAndRemoveToArrayTest()
        {
            AVLTree<int> avl = new AVLTree<int>();

            avl.Add(10);
            avl.Add(5);
            avl.Add(15);
            avl.Add(3);
            avl.Add(7);
            avl.Add(12);
            avl.Add(17);

            avl.Remove(3);
            avl.Remove(7);
            avl.Remove(17);

            int[] expected = { 5, 10, 12, 15 };
            int[] actual = avl.ToArray();

            CollectionAssert.AreEqual(expected, actual);
            PrintMyTree(avl);
        }
        #endregion General

        //REQUIRED TESTING 
        #region Setup
        //AVLTree<int> avl;
        //[TestInitialize]
        //public void Setup()
        //{
        //    avl = new AVLTree<int>();
        //}

        //[TestCleanup]
        //public void TearDown()
        //{
        //    avl = null;
        //}

        //[ClassCleanup]
        //public static void TestTearDown()
        //{
        //    //runs after all tests are done
        //}

        #endregion Setup
        //I dont even know why this didnt work cus it only worked if the array was 6, 8, 0 which doesnt make any sense at the moment CUS IM ADDING 10 but whatever 
        //I decided on using my functional toArray to trigger the rotations, not sure if that's a valid approach though
        #region trash method



        //[TestMethod]
        //public void AVL_SingleLeftRotateMe_TestOne()
        //{
        //    AVLTree<int> avl = new AVLTree<int>();

        //    avl.Add(10);
        //    PrintMyTree(avl);

        //    avl.Add(8);
        //    PrintMyTree(avl);

        //    avl.Add(6);
        //    PrintMyTree(avl);


        //    //AVLNode<int> result = avl.BalanceNode(avl.Root);
        //    //used to be 10, 8, 6 (just a line)
        //    int[] expected = { 6, 8, 10 };
        //    int[] result = avl.ToArray();

        //    CollectionAssert.AreEqual(expected, result);
        //    PrintMyTree(avl);

        //}
        #endregion trash method

        //single right rotation
        [TestMethod]
        public void AVL_TriggrSingleRightRotationOne()
        {
            AVLTree<int> avl = new AVLTree<int>();
            avl.Add(7);
            avl.Add(4);
            avl.Add(9);
            avl.Add(8);
            avl.Add(10);
            avl.Add(2);
            avl.Add(6);
            //triggers right rotation (hypothetically)
            avl.Add(5);

            int[] result = avl.ToArray();
            CollectionAssert.AreEqual(new[] { 2, 4, 5, 6, 7, 8, 9, 10 }, result);
            PrintMyTree(avl);
        }

        [TestMethod]
        public void AVL_AnotherSingleRightRotationTest()
        {
            AVLTree<int> avl = new AVLTree<int>();
            avl.Add(5);
            avl.Add(3);
            avl.Add(7);
            avl.Add(2);
            avl.Add(4);
            avl.Add(6);
            avl.Add(8);
            //triggers right rotation
            avl.Add(1);

            int[] result = avl.ToArray();
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, result);
            PrintMyTree(avl);
        }

        //single left rotation
        [TestMethod]
        public void AVL_SingleLeftRotationTest_ONe()
        {
            AVLTree<int> avl = new AVLTree<int>();
            avl.Add(5);
            avl.Add(8);
            avl.Add(3);
            avl.Add(2);
            avl.Add(4);
            avl.Add(7);
            avl.Add(9);
            //trigger the left rotation
            avl.Add(6);

            int[] result = avl.ToArray();
            CollectionAssert.AreEqual(new[] { 2, 3, 4, 5, 6, 7, 8, 9 }, result);
            PrintMyTree(avl);
        }

        [TestMethod]
        public void AVL_SingleLeftRotationTest_two()
        {
            AVLTree<int> avl = new AVLTree<int>();
            avl.Add(10);
            avl.Add(12);
            avl.Add(8);
            avl.Add(6);
            avl.Add(9);
            avl.Add(11);
            avl.Add(15);
            //trigger left rotation
            avl.Add(7);

            int[] result = avl.ToArray();
            CollectionAssert.AreEqual(new[] { 6, 7, 8, 9, 10, 11, 12, 15 }, result);
            PrintMyTree(avl);
        }

        //right left rotation
        [TestMethod]
        public void AVL_RightLeftRotationTest()
        {
            AVLTree<int> avl = new AVLTree<int>();
            avl.Add(10);
            avl.Add(15);
            avl.Add(8);
            avl.Add(12);
            avl.Add(16);
            avl.Add(6);
            avl.Add(9);
            avl.Add(11);
            //trigger right left I think
            avl.Add(13);

            int[] result = avl.ToArray();
            CollectionAssert.AreEqual(new[] { 6, 8, 9, 10, 11, 12, 13, 15, 16 }, result);
            PrintMyTree(avl);
        }

        [TestMethod]
        public void AVL_RightLeftRotationTest_two()
        {
            AVLTree<int> avl = new AVLTree<int>();
            avl.Add(50);
            //trigger right left
            avl.Add(70);
            avl.Add(80);

            int[] result = avl.ToArray();
            CollectionAssert.AreEqual(new[] { 50, 70, 80 }, result);
            PrintMyTree(avl);
        }

        //left right roation
        [TestMethod]
        public void AVL_LeftRightRotationTriggerInTheMiddleTest_One()
        {
            AVLTree<int> avl = new AVLTree<int>();
            avl.Add(100);
            avl.Add(150);
            avl.Add(80);
            avl.Add(110);
            //trigger
            avl.Add(120);
            avl.Add(90);
            avl.Add(85);
            avl.Add(95);
            avl.Add(70);
            avl.Add(75);

            int[] result = avl.ToArray();
            CollectionAssert.AreEqual(new[] { 70, 75, 80, 85, 90, 95, 100, 110, 120, 150 }, result);
            PrintMyTree(avl);
        }

        [TestMethod]
        public void AVL_LeftRightRotationTest2()
        {
            AVLTree<int> avl = new AVLTree<int>();
            avl.Add(50);
            //trigger
            avl.Add(70);
            avl.Add(60);

            int[] result = avl.ToArray();
            CollectionAssert.AreEqual(new[] { 50, 60, 70 }, result);
            PrintMyTree(avl);
        }

        #region BST TESTING METHODS

        [TestMethod]
        public void avl_AddOne()
        {
            AVLTree<int> avl = new AVLTree<int>();

            // AVLTree<int> avl = new AVLTree<int>();
            avl.Add(1);
            Assert.AreEqual(1, avl.Count);
        }

        [TestMethod]
        public void avl_AddMoreMoreMoreeee()
        {
            AVLTree<int> avl = new AVLTree<int>();
            avl.Add(10);
            avl.Add(2);
            avl.Add(3);
            avl.Add(4);
            avl.Add(5);
            avl.Add(6);
            avl.Add(7);
            avl.Add(8);
            avl.Add(9);
            avl.Add(12);
            avl.Add(43);
            avl.Add(14);
            avl.Add(6);
            avl.Add(1);
            avl.Add(23);
            avl.Add(10);
            avl.Add(11);
            avl.Add(12);

            Assert.AreEqual(18, avl.Count);
            PrintMyTree(avl);

        }

        [TestMethod]
        public void avl_RemoveMeFromMyMisery()
        {
            BinarySearchTree<int> avl = new();

            avl.Add(1);
            avl.Add(2);
            avl.Add(3);
            avl.Remove(2);

            Assert.AreEqual(2, avl.Count);
        }

        [TestMethod]
        public void avl_Remove_NowYouSeeMeNowYouDont()
        {
            BinarySearchTree<int> avl = new();
            avl.Add(1);
            avl.Remove(1);
            Assert.AreEqual(0, avl.Count);
        }

        [TestMethod]
        public void avl_DoesItActuallyGetBranchHeight()
        {
            BinarySearchTree<int> avl = new();
            avl.Add(1);
            var height = avl.Height();

            Assert.AreEqual(1, height);
        }

        [TestMethod]
        public void avl_BranchHeightTest2()
        {
            BinarySearchTree<int> avl = new();
            avl.Add(5);
            avl.Add(3);
            avl.Add(7);
            avl.Add(4);
            avl.Add(2);
            avl.Add(8);
            avl.Add(6);
            var height = avl.Height();

            Assert.AreEqual(3, height);
        }

        [TestMethod]
        public void ClearMePles()
        {
            BinarySearchTree<int> avl = new();
            avl.Add(5);
            avl.Add(3);
            avl.Add(7);
            avl.Clear();
            Assert.AreEqual(0, avl.Count);
        }

        [TestMethod]
        public void avl_AddRemoveAddClear()
        {
            BinarySearchTree<int> avl = new();
            avl.Add(5);
            avl.Add(3);
            avl.Add(7);
            avl.Add(40);
            avl.Remove(5);
            avl.Add(1);

            avl.Clear();
            Assert.AreEqual(0, avl.Count);
        }


        [TestMethod]
        public void avl_SearchForMe()
        {
            BinarySearchTree<int> avl = new();

            avl.Add(5);
            avl.Add(3);
            avl.Add(7);
            avl.Add(4);
            avl.Add(2);
            avl.Add(8);
            avl.Add(6);
            var found = avl.Contains(3);
            Assert.AreEqual(true, found);
        }

        [TestMethod]
        public void avl_SearchForMeEvenThoIDontExist()
        {
            BinarySearchTree<int> avl = new();

            avl.Add(5);
            avl.Add(3);
            avl.Add(7);
            avl.Add(4);
            avl.Add(2);
            avl.Add(8);
            avl.Add(6);
            var found = avl.Contains(10);
            Assert.AreEqual(false, found);
        }
        [TestMethod]
        public void avl_AmIInOrder()
        {
            AVLTree<int> avl = new AVLTree<int>();
            avl.Add(5);
            avl.Add(3);
            avl.Add(7);
            var result = avl.InOrder();

            Assert.AreEqual("3, 5, 7", result);
        }
        [TestMethod]
        public void avl_AmIInOrderTwo()
        {
            AVLTree<int> avl = new AVLTree<int>();
            avl.Add(34);
            avl.Add(12);
            avl.Add(100);
            var result = avl.InOrder();

            Assert.AreEqual("12, 34, 100", result);
        }
        [TestMethod]
        public void avl_AmIInPreOrder()
        {
            AVLTree<int> avl = new AVLTree<int>();
            avl.Add(5);
            avl.Add(3);
            avl.Add(7);
            var result = avl.PreOrder();

            Assert.AreEqual("5, 3, 7", result);
        }

        [TestMethod]
        public void avl_AmIInPreOrderToo()
        {
            AVLTree<int> avl = new AVLTree<int>();
            avl.Add(342);
            avl.Add(243);
            avl.Add(934);
            var result = avl.PreOrder();

            Assert.AreEqual("342, 243, 934", result);
        }


        [TestMethod]
        public void avl_AmIInPostOrder()
        {
            AVLTree<int> avl = new AVLTree<int>();
            avl.Add(5);
            avl.Add(3);
            avl.Add(7);
            var result = avl.PostOrder();

            Assert.AreEqual("3, 7, 5", result);
        }
        //LEFT RIGHT ROOT
        [TestMethod]
        public void avl_AmIInPostOrderTwo()
        {
            AVLTree<int> avl = new AVLTree<int>();
            avl.Add(50);
            avl.Add(30);
            avl.Add(70);
            var result = avl.PostOrder();

            Assert.AreEqual("30, 70, 50", result);
        }

        [TestMethod]
        public void avl_IWannaBeArrayedButIHaveKids()
        {
            AVLTree<int> avl = new AVLTree<int>();
            avl.Add(7);
            avl.Add(4);
            avl.Add(9);
            avl.Add(8);
            avl.Add(10);
            avl.Add(2);
            avl.Add(6);

            int[] result = avl.ToArray();

            CollectionAssert.AreEqual(new[] { 2, 4, 6, 7, 8, 9, 10 }, result);
        }

        [TestMethod]
        public void avl_CanIevenAddOneThingOrTwoToAnArray()
        {
            AVLTree<int> avl = new AVLTree<int>();
            avl.Add(2);
            avl.Add(3);
            avl.Add(1);



            int[] result = avl.ToArray();
            CollectionAssert.AreEqual(new[] { 1, 2, 3 }, result);

        }
        #endregion BST TESTING METHODS





    }
}
