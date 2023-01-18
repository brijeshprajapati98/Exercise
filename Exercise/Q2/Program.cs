using System;

    
namespace Exercise
{
    class Q2
    {               
        public static void Main(string[] args)
        {
            Console.Write("Enter valid number: ");
           int num=Convert.ToInt32(Console.ReadLine());
           
           int sum = 0;
           while(num>0)
           {
              sum += num % 10;
              num/=10; 
           }
           Console.WriteLine("vaild number: " + sum);  
        }

    }
}    /* Sum = sum + num % 10 
        sum =  0  + 52 % 10
        sum = 0 + 2 
        sum = 2

        num = num / 10 
        num = 5


        sum = num % 10
        sum = 2

        sum = sum + num 
        sum = 2 + 5
        sum = 7 

    */