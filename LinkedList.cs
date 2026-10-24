using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// etertion to insert new element in linked list  =  travarse 
// in array  =  etration 

namespace explain_C_
{



    public class MNode<T>
    {
        MNode<T> head;
        public void AddFrist(T data)
        {
            this.head = new MNode<T>(data, this.head);
        }
        public void travers()
        {
            var temp = this.head;
            while (temp != null)
            {
                System.Console.WriteLine(temp.Data);
                temp = temp.next;
            }
        }

        public MNode(T Data, MNode<T> next = null)
        {
            this.Data = Data;
            this.next = next;
        }
        public T Data { get; set; }
        public MNode<T> next { get; set; }
        public int size()
        {
            int counter = 0;
            var temp = this.head;
            while (temp != null)
            {
                counter++;
                temp = temp.next;
            }
            return counter;
        }
        public T _GetFrist()
        {
            return this.head.Data;
        }
        public MNode<T> _GetLast()
        {
            if (this.head == null) return null;
            var temp = this.head;
            while (temp != null)
            {
                if (temp.next == null)
                {
                    return temp;
                }
                temp = temp.next;
            }
            return temp;
        }
        public void _Clear()
        {
            this.head = null;
        }
        public void Add(T Data)
        {
            var _Lastnode = _GetLast();
            if (_Lastnode == null)
            {
                this.head = new MNode<T>(Data);
            }
            else
            {
                _Lastnode.next = new MNode<T>(Data);
            }
        }


    }


}