using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// etertion to insert new element in linked list  =  travarse 
// in array  =  etration 

namespace explain_C_1
{



    public class MNode<T>
    {
         MNode<T> head;
        public MNode(T Data, MNode<T> next = null)
        {
            this.Data = Data;
            this.next = next;
        }

        public T Data { get; set; }
        public MNode<T> next { get; set; }


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
            // this is  iam not remerber it ; 
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

        public void _DeleteElement()
        {

        }
        public void _reverse()
        {
            
        }


    }


}