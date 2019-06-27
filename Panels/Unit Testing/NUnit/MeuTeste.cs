using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesNUnit
{
    public class MeuTeste
    {
        [TestCase(1, 2, "3")]
        [TestCase(1, 3, "4")]
        [TestCase(1, 0, "1")]
        public void MeuMetodoTeste(int valor, int valorb, string resultadoEsperado)
        {
            var p = new Program();
            
            var resultadoFuncao = p.Add(valor, valorb);

            Assert.AreEqual(resultadoFuncao, resultadoEsperado);
            

        }
    }
}
