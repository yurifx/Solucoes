using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yield_LazyLoading
{

    /// <summary>
    /// 
    /// O Yield tem a função de atrasar/postergar o processamento (loop) de lista, caso você precise fazer o loop.
    /// Ele é usado em iterações onde hajam retorno de IEnumerables, listas e afins (collections)
    /// Podemos retornar um IEnumerable que só ira ser definitivamente carregado/executado, quando acionarmos o .ToList();
    /// Ou seja, mesmo chamando o método que contém o retorno Yield, ele só irá ser executado quando enumerarmos (tolist).
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<Modelo> { new Modelo { Id = 1, Nome = "Yuri" },
                                           new Modelo {Id = 2, Nome = "Teste"}
                                         };


            var instancia = new OperacaoYield();


            //Com debug acionado, veja as execuções dos métodos abaixo:
            var t1 = instancia.MetodoNormal(lista);
            var t2 = instancia.MetodoYield(lista);

            //o T2, não entra no processamento, até que seja chamado o método ToList();
            t2.ToList();
            

            Console.ReadLine();


        }
    }


    /// <summary>
    /// Os dois métodos tem a mesma funcionalidade.
    /// Verificar se existe um número com id > 1 e retornar.
    /// </summary>
    class OperacaoYield
    {

        public IEnumerable<Modelo> MetodoYield(IEnumerable<Modelo> lista)
        {
            foreach (var item in lista)
            {
                if (item.Id > 1)
                    yield return item;
            }
        }

        public IEnumerable<Modelo> MetodoNormal (IEnumerable<Modelo> lista)
        {
            var listaNova = new List<Modelo>();

            foreach (var item in lista)
            {
                if (item.Id > 1)
                    listaNova.Add(item);
            }

            return listaNova;
        }

    }





    class Modelo
    {
        public int Id { get; set; }
        public string Nome { get; set; }

    }
}
