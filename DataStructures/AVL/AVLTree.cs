using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.AVL
{
    public class AVLTree<T> where T : IComparable<T>
    {
        public AVLNode<T> Root { get; set; }
        public int Count { get; set; }
        StringBuilder sb = new StringBuilder();

        #region BST THINGIES

        //modfy to AVL?
        public void Add(T val)
        {
            //root null??? add it TOO EZ
            if (Root == null)
            {
                Root = new AVLNode<T>(val);
            }
            //else -> IN THE NODE CLASS you get the value by calling the root & compare them-> root.Add(val)
            //get tje balance
            else
            {
                Root.Add(val);
                Root = BalanceNode(Root);
            }
            Count++;
        }

        public bool Contains(T val)
        {
            if (Root.Equals(null))
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
                Root = BalanceNode(Root);
            }
            Count--;

        }

        public int Height()
        {
            if (Root == null)
            {
                return 0;
            }
            return Root.Height(Root);
        }

        public void Clear()
        {
            if (Root != null)
            {
                Root.Clear();
                Root = null;
            }
            Count = 0;

        }

        //modify to AVL
        public T[] ToArray()
        {
            int index = 0;
            int level = Height();
            if (Root == null)
            {
                return new T[0];
            }
            T[] array = new T[Count];
            Root.ToArray(array, index, level);

            return array;

        }

        public string InOrder()
        {
            if (Root != null)
            {
                sb.Append(Root.InOrder());
            }
            return sb.ToString().Substring(0, sb.ToString().ToArray().Length - 1);
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
        #endregion BST THINGIES

        //public void SingleRightRotation()
        //{
        //    if (Root == null)
        //    {

        //    }
        //    else
        //    {
        //        Root.SingleRightRotation(Root);
        //    }
        //}


        public AVLNode<T> BalanceNode(AVLNode<T> node)
        {
            //returns the methods depending on the case?
            //so like if this happens return singleRightRotation(node, height, ....);
            int balanceFactor = node.BalanceFactor(node);
            if (balanceFactor== 1 || balanceFactor==-1||balanceFactor == 0 )
            {
                return node;
            }
            else if(balanceFactor == 2)
            {
                
               node = BalanceNode(node.Left);
                if (node.BalanceFactor(node) ==-1)
                {
                    return node.LeftRightRotation(node);

                }
                return node.SingleRightRotation(node);

            } else if (balanceFactor == -2)
            {
                node = BalanceNode(node.Right);
                if (node.BalanceFactor(node)== 1)
                {
                    return node.RightLeftRotation(node);

                }
                return node.SingleLeftRotation(node);
            }

            return node;

        }
    }
}
