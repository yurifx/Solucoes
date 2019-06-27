using System;

namespace readonly_vs_const
{
    //readonly nao precisa ter valor na criacao da variavel. 
    //const precisa ter valor logo na criacao da variavel

    //const pode ser criada em metodos ou classes
    //readonly so pode ser criada em classes

    public class Program
    {
        readonly string c_name = "Yuri";
        const string r_name = "Cons_Name";

        //const string c_test; //erro por que pede que a seja iniciado
        readonly string r_test; //ok. Nao precisa ser iniciado

        public Program()
        {
            r_test = "I can set readonly value via constr.";
        }

        public static void Main(string[] args)
        {
            const string c_works = "";
            //readonly string r_doesnotwork = "";
        }
    }
}
