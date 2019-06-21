using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Delegates
{
    public class AnotherDelegate
    {
        public delegate int Imprimir(string s);
        public void Program()
        {
            var logarConsole = new Imprimir(LogarConsole);
            var logarFile = new Imprimir(LogarFile);

            Logar(logarConsole);
            Logar(logarFile);
        }

        public void Logar(Imprimir Logar)
        {
            Logar("abc");
        }

        public int LogarConsole(string texto)
        {
            Console.WriteLine($"logando console {texto}");
            return 0;
        }
        public int LogarFile(string texto)
        {
            var fs = new FileStream("C:/test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Console.WriteLine($"logando file {texto}");
            return 1;
        }

    }
}
