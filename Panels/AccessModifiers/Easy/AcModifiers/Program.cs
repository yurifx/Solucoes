using System;

/*
    private = somente usado naquela classe.
    public = usado em qualquer lugar
    internal = acessado por mesma dll - mesmo projeto (assembly).
    protected = das classes derivadas / herdadas
*/
namespace AcModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var train = new Train();
            train.PublicTest();
            //train.Private();
            train.InternalTest();
            //train.ProtectedTest();
        }
    }

    class UsingProtected: Train
    {
        private void Something()
        {
            ProtectedTest(); //I can use because the UsingProtected inherits from Train
        }
    }

    public class Train
    {
        public void PublicTest()
        {
            Console.WriteLine("public");
        }

        private void PrivateTest()
        {
            Console.WriteLine("private");
        }
        protected void ProtectedTest()
        {
            Console.WriteLine("protected");

        }
        internal void InternalTest()
        {
            Console.WriteLine("internal");
        }

        
    }
}
