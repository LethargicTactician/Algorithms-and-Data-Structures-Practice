using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace DataStructures.AVL
{
    public class AVLNode<T> where T : IComparable<T>
    {

        public AVLNode(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public AVLNode<T> Left { get; set; }
        public AVLNode<T> Right { get; set; }

        //decided to declare this outside of the method since I'm using it a lot lol
        StringBuilder sb = new StringBuilder();

        #region BST METHODS THING
        public AVLNode<T> Add(T val)
        {
            AVLNode<T> node = new AVLNode<T>(val);

            if (val.CompareTo(Data) < 0)
            {
                if (Left == null)
                {
                    Left = node;
                    
                }
                else
                {
                    Left.Add(val);
                    BalanceFactor(node);
                }
            }

            if (val.CompareTo(Data) >= 0)
            {
                if (Right == null)
                {
                    Right = node;
                }
                else
                {
                    Right.Add(val);
                    BalanceFactor(node);
                }

            }
            //return BalanceFactor(node);
            return this;

        }

        public bool Contains(T val)
        {
            if (Data == null)
            {
                return false;
            }

            int compare = val.CompareTo(Data);
            if (compare == 0)
            {
                return true;
            }
            else if (compare < 0 && Left != null)
            {
                return Left.Contains(val);
            }
            else if (compare > 0 && Right != null)
            {
                return Right.Contains(val);
            }
            else
            {
                return false;
            }
        }

        public AVLNode<T> Remove(T val)
        {
            if (Data.CompareTo(val) == 0)
            {
                if (Left == null && Right == null)
                {
                    return null;
                }
                else if (Left == null)
                {
                    return Right;
                }
                else if (Right == null)
                {
                    return Left;
                }
                else
                {
                    AVLNode<T> successor = Right;
                    while (successor.Left != null)
                    {
                        successor = successor.Left;
                    }

                    Data = successor.Data;
                    Right = Right.Remove(successor.Data);
                }
            }
            else if (Data.CompareTo(val) > 0 && Left != null)
            {
                Left = Left.Remove(val);
                //BalanceFactor(val);
            }
            else if (Data.CompareTo(val) < 0 && Right != null)
            {
                Right = Right.Remove(val);
            }

            return this;
        }


        public void Clear()
        {
            if (Left != null)
            {
                Left.Clear();
                Left = null;
            }
            if (Right != null)
            {
                Right.Clear();
                Right = null;
            }
            Data = default(T);



        }

        //I think the height method is okay? 
        //I does get the heigt of the tree but I dont see a reason to change what i already have exept now we're taking in a node
        public int Height(AVLNode<T> node)
        {
            int leftCount = 0;
            int rightCount = 0;

            if (node == null)
            {
                return -1;
            }
            
            else if (node.Left == null && node.Right == null)
            {
                return 1;
            }
            else
            {
                if (Left != null)
                {
                    leftCount = Left.Height(node.Left);
                }
                if(Right != null)
                {
                    rightCount = Right.Height(node.Right);
                }
                

                return 1 + Math.Max(leftCount, rightCount);

            }

            /* attempt
             *             int leftCount = 0;
            int rightCount = 0;

            if (this == null)
            {
                return 0;
            }
            else if(Left == null)
            {
                leftCount = Left.Height();
            }
            if (Right == null)
            {
                 rightCount = Right.Height();
            }
            return 1 + Math.Max(leftCount, rightCount);
             
             */


        }


        public int ToArray(T[] array, int index, int level)
        {
            //level = Height(Root);
            if (level == 1)
            {
                array[index++] = Data;
                return index;
            }
            else if(level > 1)
            {
                if (Left != null)
                {

                    index = Left.ToArray(array, index, level);
                }

                array[index++] = Data;

                if (Right != null)
                {
                    index = Right.ToArray(array, index, level);
                }
            }

            return index;


        }

        public string InOrder()
        {
            var rightData = Right.Data;
            var leftData = Left.Data;

            if (Left == null && Right == null)
            {
                return Data.ToString();
            }

            if (Left != null)
            {


                sb.Append(leftData.ToString() + ", ");
            }

            sb.Append(Data.ToString() + ", ");

            if (Right != null)
            {
                sb.Append(rightData.ToString() + ", ");
            }

            return sb.ToString().Trim();
        }
        public string PreOrder()
        {
            var rightData = Right.Data;
            var leftData = Left.Data;

            sb.Append(Data.ToString() + ", ");
            if (Left == null && Right == null)
            {
                return Data.ToString();
            }

            if (Left != null)
            {


                sb.Append(leftData.ToString() + ", ");
            }

            if (Right != null)
            {
                sb.Append(rightData.ToString() + ", ");
            }

            return sb.ToString().Trim();
        }
        public string PostOrder()
        {
            var rightData = Right.Data;
            var leftData = Left.Data;

            if (Left == null && Right == null)
            {
                return Data.ToString();
            }

            if (Left != null)
            {


                sb.Append(leftData.ToString() + ", ");
            }

            if (Right != null)
            {
                sb.Append(rightData.ToString() + ", ");
            }
            sb.Append(Data.ToString() + ", ");
            return sb.ToString().Trim();
        }

        #endregion BST METHODS THING

        public AVLNode<T> SingleLeftRotation(AVLNode<T> node)
        {
            //declare a pivot 
            AVLNode<T> pivot = node.Right;

            //rotation -> the right pivot will become the parent of the current node 
            //Left rotation: left child becomes the child of the the right node (the pivot is currently the parent)
            //after the rotation the parent should be the right node with the pivot being the left child and the left node is now the right child of the new parent (was the Right child before)
            //the condition of these is done with the balancer so in here it's just the rotation
            //ok i think I get it now(?)
            pivot.Left = node;

            //new height
            Height(node);
            Height(pivot);

            return pivot;
        }
        public AVLNode<T> SingleRightRotation(AVLNode<T> node)
        {
            //pivot
            AVLNode<T> pivot = node.Left;

            //left child of the pivot becomes the parent (what the pivotwa before)
            //pivot is now the right child & and right is now the left child
            
            node.Left = pivot.Right;
            pivot.Right = node;
            return pivot;
        }


        //same for all the other rotations -> no conditions yet (all in the balancer)
        //
        public AVLNode<T> RightLeftRotation(AVLNode<T> node)
        {
            //first a single right rotation
            node.Right = SingleRightRotation(node.Right);

            //then a single left rotation
            //node.Left = SingleLeftRotation(node.Left); -> I was gonna do it likethis but then I realized I can just 
            //return single Left roitation with the new node 
            return SingleLeftRotation(node);

        }

        //same here but now we do the opposite
        public AVLNode<T> LeftRightRotation(AVLNode<T> node)
        {
            node.Left = SingleLeftRotation(node.Left);

            return SingleRightRotation(node);
        }

        public int BalanceFactor(AVLNode<T> node)
        {
            int leftHeight = 0;
            int rightHeight = 0;
            //positive number -> left rotation
            //negative number -> right rotation
            //so in here you're just calculating that based on the height
            ////assuming it's correct
            if(node.Left != null)
            {
                leftHeight = Height(node.Left);
            
            }
            if(node.Right != null)
            {
                rightHeight = Height(node.Right);
            } 
           
            //int rightSideHeight = Height(node.Right);

            return leftHeight - rightHeight;
        }

        
        //public int getBalanceFactor(AVLNode<T> node)
        //{
        //    if (node == null)
        //    {
        //        return 0;
        //    }
            
        //    return Height(node.Left) - Height(node.Right);
        //}

    }

}
