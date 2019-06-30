using System;

namespace Converts
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double mydouble = 21.23;
            int mynum = (int)mydouble;

            Console.WriteLine(mynum);
            toString_vs_Convert();
            Console.WriteLine("Hello World!");
        }


        static void toString_vs_Convert()
        {
            // Object.ToString() not Handle Null Values where as Convert.ToString() can handle Null Values.
            //That means Convert.Tostring() will not generate Null Refernce Exception
            //where as Object.ToString() will generate Null Refernce Exception if you are trying to do .ToString() on object which is NULL.
            object b = null;
            var result = Convert.ToString(b);
            var result2 = b.ToString(); //'Object reference not set to an instance of an object.'
        }
    }
}

//Implicit type conversion − 
//These conversions are performed by C# in a type-safe manner. For example, are conversions from smaller to larger integral types and conversions from derived classes to base classes.

//Explicit type conversion 
//These conversions are done explicitly by users using the pre-defined functions.Explicit conversions require a cast operator.