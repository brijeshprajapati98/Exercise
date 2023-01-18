using System;

namespace Excersice
{
    class parent
    {
        public void methodA()
        {
            Console.WriteLine("MethodA " + "This is parent class ");
        }
    }

     class Child : parent
    {
        public void methodB()
        {
            Console.WriteLine("MethodB " + "This is child class ");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            parent parentClass = new parent();      
            Child ChildClass = new Child();      
            parentClass.methodA();                
            ChildClass.methodB();                
            ChildClass.methodA();    
        }
    }
}