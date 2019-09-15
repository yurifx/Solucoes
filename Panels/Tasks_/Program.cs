using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var x = new Task(() => new Base().CreateLog("escreva"));
            var x2 = Task.Run(() => new Base().CreateLog("hello"));

            x.Start();
            x.Wait();


            var x = new List<string> { "1", "2", "3" };
        }
    }

    public class Base
    {
        public async void CreateLog(string message)
        {
            Console.WriteLine(message, Thread.CurrentThread.Name);
        }
        public Base()
        {

        }
    }
}
