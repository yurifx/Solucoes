using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifiers;

namespace AccessModifiers
{
    class ClasseExternaMesmoProjeto
    {

        /// <summary>
        /// 
        /// Aqui estamos em uma classe diferente, porém dentro do mesmo projeto.
        /// Conseguimos acessar tranquilamente a classe/metodo/variavel Internal
        /// 
        /// </summary>
        public void TestaAcesso()
        {
            var classePublica = new Classe_Publica_Projeto_1();
            var classeInternal = new Classe_Internal_Projeto_1();


            classeInternal.MetodoPublico();
            classeInternal.MetodoInternal();

            var variavelPublica = classeInternal.variavelPublica;
            var variavelInternal = classeInternal.variavelInternal;

        }

    }



    



}
