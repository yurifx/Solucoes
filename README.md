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
