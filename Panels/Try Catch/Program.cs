using System;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception();
            }
            catch (ArgumentNullException ex)
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine("catch the error");
            }

            finally
            {
                Console.WriteLine("finally");
            }
        }
    }
}
