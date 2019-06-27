using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new Repository.BancoContext())
            {

                var lista = db.Tabela.ToList();

                if (lista != null){
                    foreach (var item in lista)
                    {
                        Console.WriteLine($"Nome {item.Nome}");
                    }

                    Console.ReadLine();
                }
            }
        }
    }
}
