using System.Collections;
using explain_C_;
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
           _Arraylist aa1  = new _Arraylist(100); 
           aa1 [0] =  20  ;
           System.Console.WriteLine(aa1[0]);
           aa1 [1] ="Ahmed" ;
           System.Console.WriteLine(aa1[1]);
           aa1 [0] = 5  ;
           System.Console.WriteLine(aa1[0]);
 

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
}

// time complixity 