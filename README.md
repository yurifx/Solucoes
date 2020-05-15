# C Sharp

---

### Virtual and Orverride

- use virtual so a method can be overridden by subclasses.
- use override keyword to overide virtual methods from base class

You use virtual and override to avoid this:

```csharp
class Animal
    {
        public virtual void Eat() {
            Console.WriteLine("animal");
        }
    }

    class Cat : Animal
    {
        public void Eat()
        {
            Console.WriteLine("cat");
        }
    }

    class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("dog");
        }
    }
```

```csharp
//using the same variable

var b = new Animal();
b.Eat(); //output: animal

b = new Cat(); //output: animal
b.Eat();

b = new Dog(); //output: dog
b.Eat();


//new variable
var c = new Cat();
c.Eat(); //output: cat
```

---

### Sealed:

use sealed to prevent further overriding. For example, class Cat inherits from class Animal. classe WhiteCat inherits from Cat. If class Cat does override a virtual method from and use the word sealed, the WhiteClass won't be able to override anymore.

```csharp
using System;

    class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("animal");
        }
    }

    class Cat : Animal
    {
        public override sealed void Eat()
        {
            Console.WriteLine("cat");
        }
    }

    class WhiteCat : Cat
    {
        //ERROR: 'WhiteCat.Eat()': cannot override inherited member 'Cat.Eat()' because it is sealed [app]csharp(CS0239)

        public override void Eat()
        {
            Console.WriteLine("dog");
        }
    }
}
```

### New:

the keyword `new` is tell the compiler that you know that you have a method with same name in derived class

By using new, you are asserting that you are aware that the member that it modifies hides a member that is inherited from the base class
[link](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/knowing-when-to-use-override-and-new-keywords)

---

### Generics

```csharp
using System;

namespace VirtualOverride
{
    public class Animal<T>
    {
        public void Print(T meutipo) => Console.WriteLine(typeof(T));
    }
}
```

```csharp
 var a = new Animal<string>();
 a.Print("hello"); //output: string

 var b = new Animal<int>();
 b.Print(0); //output: int
```

---

### Reflection

check the type:

```csharp
var a = new Animal<string>();
```

```csharp
 Console.WriteLine(a.GetType()); //output: VirtualOverride.Animal`1[System.String]

 Console.WriteLine(a is Animal<string>); //true

 Console.WriteLine(a.GetType() ==typeof(Animal<string>)); //true
```

---

### Factory Design Pattern

```csharp
var x = Animal.GetAnimal("dog");
Console.WriteLine(x.GetType()); //VirtualOverride.Dog


var y = Animal.GetAnimal("cat");
Console.WriteLine(y.GetType()); //VirtualOverride.Cat
```

```csharp
using System;

namespace SimpleFactory
{
    public class Animal
    {
        public static Animal GetAnimal(string animal)
        {
            if (animal == "cat") return new Cat();
            if (animal == "dog") return new Dog();
            return null;
        }
    }

    public class Cat : Animal {}

    public class Dog : Animal {}
}
```

---

### readonly

readonly indicates that assignment to the field can only occur as part of the declaration or in a constructor in the same class

---

### ref vs out

So while ref is two-ways, out is out-only.
ref is default behaviour for objects.
if you want to pass a int for example as ref, you have to use the `ref` keyword

```csharp
public void EatOut(out string test)
{
    test = "only out and needs to be assigned";
}
public void EatRef(int test)
{
    test = 55;
}
```

```csharp
var a = "";
var b = 1;
var c = 99;

x.EatOut(out a);
//or
x.EatOut(out string newstr); //wasn't declared before, the declaration happens here.

x.EatRef(ref b);
x.Eat(c);

Console.WriteLine(a); // "only out and needs to be assigned";

Console.WriteLine(b); //55

Console.WriteLine(C); //99
```

---

### Delegates, Functions, Actions

```csharp
using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string> x = Print;
            Action<string> y = Log;
            Execute(x, y);
        }

        public static string Print(string text)
        {
            Console.WriteLine(text);
            return text;
        }
        public static void Log(string text)
        {
            Console.WriteLine($"loging: {text}");
        }
        static void Execute(Func<string, string> myFunction, Action<string> myAction)
        {
            myFunction("hey");
            myAction("ho");
        }
    }
}


```

---

### CQRS

`Command Query Responsibility Segregation:`

- Command -> insert, update, delete:
  _Every command has an output: success or not._

- Query -> select

You can have multiple database, one for reading other for writing

### EventSourcing

Each change in an entity will be saved. So you can go back in time and see how you the entity was in some point in time.
