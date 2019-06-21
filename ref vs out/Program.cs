using System;

namespace ref_vs_out
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            Test(out x, ref y);

           //Error: y should be initialized before calling the method        }

            void Test(out int name, ref int another)
            {
                //use of unassigned name
                name = 0;
                another = 1;
                Console.WriteLine(name);
            }
        }
    }
