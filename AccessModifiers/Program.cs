using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 
/// Access Modifiers:
/// 
/// Protected -> Propriedades e métodos > Consigo acessar quando a classe filha seja herdada de uma classe pai que tenha esses objetos protected
/// Internal  -> Dentro do mesmo projeto, consigo acessar.
/// 
/// 
/// </summary>

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ver AccessModifiers_Externo.
        }


    }
    public class Classe_Publica_Projeto_1
    {
        private string variavelPrivate;
        public string variavelPublica;
        internal string variavelInternal;
        protected string variavelProtected;
        protected internal string variavelProtectedInternal;

        private void MetodoPrivate() { }
        public void MetodoPublico() { }
        protected void MetodoProtected() { }
        internal void MetodoInternal() { }
    }

    internal class Classe_Internal_Projeto_1
    {
        private string variavelPrivate;
        public string variavelPublica;
        internal string variavelInternal;
        protected string variavelProtected;
        protected internal string variavelProtectedInternal;

        private void MetodoPrivate() { }
        public void MetodoPublico() { }
        protected void MetodoProtected() { }
        internal void MetodoInternal() { }


    }


    public static class Classe_estatica_Projeto_1
    {
        public static void Metodo()
        {

            //do nothing
        }
    }

    //protected class Cl_A_Protected
    //{
    //    private string variavelPrivate;
    //    public string variavelPublica;
    //    internal string variavelInternal;
    //    protected string variavelProtected;
    //    protected internal string variavelProtectedInternal;
    //}
}
