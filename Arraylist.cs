using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace explain_C_
{
    public class _Arraylist
    {
           // how to creat array list 

          object []arr  ;
           int _Max_size ; 
           int _length ;
            public _Arraylist( int size )
           {
            _Max_size = size  ;
            _length =  0 ; 
            arr =  new object[size]; 
           }
            public _Arraylist( )
           {
            _Max_size = 10  ;
            _length =  0 ; 
            arr =  new object[10]; 
           }
           public int _Lenght {get => _length ;  private set => _Lenght = value; }

           public bool Isfull()
           {
            return _Lenght == _Max_size ;
           }
           
           public void print()
           {
            for (int i =0 ; i < arr.Length ;  i++ )
            {
                System.Console.WriteLine(arr[i]);
            }
            
           }
    }
}