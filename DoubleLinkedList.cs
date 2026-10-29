using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace explain_C_
{
    public class MMNode<T>
    {
        public T Data { get; set; }

        public MMNode<T> prev { get; set; }
        public MMNode<T> Next{get; set;}
        MMNode<T> Head;
        public MMNode(T Data ,MMNode<T> Next)
        {
            this.Data = Data;
            this.Next = Next ;
        }


    }
    public class DoubleLinkedList<T>
    {
        public void _AddFrist(T Data)
        {
            
        }
    }
}