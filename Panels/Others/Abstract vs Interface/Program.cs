using System;

namespace AbstractInterface
{
    // *  Abstract class *
    //    - methods must have implementations 
    //    - classes that inhertis the abstract class don't necessary need to implement the method
    //    - An abstract class cannot be instantiated > var x = new MyAbstractClass();


    // * Interface * 
    //   - methods only have signatuers, not implementation.
    //   - classes that implements an interface MUST implement all the interface methods
    //   - intefaces can't be instanciated > var x = new MyInterface(); 


    public abstract class AbstractClass
    {
        void DoSomething()
        {
            Console.WriteLine("AbstractClass Method DoSomething");
        }

        void AnotherThing() { }
    }

    public interface MyInterface
    {
        void DoSomethingInterface(); //Can't have implementation
    }


    public class UseEverything: AbstractClass, MyInterface
    {
        //We don't need to implement the DoSomething from AbstractClass, however is mandatory to implement the DoSomethingInterface
        public void DoSomethingInterface()
        {
            throw new NotImplementedException();
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // var ab = new AbstractClass(); //ERROR
            //var i = new MyInterface(); //ERROR

            AbstractClass bu = new UseEverything();
            MyInterface iu = new UseEverything();
        }
    }

}
