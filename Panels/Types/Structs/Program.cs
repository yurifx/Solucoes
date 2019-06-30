using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var x = new MyStruct() { FirstProperty = "Hello World" };
        }
    }

    //Structs are value types and classes are reference types.
    //Cannot support inheritance


    struct MyStruct
    {
        public string FirstProperty { get; set; }

        void DoSomething() {
            Console.WriteLine("ok");
        }
    }

    class MyClass
    {
        public int FirstProperty { get; set; }
        void DoSomething()
        {
            Console.WriteLine("ok");
        }
    }
}
