using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoas = CreateSimpleListPessoas();
            FirstOrDefault(pessoas);
            LastOrDefault(pessoas);
            SingleOrDefault(pessoas);
            Where(pessoas);
            Count(pessoas);
            Sum(pessoas);
            Find(pessoas);
            Concat(pessoas, pessoas);
            Select(pessoas);
            OrderBy(pessoas);
            OrderByThenBy(pessoas);
            GroupBy(pessoas);
            ToLookUp(pessoas);
            Join();
            All(pessoas);
            Any(pessoas);
            Contains(pessoas);
            Aggregate(pessoas);
            Except(pessoas);
            CopyList(pessoas);
            Skip(pessoas);
            Take(pessoas);

            Conversoes(pessoas);
        }

        private static void Conversoes(List<Pessoa> pessoas)
        {
            var a = pessoas.ToArray();
            var b = pessoas.AsEnumerable<Pessoa>();

            var p = new List<object> { new { Age = 20, Nome = "A", Carro = new List<Carro>() }};
            var x= p.Cast<Pessoa>().FirstOrDefault();
           
        }

        private static void Take(List<Pessoa> pessoas)
        {
            var x = pessoas.Take(1);
        }

        private static void Skip(List<Pessoa> pessoas)
        {
            var x = pessoas.Skip(2).Take(2);
        }

        private static void CopyList(List<Pessoa> pessoas)
        {
            List<Pessoa> pessoasCopy = pessoas.ToList();
            pessoasCopy.Add(new Pessoa { Age = 40 });

        }

        private static void Except(List<Pessoa> pessoas)
        {
            List<Pessoa> pessoasCopy = pessoas.ToList();
            pessoasCopy.Add(new Pessoa { Age = 40 });
            var res = pessoas.Except(pessoasCopy); //return the list of elements that pessoas contains and the pessoascopy
            var res2 = pessoasCopy.Except(pessoas); //return the list of elements that pessoascopy contains and the pessoas doesn't contain.

        }

        private static void Concat(List<Pessoa> pessoas1, List<Pessoa> pessoas2)
        {
            var lis = pessoas1.Concat(pessoas2);
        }

        private static void SingleOrDefault(List<Pessoa> pessoas)
        {
            try { 
            //Single or Default throws an error when there's more than one matching element.

            var res = pessoas.SingleOrDefault(x => x.Age == 20); //Sequence contains more than one matching element'
            var res3 = pessoas.SingleOrDefault(x => x.Age == 5828); //Sequence contains more than one matching element'
            }catch(Exception e)
            {

            }
        }

        private static void LastOrDefault(List<Pessoa> pessoas)
        {
            pessoas.LastOrDefault(x => x.Age == 20);
        }

        private static void Aggregate(List<Pessoa> pessoas)
        {
            //https://www.tutorialsteacher.com/linq/linq-aggregation-operator-aggregate

            var res = pessoas.Select(x => x.Nome).Aggregate((x, y) => x + ", " + y);
        }

        private static void Contains(List<Pessoa> pessoas)
        {
            var lista_contem_elemento = pessoas.Contains(new Pessoa() { Age = 20 });//false 
        }

        private static void Any(List<Pessoa> pessoas)
        {
            //will return boolean true or false, depending if exists at least one person that satisfy the condition.
            var algumaPessoaTem20 = pessoas.Any(x => x.Age == 20); //true

        }

        private static void All(List<Pessoa> pessoas)
        {
            //wil return boolean true or false, if ALL results satisfy the condition. 
            var todaspessoastem20anos = pessoas.All(x => x.Age == 20); //false
        }

        private static void Select(List<Pessoa> pessoas)
        {
            var nomes = pessoas.Select(x => x.Nome);
            var res = pessoas.Select(x => new { Nome = x.Nome, Idade = x.Age }); //will return an anonymous type.
            var re2 = pessoas.Select(x => new Pessoa { Nome = "AA" + x.Nome, Age = 20 + x.Age, Carros = x.Carros });

        }

        private static void Join()
        {
            IList<Student> studentList = new List<Student>() {
                    new Student() { StudentID = 1, StudentName = "John", StandardID =1, Age = 20 },
                    new Student() { StudentID = 2, StudentName = "Moin", StandardID =1, Age = 20 },
                    new Student() { StudentID = 3, StudentName = "Bill", StandardID =2, Age = 20 },
                    new Student() { StudentID = 4, StudentName = "Ram" , StandardID =2, Age = 20 },
                    new Student() { StudentID = 5, StudentName = "Ron"  }
                };

            IList<Standard> standardList = new List<Standard>() {
                   new Standard(){ StandardID = 1, StandardName="Standard 1"},
                   new Standard(){ StandardID = 2, StandardName="Standard 2"},
                   new Standard(){ StandardID = 3, StandardName="Standard 3"}
               };

            var innerJoin = studentList.Join(// outer sequence 
                                  standardList,  // inner sequence 
                                  student => student.StudentID,    // outerKeySelector
                                  standard => standard.StandardID,  // innerKeySelector
                                  (student, standard) => new  // result selector
                                  {
                                      StudentName = student.StudentName,
                                      StudentAge = student.Age,
                                      StandardName = standard.StandardName
                                  });


        }

        private static void ToLookUp(List<Pessoa> pessoas)
        {
            //same as group by, but returns the result immediately - instead of returning an yield (lazy loading)
            GroupBy(pessoas);
        }

        private static void GroupBy(List<Pessoa> pessoas)
        {
            //ToLookup is the same as GroupBy; the only difference is GroupBy execution is deferred

            //group by e tolookup retornam uma lista de Keys, e cada key contem uma lista de elementos.
            var t = pessoas.ToLookup(x => x.Age);
            var g = pessoas.GroupBy(x => x.Age);

            var test = pessoas.ToLookup(x => x.Age).Select(x => new Pessoa() { Age = x.Key, Nome = x.FirstOrDefault().Nome });

        }

        private static void OrderByThenBy(List<Pessoa> pessoas)
        {
            var p = pessoas.OrderBy(x => x.Carros.Count()).ThenBy(x => x.Nome);
        }

        private static void OrderBy(List<Pessoa> pessoas)
        {
            var p = pessoas.OrderBy(x => x.Carros.Count());
            var p2 = pessoas.OrderByDescending(x => x.Carros.Count());
        }

        private static string DiferencaEntreFindEWhere()
        {
            return $@" 
                o find() retorna um elemento da lista.
                o where, retorna uma lista de elementos. 
                ";
        }

        private static void Find(List<Pessoa> pessoas)
        {
            var p1 = pessoas.Find(x => x.Nome == "PessoaA"); //return pessoa
            var p2 = pessoas.Find(x => x.Nome == "X"); //return null
        }

        private static void Count(List<Pessoa> pessoas)
        {
            var qtdPessoas = pessoas.Count();
        }

        private static void Sum(List<Pessoa> pessoas)
        {
            var carros = pessoas.First().Carros;

            var soma = carros.Sum(x => x.Valor);
        }

        private static void Where(List<Pessoa> pessoas)
        {
            var p1 = pessoas.Where(x => x.Nome == "PessoaA"); //retorna pessoa A
            var p2 = pessoas.Where(x => x.Nome == "X"); //retorna lista de pessoas vazia
        }

        private static List<Pessoa> CreateSimpleListPessoas()
        {
            var listaPessoas = new List<Pessoa>();

            listaPessoas.Add(new Pessoa()
            {
                Nome = "PessoaA",
                Carros = new List<Carro> {
                    new Carro() { Model = "A", Year = 1999, Valor = 3000 },
                    new Carro() { Model = "B", Year = 1999 },
                    new Carro() { Model = "C", Year = 2005 },
                    new Carro() { Model = "D", Year = 2019 },
                },
                Age = 15
            });

            listaPessoas.Add(new Pessoa()
            {
                Nome = "PessoaB",
                Carros = new List<Carro> {
                    new Carro() { Model = "A", Year = 1999, Valor = 3000 },
                    new Carro() { Model = "B", Year = 1999 },
                },
                Age = 20
            });

            listaPessoas.Add(new Pessoa()
            {
                Nome = "PessoaC",
                Carros = new List<Carro> {
                    new Carro() { Model = "A", Year = 1999, Valor = 3000 },
                    new Carro() { Model = "B", Year = 1999 },
                },
                Age = 20
            });


            return listaPessoas;
        }

        private static void FirstOrDefault(List<Pessoa> pessoas)
        {
            try
            {
                var p1 = pessoas.FirstOrDefault(); //will return the first pessoa  A
                var p2 = pessoas.FirstOrDefault(x => x.Carros.Count > 3); //will return the first pessoa que tenha mais de 3 carros. Ou seja, pessoa A
                var p3 = pessoas.FirstOrDefault(x => x.Nome == "C"); //retorna nulo
                var p4 = pessoas.First(x => x.Nome == "C"); //throws exception
            }
            catch (Exception e)
            {

            }
        }
    }
}

public class Carro
{
    public Guid CarId
    {
        get { return Guid.NewGuid(); }
    }

    public string Model { get; set; }
    public int Year { get; set; }
    public decimal Valor { get; set; }
}

public class Pessoa
{
    public string Nome { get; set; }
    public List<Carro> Carros { get; set; }

    public int Age { get; set; }
}

public class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int StandardID { get; set; }

    public int Age { get; set; }
}

public class Standard
{
    public int StandardID { get; set; }
    public string StandardName { get; set; }
}