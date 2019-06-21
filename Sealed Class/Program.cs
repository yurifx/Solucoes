using System;

namespace Sealed_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


     public sealed class SealedClass
    {
        public int MyProperty { get; set; }
    }

    public class TryToInherit: SealedClass //cannot derive from sealed class
    {

    }
}
