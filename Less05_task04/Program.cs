using System;

namespace Less05_task04
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();

            Console.WriteLine(instance[6, " six"]);
            Console.WriteLine(instance[4, " fourth item"]);

            Console.ReadKey();
        }
    }

    class MyClass
    {
        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public string this[int index, string input]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                {
                    return input + array[index];
                }
                return "Index out of range";
            }
        }
    }
}
