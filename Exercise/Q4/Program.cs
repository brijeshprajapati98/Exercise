using System; 

namespace FibonacciExample
{
   class Program  
   {  
     public static void Main(string[] args)  
      {  
         int nu1 = 0, nu2 = 1, nu3, i, number;    
         Console.Write("Enter the number of elements: ");    
         number = Convert.ToInt32(Console.ReadLine());  
         Console.WriteLine(nu1+" "+nu2+" "); //printing 0 and 1    
         for(i = 2; i < number; i++) //loop starts from 2 because 0 and 1 are already printed    
         {    
          nu3 = nu1 + nu2;    
          Console.WriteLine(nu3 + " ");    
          nu1 = nu2;    
          nu2 = nu3;    
         }    
      }  
   } 
} 