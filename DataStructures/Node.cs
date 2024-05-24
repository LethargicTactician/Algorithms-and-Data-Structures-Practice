using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Node<T>
    {
        //prop
        //propfull

        public T Data { get; set; } 

        public Node<T> Pointer { get; set; }

        public Node<T> PreviousNode { get; set; }

        //public Node<T> Root { get; set; }

        //public Node(T data)
        //{
        //    Data = data;
        //    Ponter = null;
        //    Prev = null;
            
        //}



    }
}
