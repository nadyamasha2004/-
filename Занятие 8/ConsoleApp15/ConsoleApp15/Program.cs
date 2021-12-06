using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            {
                int[] mas = new int[12];
                Random rnd = new Random();
                for (int i = 0; i < 12; i++)
                    mas[i] = rnd.Next(24);
                for (int i = 0; i < 12; i++)
                    Console.Write("{0}  ", mas[i]);
                int s = 0;
                for (int i = 0; i < 12; i++)
                    if (i % 2 == 0) { s = s + mas[i]; }
                Console.Write("Сумма элементов массива с четными индексами {0}", s);
                Console.ReadKey();

            }
        }
    }
}
