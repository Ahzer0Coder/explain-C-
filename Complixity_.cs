using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace explain_C_
{
    public class Complixity_
    {
        public static void Ques()
        {
            int []arr = {1,5,9,3,6,7,8} ;
            int [,]arr2  = new int[10,2] ;
            int b = 1  ;
            int num  = 10  ;
            int n = 0  ;
            arr2 = new int [,] {{1,2},{2,5},{6,4},{4,6},{6,8}} ;
           
             int X = 0;
               while (X < 5)
            {
                Console.WriteLine("{0}", X); // big (O) = 1 
                X++ ;
            }
            while (X < arr.Length)
            {
               System.Console.WriteLine("{0}" , arr[X]);  // big(O) = n
               X++ ; 
            }
            while (b <= num )
            {
              b = b * 2;  // if b = 0 you enter infinity loop big(O) = infinity  (fire) 
             System.Console.WriteLine(b);  // big(O) =  log n
             
            }
            for(int  i =0 ;i < 5 ; i++)
            {
                while (n < 10)
                {
                    System.Console.WriteLine("{0}", n);  // big(O) = 1 
                    n++ ;
                }
            }
            for(int i =0 ; i < 3 ; i++)
            {
                int k = 1 ; 
                
                while (k < n)
                {
                    k *= 2 ; 
                    System.Console.WriteLine("{0}", k );  //  big(O) = log n
                }
            }
            for(int  i =0 ;i < 5 ; i++)
            {
                while (n < arr.Length)
                {
                    System.Console.WriteLine("{0}", arr[n]);  // big(O) = n
                    n++ ;
                }
            }
            for(int i = 0 ;i < arr.Length; i++)
            {
                int k = 1 ; 
                while (k <  arr.Length )
                {
                    arr[i] *= 2  ;  // big(O) = n log n
                    k++ ; 
                }
            }
            for(int i = 0  ; i < 5; i++)
            {
                 Console.WriteLine("{0}", i); // Big (O) = 1 
            }
            for(int  i = 0 ; i < arr.Length ; i++)
            {
                Console.WriteLine("{0}", arr[i]);  // big(O) = n  to read or write
            }
            for(int i = 0 ; i < 5; i++)  // constant loop in for
            {
                for(int j = 0  ;j <  5 ; j++)  // constant loop in for 
                {
                     Console.WriteLine("{0}", j) ; //big(O) = 1
                }
            }
            for(int i =  0 ;  i <  10 ; i++)
            {
                for(int j = 0 ; j <  arr.Length ; j++)
                {
                    Console.WriteLine("{0}",  arr[j]) ; //  big (O) = n
                }
                
            }
            for(int i = 0 ;i< arr2.GetLength(0);i++)
            {
                for(int j = 0 ; j < arr2.GetLength(1) ; j++)
                {
                    System.Console.WriteLine("arr x = {0} ", arr2[i,j] ); //big(O) = n^2  if square m*n if rectangle  
                }
            }

        }
    }
}