using System;

namespace ConstructorDestructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new A();
            var b = new B();
        }
    }

    public class A
    {
        public A()
        {
            Console.WriteLine("Constructor A actioned");
        }
    }

    public class B:A
    {
        public B():base() //this will call the constructor of the class A.
        {
            Console.WriteLine("Constructor B actioned");
        }

        ~B()
        {
            Console.WriteLine("Destructor Actioned");
        }
    }
}
