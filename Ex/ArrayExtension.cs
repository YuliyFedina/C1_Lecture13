using System;

namespace Ex
{
    public static class ArrayExtension
    {
        public static void WriteToConsole<T>(this T[] array)
        {
            if (array.Length != 0)
            {
                foreach (var item in array) Console.WriteLine(item);
            }
            else
            {
                Console.WriteLine("Коллекция не содержит элементов");
            }

            Console.WriteLine();
        }
    }
}