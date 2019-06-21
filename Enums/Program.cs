using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            var novo = Tipos.Novo;
            Console.WriteLine(novo); //output: Novo

            var novoValue = (int)Tipos.Novo;
            Console.WriteLine(novoValue);

            var newTipo = Enum.Parse(typeof(Tipos), "0");
            Console.WriteLine(newTipo);
        }
    }

    enum Tipos
    {
        Novo = 0,
        Velho = 1
    }

    public enum Atualizado
    {
        True = 0,
        False = 1
    }
}
