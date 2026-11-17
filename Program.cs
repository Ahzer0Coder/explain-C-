using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using explain_C_;
using explain_C_1;
using him;

namespace pro
{

    class APP
    {


        static void Main()
        {
            // int []arr =  new int [1] ;
            // arr [0] = 15 ;
            // func1(arr) ;  //  O{1}
            // func2(arr) ; // O{n}
            // func3(arr) ; // O{n^2}
            // Complixity_.Ques();
            // BinarySearch.Binary(); 
            // _Arraylist aa1 = new _Arraylist(100);
            // aa1[0] = 20;
            // System.Console.WriteLine(aa1[0]);
            // aa1[1] = "Ahmed";
            // System.Console.WriteLine(aa1[1]);
            // aa1[0] = 5;
            // System.Console.WriteLine(aa1[0]);
            // var node2 = new MNode<object>(2);
            // var node1 = new MNode<object>("ALi", node2);

            // MNode<object> aa1 = new MNode<object>(null);  // data you enter it in not have any value 
            // aa1.AddFrist(5);
            // aa1.AddFrist(2);  // big(O) =1
            // aa1.AddFrist(10);
            // aa1.travers();   //big(0) =  n 
            // Console.WriteLine(aa1.size());  // big(O) = n 
            // System.Console.WriteLine(aa1._GetLast());
            // System.Console.WriteLine(aa1._GetFrist());  

            // aa1._Clear();
            // System.Console.WriteLine(aa1._GetFrist());
            // MNode<object> newnode = new MNode<object>(20);
            // newnode.AddFrist(20);
            // newnode.AddFrist(50);
            // newnode.AddFrist(100);
            // // newnode.travers();
            // // newnode._removelast();
            // // newnode.travers();
            // System.Console.WriteLine(newnode._GetAt(0).Data);

            // Queue<string> q1 = new();
            // q1.Enqueue("A"); q1.Enqueue("B"); q1.Enqueue("C");
            // System.Console.WriteLine(q1.Peek());
            // System.Console.WriteLine(q1.Dequeue());
            // q1.Enqueue("D");
            // while (q1.Count > 0)
            // {
            //     System.Console.WriteLine(q1.Dequeue());
            // }


        }

        static int func1(int[] a)
        {
            // big O 
            //constant
            return a[0] + 1;
        }
        static int func2(int[] a)
        {
            // linera 
            int resulte = 0;
            foreach (int arr in a)
            {
                resulte += arr;
            }
            return resulte;

        }
        static void func3(int[] a)
        {
            //Quadritc 
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    Console.WriteLine("i {0} , j {1}", a[i], a[j]);


                }
            }
        }
    }

    // public class Node<T>
    // {
    //     public T Data;
    //     public Node<T>? Next;

    //     public Node(T data)
    //     {
    //         Data = data;
    //         Next = null;
    //     }
    // }

    // public class linkedqueue<T>
    // {
    //     public Node<T>? front, raer;
    //     public int count { get; set; }
    //     public bool Isempity() => front == null;
    //     public void Enqueue(T item)
    //     {
    //         var node = new Node<T>(item);
    //         if (raer == null) front = raer = node;
    //         else { raer.Next = node; raer = node; }
    //         count++;
    //     }

    // }

}

// time complixity 