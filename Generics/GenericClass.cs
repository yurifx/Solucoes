using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class GenericClass<T>
    {
        public void DoSomething(T value)
        {
            Console.WriteLine(value.ToString());
        }
    }
}
