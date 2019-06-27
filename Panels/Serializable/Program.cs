using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializeLearn
{
    class Program
    {
        static void Main(string[] args)
        {
           // SerializeExample();
            DeserializeExample();

        }
        private static void SerializeExample()
        {
            var car = new Car { Id = Guid.NewGuid(), Modelo = "Modelo 1", Year = 1999 };
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("D:\\SerializeExample.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            formatter.Serialize(stream, car);
            Console.WriteLine("Serialized");
        }

        private static void DeserializeExample()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("D:\\SerializeExample.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            var car = (Car)formatter.Deserialize(stream);
            Console.WriteLine("Deserialized");
        }

    }


    [Serializable]
    class Car
    {
        public Guid Id { get; set; }
        public int Year { get; set; }
        public string Modelo { get; set; }
    }
}


