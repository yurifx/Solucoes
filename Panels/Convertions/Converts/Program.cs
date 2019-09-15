using System;

//https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions

namespace Converts
{
    class Program
    {
        static void Main(string[] args)
        {

            // Implicit conversion. A long can
            // hold any value an int can hold, and more!


            int num = 2147483647;
            long bigNum = num;


            // another example would be - convert derived class to a base class.
            Derived d = new Derived() { PropertyFromDerived = "hello world" };
            Base b = d; // Always OK.  
            Console.WriteLine(b);


            //Explicit Conversion (from a bigger type to a smaller) - you may loose information in this conversion
            //Explicit conversions
            //However, if a conversion cannot be made without a risk of losing information, 
            //the compiler requires that you perform an explicit conversion, which is called a cast.
            //A cast is a way of explicitly informing the compiler that you intend to make the conversion 
            //and that you are aware that data loss might occur. To perform a cast, specify the type that you are casting to in parentheses in front of the value or variable to be converted.
            double mydouble = 21.23;
            int mynum = (int)mydouble; //display 21;


            //var mystring = "hello world";
            //var myint = (int)mystring; //cannot convert

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
//These conversions are performed by C# in a type-safe manner. 
//Conversions from smaller to larger integral types and conversions from derived classes to base classes.

//Explicit type conversion 
//These conversions are done explicitly by users using the pre-defined functions.Explicit conversions require a cast operator.