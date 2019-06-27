using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MeuMetodoGenericoSimples<String>();
            MeuMetodoGenericoSimples<Int32>();
            MetodoGenerico<Program>();
            MetodoGenerico<Program>();


            var classeGenericaString = new GenericClass<string>();
            var classeGenericaInt = new GenericClass<Int32>();

            classeGenericaString.DoSomething("valor");
            classeGenericaInt.DoSomething(0);

        }

        private static void MeuMetodoGenericoSimples<T>()
        {
            Console.WriteLine(typeof(T).ToString());
        }

        static void MetodoGenerico<T>() where T: Program
        {
            Console.WriteLine(typeof(T).ToString());
        }
    }
}
