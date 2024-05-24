using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class BinaryTreeNode<T> where T : IComparable<T>
    {

        /*
        //Treaverse tree to find node 
        //go left if smaller
        //go right if larger
        //once we are on the node 
        //check if we have 0|1 child
        //if 1, swap parent with that child
        //if 0, return null
        //if 2 children 
        //find largest node in left subtree -> Data = FindMaz(Left)
        //copy val of that node into Data
        //delete found node in Left Subtree
        //return



        //stirng InOrder()
        //bst
        //if root != null ? root.InOrder() : "";


        //node
        //left subtree
        //right subtree
        //self
        //return left + root + right;





*/

        public BinaryTreeNode(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }

        //decided to declare this outside of the method since I'm using it a lot lol
        StringBuilder sb = new StringBuilder();

        //BinarySearchTree<T> root;

        //public BinaryTreeNode<T> Root { get; set; }

        public void Add(T val)
        {
            //make a new node first
            BinaryTreeNode<T> node = new BinaryTreeNode<T>(val);
            // BinaryTreeNode<T> newNode;
            //if the new value is less than the value of the current node, go to the left subtree
            if (val.CompareTo(Data) < 0)
            {
                if (Left == null)
                {
                    Left = node;
                }
                else
                {
                    Left.Add(val);
                }

            }
            //if the left subtree is empty, attach the new node there
            // else -> continue searching in the left subtree
            //do the same for the right subtree
            if(val.CompareTo(Data) >= 0)
            {
                if(Right == null)
                {
                    Right = node;
                }
                else
                {
                    Right.Add(val);
                }
                
            } 
            // if the new value is equal to the value of the current node
            // do nothing (the node is already in the tree) so just return;

        }

        //kind of like search??
        //withthat in mind I think it will just look through each node and see if  the values are equal -> if they are then return it
        public bool Contains(T val)
        {
            //check if the current node is null
            if (Data == null)
            {
                return false;
            }
            //go thorough the tree and compare the value of the nodes with the value you want to look for
            //it's already taking care of the comparing part so i just have to make sure it goes throught the tree correctly
            //not entirely sure if this is gonna work the way i want it to
            int compare = val.CompareTo(Data);
            //if the node we're at roght now is equal to the value -> starting from the root _> then we will return true -> value found easyyy
            //if not then go to the left child
            if(compare == 0)
            {
                return true;
            }
            //if it's greater then go to the left again and look for the value there
            else if(compare < 0 && Left != null)
            {
                return Left.Contains(val);
            }
            //same with the right just in case
            else if(compare > 0 && Right != null)
            {
                return Right.Contains(val);
            }
            //if it reaches the end with no result, return false
            else
            {
                return false;
            }
        }

        public void Remove(T val)
        {
            //it keeps comparing through the nodes
            //so one of the if statements could be if the node it's currently looking at is < or > than the one you want to delete
            //that will determine whether you got left or right -> 
            //Left has the number that's smaller than the root & right has the number that's large than the root node
            //and then when we do find the matching node, we check if it has chidlren 
            //so if one, that one will become the new parent
            // if two the one to the left becomes the parent and the one to the right becomes the child

            if (Data.CompareTo(val) == 0) //if the value is found
            {
                //if no kids
                if (Left == null && Right == null)
                {
                    Data = default(T);
                }
                else if (Left == null) 
                {
                    //only roght child exists:
                    //copy thedata of the current parent and the right child
                    // make the right child the new parent
                    Data = Right.Data;
                    Left = Right.Left;
                    Right = Right.Right;
                }
                //smae for the othr side -> only left child exists
                else if (Right == null) 
                {
                    Data = Left.Data;
                    Right = Left.Right;
                    Left = Left.Left;
                }
                //it has two kids
                else
                {
                    BinaryTreeNode<T> nodeThatsTakingOver = Right;
                    while (nodeThatsTakingOver.Left != null)
                    {
                        nodeThatsTakingOver = nodeThatsTakingOver.Left;
                    }

                    Data = nodeThatsTakingOver.Data;
                    Right.Remove(nodeThatsTakingOver.Data);
                }
            }
            ///value not found
            else if (Data.CompareTo(val) > 0 && Left != null)
            {
                Left.Remove(val);

            }
            else if( Data.CompareTo(val) < 0 && Right != null) //val is less than the current node
            {
                Right.Remove(val);
            }
        }

        public void Clear()
        {
            //I THOUGHT THIS WAS GONNA EB THE EASIEST ONE AHHHHHHHHHHHH
            //OK SO
            //research(& our friend the AI) siad to get rid og the kids first 
            if(Left != null)
            {
                Left.Clear();
                Left = null;
            }
            if(Right != null)
            {
                Right.Clear();
                Right = null;
            }
            //have to use default cus data doesnt like getting set to null??
            Data = default(T);

            //root check on BST

            //apparently nvm I njust need to set the root to null so this method is useless XD
            //Imma leaveit anyways for testing  
            

        }

        public int Height()
        {
            /*
            //BST
            //int Height()
            //return Root != null ? root.Height(): -1;
            //Node
            //int Height();
            //if(left null && rigth null)
            //return 1;
            //leftHeight = 0
            //rightHeight =0;
            //have left?
            //leftHeight = left.Height();
            //haveright?
            //right height  = Right.Height();
            //return 1 + Math.Max(left, right)

            //go through the tree until you find a node where both the left and right values are null
            //to do that, you might want to start by doing a compatison on whether or not out current node has children
            //so maybe have a new variable to keep track of that? (the count)
            */

            if(this == null)
            {
                //this is as in- there's no root/ parent || if the node is null
                return 0;
            }
            else if (Left == null && Right == null)
            {
                //no children? height is one
                return 1;
            }
            else
            {
                //calculating the height of the right and left subtrees
                int leftCount = Left.Height();
                int rightCount = Right.Height();

                //then return the actual height of the node and add +1 for the parent
                return 1 + Math.Max(leftCount, rightCount);

                //not sure if this will work
            }
           /*
            //wasnt sure if this part was going to work but was told by the coach that recursion might be a good way to go for this part ^^^
            //if(Right != null)
            //{

            //    rightCount = Right.Height();

            //}
            //if (Left != null)
            //{
            //    leftCount = Left.Height();
            //}
           */

           
        }


        public int ToArray(T[] array, int index)
        {
            if (Left != null)
            {

                index = Left.ToArray(array, index);
            }

            array[index++] = Data;

            if (Right != null)
            {
               index = Right.ToArray(array, index); 
            }

            return index;


        }

        //so with research I saw that you use traversals to make this work?
        //I'm assuming the ones in this class are supposed to be the traversals 
        //and on the other class is the rest of the logic since the root is being 
        //tracked from over there so I'm going to try it 
        //even though I doubt it will work properly- plot twist: it didnt)
        public string InOrder()
        {
            var rightData = Right.Data;
            var leftData = Left.Data;

            if(Left == null && Right == null)
            {
                return Data.ToString();
            }

            if(Left != null)
            {
          

                sb.Append(leftData.ToString() + ", ");
            }
     
            sb.Append(Data.ToString() + ", ");
            
            if(Right != null)
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
    }
}
