using explain_C_;
using him; 

namespace pro
{


    class APP
    {


        static void Main()
        {
            int []arr =  new int [1] ;
            arr [0] = 15 ;
            func1(arr) ;  //  O{1}
            func2(arr) ; // O{n}
            func3(arr) ; // O{n^2}
             Complixity_.Ques();
             BinarySearch.Binary(); 


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