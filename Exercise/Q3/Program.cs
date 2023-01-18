using System;

namespace Exercise
{
    class Q3
    {
        public static void Main(string[] args)
        {
            int fact=1, i, number;
            Console.Write("Enter factorial number: ");
             number=Convert.ToInt32(Console.ReadLine());
            for(i=1;i <= number; i++)
            {
                fact= fact * i;

            }Console.WriteLine("Factorial of " + number + " is: " + fact);
                
        }
    }
}
