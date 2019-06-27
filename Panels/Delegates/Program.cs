using System;

namespace Delegates
{
    class Program
    {
        public delegate int MyDelegate(string s);
        static void Main(string[] args)
        {
            var mydel = new MyDelegate(MeuMetodo);
            DoSomething(mydel);

            var p = new AnotherDelegate();
            p.Program();

        }

        private static int MeuMetodo(string s)
        {
            Console.WriteLine("Meu Metodo executado" ,s);
            return 0;
        }

        public static void DoSomething(MyDelegate funcao)
        {

            funcao("something");
        }
    }
}

