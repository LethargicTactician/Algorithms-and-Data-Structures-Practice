using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class SingleLinkedList<T> where T : IComparable<T>
    {
        public Node<T> Head { get; set; }
        public int Count { get; set; }
        //make a method for each thing you have to have ex. one for Add, one for search, etc.
        //start with add
        //thats it
        //I lied
        //add the thing in the thing that things

        #region Basic add & insert
        public void Add(T index)
        {
            if (Head == null)
            {
                Node<T> node = new Node<T>();
                node.Data = index;
                Head = node;
            }
            else {
                Node<T> betterNode = new Node<T>();
                betterNode.Data = index;

                Node<T> temp = Head;
                while (temp.Pointer != null)
                {
                    temp = temp.Pointer;
                }

                temp.Pointer = betterNode;

            }
            Count++;
        }

        public void Insert(T val, int index)
        {
            if(index < 0 || index > Count)
            {
                throw new IndexOutOfRangeException("Index is out of Bounds :(");
            }
            // If the index is 0 add a new node at the beginning of the list
            if (index == 0)
            {
                Node<T> node = new Node<T>();
                node.Data = val;
                node.Pointer = Head;
                Head = node;
            }
            else
            {
                Node<T> temp = Head;
                for (int i = 0 ; i < index; i++)
                {
                    temp = temp.Pointer;

                }

                //create an new node with the val and set the pointer to the node next to it
                Node<T> bwtterNode = new Node<T>();
                bwtterNode.Data = val;
                bwtterNode.Pointer = temp.Pointer;

                //previous node now points to the new node(bwtternode)
                temp.Pointer = bwtterNode;
            }
            Count++;
            
        }

        #endregion Basic add & insert

        public T Get(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
            Node<T> currentNode = Head;
            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.Pointer;
            }

            return currentNode.Data;
        }


        #region Remove

        public T Remove()
        {
          //removing frist value of the element 
          //in case th list is empty(this is for one of the tests)
          if(Head == null )
            {
                throw new InvalidOperationException("Linked list is empty");
            }

            //so get the first val of the linked list and make the next node the head then decrease the cound of the list 
            T removedNode = Head.Data;
            Head = Head.Pointer;
            Count--;

            //return it (maybe console.write?) then delete it 
            return removedNode;


        }
        public T RemoveAt(int index)
        {
            //I think this one works a similar way as insert except instead of adding to the given indext, you remove it
            //so if there's existing data at the index that is entered, return the value then delete it
            //for some reason count needs to be involved(im guessing its for the index)
            //starting with the condition (which is similar to the insert one)
            if (index < 0 || index > Count)
            {
                throw new IndexOutOfRangeException("Index is out of Bounds :(");
            }

            //then remove the same way you  owuld remove an item but taking the index into consideration ( thisis where pointers from the video come to playI think)
            Node<T> currentNode = Head;//starting with the head
            Node<T> previousNode = null;// this is to keep track of the nodes as they change

            //setting up the index that we want to delete when we have items on the list
            for (int i = 0; i < index; i++)
            {
                previousNode = currentNode;
                currentNode = currentNode.Pointer;

            }

            //condition to delete/remove
            if(previousNode == null ) {
                Head = currentNode.Pointer;

            }
            else
            {
                previousNode.Pointer = currentNode.Pointer;
            }

            Count--;
            return currentNode.Data;
        }

        public T RemoveLast()
        {
            //Thought process: this one removes the tail I think
            //so just iterate through the list until the next one is null
            //when you find the null element, delete the previous one (which means its the last one) or get the pointer since thats the end of the list
            //starting on something for testing purposes and this is if the list is null since theres nothing to remove
            if (Count == 0)
            {
                throw new InvalidOperationException("Cannot remove from an empty list.");
            }
            T tail; //item to remove
            //this is an idea I was given by someone but basically if theres only one item in the given list then it will remove that item. since theres no tail to remove
            if (Count == 1)
            {
                tail = Head.Data;
                Head = null;
            }
            else
            {
               Node<T> temp = Head;
                //idk how Pointer.Pointer is a thing but it works
                while(temp.Pointer.Pointer != null)
                {
                    temp = temp.Pointer;
                }
                tail = temp.Pointer.Data;
                temp.Pointer = null;
            }
            Count--;
            return tail;


        }

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
            StringBuilder sb = new StringBuilder();

            sb.Append(Head.Data + ", ");
            Node<T> temp = Head;
            while (temp.Pointer != null)
            {
                temp = temp.Pointer;
                sb.Append(temp.Data + ", ");
            }
            sb = sb.Remove(sb.Length-2, 2);

            return sb.ToString();

        }

        public int Search(T val)
        {
          //Im assuming this is where the user has to enter a value to looks for?
          //so T val comes off as the data that we're trying to find
          //if this data doesnt exist then return -1
          //if it does exist, return the value

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
