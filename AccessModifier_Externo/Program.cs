using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifiers;

namespace AccessModifier_Externo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Não conseguimos instanciar uma classe internal, de outro projeto
            //Class_internal_Projeto_1 is inacessible due a protected level
            //var instaciaInternal = new Classe_Internal_Projeto_1();
            var instanciaPublica = new AccessModifiers.Classe_Publica_Projeto_1();

            instanciaPublica.MetodoPublico(); //consigo acessar o método público
            var p = instanciaPublica.variavelPublica;  //consigo acessar a variável pública.

        }

        //Classes em projetos separados, só podem acessar as variaveis publicas
        //E caso a classe herde de uma outra classe, pode visualizar as variaveis protected
        public class Herda : Classe_Publica_Projeto_1
        {
            public void Metodo()
            {
                var x = variavelProtected;
                var y = variavelProtectedInternal;
                var z = variavelPublica;

                //MetodoInternal(); //Não conseguimos utilizar o método internal.
                MetodoProtected();
                MetodoPublico();

            }
        }

        public sealed class ClasseSelada
        {
            public void Metodo()
            {
            }
        }

        public class HerdaDeSelada //: ClasseSelada
        {
            //Cannot derive from sealed clas
        }


    }
}
