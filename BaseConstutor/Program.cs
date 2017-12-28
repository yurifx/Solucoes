using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Herdando uma classe e chamando o construtor da classe base com a palavra reservada: base!
/// </summary>

namespace BaseConstutor
{
    class Program
    {
        static void Main(string[] args)
        {

            var instanciaClasseFilha = new ClasseFilha();
            Console.ReadLine();

        }
    }


    //class base
    public class ClassePai
    {
        public ClassePai(/*string MensagemClassePai*/)
        {
            Console.WriteLine($"Enviado pela classe pai");
        }
    }

    //class que herda
    public class ClasseFilha: ClassePai
    {
        //a palavra base, após a declaração do construtor desta classe, faz um acionamento no construtor da classe base que ela herda.
        public ClasseFilha(): base(/*"Chamando a classe pai"*/)
        {
            Console.WriteLine($"Mensagem da classe filha");
        }
    }


}
