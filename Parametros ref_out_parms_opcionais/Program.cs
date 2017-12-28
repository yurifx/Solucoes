using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametros_ref_out_parms_opcionais
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Parametros p = new Parametros();

            var a = "outxref";

            p.Metodo_Ref(ref a); // o método ref vai usar o valor do a

            p.Metodo_Out(out a); //o método out não vai usar o valor do a

            a = "opcional";

            p.Metodo_Opcional(); //como podemos não passar o a

            p.Metodo_Opcional(a); //podemos passar o a

            a = "N";

            p.Metodo_NParametros(a, a, a); //Aqui podemos passar quantas vezes quisermos.

            p.Metodo_NParametros(100, a, a, a); //Aqui podemos passar um int e ainda assim quantas vezes quisermos.

            Console.ReadLine();
        }
    }


    class Parametros
    {
        public void Metodo_Ref(ref string a)
        {
            //No parâmetro REF, pode ser passado um valor para dentro do método.

            Console.WriteLine("Chamada Metodo Ref:" + a);

        }

        public void Metodo_Out (out string a)
        {
            //Out é usado apenas para saídas. Qualquer coisa que vier pelo parametro não pode ser usado no método
            //É necessário atribuir ele aqui em baixo.
            a = "atribuição out";

            Console.WriteLine("Chamada Metodo Out: " + a);
        }


        public void Metodo_Opcional (string a = "")
        {

            Console.WriteLine($"Parametro Opcional:  {a}");
        }

        public void Metodo_NParametros(params string[] a)
        {
            //Este método recebe diversos parametros, string.

            foreach(var str in a)
            {
                Console.WriteLine("'Params' - Diversos parametros: " + str);
            }
        }

        public void Metodo_NParametros(int resultado, params string[] a)
        {
            //Este método recebe um int e ainda assim, diversos parametros string.
            if (resultado > 0)
            {
                foreach (var str in a)
                {
                    Console.WriteLine("'Params' - INT + Diversos parametros: " + str);
                }
            }
        }
    }
}
