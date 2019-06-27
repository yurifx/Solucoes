using AcModifiers;
using System;

namespace UsingInternalFromAnotherAssembly
{
    class Program: Train
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var train = new Train();
            //train.InternalTest(); //does not work
            //train.ProtectedTest(); //does not work
        }
    }
}
