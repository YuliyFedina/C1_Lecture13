using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ex
{
    class Program
    {
        static void Main()
        {
            //Создать список из N дробей, сериализовать их в файл. Десериализовать.
            var rnd = new Random();
            const int countOfFractions = 10;
            const int maxValue = 100;

            var fractions = new Fraction[countOfFractions];

            for (var i = 0; i < countOfFractions; i++)
            {
                fractions[i] = new Fraction(rnd.Next(-maxValue, maxValue), rnd.Next(1, maxValue));
            }

            Console.WriteLine("Созданная коллекция случайных дробей");
            fractions.WriteToConsole();

            var formatter = new BinaryFormatter();
            using (var fs = new FileStream(@"..\..\..\fractions.txt", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, fractions);
                Console.WriteLine("Данные сериализованы");
                Console.WriteLine();
            }

            using (var fs = new FileStream(@"..\..\..\fractions.txt", FileMode.OpenOrCreate))
            {
                var fractionsDeserialize = (Fraction[])formatter.Deserialize(fs);

                Console.WriteLine("Объекты десериализованы:");
                fractionsDeserialize.WriteToConsole();

                Console.ReadLine();
            }
        }
    }
}
