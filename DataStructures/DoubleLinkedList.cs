using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    //Imma be honest I just copy and pasted what I had for single linked list and made it a double

    public class DoubleLinkedList<T> where T : IComparable<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Count { get; set; }

        #region Basic add & insert
        public void Add(T index)
        {
            if (Head == null)
            {
                Node<T> node = new Node<T>();
                node.Data = index;
                Head = node;
            }
            else
            {
                Node<T> betterNode = new Node<T>();
                betterNode.Data = index;

                Node<T> temp = Head;
                while (temp.Pointer != null)
                {
                    temp = temp.Pointer;
                }

                temp.Pointer = betterNode;
                betterNode.PreviousNode = temp;

            }
            Count++;
        }

        public void Insert(T val, int index)
        {
            if (index < 0 || index > Count)
            {
                throw new IndexOutOfRangeException("Index is out of Bounds :(");
            }
            // If the index is 0 add a new node at the beginning of the list
            if (index == 0)
            {
                Node<T> node = new Node<T>();
                node.Data = val;
                node.Pointer = Head;
                //this time I try to keep track of the previous node as you insert one in an empty list
                if(Head != null)
                {
                    Head.PreviousNode = node;
                }
            }
            else
            {
                Node<T> temp = Head;
                for (int i = 0; i < index; i++)
                {
                    temp = temp.Pointer;

                }

                //this part is so weird 
                //so basicallywhen inserting a node I would need to keep up with the pointer of the new value while having the new one that's being inserted
                Node<T> bwtterNode = new Node<T>();
                bwtterNode.Data = val;
                bwtterNode.Pointer = temp;
                bwtterNode.PreviousNode = temp.PreviousNode;
                temp.PreviousNode = bwtterNode;

                //update the PreviousNode's pointer of temp to point to betterNode
                // and it should be inserting before temp
                if (bwtterNode.PreviousNode != null)
                {
                    bwtterNode.PreviousNode.Pointer = bwtterNode;
                }
            }
            Count++;

        }

        #endregion Basic add & insert


        //Imma be honest I got A LOT of help from the AI on this one because I couldnt figure it out on my own
        public T Get(int index)
        {
            //first we got the exception handled
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            //weird part #1 - count is divided by 2 to determine if the index is closer to the beginning or the end of the of the list (so a more effective search Im assuming?)
            if (index < Count / 2)
            {
                //then just like in single linked list we can search from the beignning of the list 
                Node<T> currentNode = Head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Pointer;
                }

                return currentNode.Data;
            }
            else
            {
                //search from the end / second half of the divided list starting from the trash
                Node<T> node = Tail;
                //return if its found during this iteration
                for(int i = Count -1; i > index; i--)
                {
                    node = node.PreviousNode;
                }
                return node.Data;
            }

        }


        #region Remove

        public T Remove()
        {

            if (Head == null)
            {
                throw new InvalidOperationException("Linked list is empty");
            }

            T removedNode = Head.Data;
            if(Count == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Head = Head.Pointer;
                Head.PreviousNode = null;
            }
            Count--;
            //return it (maybe console.write?) then delete it 
            return removedNode;


        }

        // this one was a bit more complicated than I thought too but then I realized that I only had to work a bit more with the pointers and previous nodes
        public T RemoveAt(int index)
        {
            if (index < 0 || index > Count)
            {
                throw new IndexOutOfRangeException("Index is out of Bounds :(");
            }

            //removing from the beginning for testing
            if(index == 0)
            {
                T removedNode = Head.Data;
                Head = Head.Pointer;
                if(Head != null)
                {
                    Head.PreviousNode = null;
                }
                Count--;
                return removedNode;
            }

            //removing from other places in the list
            Node<T> currentNode = Head;
            for(int i = 0; i< index; i++)
            {
                currentNode = currentNode.Pointer;
            }

            //remove selected node
            currentNode.PreviousNode.Pointer = currentNode.Pointer;
            if(currentNode.Pointer != null)
            {
                currentNode.Pointer.PreviousNode = currentNode.PreviousNode;

            }
            Count--;
            return currentNode.Data;

            
        }

        public T RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Cannot remove from an empty list.");
            }

            T trash; //item to remove

            if (Count == 1)
            {
                trash = Head.Data;
                Head = null;
                Tail = null;
            }
            else
            {
                trash = Tail.Data;
                Tail = Tail.PreviousNode;
                //this officially makes the previous node the new tail :)
                Tail.Pointer = null;
            }

            Count--;
            return trash;
        }

        //I THINK this is the same as for double linked list? its not asking for specifics so imma leav it as it is
        public void Clear()
        {
            //delete/reset the whole thing
            Head = null;
            Count = 0;

        }
        #endregion Remove

        override
        public string ToString()
        {
            if(Count == 0)
            {
                return "";
            }
            StringBuilder sb = new StringBuilder();


            sb.Append(Head.Data + ", ");
            Node<T> temp = Head;
            while (temp.Pointer != null)
            {
                temp = temp.Pointer;
                sb.Append(temp.Data + ", ");
            }
            sb = sb.Remove(sb.Length - 2, 2);

            return sb.ToString();

        }

        public int Search(T val)
        {

            Node<T> node = Head;
            int index = 0;
            while (node != null)
            {
                if (node.Data.Equals(val))
                {
                    return index;
                }

                node = node.Pointer;
                index++;

            }

            //if condition above isnt met then return -1
            return -1;


        }





    }
}
