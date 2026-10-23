using System;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace him
{
    public class BinarySearch
    {
        public static void Binary()
        {
            int x = 20 ;
            int []arr  = {5,12,17,28,38,44,77,84,90};

            double epsloint =  0.01 ;
            double low =1 ;
            
            double high =  x  ;
            double ans =  (low + high)/2 ; 
            int counter = 0 ; 
         
            
            while(Math.Abs(Math.Pow(ans , 2) - x) >= epsloint){
                System.Console.WriteLine($"low : {low}  high : {high} answer : {ans}");
                if (Math.Pow(ans,2 ) < x)
                {
                    low = ans ;
                }else
                {
                    high =  ans ;
                }
                ans = (low +  high) / 2 ;
                counter++;
            }
            System.Console.WriteLine(counter+ '\n');
            System.Console.WriteLine(ans);
            
        }



    }
}