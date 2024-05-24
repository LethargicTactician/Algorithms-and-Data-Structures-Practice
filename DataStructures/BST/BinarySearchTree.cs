using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        /*
        //add method

        //IN THE NODE CLASS -> if (myValue > val) , (myvalue < val), (myValue == val) && one side is null
        //if the child is null-> recursively add a new node -> ch == null Left = newNode -> left & right are children
        //else left.Add(val) -> samecondition for the right node, that's a lot of code*
        //its a repeaed process as you go thorugh the nodes
        //when values are equal -> increment the count & it doesnt get added to the treeand when u remove a duplicate node, it decreases that count
        //remove(t val) if root != null & contains
        //root= root.Remove(val) -> Count --;
        //if(val < myVal) -> Left = Left.Remove(val)
        //else -> if(val > myVal) -> Right = Right.remove(val)
        //else if(right is null) -> return Left
        //else if(left is null) -> return right
        //Data = FindMax(Left)
        //left = Left.Remove(Data)
        //return this
        */

        private BinaryTreeNode<T> Root { get; set; }
        public int Count { get; set; }
        StringBuilder sb = new StringBuilder();

        public void Add(T val)
        {
            //root null??? add it TOO EZ
            if (Root == null)
            {
                Root = new BinaryTreeNode<T>(val);
            }
            //else -> IN THE NODE CLASS you get the value by calling the root & compare them-> root.Add(val)
            else
            {
                Root.Add(val);
            }
            Count++;
        }

        public bool Contains(T val)
        {
            if(Root.Equals(null))
            {
                return false;
            }
            return Root.Contains(val);
           // return null;
        }

        public void Remove(T val)
        {
           

            if (Root != null)
            {
                Root.Remove(val);
            }
            Count--;


        }

        public int Height()
        {
            if(this == null)
            {
                return 0;
            }
            return Root.Height();
        }

        public void Clear()
        {
            if(Root != null)
            {
                Root.Clear();
                Root = null;
            } 
            Count = 0;

        }

        public T[] ToArray()
        {
             if(Root == null)
            {
                return new T[0];
            }
            T[] array = new T[Count];
            Root.ToArray(array, 0);

            return array;

        }

        public string InOrder()
        {

            if (Root != null)
            {
                sb.Append(Root.InOrder());
            }
           

            return sb.ToString().Substring(0, sb.ToString().ToArray().Length-1);
        }
        
        public string PreOrder()
        {

            if (Root != null)
            {
                sb.Append(Root.PreOrder());
            }


            return sb.ToString().Substring(0, sb.ToString().ToArray().Length - 1);
        }
        
        public string PostOrder()
        {

            if (Root != null)
            {
                sb.Append(Root.PostOrder());
            }


            return sb.ToString().Substring(0, sb.ToString().ToArray().Length - 1);
        }








    }
}
