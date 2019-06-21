using System;
using System.Linq;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Test();
            System.Type type = test.GetType();

            FieldInfo[] fields = type.GetFields();


            SomethingAttribute MyAttribute = (SomethingAttribute)Attribute.GetCustomAttribute(type, typeof(SomethingAttribute));

            Console.WriteLine(MyAttribute.Developer);

            DateTime dateTime = (DateTime)Activator.CreateInstance(typeof(DateTime));

        }
    }

    [Something(true)]
    class Test
    {
        public int Name { get; set; }
    }

}
