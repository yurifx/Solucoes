## C#

C# is statically-typed at compile time, after a variable is declared, it cannot be declared again





## Value Types

```c#
bool boleano = true;

short numeropequeno = 0;
int inteiro = 0; //int 32
uint naopodenegativo = 0;
long inteirolongo = 100L; //int 64
ulong naopodenegativoLong = 0;

decimal dec = 10.2M;
decimal dec2 = 10;

double dob = 10.02D;
double dob2 = 10;

char ch = 'a';

float flutuante = 20f;

//pointer type
//char* cptr;
```



- Structs


```C#
//Structs are value types and classes are reference types.
//Cannot support inheritance

struct MyStruct
{
    public string FirstProperty { get; set; }

    void DoSomething() {
        Console.WriteLine("ok");
    }
}
```


## Reference Types

- Enum 

```C#
enum Tipos
{
	New = 0,
	Old = 1
}
```

```C#
var novo = Tipos.New;
Console.WriteLine(novo); //output: Novo

var novoValue = (int)Tipos.New;
Console.WriteLine(novoValue); //output: 0
```


- Classes

```c#
class MyClass
    {
        public int FirstProperty { get; set; }
        void DoSomething()
        {
            Console.WriteLine("ok");
        }
    }
```



## Conversions

Object.ToString() 

- cannot handle nulls. if object = null, will throw an exception

Convert.ToString(object)

- does handle nulls, which means: if object = null, won't throw exception



Implicity Conversions [Link](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/implicit-numeric-conversions-table)

```C#	
Implicity 

[They are safe] - conversions from smaller to larger integral types and conversions from derived classes to base classes

// Example: A double can hold any value an int can hold.
int num = 21;
double mydouble = num;
```



Explicity Conversions - [Link](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/explicit-numeric-conversions-table)

```C#
Explicity
[They are risky] - You can loose information when converting. 
    
//Example:
double mydouble = 21.23;
int mynum = (int)mydouble; //output: 21

    
```

