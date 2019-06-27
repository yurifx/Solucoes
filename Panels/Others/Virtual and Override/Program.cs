using System;


//You use virtual to specify a method can be overridden by subclasses.
//You use override to specify you are overriding a method that you know is virtual
//You use sealed to prevent further overriding. For example, class A herda de class Base. Classe B herda de A. Se o A faz override de um metodo virtual da classe base, e coloca o sealded, entao a classe B nao pode mais fazer overide
//And you use new to create method with same name, but not override.
//All the "new" keywords allows you to do is to have two methods with the same name in a class hierarchy.


//If you don't specify the override or new, it will assume the "new"  
//https://stackoverflow.com/questions/6162451/the-difference-between-virtual-override-new-and-sealed-override
//A method not declared virtual or abstract can be re-defined with the new modifier in a derived class. 

//Any method can be overridable, using the keyword virtual or not. The decision is made by the one who defines the method:


namespace VirtualOverride
{
    public class Base
    {
        public virtual void SimpleOverride()
        {
            Console.WriteLine("base class simple override");
        }

        public virtual void OverrideWithSealed()
        {
            Console.WriteLine("base class override with sealed");
        }

        public void WithoutVirtualKeyword()
        {
            Console.WriteLine("base class method without virtual keyword");
        }
    }

    public class Test : Base
    {
        public override void SimpleOverride()
        {
            Console.WriteLine("test class Simple override");
        }
        public sealed override void OverrideWithSealed()
        {
            Console.WriteLine("test Class override with Sealed");
        }

        public new void WithoutVirtualKeyword()
        {
            Console.WriteLine("test Class Method Without Virtual Keyword");
        }
    }

    public class TestA : Test
    {
        public override void SimpleOverride()
        {
            Console.WriteLine("yeah, you can overide as much as you want");
        }

        //public override void OverrideWithSealed() //erro (cannot override inherited member because it is sealded
        //{
        //    Console.WriteLine("No, you can't override because it was sealed");
        //}
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------- SIMPLE OVERRIDE -------");


            Base b = new Base();
            b.SimpleOverride(); //output:  base class simple override

            Base bt = new Test();
            bt.SimpleOverride(); //output: test class Simple override

            Test t = new Test();
            t.SimpleOverride(); //output:  test class Simple override


            Console.WriteLine("------- USING THE NEW KEYWORD -------");

            Base b2 = new Base();
            Test t2 = new Test();
            Base bt2 = new Test();

            b2.WithoutVirtualKeyword();  //output:  base class method without virtual keyword
            bt2.WithoutVirtualKeyword(); //output:  base class method without virtual keyword
            t2.WithoutVirtualKeyword();  //output:  test Class Method Without Virtual Keyword


            //COMPARE BT and BT2 outputs. That`s the difference when we use the NEW keyword and the VIRTUAL/OVERRIDE. 
            //the bt.MethodWithoutVirtualKeyword executed the base method even though it was an instance of Test.
            //That happens because the method wasn't overriden.

            ////When the method is called in the base class the base method executed, 
            //and when called in the derived class, the new method is executed. 


        }
    }
}
